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
            this.ExportReportButton = new System.Windows.Forms.Button();
            this.SearchDirectoryButton = new System.Windows.Forms.Button();
            this.PrintReportButton = new System.Windows.Forms.Button();
            this.RefreshDirectoryButton = new System.Windows.Forms.Button();
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
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.TotalLabel.ForeColor = System.Drawing.Color.Silver;
            this.TotalLabel.Location = new System.Drawing.Point(32, 472);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(74, 15);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "TOTAL TASKS";
            // 
            // PendingLabel
            // 
            this.PendingLabel.AutoSize = true;
            this.PendingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PendingLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.PendingLabel.ForeColor = System.Drawing.Color.Silver;
            this.PendingLabel.Location = new System.Drawing.Point(32, 555);
            this.PendingLabel.Name = "PendingLabel";
            this.PendingLabel.Size = new System.Drawing.Size(57, 15);
            this.PendingLabel.TabIndex = 2;
            this.PendingLabel.Text = "PENDING";
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompletedLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.CompletedLabel.ForeColor = System.Drawing.Color.Silver;
            this.CompletedLabel.Location = new System.Drawing.Point(136, 554);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(72, 15);
            this.CompletedLabel.TabIndex = 2;
            this.CompletedLabel.Text = "COMPLETED";
            // 
            // CompletedTasksCounterLabel
            // 
            this.CompletedTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompletedTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedTasksCounterLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.CompletedTasksCounterLabel.Location = new System.Drawing.Point(131, 513);
            this.CompletedTasksCounterLabel.Name = "CompletedTasksCounterLabel";
            this.CompletedTasksCounterLabel.Size = new System.Drawing.Size(98, 59);
            this.CompletedTasksCounterLabel.TabIndex = 10;
            this.CompletedTasksCounterLabel.Text = "--";
            this.CompletedTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PendingTasksCounterLabel
            // 
            this.PendingTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PendingTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingTasksCounterLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.PendingTasksCounterLabel.Location = new System.Drawing.Point(27, 513);
            this.PendingTasksCounterLabel.Name = "PendingTasksCounterLabel";
            this.PendingTasksCounterLabel.Size = new System.Drawing.Size(98, 59);
            this.PendingTasksCounterLabel.TabIndex = 10;
            this.PendingTasksCounterLabel.Text = "--";
            this.PendingTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalTasksCounterLabel
            // 
            this.TotalTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TotalTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTasksCounterLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.TotalTasksCounterLabel.Location = new System.Drawing.Point(27, 448);
            this.TotalTasksCounterLabel.Name = "TotalTasksCounterLabel";
            this.TotalTasksCounterLabel.Size = new System.Drawing.Size(304, 55);
            this.TotalTasksCounterLabel.TabIndex = 10;
            this.TotalTasksCounterLabel.Text = "--";
            this.TotalTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TaskDirectoryLabel
            // 
            this.TaskDirectoryLabel.BackColor = System.Drawing.Color.Orange;
            this.TaskDirectoryLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskDirectoryLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskDirectoryLabel.Name = "TaskDirectoryLabel";
            this.TaskDirectoryLabel.Size = new System.Drawing.Size(708, 44);
            this.TaskDirectoryLabel.TabIndex = 0;
            this.TaskDirectoryLabel.Text = "Task Directory";
            this.TaskDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskDirectoryDataGridView
            // 
            this.TaskDirectoryDataGridView.AllowUserToAddRows = false;
            this.TaskDirectoryDataGridView.AllowUserToDeleteRows = false;
            this.TaskDirectoryDataGridView.AllowUserToOrderColumns = true;
            this.TaskDirectoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.TaskDirectoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TaskDirectoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TaskDirectoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskDirectoryDataGridView.Location = new System.Drawing.Point(15, 53);
            this.TaskDirectoryDataGridView.Name = "TaskDirectoryDataGridView";
            this.TaskDirectoryDataGridView.Size = new System.Drawing.Size(666, 590);
            this.TaskDirectoryDataGridView.TabIndex = 3;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SearchLabel.ForeColor = System.Drawing.Color.Silver;
            this.SearchLabel.Location = new System.Drawing.Point(23, 78);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(53, 20);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search";
            // 
            // menuTasks
            // 
            this.menuTasks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuTasks.Location = new System.Drawing.Point(0, 0);
            this.menuTasks.Name = "menuTasks";
            this.menuTasks.Size = new System.Drawing.Size(1102, 25);
            this.menuTasks.TabIndex = 9;
            this.menuTasks.Text = "menuTasks";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToDashboardToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // returnToDashboardToolStripMenuItem
            // 
            this.returnToDashboardToolStripMenuItem.Name = "returnToDashboardToolStripMenuItem";
            this.returnToDashboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.returnToDashboardToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.returnToDashboardToolStripMenuItem.Text = "Return to Dashboard";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.logoutToolStripMenuItem.Text = "Log-out";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTasksToolStripMenuItem,
            this.completedTasksToolStripMenuItem,
            this.pendingTasksToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.recordToolStripMenuItem.Text = "F&ilter";
            // 
            // allTasksToolStripMenuItem
            // 
            this.allTasksToolStripMenuItem.Name = "allTasksToolStripMenuItem";
            this.allTasksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.allTasksToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.allTasksToolStripMenuItem.Text = "A&ll Tasks";
            // 
            // completedTasksToolStripMenuItem
            // 
            this.completedTasksToolStripMenuItem.Name = "completedTasksToolStripMenuItem";
            this.completedTasksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.completedTasksToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.completedTasksToolStripMenuItem.Text = "&Completed Tasks";
            // 
            // pendingTasksToolStripMenuItem
            // 
            this.pendingTasksToolStripMenuItem.Name = "pendingTasksToolStripMenuItem";
            this.pendingTasksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pendingTasksToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.pendingTasksToolStripMenuItem.Text = "&Pending Tasks";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.categoryManagementToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.refreshToolStripMenuItem.Text = "&View";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem3.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem3.Text = "Refresh/View All Tasks";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(253, 6);
            // 
            // categoryManagementToolStripMenuItem
            // 
            this.categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            this.categoryManagementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.categoryManagementToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.categoryManagementToolStripMenuItem.Text = "Category Management";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.Controls.Add(this.TaskDirectoryPanel);
            this.MainPanel.Controls.Add(this.ReportControlPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 91);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.MainPanel.Size = new System.Drawing.Size(1102, 724);
            this.MainPanel.TabIndex = 11;
            // 
            // TaskDirectoryPanel
            // 
            this.TaskDirectoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TaskDirectoryPanel.Controls.Add(this.statusStripTasks);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryLabel);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryDataGridView);
            this.TaskDirectoryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TaskDirectoryPanel.Location = new System.Drawing.Point(386, 20);
            this.TaskDirectoryPanel.Name = "TaskDirectoryPanel";
            this.TaskDirectoryPanel.Size = new System.Drawing.Size(696, 684);
            this.TaskDirectoryPanel.TabIndex = 0;
            // 
            // statusStripTasks
            // 
            this.statusStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskDirectoryStatusMessage,
            this.DatabaseStatusMessage});
            this.statusStripTasks.Location = new System.Drawing.Point(0, 662);
            this.statusStripTasks.Name = "statusStripTasks";
            this.statusStripTasks.Size = new System.Drawing.Size(696, 22);
            this.statusStripTasks.TabIndex = 6;
            this.statusStripTasks.Text = "statusStripTasks";
            // 
            // TaskDirectoryStatusMessage
            // 
            this.TaskDirectoryStatusMessage.Name = "TaskDirectoryStatusMessage";
            this.TaskDirectoryStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // DatabaseStatusMessage
            // 
            this.DatabaseStatusMessage.Name = "DatabaseStatusMessage";
            this.DatabaseStatusMessage.Size = new System.Drawing.Size(0, 17);
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
            this.ReportControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReportControlPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReportControlPanel.Location = new System.Drawing.Point(20, 20);
            this.ReportControlPanel.Name = "ReportControlPanel";
            this.ReportControlPanel.Size = new System.Drawing.Size(360, 684);
            this.ReportControlPanel.TabIndex = 0;
            // 
            // LowPriorityButton
            // 
            this.LowPriorityButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.LowPriorityButton.FlatAppearance.BorderSize = 0;
            this.LowPriorityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LowPriorityButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowPriorityButton.Location = new System.Drawing.Point(235, 274);
            this.LowPriorityButton.Name = "LowPriorityButton";
            this.LowPriorityButton.Size = new System.Drawing.Size(96, 25);
            this.LowPriorityButton.TabIndex = 11;
            this.LowPriorityButton.Text = "&LOW";
            this.LowPriorityButton.UseVisualStyleBackColor = false;
            // 
            // MediumPriorityButton
            // 
            this.MediumPriorityButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.MediumPriorityButton.FlatAppearance.BorderSize = 0;
            this.MediumPriorityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumPriorityButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumPriorityButton.Location = new System.Drawing.Point(131, 274);
            this.MediumPriorityButton.Name = "MediumPriorityButton";
            this.MediumPriorityButton.Size = new System.Drawing.Size(98, 25);
            this.MediumPriorityButton.TabIndex = 11;
            this.MediumPriorityButton.Text = "&MEDIUM";
            this.MediumPriorityButton.UseVisualStyleBackColor = false;
            // 
            // HighPriorityButton
            // 
            this.HighPriorityButton.BackColor = System.Drawing.Color.Firebrick;
            this.HighPriorityButton.FlatAppearance.BorderSize = 0;
            this.HighPriorityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighPriorityButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighPriorityButton.Location = new System.Drawing.Point(27, 274);
            this.HighPriorityButton.Name = "HighPriorityButton";
            this.HighPriorityButton.Size = new System.Drawing.Size(98, 25);
            this.HighPriorityButton.TabIndex = 11;
            this.HighPriorityButton.Text = "&HIGH";
            this.HighPriorityButton.UseVisualStyleBackColor = false;
            // 
            // OverdueTasksButton
            // 
            this.OverdueTasksButton.BackColor = System.Drawing.Color.Red;
            this.OverdueTasksButton.FlatAppearance.BorderSize = 0;
            this.OverdueTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverdueTasksButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverdueTasksButton.Location = new System.Drawing.Point(235, 221);
            this.OverdueTasksButton.Name = "OverdueTasksButton";
            this.OverdueTasksButton.Size = new System.Drawing.Size(96, 25);
            this.OverdueTasksButton.TabIndex = 11;
            this.OverdueTasksButton.Text = "OVERDUE";
            this.OverdueTasksButton.UseVisualStyleBackColor = false;
            // 
            // PendingTasksButton
            // 
            this.PendingTasksButton.BackColor = System.Drawing.Color.Goldenrod;
            this.PendingTasksButton.FlatAppearance.BorderSize = 0;
            this.PendingTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingTasksButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingTasksButton.Location = new System.Drawing.Point(148, 221);
            this.PendingTasksButton.Name = "PendingTasksButton";
            this.PendingTasksButton.Size = new System.Drawing.Size(81, 25);
            this.PendingTasksButton.TabIndex = 11;
            this.PendingTasksButton.Text = "&PENDING";
            this.PendingTasksButton.UseVisualStyleBackColor = false;
            // 
            // DoneTasksButton
            // 
            this.DoneTasksButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DoneTasksButton.FlatAppearance.BorderSize = 0;
            this.DoneTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneTasksButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneTasksButton.Location = new System.Drawing.Point(82, 221);
            this.DoneTasksButton.Name = "DoneTasksButton";
            this.DoneTasksButton.Size = new System.Drawing.Size(60, 25);
            this.DoneTasksButton.TabIndex = 11;
            this.DoneTasksButton.Text = "DO&NE";
            this.DoneTasksButton.UseVisualStyleBackColor = false;
            // 
            // AllTasksButton
            // 
            this.AllTasksButton.BackColor = System.Drawing.Color.DimGray;
            this.AllTasksButton.FlatAppearance.BorderSize = 0;
            this.AllTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllTasksButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTasksButton.Location = new System.Drawing.Point(27, 221);
            this.AllTasksButton.Name = "AllTasksButton";
            this.AllTasksButton.Size = new System.Drawing.Size(49, 25);
            this.AllTasksButton.TabIndex = 11;
            this.AllTasksButton.Text = "A&LL";
            this.AllTasksButton.UseVisualStyleBackColor = false;
            // 
            // ExportReportButton
            // 
            this.ExportReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExportReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportReportButton.FlatAppearance.BorderSize = 0;
            this.ExportReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportReportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportReportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportReportButton.Image = global::MachineProject3_TMS.Properties.Resources.export;
            this.ExportReportButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ExportReportButton.Location = new System.Drawing.Point(27, 360);
            this.ExportReportButton.Name = "ExportReportButton";
            this.ExportReportButton.Size = new System.Drawing.Size(149, 51);
            this.ExportReportButton.TabIndex = 9;
            this.ExportReportButton.Text = "&EXPORT";
            this.ExportReportButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ExportReportButton.UseVisualStyleBackColor = false;
            // 
            // SearchDirectoryButton
            // 
            this.SearchDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SearchDirectoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchDirectoryButton.FlatAppearance.BorderSize = 0;
            this.SearchDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchDirectoryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDirectoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchDirectoryButton.Image = global::MachineProject3_TMS.Properties.Resources.search;
            this.SearchDirectoryButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.SearchDirectoryButton.Location = new System.Drawing.Point(27, 137);
            this.SearchDirectoryButton.Name = "SearchDirectoryButton";
            this.SearchDirectoryButton.Size = new System.Drawing.Size(149, 51);
            this.SearchDirectoryButton.TabIndex = 9;
            this.SearchDirectoryButton.Text = "&SEARCH";
            this.SearchDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SearchDirectoryButton.UseVisualStyleBackColor = false;
            // 
            // PrintReportButton
            // 
            this.PrintReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PrintReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintReportButton.FlatAppearance.BorderSize = 0;
            this.PrintReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintReportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintReportButton.Image = global::MachineProject3_TMS.Properties.Resources.print;
            this.PrintReportButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.PrintReportButton.Location = new System.Drawing.Point(182, 360);
            this.PrintReportButton.Name = "PrintReportButton";
            this.PrintReportButton.Size = new System.Drawing.Size(149, 51);
            this.PrintReportButton.TabIndex = 7;
            this.PrintReportButton.Text = "&PRINT";
            this.PrintReportButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.PrintReportButton.UseVisualStyleBackColor = false;
            // 
            // RefreshDirectoryButton
            // 
            this.RefreshDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshDirectoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshDirectoryButton.FlatAppearance.BorderSize = 0;
            this.RefreshDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshDirectoryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshDirectoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshDirectoryButton.Image = global::MachineProject3_TMS.Properties.Resources.refresh;
            this.RefreshDirectoryButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.RefreshDirectoryButton.Location = new System.Drawing.Point(182, 137);
            this.RefreshDirectoryButton.Name = "RefreshDirectoryButton";
            this.RefreshDirectoryButton.Size = new System.Drawing.Size(149, 51);
            this.RefreshDirectoryButton.TabIndex = 7;
            this.RefreshDirectoryButton.Text = "&REFRESH";
            this.RefreshDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RefreshDirectoryButton.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.CausesValidation = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchTextBox.Location = new System.Drawing.Point(27, 102);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(304, 29);
            this.SearchTextBox.TabIndex = 3;
            // 
            // ExportToolsLabel
            // 
            this.ExportToolsLabel.CausesValidation = false;
            this.ExportToolsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToolsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToolsLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.ExportToolsLabel.Location = new System.Drawing.Point(24, 307);
            this.ExportToolsLabel.Name = "ExportToolsLabel";
            this.ExportToolsLabel.Size = new System.Drawing.Size(307, 29);
            this.ExportToolsLabel.TabIndex = 10;
            this.ExportToolsLabel.Text = "EXPORT TOOLS";
            this.ExportToolsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LiveStatusLabel
            // 
            this.LiveStatusLabel.CausesValidation = false;
            this.LiveStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LiveStatusLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveStatusLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.LiveStatusLabel.Location = new System.Drawing.Point(27, 416);
            this.LiveStatusLabel.Name = "LiveStatusLabel";
            this.LiveStatusLabel.Size = new System.Drawing.Size(304, 29);
            this.LiveStatusLabel.TabIndex = 10;
            this.LiveStatusLabel.Text = "LIVE STATUS";
            this.LiveStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditorStatusMessageLabel
            // 
            this.EditorStatusMessageLabel.CausesValidation = false;
            this.EditorStatusMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorStatusMessageLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorStatusMessageLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.EditorStatusMessageLabel.Location = new System.Drawing.Point(24, 53);
            this.EditorStatusMessageLabel.Name = "EditorStatusMessageLabel";
            this.EditorStatusMessageLabel.Size = new System.Drawing.Size(307, 29);
            this.EditorStatusMessageLabel.TabIndex = 10;
            this.EditorStatusMessageLabel.Text = "DATA CONTROLS";
            this.EditorStatusMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LowPriorityTasksLabel
            // 
            this.LowPriorityTasksLabel.AutoSize = true;
            this.LowPriorityTasksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LowPriorityTasksLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.LowPriorityTasksLabel.ForeColor = System.Drawing.Color.Silver;
            this.LowPriorityTasksLabel.Location = new System.Drawing.Point(240, 642);
            this.LowPriorityTasksLabel.Name = "LowPriorityTasksLabel";
            this.LowPriorityTasksLabel.Size = new System.Drawing.Size(33, 15);
            this.LowPriorityTasksLabel.TabIndex = 2;
            this.LowPriorityTasksLabel.Text = "LOW";
            // 
            // MediumPriorityTasksLabel
            // 
            this.MediumPriorityTasksLabel.AutoSize = true;
            this.MediumPriorityTasksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MediumPriorityTasksLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.MediumPriorityTasksLabel.ForeColor = System.Drawing.Color.Silver;
            this.MediumPriorityTasksLabel.Location = new System.Drawing.Point(136, 642);
            this.MediumPriorityTasksLabel.Name = "MediumPriorityTasksLabel";
            this.MediumPriorityTasksLabel.Size = new System.Drawing.Size(52, 15);
            this.MediumPriorityTasksLabel.TabIndex = 2;
            this.MediumPriorityTasksLabel.Text = "MEDIUM";
            // 
            // HighPriorityTasksLabel
            // 
            this.HighPriorityTasksLabel.AutoSize = true;
            this.HighPriorityTasksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HighPriorityTasksLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.HighPriorityTasksLabel.ForeColor = System.Drawing.Color.Silver;
            this.HighPriorityTasksLabel.Location = new System.Drawing.Point(32, 642);
            this.HighPriorityTasksLabel.Name = "HighPriorityTasksLabel";
            this.HighPriorityTasksLabel.Size = new System.Drawing.Size(34, 15);
            this.HighPriorityTasksLabel.TabIndex = 2;
            this.HighPriorityTasksLabel.Text = "HIGH";
            // 
            // OverdueTasksLabel
            // 
            this.OverdueTasksLabel.AutoSize = true;
            this.OverdueTasksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OverdueTasksLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.OverdueTasksLabel.ForeColor = System.Drawing.Color.Silver;
            this.OverdueTasksLabel.Location = new System.Drawing.Point(240, 554);
            this.OverdueTasksLabel.Name = "OverdueTasksLabel";
            this.OverdueTasksLabel.Size = new System.Drawing.Size(58, 15);
            this.OverdueTasksLabel.TabIndex = 2;
            this.OverdueTasksLabel.Text = "OVERDUE";
            // 
            // OverdueTasksCounterLabel
            // 
            this.OverdueTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OverdueTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverdueTasksCounterLabel.ForeColor = System.Drawing.Color.Crimson;
            this.OverdueTasksCounterLabel.Location = new System.Drawing.Point(235, 513);
            this.OverdueTasksCounterLabel.Name = "OverdueTasksCounterLabel";
            this.OverdueTasksCounterLabel.Size = new System.Drawing.Size(98, 59);
            this.OverdueTasksCounterLabel.TabIndex = 10;
            this.OverdueTasksCounterLabel.Text = "--";
            this.OverdueTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LowPriorityCounterLabel
            // 
            this.LowPriorityCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LowPriorityCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowPriorityCounterLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LowPriorityCounterLabel.Location = new System.Drawing.Point(235, 582);
            this.LowPriorityCounterLabel.Name = "LowPriorityCounterLabel";
            this.LowPriorityCounterLabel.Size = new System.Drawing.Size(96, 81);
            this.LowPriorityCounterLabel.TabIndex = 10;
            this.LowPriorityCounterLabel.Text = "--";
            this.LowPriorityCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MediumTasksCounterLabel
            // 
            this.MediumTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MediumTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumTasksCounterLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.MediumTasksCounterLabel.Location = new System.Drawing.Point(131, 582);
            this.MediumTasksCounterLabel.Name = "MediumTasksCounterLabel";
            this.MediumTasksCounterLabel.Size = new System.Drawing.Size(98, 81);
            this.MediumTasksCounterLabel.TabIndex = 10;
            this.MediumTasksCounterLabel.Text = "--";
            this.MediumTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HighPriorityTasksCounterLabel
            // 
            this.HighPriorityTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HighPriorityTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighPriorityTasksCounterLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.HighPriorityTasksCounterLabel.Location = new System.Drawing.Point(27, 582);
            this.HighPriorityTasksCounterLabel.Name = "HighPriorityTasksCounterLabel";
            this.HighPriorityTasksCounterLabel.Size = new System.Drawing.Size(98, 81);
            this.HighPriorityTasksCounterLabel.TabIndex = 10;
            this.HighPriorityTasksCounterLabel.Text = "--";
            this.HighPriorityTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // QuickPriorityLabel
            // 
            this.QuickPriorityLabel.AutoSize = true;
            this.QuickPriorityLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.QuickPriorityLabel.ForeColor = System.Drawing.Color.Silver;
            this.QuickPriorityLabel.Location = new System.Drawing.Point(23, 251);
            this.QuickPriorityLabel.Name = "QuickPriorityLabel";
            this.QuickPriorityLabel.Size = new System.Drawing.Size(97, 20);
            this.QuickPriorityLabel.TabIndex = 2;
            this.QuickPriorityLabel.Text = "Quick Priority";
            // 
            // ExportsGuideLabel
            // 
            this.ExportsGuideLabel.AutoSize = true;
            this.ExportsGuideLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportsGuideLabel.ForeColor = System.Drawing.Color.Silver;
            this.ExportsGuideLabel.Location = new System.Drawing.Point(23, 336);
            this.ExportsGuideLabel.Name = "ExportsGuideLabel";
            this.ExportsGuideLabel.Size = new System.Drawing.Size(230, 21);
            this.ExportsGuideLabel.TabIndex = 2;
            this.ExportsGuideLabel.Text = "Save the report to a file or print:";
            // 
            // FilterByLabel
            // 
            this.FilterByLabel.AutoSize = true;
            this.FilterByLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FilterByLabel.ForeColor = System.Drawing.Color.Silver;
            this.FilterByLabel.Location = new System.Drawing.Point(23, 197);
            this.FilterByLabel.Name = "FilterByLabel";
            this.FilterByLabel.Size = new System.Drawing.Size(90, 20);
            this.FilterByLabel.TabIndex = 2;
            this.FilterByLabel.Text = "Quick Status";
            // 
            // TaskEditorTitleLabel
            // 
            this.TaskEditorTitleLabel.BackColor = System.Drawing.Color.Orange;
            this.TaskEditorTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskEditorTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskEditorTitleLabel.Name = "TaskEditorTitleLabel";
            this.TaskEditorTitleLabel.Size = new System.Drawing.Size(360, 44);
            this.TaskEditorTitleLabel.TabIndex = 0;
            this.TaskEditorTitleLabel.Text = "Report Controls";
            this.TaskEditorTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitleLabel.ForeColor = System.Drawing.Color.White;
            this.MainTitleLabel.Location = new System.Drawing.Point(68, 25);
            this.MainTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(516, 65);
            this.MainTitleLabel.TabIndex = 10;
            this.MainTitleLabel.Text = "Reports and Task Viewer";
            this.MainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgramLogoPictureBox
            // 
            this.ProgramLogoPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            this.ProgramLogoPictureBox.Location = new System.Drawing.Point(1037, 38);
            this.ProgramLogoPictureBox.Name = "ProgramLogoPictureBox";
            this.ProgramLogoPictureBox.Size = new System.Drawing.Size(45, 45);
            this.ProgramLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProgramLogoPictureBox.TabIndex = 12;
            this.ProgramLogoPictureBox.TabStop = false;
            // 
            // ReturnToDashboardButton
            // 
            this.ReturnToDashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnToDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToDashboardButton.Image = global::MachineProject3_TMS.Properties.Resources.arrow_back;
            this.ReturnToDashboardButton.Location = new System.Drawing.Point(20, 38);
            this.ReturnToDashboardButton.Name = "ReturnToDashboardButton";
            this.ReturnToDashboardButton.Size = new System.Drawing.Size(45, 45);
            this.ReturnToDashboardButton.TabIndex = 13;
            this.ReturnToDashboardButton.UseVisualStyleBackColor = false;
            this.ReturnToDashboardButton.Click += new System.EventHandler(this.ReturnToDashboardButton_Click);
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1102, 815);
            this.Controls.Add(this.ProgramLogoPictureBox);
            this.Controls.Add(this.menuTasks);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainTitleLabel);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management System | Reports";
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