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
            this.LogoutSystemButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.CategoriesButton = new System.Windows.Forms.Button();
            this.ReportTaskButton = new System.Windows.Forms.Button();
            this.TaskManagementButton = new System.Windows.Forms.Button();
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
            this.DashboardStatusBar = new System.Windows.Forms.StatusStrip();
            this.DbConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DbConnectionProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.DashboardButtonsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AboutUserButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DashboardPanel.SuspendLayout();
            this.DashboardMenuStrip.SuspendLayout();
            this.DashboardStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 30F, System.Drawing.FontStyle.Italic);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(75, 21);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(190, 54);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.Color.White;
            this.DashboardLabel.Location = new System.Drawing.Point(73, 30);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(249, 65);
            this.DashboardLabel.TabIndex = 2;
            this.DashboardLabel.Text = "Dashboard";
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.DashboardPanel.Controls.Add(this.SelectLabel);
            this.DashboardPanel.Controls.Add(this.WelcomeLabel);
            this.DashboardPanel.Controls.Add(this.LogoutSystemButton);
            this.DashboardPanel.Controls.Add(this.AboutButton);
            this.DashboardPanel.Controls.Add(this.CategoriesButton);
            this.DashboardPanel.Controls.Add(this.ReportTaskButton);
            this.DashboardPanel.Controls.Add(this.TaskManagementButton);
            this.DashboardPanel.Location = new System.Drawing.Point(0, 98);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1074, 429);
            this.DashboardPanel.TabIndex = 3;
            // 
            // SelectLabel
            // 
            this.SelectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Italic);
            this.SelectLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SelectLabel.Location = new System.Drawing.Point(752, 45);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(238, 25);
            this.SelectLabel.TabIndex = 1;
            this.SelectLabel.Text = "Select an option to continue...";
            this.SelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoutSystemButton
            // 
            this.LogoutSystemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoutSystemButton.AutoSize = true;
            this.LogoutSystemButton.BackColor = System.Drawing.Color.DimGray;
            this.LogoutSystemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutSystemButton.FlatAppearance.BorderSize = 0;
            this.LogoutSystemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutSystemButton.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutSystemButton.ForeColor = System.Drawing.Color.White;
            this.LogoutSystemButton.Image = global::MachineProject3_TMS.Properties.Resources.logout;
            this.LogoutSystemButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LogoutSystemButton.Location = new System.Drawing.Point(772, 260);
            this.LogoutSystemButton.Name = "LogoutSystemButton";
            this.LogoutSystemButton.Padding = new System.Windows.Forms.Padding(5);
            this.LogoutSystemButton.Size = new System.Drawing.Size(218, 91);
            this.LogoutSystemButton.TabIndex = 0;
            this.LogoutSystemButton.Text = "Logout";
            this.LogoutSystemButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DashboardButtonsToolTip.SetToolTip(this.LogoutSystemButton, "Securely log out of the current session and return to the login screen");
            this.LogoutSystemButton.UseVisualStyleBackColor = false;
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AboutButton.AutoSize = true;
            this.AboutButton.BackColor = System.Drawing.Color.BlueViolet;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Image = global::MachineProject3_TMS.Properties.Resources.about;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AboutButton.Location = new System.Drawing.Point(772, 85);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Padding = new System.Windows.Forms.Padding(5);
            this.AboutButton.Size = new System.Drawing.Size(218, 169);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DashboardButtonsToolTip.SetToolTip(this.AboutButton, "View system information, course details, and developer credits.");
            this.AboutButton.UseVisualStyleBackColor = false;
            // 
            // CategoriesButton
            // 
            this.CategoriesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoriesButton.AutoSize = true;
            this.CategoriesButton.BackColor = System.Drawing.Color.SeaGreen;
            this.CategoriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoriesButton.FlatAppearance.BorderSize = 0;
            this.CategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoriesButton.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesButton.ForeColor = System.Drawing.Color.White;
            this.CategoriesButton.Image = global::MachineProject3_TMS.Properties.Resources.category;
            this.CategoriesButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.CategoriesButton.Location = new System.Drawing.Point(370, 85);
            this.CategoriesButton.Name = "CategoriesButton";
            this.CategoriesButton.Padding = new System.Windows.Forms.Padding(5);
            this.CategoriesButton.Size = new System.Drawing.Size(396, 138);
            this.CategoriesButton.TabIndex = 0;
            this.CategoriesButton.Text = "Categories";
            this.CategoriesButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DashboardButtonsToolTip.SetToolTip(this.CategoriesButton, "Organize your tasks by creating, editing, and managing custom task categories.");
            this.CategoriesButton.UseVisualStyleBackColor = false;
            // 
            // ReportTaskButton
            // 
            this.ReportTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportTaskButton.AutoSize = true;
            this.ReportTaskButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ReportTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportTaskButton.FlatAppearance.BorderSize = 0;
            this.ReportTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportTaskButton.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTaskButton.ForeColor = System.Drawing.Color.White;
            this.ReportTaskButton.Image = global::MachineProject3_TMS.Properties.Resources.reports;
            this.ReportTaskButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ReportTaskButton.Location = new System.Drawing.Point(370, 229);
            this.ReportTaskButton.Name = "ReportTaskButton";
            this.ReportTaskButton.Padding = new System.Windows.Forms.Padding(5);
            this.ReportTaskButton.Size = new System.Drawing.Size(396, 122);
            this.ReportTaskButton.TabIndex = 0;
            this.ReportTaskButton.Text = "View Reports";
            this.ReportTaskButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DashboardButtonsToolTip.SetToolTip(this.ReportTaskButton, "Generate filtered views of your tasks to monitor pending, completed, and overdue " +
        "work.");
            this.ReportTaskButton.UseVisualStyleBackColor = false;
            // 
            // TaskManagementButton
            // 
            this.TaskManagementButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskManagementButton.AutoSize = true;
            this.TaskManagementButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.TaskManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskManagementButton.FlatAppearance.BorderSize = 0;
            this.TaskManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskManagementButton.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskManagementButton.ForeColor = System.Drawing.Color.White;
            this.TaskManagementButton.Image = global::MachineProject3_TMS.Properties.Resources.task;
            this.TaskManagementButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.TaskManagementButton.Location = new System.Drawing.Point(84, 85);
            this.TaskManagementButton.Name = "TaskManagementButton";
            this.TaskManagementButton.Padding = new System.Windows.Forms.Padding(5);
            this.TaskManagementButton.Size = new System.Drawing.Size(280, 266);
            this.TaskManagementButton.TabIndex = 0;
            this.TaskManagementButton.Text = "Task Management";
            this.TaskManagementButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DashboardButtonsToolTip.SetToolTip(this.TaskManagementButton, "Open the Task Management module to create, update, delete, and track your daily a" +
        "ssignments.");
            this.TaskManagementButton.UseVisualStyleBackColor = false;
            // 
            // DashboardMenuStrip
            // 
            this.DashboardMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.DashboardMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modulesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.DashboardMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DashboardMenuStrip.Name = "DashboardMenuStrip";
            this.DashboardMenuStrip.Size = new System.Drawing.Size(1074, 25);
            this.DashboardMenuStrip.TabIndex = 5;
            this.DashboardMenuStrip.Text = "menuStrip1";
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // LogoutSystemToolStripMenuItem
            // 
            this.LogoutSystemToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.LogoutSystemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogoutSystemToolStripMenuItem.Name = "LogoutSystemToolStripMenuItem";
            this.LogoutSystemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LogoutSystemToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.LogoutSystemToolStripMenuItem.Tag = "";
            this.LogoutSystemToolStripMenuItem.Text = "Log-out System";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskManagementToolStripMenuItem,
            this.toolStripSeparator1,
            this.categoriesToolStripMenuItem});
            this.modulesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.modulesToolStripMenuItem.Text = "&Modules";
            // 
            // taskManagementToolStripMenuItem
            // 
            this.taskManagementToolStripMenuItem.Name = "taskManagementToolStripMenuItem";
            this.taskManagementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.taskManagementToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.taskManagementToolStripMenuItem.Text = "Task Management";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTasksToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // viewTasksToolStripMenuItem
            // 
            this.viewTasksToolStripMenuItem.Name = "viewTasksToolStripMenuItem";
            this.viewTasksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.viewTasksToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewTasksToolStripMenuItem.Text = "&View Tasks";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashboardStatusBar
            // 
            this.DashboardStatusBar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DashboardStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DbConnectionStatusLabel,
            this.DbConnectionProgressBar});
            this.DashboardStatusBar.Location = new System.Drawing.Point(0, 517);
            this.DashboardStatusBar.Name = "DashboardStatusBar";
            this.DashboardStatusBar.Size = new System.Drawing.Size(1074, 22);
            this.DashboardStatusBar.TabIndex = 6;
            this.DashboardStatusBar.Text = "statusStrip1";
            // 
            // DbConnectionStatusLabel
            // 
            this.DbConnectionStatusLabel.Name = "DbConnectionStatusLabel";
            this.DbConnectionStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // DbConnectionProgressBar
            // 
            this.DbConnectionProgressBar.Name = "DbConnectionProgressBar";
            this.DbConnectionProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // AboutUserButton
            // 
            this.AboutUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutUserButton.BackColor = System.Drawing.Color.MediumPurple;
            this.AboutUserButton.FlatAppearance.BorderSize = 0;
            this.AboutUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUserButton.ForeColor = System.Drawing.Color.White;
            this.AboutUserButton.Image = global::MachineProject3_TMS.Properties.Resources.person;
            this.AboutUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AboutUserButton.Location = new System.Drawing.Point(796, 44);
            this.AboutUserButton.Name = "AboutUserButton";
            this.AboutUserButton.Size = new System.Drawing.Size(259, 37);
            this.AboutUserButton.TabIndex = 4;
            this.AboutUserButton.Text = "User";
            this.AboutUserButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(12, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1074, 539);
            this.Controls.Add(this.DashboardMenuStrip);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.DashboardStatusBar);
            this.Controls.Add(this.AboutUserButton);
            this.Controls.Add(this.DashboardLabel);
            this.Controls.Add(this.DashboardPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.DashboardMenuStrip;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.DashboardMenuStrip.ResumeLayout(false);
            this.DashboardMenuStrip.PerformLayout();
            this.DashboardStatusBar.ResumeLayout(false);
            this.DashboardStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}