namespace CyanJamClockInOut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authenticateButton = new System.Windows.Forms.Button();
            this.lostPassword = new System.Windows.Forms.Label();
            this.clockInButton = new System.Windows.Forms.Button();
            this.clockOutButton = new System.Windows.Forms.Button();
            this.breakStartButton = new System.Windows.Forms.Button();
            this.breakEndButton = new System.Windows.Forms.Button();
            this.timesheetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(144, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 55);
            this.Title.TabIndex = 0;
            this.Title.Text = "MyTime";
            // 
            // usernameEntry
            // 
            this.usernameEntry.Location = new System.Drawing.Point(179, 134);
            this.usernameEntry.Name = "usernameEntry";
            this.usernameEntry.Size = new System.Drawing.Size(123, 20);
            this.usernameEntry.TabIndex = 1;
            this.usernameEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(179, 189);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Size = new System.Drawing.Size(123, 20);
            this.passwordEntry.TabIndex = 2;
            this.passwordEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // authenticateButton
            // 
            this.authenticateButton.Location = new System.Drawing.Point(205, 275);
            this.authenticateButton.Name = "authenticateButton";
            this.authenticateButton.Size = new System.Drawing.Size(84, 23);
            this.authenticateButton.TabIndex = 5;
            this.authenticateButton.Text = "Authenticate!";
            this.authenticateButton.UseVisualStyleBackColor = true;
            this.authenticateButton.Click += new System.EventHandler(this.authenticateButton_Click);
            // 
            // lostPassword
            // 
            this.lostPassword.AutoSize = true;
            this.lostPassword.Location = new System.Drawing.Point(58, 229);
            this.lostPassword.Name = "lostPassword";
            this.lostPassword.Size = new System.Drawing.Size(403, 26);
            this.lostPassword.TabIndex = 6;
            this.lostPassword.Text = "Please contact the System Administrator if you lose your password or have any oth" +
    "er\r\ndifficulties with this software.";
            // 
            // clockInButton
            // 
            this.clockInButton.Enabled = false;
            this.clockInButton.Location = new System.Drawing.Point(76, 337);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(75, 83);
            this.clockInButton.TabIndex = 7;
            this.clockInButton.Text = "Clock In";
            this.clockInButton.UseVisualStyleBackColor = true;
            this.clockInButton.Click += new System.EventHandler(this.clockInButton_Click);
            // 
            // clockOutButton
            // 
            this.clockOutButton.Enabled = false;
            this.clockOutButton.Location = new System.Drawing.Point(164, 337);
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.Size = new System.Drawing.Size(75, 83);
            this.clockOutButton.TabIndex = 8;
            this.clockOutButton.Text = "Clock Out";
            this.clockOutButton.UseVisualStyleBackColor = true;
            this.clockOutButton.Click += new System.EventHandler(this.clockOutButton_Click);
            // 
            // breakStartButton
            // 
            this.breakStartButton.Enabled = false;
            this.breakStartButton.Location = new System.Drawing.Point(253, 337);
            this.breakStartButton.Name = "breakStartButton";
            this.breakStartButton.Size = new System.Drawing.Size(75, 83);
            this.breakStartButton.TabIndex = 9;
            this.breakStartButton.Text = "Start Break";
            this.breakStartButton.UseVisualStyleBackColor = true;
            this.breakStartButton.Click += new System.EventHandler(this.breakStartButton_Click);
            // 
            // breakEndButton
            // 
            this.breakEndButton.Enabled = false;
            this.breakEndButton.Location = new System.Drawing.Point(343, 337);
            this.breakEndButton.Name = "breakEndButton";
            this.breakEndButton.Size = new System.Drawing.Size(75, 83);
            this.breakEndButton.TabIndex = 10;
            this.breakEndButton.Text = "End Break";
            this.breakEndButton.UseVisualStyleBackColor = true;
            this.breakEndButton.Click += new System.EventHandler(this.breakEndButton_Click);
            // 
            // timesheetButton
            // 
            this.timesheetButton.Enabled = false;
            this.timesheetButton.Location = new System.Drawing.Point(193, 444);
            this.timesheetButton.Name = "timesheetButton";
            this.timesheetButton.Size = new System.Drawing.Size(110, 36);
            this.timesheetButton.TabIndex = 11;
            this.timesheetButton.Text = "View Timesheets";
            this.timesheetButton.UseVisualStyleBackColor = true;
            this.timesheetButton.Click += new System.EventHandler(this.timesheetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 524);
            this.Controls.Add(this.timesheetButton);
            this.Controls.Add(this.breakEndButton);
            this.Controls.Add(this.breakStartButton);
            this.Controls.Add(this.clockOutButton);
            this.Controls.Add(this.clockInButton);
            this.Controls.Add(this.lostPassword);
            this.Controls.Add(this.authenticateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.usernameEntry);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "MyTime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button authenticateButton;
        private System.Windows.Forms.Label lostPassword;
        private System.Windows.Forms.Button clockInButton;
        private System.Windows.Forms.Button clockOutButton;
        private System.Windows.Forms.Button breakStartButton;
        private System.Windows.Forms.Button breakEndButton;
        private System.Windows.Forms.Button timesheetButton;
    }
}

