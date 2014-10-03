namespace UserInterface
{
    partial class urlmonitoringform
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
            this.components = new System.ComponentModel.Container();
            this.URLMonitoredGroupbox = new System.Windows.Forms.GroupBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ViewAll = new System.Windows.Forms.Button();
            this.urltobemonitored = new System.Windows.Forms.ListBox();
            this.Disable = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.Trigger = new System.Windows.Forms.Timer(this.components);
            this.MonitoringStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.MonitorStatus = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reset = new System.Windows.Forms.ToolStripMenuItem();
            this.Clearstatus = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMTPSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.URLMonitoredGroupbox.SuspendLayout();
            this.MonitoringStatusGroupBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLMonitoredGroupbox
            // 
            this.URLMonitoredGroupbox.Controls.Add(this.Edit);
            this.URLMonitoredGroupbox.Controls.Add(this.Add);
            this.URLMonitoredGroupbox.Controls.Add(this.ViewAll);
            this.URLMonitoredGroupbox.Controls.Add(this.urltobemonitored);
            this.URLMonitoredGroupbox.Controls.Add(this.Disable);
            this.URLMonitoredGroupbox.Location = new System.Drawing.Point(0, 27);
            this.URLMonitoredGroupbox.Name = "URLMonitoredGroupbox";
            this.URLMonitoredGroupbox.Size = new System.Drawing.Size(335, 149);
            this.URLMonitoredGroupbox.TabIndex = 0;
            this.URLMonitoredGroupbox.TabStop = false;
            this.URLMonitoredGroupbox.Text = "Url Monitored";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(250, 30);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(250, 88);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add URL";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ViewAll
            // 
            this.ViewAll.Location = new System.Drawing.Point(250, 117);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(75, 23);
            this.ViewAll.TabIndex = 3;
            this.ViewAll.Text = "All URL";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // urltobemonitored
            // 
            this.urltobemonitored.FormattingEnabled = true;
            this.urltobemonitored.HorizontalScrollbar = true;
            this.urltobemonitored.Location = new System.Drawing.Point(11, 19);
            this.urltobemonitored.Name = "urltobemonitored";
            this.urltobemonitored.Size = new System.Drawing.Size(233, 121);
            this.urltobemonitored.TabIndex = 2;
            // 
            // Disable
            // 
            this.Disable.Location = new System.Drawing.Point(250, 59);
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(75, 23);
            this.Disable.TabIndex = 1;
            this.Disable.Text = "Disable";
            this.Disable.UseVisualStyleBackColor = true;
            this.Disable.Click += new System.EventHandler(this.Disable_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(272, 449);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(57, 23);
            this.closebutton.TabIndex = 4;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Trigger
            // 
            this.Trigger.Enabled = true;
            this.Trigger.Interval = 1000;
            this.Trigger.Tick += new System.EventHandler(this.Trigger_Tick);
            // 
            // MonitoringStatusGroupBox
            // 
            this.MonitoringStatusGroupBox.Controls.Add(this.MonitorStatus);
            this.MonitoringStatusGroupBox.Location = new System.Drawing.Point(0, 182);
            this.MonitoringStatusGroupBox.Name = "MonitoringStatusGroupBox";
            this.MonitoringStatusGroupBox.Size = new System.Drawing.Size(335, 261);
            this.MonitoringStatusGroupBox.TabIndex = 10;
            this.MonitoringStatusGroupBox.TabStop = false;
            this.MonitoringStatusGroupBox.Text = "Monitoring Status";
            // 
            // MonitorStatus
            // 
            this.MonitorStatus.FormattingEnabled = true;
            this.MonitorStatus.HorizontalScrollbar = true;
            this.MonitorStatus.Location = new System.Drawing.Point(6, 16);
            this.MonitorStatus.Name = "MonitorStatus";
            this.MonitorStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MonitorStatus.Size = new System.Drawing.Size(323, 238);
            this.MonitorStatus.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(334, 24);
            this.MenuStrip.TabIndex = 11;
            this.MenuStrip.Text = "File Menu";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reset,
            this.Clearstatus,
            this.exit});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.applicationToolStripMenuItem.Text = "File";
            // 
            // reset
            // 
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(144, 22);
            this.reset.Text = "Reset";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Clearstatus
            // 
            this.Clearstatus.Name = "Clearstatus";
            this.Clearstatus.Size = new System.Drawing.Size(144, 22);
            this.Clearstatus.Text = "Clear Status";
            this.Clearstatus.Click += new System.EventHandler(this.Clearstatus_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(144, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMTPSettingsToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // SMTPSettingsToolStripMenuItem
            // 
            this.SMTPSettingsToolStripMenuItem.Name = "SMTPSettingsToolStripMenuItem";
            this.SMTPSettingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SMTPSettingsToolStripMenuItem.Text = "SMTP Settings";
            this.SMTPSettingsToolStripMenuItem.Click += new System.EventHandler(this.SMTPSettingsToolStripMenuItem_Click_1);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // urlmonitoringform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(334, 474);
            this.Controls.Add(this.MonitoringStatusGroupBox);
            this.Controls.Add(this.URLMonitoredGroupbox);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "urlmonitoringform";
            this.Text = "URL Monitoring";
            this.Load += new System.EventHandler(this.urlmonitoringform_Load);
            this.URLMonitoredGroupbox.ResumeLayout(false);
            this.MonitoringStatusGroupBox.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox URLMonitoredGroupbox;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.ListBox urltobemonitored;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Timer Trigger;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox MonitoringStatusGroupBox;
        private System.Windows.Forms.ListBox MonitorStatus;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SMTPSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reset;
        private System.Windows.Forms.ToolStripMenuItem Clearstatus;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker;

    }
}

