namespace MachineProject3_TMS
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Specifies the designer-managed container for components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Releases resources that the form uses.
        /// </summary>
        /// <param name="disposing">True when managed resources require disposal; otherwise false.</param>
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
        /// Initializes components created by the Windows Forms Designer. Do not modify the method body.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.DashboardMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DashboardStatusBar = new System.Windows.Forms.StatusStrip();
            this.DbConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DbConnectionProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.DashboardButtonsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ProgramLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.DatabaseConnectionButton = new System.Windows.Forms.Button();
            this.AboutUserButton = new System.Windows.Forms.Button();
            this.LogoutSystemButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.CategoriesButton = new System.Windows.Forms.Button();
            this.ReportTaskButton = new System.Windows.Forms.Button();
            this.TaskManagementButton = new System.Windows.Forms.Button();
            this.DescriptorLabel = new System.Windows.Forms.Label();
            this.DashboardPanel.SuspendLayout();
            this.DashboardMenuStrip.SuspendLayout();
            this.DashboardStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            resources.ApplyResources(this.WelcomeLabel, "WelcomeLabel");
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Name = "WelcomeLabel";
            // 
            // DashboardLabel
            // 
            resources.ApplyResources(this.DashboardLabel, "DashboardLabel");
            this.DashboardLabel.ForeColor = System.Drawing.Color.White;
            this.DashboardLabel.Name = "DashboardLabel";
            // 
            // DashboardPanel
            // 
            resources.ApplyResources(this.DashboardPanel, "DashboardPanel");
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.DashboardPanel.Controls.Add(this.DescriptorLabel);
            this.DashboardPanel.Controls.Add(this.SelectLabel);
            this.DashboardPanel.Controls.Add(this.WelcomeLabel);
            this.DashboardPanel.Controls.Add(this.LogoutSystemButton);
            this.DashboardPanel.Controls.Add(this.AboutButton);
            this.DashboardPanel.Controls.Add(this.CategoriesButton);
            this.DashboardPanel.Controls.Add(this.ReportTaskButton);
            this.DashboardPanel.Controls.Add(this.TaskManagementButton);
            this.DashboardPanel.Name = "DashboardPanel";
            // 
            // SelectLabel
            // 
            resources.ApplyResources(this.SelectLabel, "SelectLabel");
            this.SelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SelectLabel.Name = "SelectLabel";
            // 
            // DashboardMenuStrip
            // 
            this.DashboardMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.DashboardMenuStrip, "DashboardMenuStrip");
            this.DashboardMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modulesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.DashboardMenuStrip.Name = "DashboardMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutSystemToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // LogoutSystemToolStripMenuItem
            // 
            this.LogoutSystemToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.LogoutSystemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogoutSystemToolStripMenuItem.Name = "LogoutSystemToolStripMenuItem";
            resources.ApplyResources(this.LogoutSystemToolStripMenuItem, "LogoutSystemToolStripMenuItem");
            this.LogoutSystemToolStripMenuItem.Tag = "";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskManagementToolStripMenuItem,
            this.toolStripSeparator1,
            this.categoriesToolStripMenuItem});
            this.modulesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            resources.ApplyResources(this.modulesToolStripMenuItem, "modulesToolStripMenuItem");
            // 
            // taskManagementToolStripMenuItem
            // 
            this.taskManagementToolStripMenuItem.Name = "taskManagementToolStripMenuItem";
            resources.ApplyResources(this.taskManagementToolStripMenuItem, "taskManagementToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            resources.ApplyResources(this.categoriesToolStripMenuItem, "categoriesToolStripMenuItem");
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTasksToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
            // 
            // viewTasksToolStripMenuItem
            // 
            this.viewTasksToolStripMenuItem.Name = "viewTasksToolStripMenuItem";
            resources.ApplyResources(this.viewTasksToolStripMenuItem, "viewTasksToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
            // 
            // DashboardStatusBar
            // 
            this.DashboardStatusBar.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.DashboardStatusBar, "DashboardStatusBar");
            this.DashboardStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DbConnectionStatusLabel,
            this.DbConnectionProgressBar});
            this.DashboardStatusBar.Name = "DashboardStatusBar";
            // 
            // DbConnectionStatusLabel
            // 
            this.DbConnectionStatusLabel.Name = "DbConnectionStatusLabel";
            resources.ApplyResources(this.DbConnectionStatusLabel, "DbConnectionStatusLabel");
            // 
            // DbConnectionProgressBar
            // 
            this.DbConnectionProgressBar.Name = "DbConnectionProgressBar";
            resources.ApplyResources(this.DbConnectionProgressBar, "DbConnectionProgressBar");
            // 
            // ProgramLogoPictureBox
            // 
            this.ProgramLogoPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            resources.ApplyResources(this.ProgramLogoPictureBox, "ProgramLogoPictureBox");
            this.ProgramLogoPictureBox.Name = "ProgramLogoPictureBox";
            this.ProgramLogoPictureBox.TabStop = false;
            // 
            // DatabaseConnectionButton
            // 
            resources.ApplyResources(this.DatabaseConnectionButton, "DatabaseConnectionButton");
            this.DatabaseConnectionButton.BackColor = System.Drawing.Color.MediumPurple;
            this.DatabaseConnectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatabaseConnectionButton.FlatAppearance.BorderSize = 0;
            this.DatabaseConnectionButton.ForeColor = System.Drawing.Color.White;
            this.DatabaseConnectionButton.Image = global::MachineProject3_TMS.Properties.Resources.sql;
            this.DatabaseConnectionButton.Name = "DatabaseConnectionButton";
            this.DatabaseConnectionButton.UseVisualStyleBackColor = false;
            // 
            // AboutUserButton
            // 
            resources.ApplyResources(this.AboutUserButton, "AboutUserButton");
            this.AboutUserButton.BackColor = System.Drawing.Color.MediumPurple;
            this.AboutUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutUserButton.FlatAppearance.BorderSize = 0;
            this.AboutUserButton.ForeColor = System.Drawing.Color.White;
            this.AboutUserButton.Image = global::MachineProject3_TMS.Properties.Resources.person;
            this.AboutUserButton.Name = "AboutUserButton";
            this.AboutUserButton.UseVisualStyleBackColor = false;
            // 
            // LogoutSystemButton
            // 
            resources.ApplyResources(this.LogoutSystemButton, "LogoutSystemButton");
            this.LogoutSystemButton.BackColor = System.Drawing.Color.DimGray;
            this.LogoutSystemButton.CausesValidation = false;
            this.LogoutSystemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutSystemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LogoutSystemButton.FlatAppearance.BorderSize = 0;
            this.LogoutSystemButton.ForeColor = System.Drawing.Color.White;
            this.LogoutSystemButton.Image = global::MachineProject3_TMS.Properties.Resources.logout;
            this.LogoutSystemButton.Name = "LogoutSystemButton";
            this.DashboardButtonsToolTip.SetToolTip(this.LogoutSystemButton, resources.GetString("LogoutSystemButton.ToolTip"));
            this.LogoutSystemButton.UseVisualStyleBackColor = false;
            // 
            // AboutButton
            // 
            resources.ApplyResources(this.AboutButton, "AboutButton");
            this.AboutButton.BackColor = System.Drawing.Color.BlueViolet;
            this.AboutButton.CausesValidation = false;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Image = global::MachineProject3_TMS.Properties.Resources.about;
            this.AboutButton.Name = "AboutButton";
            this.DashboardButtonsToolTip.SetToolTip(this.AboutButton, resources.GetString("AboutButton.ToolTip"));
            this.AboutButton.UseVisualStyleBackColor = false;
            // 
            // CategoriesButton
            // 
            resources.ApplyResources(this.CategoriesButton, "CategoriesButton");
            this.CategoriesButton.BackColor = System.Drawing.Color.SeaGreen;
            this.CategoriesButton.CausesValidation = false;
            this.CategoriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoriesButton.FlatAppearance.BorderSize = 0;
            this.CategoriesButton.ForeColor = System.Drawing.Color.White;
            this.CategoriesButton.Image = global::MachineProject3_TMS.Properties.Resources.category;
            this.CategoriesButton.Name = "CategoriesButton";
            this.DashboardButtonsToolTip.SetToolTip(this.CategoriesButton, resources.GetString("CategoriesButton.ToolTip"));
            this.CategoriesButton.UseVisualStyleBackColor = false;
            // 
            // ReportTaskButton
            // 
            resources.ApplyResources(this.ReportTaskButton, "ReportTaskButton");
            this.ReportTaskButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ReportTaskButton.CausesValidation = false;
            this.ReportTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportTaskButton.FlatAppearance.BorderSize = 0;
            this.ReportTaskButton.ForeColor = System.Drawing.Color.White;
            this.ReportTaskButton.Image = global::MachineProject3_TMS.Properties.Resources.reports;
            this.ReportTaskButton.Name = "ReportTaskButton";
            this.DashboardButtonsToolTip.SetToolTip(this.ReportTaskButton, resources.GetString("ReportTaskButton.ToolTip"));
            this.ReportTaskButton.UseVisualStyleBackColor = false;
            // 
            // TaskManagementButton
            // 
            resources.ApplyResources(this.TaskManagementButton, "TaskManagementButton");
            this.TaskManagementButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.TaskManagementButton.CausesValidation = false;
            this.TaskManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskManagementButton.FlatAppearance.BorderSize = 0;
            this.TaskManagementButton.ForeColor = System.Drawing.Color.White;
            this.TaskManagementButton.Image = global::MachineProject3_TMS.Properties.Resources.task;
            this.TaskManagementButton.Name = "TaskManagementButton";
            this.DashboardButtonsToolTip.SetToolTip(this.TaskManagementButton, resources.GetString("TaskManagementButton.ToolTip"));
            this.TaskManagementButton.UseVisualStyleBackColor = false;
            // 
            // DescriptorLabel
            // 
            resources.ApplyResources(this.DescriptorLabel, "DescriptorLabel");
            this.DescriptorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescriptorLabel.Name = "DescriptorLabel";
            // 
            // FrmDashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.CancelButton = this.LogoutSystemButton;
            this.Controls.Add(this.DashboardMenuStrip);
            this.Controls.Add(this.ProgramLogoPictureBox);
            this.Controls.Add(this.DashboardStatusBar);
            this.Controls.Add(this.DatabaseConnectionButton);
            this.Controls.Add(this.AboutUserButton);
            this.Controls.Add(this.DashboardLabel);
            this.Controls.Add(this.DashboardPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.DashboardMenuStrip;
            this.Name = "FrmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.DashboardMenuStrip.ResumeLayout(false);
            this.DashboardMenuStrip.PerformLayout();
            this.DashboardStatusBar.ResumeLayout(false);
            this.DashboardStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Button TaskManagementButton;
        private System.Windows.Forms.Button CategoriesButton;
        private System.Windows.Forms.Button ReportTaskButton;
        private System.Windows.Forms.Button LogoutSystemButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button AboutUserButton;
        private System.Windows.Forms.MenuStrip DashboardMenuStrip;
        private System.Windows.Forms.StatusStrip DashboardStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel DbConnectionStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar DbConnectionProgressBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip DashboardButtonsToolTip;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.PictureBox ProgramLogoPictureBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Button DatabaseConnectionButton;
        private System.Windows.Forms.Label DescriptorLabel;
    }
}