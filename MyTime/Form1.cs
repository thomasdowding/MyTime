using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CyanJamClockInOut
{
    public partial class Form1 : Form
    {

        public string employeeID;

        public string entryID;
        public string entryPassword;

        public string timesheetPath;

        public string[,] employeeAccounts;

        public bool clockRunning;

        EmployeeClock currentClock = new EmployeeClock();

        public Form1()
        {
            InitializeComponent();

            clockRunning = false;
        }

        private void authenticateButton_Click(object sender, EventArgs e)
        {
            string accountsPath = @"C:\TimesheetProgram\accounts.txt"; //Set the string to the path of the accounts file

            int numberOfLines = File.ReadLines(accountsPath).Count(); //How many accounts are there?

            employeeAccounts = new string[numberOfLines, 3]; //Creates a 2D array for the number of accounts, each with 3 elements (name, employee id, password)

            StreamReader file = new StreamReader(accountsPath); //Creates a new StreamReader at the location of our file

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] line = file.ReadLine().Split(','); //Splits each single line (i.e. account) at every comma

                employeeAccounts[i, 0] = line[0]; //Then stores the correct parts of the line in the correct parts of the 2D array
                employeeAccounts[i, 1] = line[1];
                employeeAccounts[i, 2] = line[2]; 
            }

            entryID = usernameEntry.Text;
            entryPassword = passwordEntry.Text; //Syncs the text box field to a variable

            for (int i = 0; i < numberOfLines; i++) //Repeats the code for each account
            {
                if (entryID == employeeAccounts[i, 1]) //Does the inputted Employee ID match one in the file?
                {
                    if (entryPassword == employeeAccounts[i, 2]) //If it does, does it match the password?
                    {
                        employeeID = entryID; //Sync the employeeID variable

                        timesheetPath = @"C:\TimesheetProgram\timesheet\" + employeeID + ".txt"; //Set the path that the timesheet is located at

                        MessageBox.Show("Employee authenticated as " + employeeAccounts[i, 0], "Authentication Successful"); //Display a message to the user

                        clockInButton.Enabled = true;
                        timesheetButton.Enabled = true; //Enables the clock in and view timesheet buttons

                        break; //Exit out of the loop
                    }

                    else //If the password doesn't match
                    {
                        MessageBox.Show("Incorrect password", "Authentication Failed"); //Display error message
                        break; //Exit out of the loop
                    }
                }

                else if (i == (numberOfLines - 1)) //If on the last employee account and the employee IDs still don't match
                {
                    MessageBox.Show("Employee ID not recognised, please contact your System Administrator or try again.", "Authentication Failed"); //Display error message
                    break; //Exit out of the loop
                }
            }

            
        }

        private void clockInButton_Click(object sender, EventArgs e)
        {
            currentClock.date = DateTime.Now.ToShortDateString(); //Set the date of the current clock to the current date
            currentClock.clockIn = DateTime.Now.ToShortTimeString(); //Set the clock in time of the current clock to the current time

            currentClock.breakStart = null;
            currentClock.breakEnd = null;
            currentClock.clockOut = null; //Set all other values to null - this is needed in case a previous clock is still stored here

            clockRunning = true; //Set this bool to true (it is used later to prevent the user closing the program when their clock is running)

            MessageBox.Show("Clocked In at: " + currentClock.date + " " + currentClock.clockIn, "Clock In Successful"); //Display message

            clockInButton.Enabled = false; //Disable the clock in button (as the user is already clocked in)
            breakStartButton.Enabled = true;
            clockOutButton.Enabled = true; //Enable the buttons for clocking out and starting a break

            authenticateButton.Enabled = false; //Disable the authenticate button so that people cannot change accounts once clocked in
            usernameEntry.Enabled = false; //Disable the username text entry for the reason above
            passwordEntry.Enabled = false; //Disable the password text entry for the reason above
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clockRunning) //If the bool from earlier is true
            {
                MessageBox.Show("Your clock is currently running. You cannot close this program whilst your clocking is running. Please clock out first."); //Display error message

                e.Cancel = true; //Cancel closing the program
            }

        }

        private void breakStartButton_Click(object sender, EventArgs e)
        {
            currentClock.breakStart = DateTime.Now.ToShortTimeString(); //Set the break start of the clock to the current time

            MessageBox.Show("You have started your break at: " + currentClock.breakStart, "Break Started"); //Display message

            breakStartButton.Enabled = false; 
            clockOutButton.Enabled = false; //Disable the break start button (as the user is already on break) and clock out button (the user needs to finish their break first)
            breakEndButton.Enabled = true; //Enable the break end button
        }

        private void breakEndButton_Click(object sender, EventArgs e)
        {
            currentClock.breakEnd = DateTime.Now.ToShortTimeString(); //Set the break end of the clock to the current time

            MessageBox.Show("You have ended your break at: " + currentClock.breakEnd, "Break Ended"); //Display message

            breakEndButton.Enabled = false; //Disable the end break button
            clockOutButton.Enabled = true; //Enable the clock out button (clock in and the break start button are still disabled so the user can't start a second break or clock in again
        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {
            currentClock.clockOut = DateTime.Now.ToShortTimeString(); //Sets the clock out time of the clock to the current time

            if(currentClock.breakStart == null) //If a break was never started
            {
                currentClock.breakStart = "No Break";
                currentClock.breakEnd = "No Break"; //Set the value of the break to "No Break"
            }

            File.AppendAllText(timesheetPath, currentClock.date + "," + currentClock.clockIn + "," + currentClock.breakStart + "," + currentClock.breakEnd + "," + currentClock.clockOut + "\r\n"); //Write the clock to the employee's timesheet

            MessageBox.Show("You are now clocked out of your shift and free to close the program.", "Clock Out Successful"); //Display message

            clockRunning = false; //Set clock running to false (so the user can close the program).

            clockInButton.Enabled = true;
            clockOutButton.Enabled = false;
            breakStartButton.Enabled = false;
            breakEndButton.Enabled = false; //Reset the buttons to their default states

            authenticateButton.Enabled = false;
            usernameEntry.Enabled = false;
            passwordEntry.Enabled = false; //Resets the login fields to their default states
        }

        private void timesheetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText(timesheetPath), "My Timesheet"); //Read all the data from the employee's timesheet file and display it in a message box.
        }
    }
}
