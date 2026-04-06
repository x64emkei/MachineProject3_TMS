namespace MachineProject3_TMS
{
    partial class FrmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReports));
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PendingLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.CompletedTasksCounterLabel = new System.Windows.Forms.Label();
            this.PendingTasksCounterLabel = new System.Windows.Forms.Label();
            this.TotalTasksCounterLabel = new System.Windows.Forms.Label();
            this.TaskDirectoryLabel = new System.Windows.Forms.Label();
            this.TaskDirectoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.menuTasks = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TaskDirectoryPanel = new System.Windows.Forms.Panel();
            this.statusStripTasks = new System.Windows.Forms.StatusStrip();
            this.TaskDirectoryStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatabaseStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ReportControlPanel = new System.Windows.Forms.Panel();
            this.LowPriorityButton = new System.Windows.Forms.Button();
            this.MediumPriorityButton = new System.Windows.Forms.Button();
            this.HighPriorityButton = new System.Windows.Forms.Button();
            this.OverdueTasksButton = new System.Windows.Forms.Button();
            this.PendingTasksButton = new System.Windows.Forms.Button();
            this.DoneTasksButton = new System.Windows.Forms.Button();
            this.AllTasksButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ExportToolsLabel = new System.Windows.Forms.Label();
            this.LiveStatusLabel = new System.Windows.Forms.Label();
            this.EditorStatusMessageLabel = new System.Windows.Forms.Label();
            this.LowPriorityTasksLabel = new System.Windows.Forms.Label();
            this.MediumPriorityTasksLabel = new System.Windows.Forms.Label();
            this.HighPriorityTasksLabel = new System.Windows.Forms.Label();
            this.OverdueTasksLabel = new System.Windows.Forms.Label();
            this.OverdueTasksCounterLabel = new System.Windows.Forms.Label();
            this.LowPriorityCounterLabel = new System.Windows.Forms.Label();
            this.MediumTasksCounterLabel = new System.Windows.Forms.Label();
            this.HighPriorityTasksCounterLabel = new System.Windows.Forms.Label();
            this.QuickPriorityLabel = new System.Windows.Forms.Label();
            this.ExportsGuideLabel = new System.Windows.Forms.Label();
            this.FilterByLabel = new System.Windows.Forms.Label();
            this.TaskEditorTitleLabel = new System.Windows.Forms.Label();
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.ProgramLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ExportReportButton = new System.Windows.Forms.Button();
            this.SearchDirectoryButton = new System.Windows.Forms.Button();
            this.PrintReportButton = new System.Windows.Forms.Button();
            this.RefreshDirectoryButton = new System.Windows.Forms.Button();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDirectoryDataGridView)).BeginInit();
            this.menuTasks.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TaskDirectoryPanel.SuspendLayout();
            this.statusStripTasks.SuspendLayout();
            this.ReportControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            resources.ApplyResources(this.TotalLabel, "TotalLabel");
            this.TotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TotalLabel.ForeColor = System.Drawing.Color.Silver;
            this.TotalLabel.Name = "TotalLabel";
            // 
            // PendingLabel
            // 
            resources.ApplyResources(this.PendingLabel, "PendingLabel");
            this.PendingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PendingLabel.ForeColor = System.Drawing.Color.Silver;
            this.PendingLabel.Name = "PendingLabel";
            // 
            // CompletedLabel
            // 
            resources.ApplyResources(this.CompletedLabel, "CompletedLabel");
            this.CompletedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompletedLabel.ForeColor = System.Drawing.Color.Silver;
            this.CompletedLabel.Name = "CompletedLabel";
            // 
            // CompletedTasksCounterLabel
            // 
            resources.ApplyResources(this.CompletedTasksCounterLabel, "CompletedTasksCounterLabel");
            this.CompletedTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompletedTasksCounterLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.CompletedTasksCounterLabel.Name = "CompletedTasksCounterLabel";
            // 
            // PendingTasksCounterLabel
            // 
            resources.ApplyResources(this.PendingTasksCounterLabel, "PendingTasksCounterLabel");
            this.PendingTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PendingTasksCounterLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.PendingTasksCounterLabel.Name = "PendingTasksCounterLabel";
            // 
            // TotalTasksCounterLabel
            // 
            resources.ApplyResources(this.TotalTasksCounterLabel, "TotalTasksCounterLabel");
            this.TotalTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TotalTasksCounterLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.TotalTasksCounterLabel.Name = "TotalTasksCounterLabel";
            // 
            // TaskDirectoryLabel
            // 
            resources.ApplyResources(this.TaskDirectoryLabel, "TaskDirectoryLabel");
            this.TaskDirectoryLabel.BackColor = System.Drawing.Color.Orange;
            this.TaskDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskDirectoryLabel.Name = "TaskDirectoryLabel";
            // 
            // TaskDirectoryDataGridView
            // 
            this.TaskDirectoryDataGridView.AllowUserToAddRows = false;
            this.TaskDirectoryDataGridView.AllowUserToDeleteRows = false;
            this.TaskDirectoryDataGridView.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.TaskDirectoryDataGridView, "TaskDirectoryDataGridView");
            this.TaskDirectoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskDirectoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TaskDirectoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TaskDirectoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskDirectoryDataGridView.MultiSelect = false;
            this.TaskDirectoryDataGridView.Name = "TaskDirectoryDataGridView";
            this.TaskDirectoryDataGridView.ReadOnly = true;
            // 
            // SearchLabel
            // 
            resources.ApplyResources(this.SearchLabel, "SearchLabel");
            this.SearchLabel.ForeColor = System.Drawing.Color.Silver;
            this.SearchLabel.Name = "SearchLabel";
            // 
            // menuTasks
            // 
            resources.ApplyResources(this.menuTasks, "menuTasks");
            this.menuTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuTasks.Name = "menuTasks";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToDashboardToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // returnToDashboardToolStripMenuItem
            // 
            this.returnToDashboardToolStripMenuItem.Name = "returnToDashboardToolStripMenuItem";
            resources.ApplyResources(this.returnToDashboardToolStripMenuItem, "returnToDashboardToolStripMenuItem");
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTasksToolStripMenuItem,
            this.completedTasksToolStripMenuItem,
            this.pendingTasksToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            resources.ApplyResources(this.recordToolStripMenuItem, "recordToolStripMenuItem");
            // 
            // allTasksToolStripMenuItem
            // 
            this.allTasksToolStripMenuItem.Name = "allTasksToolStripMenuItem";
            resources.ApplyResources(this.allTasksToolStripMenuItem, "allTasksToolStripMenuItem");
            // 
            // completedTasksToolStripMenuItem
            // 
            this.completedTasksToolStripMenuItem.Name = "completedTasksToolStripMenuItem";
            resources.ApplyResources(this.completedTasksToolStripMenuItem, "completedTasksToolStripMenuItem");
            // 
            // pendingTasksToolStripMenuItem
            // 
            this.pendingTasksToolStripMenuItem.Name = "pendingTasksToolStripMenuItem";
            resources.ApplyResources(this.pendingTasksToolStripMenuItem, "pendingTasksToolStripMenuItem");
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.categoryManagementToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // categoryManagementToolStripMenuItem
            // 
            this.categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            resources.ApplyResources(this.categoryManagementToolStripMenuItem, "categoryManagementToolStripMenuItem");
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
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
            // MainPanel
            // 
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.Controls.Add(this.TaskDirectoryPanel);
            this.MainPanel.Controls.Add(this.ReportControlPanel);
            this.MainPanel.Name = "MainPanel";
            // 
            // TaskDirectoryPanel
            // 
            resources.ApplyResources(this.TaskDirectoryPanel, "TaskDirectoryPanel");
            this.TaskDirectoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TaskDirectoryPanel.Controls.Add(this.statusStripTasks);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryLabel);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryDataGridView);
            this.TaskDirectoryPanel.Name = "TaskDirectoryPanel";
            // 
            // statusStripTasks
            // 
            this.statusStripTasks.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskDirectoryStatusMessage,
            this.DatabaseStatusMessage});
            resources.ApplyResources(this.statusStripTasks, "statusStripTasks");
            this.statusStripTasks.Name = "statusStripTasks";
            // 
            // TaskDirectoryStatusMessage
            // 
            this.TaskDirectoryStatusMessage.Name = "TaskDirectoryStatusMessage";
            resources.ApplyResources(this.TaskDirectoryStatusMessage, "TaskDirectoryStatusMessage");
            // 
            // DatabaseStatusMessage
            // 
            this.DatabaseStatusMessage.Name = "DatabaseStatusMessage";
            resources.ApplyResources(this.DatabaseStatusMessage, "DatabaseStatusMessage");
            // 
            // ReportControlPanel
            // 
            this.ReportControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ReportControlPanel.Controls.Add(this.LowPriorityButton);
            this.ReportControlPanel.Controls.Add(this.MediumPriorityButton);
            this.ReportControlPanel.Controls.Add(this.HighPriorityButton);
            this.ReportControlPanel.Controls.Add(this.OverdueTasksButton);
            this.ReportControlPanel.Controls.Add(this.PendingTasksButton);
            this.ReportControlPanel.Controls.Add(this.DoneTasksButton);
            this.ReportControlPanel.Controls.Add(this.AllTasksButton);
            this.ReportControlPanel.Controls.Add(this.ExportReportButton);
            this.ReportControlPanel.Controls.Add(this.SearchDirectoryButton);
            this.ReportControlPanel.Controls.Add(this.PrintReportButton);
            this.ReportControlPanel.Controls.Add(this.RefreshDirectoryButton);
            this.ReportControlPanel.Controls.Add(this.SearchTextBox);
            this.ReportControlPanel.Controls.Add(this.TotalLabel);
            this.ReportControlPanel.Controls.Add(this.ExportToolsLabel);
            this.ReportControlPanel.Controls.Add(this.LiveStatusLabel);
            this.ReportControlPanel.Controls.Add(this.EditorStatusMessageLabel);
            this.ReportControlPanel.Controls.Add(this.LowPriorityTasksLabel);
            this.ReportControlPanel.Controls.Add(this.MediumPriorityTasksLabel);
            this.ReportControlPanel.Controls.Add(this.HighPriorityTasksLabel);
            this.ReportControlPanel.Controls.Add(this.PendingLabel);
            this.ReportControlPanel.Controls.Add(this.OverdueTasksLabel);
            this.ReportControlPanel.Controls.Add(this.CompletedLabel);
            this.ReportControlPanel.Controls.Add(this.OverdueTasksCounterLabel);
            this.ReportControlPanel.Controls.Add(this.CompletedTasksCounterLabel);
            this.ReportControlPanel.Controls.Add(this.LowPriorityCounterLabel);
            this.ReportControlPanel.Controls.Add(this.MediumTasksCounterLabel);
            this.ReportControlPanel.Controls.Add(this.HighPriorityTasksCounterLabel);
            this.ReportControlPanel.Controls.Add(this.PendingTasksCounterLabel);
            this.ReportControlPanel.Controls.Add(this.TotalTasksCounterLabel);
            this.ReportControlPanel.Controls.Add(this.QuickPriorityLabel);
            this.ReportControlPanel.Controls.Add(this.ExportsGuideLabel);
            this.ReportControlPanel.Controls.Add(this.FilterByLabel);
            this.ReportControlPanel.Controls.Add(this.SearchLabel);
            this.ReportControlPanel.Controls.Add(this.TaskEditorTitleLabel);
            this.ReportControlPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ReportControlPanel, "ReportControlPanel");
            this.ReportControlPanel.Name = "ReportControlPanel";
            // 
            // LowPriorityButton
            // 
            this.LowPriorityButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.LowPriorityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LowPriorityButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.LowPriorityButton, "LowPriorityButton");
            this.LowPriorityButton.Name = "LowPriorityButton";
            this.LowPriorityButton.UseVisualStyleBackColor = false;
            this.LowPriorityButton.Click += new System.EventHandler(this.LowPriorityButton_Click);
            // 
            // MediumPriorityButton
            // 
            this.MediumPriorityButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.MediumPriorityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MediumPriorityButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.MediumPriorityButton, "MediumPriorityButton");
            this.MediumPriorityButton.Name = "MediumPriorityButton";
            this.MediumPriorityButton.UseVisualStyleBackColor = false;
            this.MediumPriorityButton.Click += new System.EventHandler(this.MediumPriorityButton_Click);
            // 
            // HighPriorityButton
            // 
            this.HighPriorityButton.BackColor = System.Drawing.Color.Firebrick;
            this.HighPriorityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HighPriorityButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.HighPriorityButton, "HighPriorityButton");
            this.HighPriorityButton.Name = "HighPriorityButton";
            this.HighPriorityButton.UseVisualStyleBackColor = false;
            this.HighPriorityButton.Click += new System.EventHandler(this.HighPriorityButton_Click);
            // 
            // OverdueTasksButton
            // 
            this.OverdueTasksButton.BackColor = System.Drawing.Color.Red;
            this.OverdueTasksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverdueTasksButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.OverdueTasksButton, "OverdueTasksButton");
            this.OverdueTasksButton.Name = "OverdueTasksButton";
            this.OverdueTasksButton.UseVisualStyleBackColor = false;
            this.OverdueTasksButton.Click += new System.EventHandler(this.OverdueTasksButton_Click);
            // 
            // PendingTasksButton
            // 
            this.PendingTasksButton.BackColor = System.Drawing.Color.Goldenrod;
            this.PendingTasksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PendingTasksButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PendingTasksButton, "PendingTasksButton");
            this.PendingTasksButton.Name = "PendingTasksButton";
            this.PendingTasksButton.UseVisualStyleBackColor = false;
            this.PendingTasksButton.Click += new System.EventHandler(this.PendingTasksButton_Click);
            // 
            // DoneTasksButton
            // 
            this.DoneTasksButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DoneTasksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneTasksButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.DoneTasksButton, "DoneTasksButton");
            this.DoneTasksButton.Name = "DoneTasksButton";
            this.DoneTasksButton.UseVisualStyleBackColor = false;
            this.DoneTasksButton.Click += new System.EventHandler(this.DoneTasksButton_Click);
            // 
            // AllTasksButton
            // 
            this.AllTasksButton.BackColor = System.Drawing.Color.DimGray;
            this.AllTasksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllTasksButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.AllTasksButton, "AllTasksButton");
            this.AllTasksButton.Name = "AllTasksButton";
            this.AllTasksButton.UseVisualStyleBackColor = false;
            this.AllTasksButton.Click += new System.EventHandler(this.AllTasksButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.CausesValidation = false;
            resources.ApplyResources(this.SearchTextBox, "SearchTextBox");
            this.SearchTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchTextBox.Name = "SearchTextBox";
            // 
            // ExportToolsLabel
            // 
            this.ExportToolsLabel.CausesValidation = false;
            this.ExportToolsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.ExportToolsLabel, "ExportToolsLabel");
            this.ExportToolsLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.ExportToolsLabel.Name = "ExportToolsLabel";
            // 
            // LiveStatusLabel
            // 
            this.LiveStatusLabel.CausesValidation = false;
            this.LiveStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.LiveStatusLabel, "LiveStatusLabel");
            this.LiveStatusLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.LiveStatusLabel.Name = "LiveStatusLabel";
            // 
            // EditorStatusMessageLabel
            // 
            this.EditorStatusMessageLabel.CausesValidation = false;
            this.EditorStatusMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.EditorStatusMessageLabel, "EditorStatusMessageLabel");
            this.EditorStatusMessageLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.EditorStatusMessageLabel.Name = "EditorStatusMessageLabel";
            // 
            // LowPriorityTasksLabel
            // 
            resources.ApplyResources(this.LowPriorityTasksLabel, "LowPriorityTasksLabel");
            this.LowPriorityTasksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LowPriorityTasksLabel.ForeColor = System.Drawing.Color.Silver;
            this.LowPriorityTasksLabel.Name = "LowPriorityTasksLabel";
            // 
            // MediumPriorityTasksLabel
            // 
            resources.ApplyResources(this.MediumPriorityTasksLabel, "MediumPriorityTasksLabel");
            this.MediumPriorityTasksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MediumPriorityTasksLabel.ForeColor = System.Drawing.Color.Silver;
            this.MediumPriorityTasksLabel.Name = "MediumPriorityTasksLabel";
            // 
            // HighPriorityTasksLabel
            // 
            resources.ApplyResources(this.HighPriorityTasksLabel, "HighPriorityTasksLabel");
            this.HighPriorityTasksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HighPriorityTasksLabel.ForeColor = System.Drawing.Color.Silver;
            this.HighPriorityTasksLabel.Name = "HighPriorityTasksLabel";
            // 
            // OverdueTasksLabel
            // 
            resources.ApplyResources(this.OverdueTasksLabel, "OverdueTasksLabel");
            this.OverdueTasksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OverdueTasksLabel.ForeColor = System.Drawing.Color.Silver;
            this.OverdueTasksLabel.Name = "OverdueTasksLabel";
            // 
            // OverdueTasksCounterLabel
            // 
            resources.ApplyResources(this.OverdueTasksCounterLabel, "OverdueTasksCounterLabel");
            this.OverdueTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OverdueTasksCounterLabel.ForeColor = System.Drawing.Color.Crimson;
            this.OverdueTasksCounterLabel.Name = "OverdueTasksCounterLabel";
            // 
            // LowPriorityCounterLabel
            // 
            resources.ApplyResources(this.LowPriorityCounterLabel, "LowPriorityCounterLabel");
            this.LowPriorityCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LowPriorityCounterLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LowPriorityCounterLabel.Name = "LowPriorityCounterLabel";
            // 
            // MediumTasksCounterLabel
            // 
            resources.ApplyResources(this.MediumTasksCounterLabel, "MediumTasksCounterLabel");
            this.MediumTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MediumTasksCounterLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.MediumTasksCounterLabel.Name = "MediumTasksCounterLabel";
            // 
            // HighPriorityTasksCounterLabel
            // 
            resources.ApplyResources(this.HighPriorityTasksCounterLabel, "HighPriorityTasksCounterLabel");
            this.HighPriorityTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HighPriorityTasksCounterLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.HighPriorityTasksCounterLabel.Name = "HighPriorityTasksCounterLabel";
            // 
            // QuickPriorityLabel
            // 
            resources.ApplyResources(this.QuickPriorityLabel, "QuickPriorityLabel");
            this.QuickPriorityLabel.ForeColor = System.Drawing.Color.Silver;
            this.QuickPriorityLabel.Name = "QuickPriorityLabel";
            // 
            // ExportsGuideLabel
            // 
            resources.ApplyResources(this.ExportsGuideLabel, "ExportsGuideLabel");
            this.ExportsGuideLabel.ForeColor = System.Drawing.Color.Silver;
            this.ExportsGuideLabel.Name = "ExportsGuideLabel";
            // 
            // FilterByLabel
            // 
            resources.ApplyResources(this.FilterByLabel, "FilterByLabel");
            this.FilterByLabel.ForeColor = System.Drawing.Color.Silver;
            this.FilterByLabel.Name = "FilterByLabel";
            // 
            // TaskEditorTitleLabel
            // 
            this.TaskEditorTitleLabel.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.TaskEditorTitleLabel, "TaskEditorTitleLabel");
            this.TaskEditorTitleLabel.Name = "TaskEditorTitleLabel";
            // 
            // MainTitleLabel
            // 
            resources.ApplyResources(this.MainTitleLabel, "MainTitleLabel");
            this.MainTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainTitleLabel.ForeColor = System.Drawing.Color.White;
            this.MainTitleLabel.Name = "MainTitleLabel";
            // 
            // ProgramLogoPictureBox
            // 
            resources.ApplyResources(this.ProgramLogoPictureBox, "ProgramLogoPictureBox");
            this.ProgramLogoPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            this.ProgramLogoPictureBox.Name = "ProgramLogoPictureBox";
            this.ProgramLogoPictureBox.TabStop = false;
            // 
            // ExportReportButton
            // 
            this.ExportReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExportReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportReportButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ExportReportButton, "ExportReportButton");
            this.ExportReportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportReportButton.Image = global::MachineProject3_TMS.Properties.Resources.export;
            this.ExportReportButton.Name = "ExportReportButton";
            this.ExportReportButton.UseVisualStyleBackColor = false;
            this.ExportReportButton.Click += new System.EventHandler(this.ExportReportButton_Click);
            // 
            // SearchDirectoryButton
            // 
            this.SearchDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SearchDirectoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchDirectoryButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.SearchDirectoryButton, "SearchDirectoryButton");
            this.SearchDirectoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchDirectoryButton.Image = global::MachineProject3_TMS.Properties.Resources.search;
            this.SearchDirectoryButton.Name = "SearchDirectoryButton";
            this.SearchDirectoryButton.UseVisualStyleBackColor = false;
            this.SearchDirectoryButton.Click += new System.EventHandler(this.SearchDirectoryButton_Click);
            // 
            // PrintReportButton
            // 
            this.PrintReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PrintReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintReportButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PrintReportButton, "PrintReportButton");
            this.PrintReportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintReportButton.Image = global::MachineProject3_TMS.Properties.Resources.print;
            this.PrintReportButton.Name = "PrintReportButton";
            this.PrintReportButton.UseVisualStyleBackColor = false;
            this.PrintReportButton.Click += new System.EventHandler(this.PrintReportButton_Click);
            // 
            // RefreshDirectoryButton
            // 
            this.RefreshDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshDirectoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshDirectoryButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.RefreshDirectoryButton, "RefreshDirectoryButton");
            this.RefreshDirectoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshDirectoryButton.Image = global::MachineProject3_TMS.Properties.Resources.refresh;
            this.RefreshDirectoryButton.Name = "RefreshDirectoryButton";
            this.RefreshDirectoryButton.UseVisualStyleBackColor = false;
            this.RefreshDirectoryButton.Click += new System.EventHandler(this.RefreshDirectoryButton_Click);
            // 
            // ReturnToDashboardButton
            // 
            this.ReturnToDashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToDashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnToDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.ReturnToDashboardButton, "ReturnToDashboardButton");
            this.ReturnToDashboardButton.Image = global::MachineProject3_TMS.Properties.Resources.arrow_back;
            this.ReturnToDashboardButton.Name = "ReturnToDashboardButton";
            this.ReturnToDashboardButton.UseVisualStyleBackColor = false;
            this.ReturnToDashboardButton.Click += new System.EventHandler(this.ReturnToDashboardButton_Click);
            // 
            // FrmReports
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.ProgramLogoPictureBox);
            this.Controls.Add(this.menuTasks);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainTitleLabel);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.MainMenuStrip = this.menuTasks;
            this.Name = "FrmReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.TaskDirectoryDataGridView)).EndInit();
            this.menuTasks.ResumeLayout(false);
            this.menuTasks.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.TaskDirectoryPanel.ResumeLayout(false);
            this.TaskDirectoryPanel.PerformLayout();
            this.statusStripTasks.ResumeLayout(false);
            this.statusStripTasks.PerformLayout();
            this.ReportControlPanel.ResumeLayout(false);
            this.ReportControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.PictureBox ProgramLogoPictureBox;
        private System.Windows.Forms.Label PendingLabel;
        private System.Windows.Forms.Label CompletedLabel;
        private System.Windows.Forms.Label CompletedTasksCounterLabel;
        private System.Windows.Forms.Label PendingTasksCounterLabel;
        private System.Windows.Forms.Label TotalTasksCounterLabel;
        private System.Windows.Forms.Button SearchDirectoryButton;
        private System.Windows.Forms.Button RefreshDirectoryButton;
        private System.Windows.Forms.Label TaskDirectoryLabel;
        private System.Windows.Forms.DataGridView TaskDirectoryDataGridView;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.MenuStrip menuTasks;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem categoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TaskDirectoryPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Button ReturnToDashboardButton;
        private System.Windows.Forms.Panel ReportControlPanel;
        private System.Windows.Forms.Label EditorStatusMessageLabel;
        private System.Windows.Forms.Label TaskEditorTitleLabel;
        private System.Windows.Forms.Button AllTasksButton;
        private System.Windows.Forms.Label FilterByLabel;
        private System.Windows.Forms.Button PendingTasksButton;
        private System.Windows.Forms.Button DoneTasksButton;
        private System.Windows.Forms.Label QuickPriorityLabel;
        private System.Windows.Forms.Label LiveStatusLabel;
        private System.Windows.Forms.Label LowPriorityCounterLabel;
        private System.Windows.Forms.Label MediumTasksCounterLabel;
        private System.Windows.Forms.Label HighPriorityTasksCounterLabel;
        private System.Windows.Forms.Label LowPriorityTasksLabel;
        private System.Windows.Forms.Label MediumPriorityTasksLabel;
        private System.Windows.Forms.Label HighPriorityTasksLabel;
        private System.Windows.Forms.Label ExportToolsLabel;
        private System.Windows.Forms.StatusStrip statusStripTasks;
        private System.Windows.Forms.ToolStripStatusLabel TaskDirectoryStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel DatabaseStatusMessage;
        private System.Windows.Forms.Label ExportsGuideLabel;
        private System.Windows.Forms.Button ExportReportButton;
        private System.Windows.Forms.Button PrintReportButton;
        private System.Windows.Forms.Button LowPriorityButton;
        private System.Windows.Forms.Button MediumPriorityButton;
        private System.Windows.Forms.Button HighPriorityButton;
        private System.Windows.Forms.Button OverdueTasksButton;
        private System.Windows.Forms.Label OverdueTasksLabel;
        private System.Windows.Forms.Label OverdueTasksCounterLabel;
        private System.Windows.Forms.ToolStripMenuItem allTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}