﻿namespace BackUpDb
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailnotcheckBox = new System.Windows.Forms.CheckBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.SchedulecheckBox = new System.Windows.Forms.CheckBox();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.ScheduleTime = new System.Windows.Forms.DateTimePicker();
            this.SetSchedulebutton = new System.Windows.Forms.Button();
            this.selectDestLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bChangeLocalDest = new System.Windows.Forms.Button();
            this.tbLocalDest = new System.Windows.Forms.TextBox();
            this.localDest = new System.Windows.Forms.Label();
            this.cbUploadFtp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ErrorScheduleLabel = new System.Windows.Forms.Label();
            this.Scheduler = new System.Windows.Forms.Label();
            this.DatabasesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveAsToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logFileToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // logFileToolStripMenuItem
            // 
            this.logFileToolStripMenuItem.Name = "logFileToolStripMenuItem";
            this.logFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logFileToolStripMenuItem.Text = "Log File";
            this.logFileToolStripMenuItem.Click += new System.EventHandler(this.logFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // emailnotcheckBox
            // 
            this.emailnotcheckBox.AutoSize = true;
            this.emailnotcheckBox.Location = new System.Drawing.Point(20, 47);
            this.emailnotcheckBox.Name = "emailnotcheckBox";
            this.emailnotcheckBox.Size = new System.Drawing.Size(135, 17);
            this.emailnotcheckBox.TabIndex = 3;
            this.emailnotcheckBox.Text = "Send e-mail notification";
            this.emailnotcheckBox.UseVisualStyleBackColor = true;
            this.emailnotcheckBox.CheckedChanged += new System.EventHandler(this.emailnotcheckBox_CheckedChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Enabled = false;
            this.emailLabel.Location = new System.Drawing.Point(17, 87);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(80, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Send e-mail to :";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Enabled = false;
            this.emailtextBox.Location = new System.Drawing.Point(103, 80);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(143, 20);
            this.emailtextBox.TabIndex = 5;
            // 
            // SchedulecheckBox
            // 
            this.SchedulecheckBox.AutoSize = true;
            this.SchedulecheckBox.Location = new System.Drawing.Point(16, 44);
            this.SchedulecheckBox.Name = "SchedulecheckBox";
            this.SchedulecheckBox.Size = new System.Drawing.Size(71, 17);
            this.SchedulecheckBox.TabIndex = 6;
            this.SchedulecheckBox.Text = "Schedule";
            this.SchedulecheckBox.UseVisualStyleBackColor = true;
            this.SchedulecheckBox.CheckedChanged += new System.EventHandler(this.SchedulecheckBox_CheckedChanged);
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.Enabled = false;
            this.ScheduleLabel.Location = new System.Drawing.Point(13, 76);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(110, 13);
            this.ScheduleLabel.TabIndex = 7;
            this.ScheduleLabel.Text = "Start backup daily at :";
            // 
            // ScheduleTime
            // 
            this.ScheduleTime.CustomFormat = "hh:mm tt";
            this.ScheduleTime.Enabled = false;
            this.ScheduleTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ScheduleTime.Location = new System.Drawing.Point(132, 70);
            this.ScheduleTime.Name = "ScheduleTime";
            this.ScheduleTime.ShowUpDown = true;
            this.ScheduleTime.Size = new System.Drawing.Size(85, 20);
            this.ScheduleTime.TabIndex = 9;
            this.ScheduleTime.Value = new System.DateTime(2015, 12, 11, 12, 25, 0, 0);
            this.ScheduleTime.ValueChanged += new System.EventHandler(this.ScheduleTime_ValueChanged);
            // 
            // SetSchedulebutton
            // 
            this.SetSchedulebutton.Location = new System.Drawing.Point(391, 470);
            this.SetSchedulebutton.Name = "SetSchedulebutton";
            this.SetSchedulebutton.Size = new System.Drawing.Size(107, 23);
            this.SetSchedulebutton.TabIndex = 10;
            this.SetSchedulebutton.Text = "Set Schedule";
            this.SetSchedulebutton.UseVisualStyleBackColor = true;
            this.SetSchedulebutton.Visible = false;
            this.SetSchedulebutton.Click += new System.EventHandler(this.Runbutton_Click);
            // 
            // selectDestLabel
            // 
            this.selectDestLabel.AutoSize = true;
            this.selectDestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDestLabel.Location = new System.Drawing.Point(3, 16);
            this.selectDestLabel.Name = "selectDestLabel";
            this.selectDestLabel.Size = new System.Drawing.Size(138, 13);
            this.selectDestLabel.TabIndex = 12;
            this.selectDestLabel.Text = "Store Backup with FTP";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(19, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ftp Destination";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bChangeLocalDest);
            this.groupBox1.Controls.Add(this.tbLocalDest);
            this.groupBox1.Controls.Add(this.localDest);
            this.groupBox1.Controls.Add(this.cbUploadFtp);
            this.groupBox1.Controls.Add(this.selectDestLabel);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(242, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 169);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // bChangeLocalDest
            // 
            this.bChangeLocalDest.Location = new System.Drawing.Point(161, 89);
            this.bChangeLocalDest.Name = "bChangeLocalDest";
            this.bChangeLocalDest.Size = new System.Drawing.Size(75, 23);
            this.bChangeLocalDest.TabIndex = 17;
            this.bChangeLocalDest.Text = "Change";
            this.bChangeLocalDest.UseVisualStyleBackColor = true;
            this.bChangeLocalDest.Click += new System.EventHandler(this.bChangeLocalDest_Click);
            // 
            // tbLocalDest
            // 
            this.tbLocalDest.Location = new System.Drawing.Point(20, 63);
            this.tbLocalDest.Name = "tbLocalDest";
            this.tbLocalDest.ReadOnly = true;
            this.tbLocalDest.Size = new System.Drawing.Size(216, 20);
            this.tbLocalDest.TabIndex = 16;
            // 
            // localDest
            // 
            this.localDest.AutoSize = true;
            this.localDest.Location = new System.Drawing.Point(19, 47);
            this.localDest.Name = "localDest";
            this.localDest.Size = new System.Drawing.Size(90, 13);
            this.localDest.TabIndex = 15;
            this.localDest.Text = "Local destination:";
            // 
            // cbUploadFtp
            // 
            this.cbUploadFtp.AutoSize = true;
            this.cbUploadFtp.Location = new System.Drawing.Point(20, 115);
            this.cbUploadFtp.Name = "cbUploadFtp";
            this.cbUploadFtp.Size = new System.Drawing.Size(87, 17);
            this.cbUploadFtp.TabIndex = 14;
            this.cbUploadFtp.Text = "Upload to ftp";
            this.cbUploadFtp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.emailnotcheckBox);
            this.groupBox2.Controls.Add(this.emailLabel);
            this.groupBox2.Controls.Add(this.emailtextBox);
            this.groupBox2.Location = new System.Drawing.Point(242, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 116);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(3, 16);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(37, 13);
            this.email.TabIndex = 6;
            this.email.Text = "Email";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ErrorScheduleLabel);
            this.groupBox3.Controls.Add(this.Scheduler);
            this.groupBox3.Controls.Add(this.SchedulecheckBox);
            this.groupBox3.Controls.Add(this.ScheduleLabel);
            this.groupBox3.Controls.Add(this.ScheduleTime);
            this.groupBox3.Location = new System.Drawing.Point(242, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 116);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ErrorScheduleLabel
            // 
            this.ErrorScheduleLabel.AutoSize = true;
            this.ErrorScheduleLabel.Location = new System.Drawing.Point(13, 100);
            this.ErrorScheduleLabel.Name = "ErrorScheduleLabel";
            this.ErrorScheduleLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorScheduleLabel.TabIndex = 11;
            // 
            // Scheduler
            // 
            this.Scheduler.AutoSize = true;
            this.Scheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scheduler.Location = new System.Drawing.Point(7, 8);
            this.Scheduler.Name = "Scheduler";
            this.Scheduler.Size = new System.Drawing.Size(64, 13);
            this.Scheduler.TabIndex = 10;
            this.Scheduler.Text = "Scheduler";
            // 
            // DatabasesCheckedListBox
            // 
            this.DatabasesCheckedListBox.CheckOnClick = true;
            this.DatabasesCheckedListBox.FormattingEnabled = true;
            this.DatabasesCheckedListBox.Location = new System.Drawing.Point(12, 42);
            this.DatabasesCheckedListBox.Name = "DatabasesCheckedListBox";
            this.DatabasesCheckedListBox.Size = new System.Drawing.Size(178, 439);
            this.DatabasesCheckedListBox.TabIndex = 17;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(258, 470);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(119, 23);
            this.button.TabIndex = 18;
            this.button.Text = "Get backup and store";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 505);
            this.Controls.Add(this.button);
            this.Controls.Add(this.DatabasesCheckedListBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SetSchedulebutton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox emailnotcheckBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.CheckBox SchedulecheckBox;
        private System.Windows.Forms.Label ScheduleLabel;
        private System.Windows.Forms.DateTimePicker ScheduleTime;
        private System.Windows.Forms.Button SetSchedulebutton;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logFileToolStripMenuItem;
        private System.Windows.Forms.Label selectDestLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bChangeLocalDest;
        private System.Windows.Forms.TextBox tbLocalDest;
        private System.Windows.Forms.Label localDest;
        private System.Windows.Forms.CheckBox cbUploadFtp;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label Scheduler;
        private System.Windows.Forms.CheckedListBox DatabasesCheckedListBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ErrorScheduleLabel;
    }
}
