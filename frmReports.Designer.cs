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
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ProgramLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.PendingLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.CompletedTasksCounterLabel = new System.Windows.Forms.Label();
            this.PendingTasksCounterLabel = new System.Windows.Forms.Label();
            this.TotalTasksCounterLabel = new System.Windows.Forms.Label();
            this.FilterByLabel = new System.Windows.Forms.Label();
            this.SearchDirectoryButton = new System.Windows.Forms.Button();
            this.RefreshDirectoryButton = new System.Windows.Forms.Button();
            this.TaskDirectoryLabel = new System.Windows.Forms.Label();
            this.FilterByComboBox = new System.Windows.Forms.ComboBox();
            this.TaskDirectoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.menuTasks = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TaskDirectoryPanel = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.statusStripTasks = new System.Windows.Forms.StatusStrip();
            this.TaskDirectoryStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatabaseStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            this.TaskEditorTitleLabel = new System.Windows.Forms.Label();
            this.EditorStatusMessageLabel = new System.Windows.Forms.Label();
            this.TaskEditorPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDirectoryDataGridView)).BeginInit();
            this.menuTasks.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TaskDirectoryPanel.SuspendLayout();
            this.statusStripTasks.SuspendLayout();
            this.TaskEditorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.TotalLabel.ForeColor = System.Drawing.Color.Silver;
            this.TotalLabel.Location = new System.Drawing.Point(38, 354);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(74, 15);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "TOTAL TASKS";
            // 
            // ProgramLogoPictureBox
            // 
            this.ProgramLogoPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            this.ProgramLogoPictureBox.Location = new System.Drawing.Point(1047, 28);
            this.ProgramLogoPictureBox.Name = "ProgramLogoPictureBox";
            this.ProgramLogoPictureBox.Size = new System.Drawing.Size(60, 58);
            this.ProgramLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProgramLogoPictureBox.TabIndex = 12;
            this.ProgramLogoPictureBox.TabStop = false;
            // 
            // PendingLabel
            // 
            this.PendingLabel.AutoSize = true;
            this.PendingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PendingLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.PendingLabel.ForeColor = System.Drawing.Color.Silver;
            this.PendingLabel.Location = new System.Drawing.Point(37, 427);
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
            this.CompletedLabel.Location = new System.Drawing.Point(37, 497);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(72, 15);
            this.CompletedLabel.TabIndex = 2;
            this.CompletedLabel.Text = "COMPLETED";
            // 
            // CompletedTasksCounterLabel
            // 
            this.CompletedTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompletedTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedTasksCounterLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CompletedTasksCounterLabel.Location = new System.Drawing.Point(33, 454);
            this.CompletedTasksCounterLabel.Name = "CompletedTasksCounterLabel";
            this.CompletedTasksCounterLabel.Size = new System.Drawing.Size(164, 64);
            this.CompletedTasksCounterLabel.TabIndex = 10;
            this.CompletedTasksCounterLabel.Text = "--";
            this.CompletedTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PendingTasksCounterLabel
            // 
            this.PendingTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PendingTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingTasksCounterLabel.ForeColor = System.Drawing.Color.Crimson;
            this.PendingTasksCounterLabel.Location = new System.Drawing.Point(33, 383);
            this.PendingTasksCounterLabel.Name = "PendingTasksCounterLabel";
            this.PendingTasksCounterLabel.Size = new System.Drawing.Size(164, 64);
            this.PendingTasksCounterLabel.TabIndex = 10;
            this.PendingTasksCounterLabel.Text = "--";
            this.PendingTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalTasksCounterLabel
            // 
            this.TotalTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TotalTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTasksCounterLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.TotalTasksCounterLabel.Location = new System.Drawing.Point(33, 312);
            this.TotalTasksCounterLabel.Name = "TotalTasksCounterLabel";
            this.TotalTasksCounterLabel.Size = new System.Drawing.Size(164, 64);
            this.TotalTasksCounterLabel.TabIndex = 10;
            this.TotalTasksCounterLabel.Text = "--";
            this.TotalTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FilterByLabel
            // 
            this.FilterByLabel.AutoSize = true;
            this.FilterByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterByLabel.ForeColor = System.Drawing.Color.Silver;
            this.FilterByLabel.Location = new System.Drawing.Point(29, 614);
            this.FilterByLabel.Name = "FilterByLabel";
            this.FilterByLabel.Size = new System.Drawing.Size(66, 21);
            this.FilterByLabel.TabIndex = 2;
            this.FilterByLabel.Text = "Filter By";
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
            this.SearchDirectoryButton.Location = new System.Drawing.Point(33, 679);
            this.SearchDirectoryButton.Name = "SearchDirectoryButton";
            this.SearchDirectoryButton.Size = new System.Drawing.Size(164, 51);
            this.SearchDirectoryButton.TabIndex = 9;
            this.SearchDirectoryButton.Text = "SEARCH";
            this.SearchDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SearchDirectoryButton.UseVisualStyleBackColor = false;
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
            this.RefreshDirectoryButton.Location = new System.Drawing.Point(33, 736);
            this.RefreshDirectoryButton.Name = "RefreshDirectoryButton";
            this.RefreshDirectoryButton.Size = new System.Drawing.Size(164, 51);
            this.RefreshDirectoryButton.TabIndex = 7;
            this.RefreshDirectoryButton.Text = "REFRESH";
            this.RefreshDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RefreshDirectoryButton.UseVisualStyleBackColor = false;
            // 
            // TaskDirectoryLabel
            // 
            this.TaskDirectoryLabel.BackColor = System.Drawing.Color.Orange;
            this.TaskDirectoryLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskDirectoryLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskDirectoryLabel.Name = "TaskDirectoryLabel";
            this.TaskDirectoryLabel.Size = new System.Drawing.Size(838, 44);
            this.TaskDirectoryLabel.TabIndex = 0;
            this.TaskDirectoryLabel.Text = "Task Directory";
            this.TaskDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilterByComboBox
            // 
            this.FilterByComboBox.BackColor = System.Drawing.Color.Gray;
            this.FilterByComboBox.CausesValidation = false;
            this.FilterByComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterByComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FilterByComboBox.ForeColor = System.Drawing.Color.White;
            this.FilterByComboBox.FormattingEnabled = true;
            this.FilterByComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.FilterByComboBox.Location = new System.Drawing.Point(33, 638);
            this.FilterByComboBox.Name = "FilterByComboBox";
            this.FilterByComboBox.Size = new System.Drawing.Size(164, 29);
            this.FilterByComboBox.TabIndex = 5;
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
            this.TaskDirectoryDataGridView.Location = new System.Drawing.Point(13, 57);
            this.TaskDirectoryDataGridView.Name = "TaskDirectoryDataGridView";
            this.TaskDirectoryDataGridView.Size = new System.Drawing.Size(669, 697);
            this.TaskDirectoryDataGridView.TabIndex = 3;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Silver;
            this.SearchLabel.Location = new System.Drawing.Point(29, 555);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 21);
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
            this.menuTasks.Size = new System.Drawing.Size(1125, 25);
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
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.recordToolStripMenuItem.Text = "&Record";
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
            this.aboutToolStripMenuItem});
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.Controls.Add(this.TaskDirectoryPanel);
            this.MainPanel.Controls.Add(this.TaskEditorPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 91);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.MainPanel.Size = new System.Drawing.Size(1127, 831);
            this.MainPanel.TabIndex = 11;
            // 
            // TaskDirectoryPanel
            // 
            this.TaskDirectoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryLabel);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryDataGridView);
            this.TaskDirectoryPanel.Controls.Add(this.statusStripTasks);
            this.TaskDirectoryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TaskDirectoryPanel.Location = new System.Drawing.Point(412, 20);
            this.TaskDirectoryPanel.Name = "TaskDirectoryPanel";
            this.TaskDirectoryPanel.Size = new System.Drawing.Size(695, 791);
            this.TaskDirectoryPanel.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Gray;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.CausesValidation = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchTextBox.Location = new System.Drawing.Point(33, 579);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(164, 29);
            this.SearchTextBox.TabIndex = 3;
            // 
            // statusStripTasks
            // 
            this.statusStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskDirectoryStatusMessage,
            this.DatabaseStatusMessage});
            this.statusStripTasks.Location = new System.Drawing.Point(0, 769);
            this.statusStripTasks.Name = "statusStripTasks";
            this.statusStripTasks.Size = new System.Drawing.Size(695, 22);
            this.statusStripTasks.TabIndex = 1;
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
            // ReturnToDashboardButton
            // 
            this.ReturnToDashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnToDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToDashboardButton.Image = global::MachineProject3_TMS.Properties.Resources.arrow_back;
            this.ReturnToDashboardButton.Location = new System.Drawing.Point(20, 40);
            this.ReturnToDashboardButton.Name = "ReturnToDashboardButton";
            this.ReturnToDashboardButton.Size = new System.Drawing.Size(45, 45);
            this.ReturnToDashboardButton.TabIndex = 13;
            this.ReturnToDashboardButton.UseVisualStyleBackColor = false;
            // 
            // TaskEditorTitleLabel
            // 
            this.TaskEditorTitleLabel.BackColor = System.Drawing.Color.Orange;
            this.TaskEditorTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskEditorTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskEditorTitleLabel.Name = "TaskEditorTitleLabel";
            this.TaskEditorTitleLabel.Size = new System.Drawing.Size(379, 44);
            this.TaskEditorTitleLabel.TabIndex = 0;
            this.TaskEditorTitleLabel.Text = "Report Control";
            this.TaskEditorTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditorStatusMessageLabel
            // 
            this.EditorStatusMessageLabel.CausesValidation = false;
            this.EditorStatusMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorStatusMessageLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorStatusMessageLabel.Location = new System.Drawing.Point(17, 75);
            this.EditorStatusMessageLabel.Name = "EditorStatusMessageLabel";
            this.EditorStatusMessageLabel.Size = new System.Drawing.Size(342, 29);
            this.EditorStatusMessageLabel.TabIndex = 10;
            this.EditorStatusMessageLabel.Text = "--";
            this.EditorStatusMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskEditorPanel
            // 
            this.TaskEditorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TaskEditorPanel.Controls.Add(this.TotalLabel);
            this.TaskEditorPanel.Controls.Add(this.EditorStatusMessageLabel);
            this.TaskEditorPanel.Controls.Add(this.PendingLabel);
            this.TaskEditorPanel.Controls.Add(this.CompletedLabel);
            this.TaskEditorPanel.Controls.Add(this.CompletedTasksCounterLabel);
            this.TaskEditorPanel.Controls.Add(this.PendingTasksCounterLabel);
            this.TaskEditorPanel.Controls.Add(this.TotalTasksCounterLabel);
            this.TaskEditorPanel.Controls.Add(this.FilterByLabel);
            this.TaskEditorPanel.Controls.Add(this.SearchDirectoryButton);
            this.TaskEditorPanel.Controls.Add(this.RefreshDirectoryButton);
            this.TaskEditorPanel.Controls.Add(this.FilterByComboBox);
            this.TaskEditorPanel.Controls.Add(this.SearchLabel);
            this.TaskEditorPanel.Controls.Add(this.SearchTextBox);
            this.TaskEditorPanel.Controls.Add(this.TaskEditorTitleLabel);
            this.TaskEditorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TaskEditorPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskEditorPanel.Location = new System.Drawing.Point(20, 20);
            this.TaskEditorPanel.Name = "TaskEditorPanel";
            this.TaskEditorPanel.Size = new System.Drawing.Size(377, 791);
            this.TaskEditorPanel.TabIndex = 0;
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1125, 919);
            this.Controls.Add(this.ProgramLogoPictureBox);
            this.Controls.Add(this.menuTasks);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainTitleLabel);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.Name = "FrmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDirectoryDataGridView)).EndInit();
            this.menuTasks.ResumeLayout(false);
            this.menuTasks.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.TaskDirectoryPanel.ResumeLayout(false);
            this.TaskDirectoryPanel.PerformLayout();
            this.statusStripTasks.ResumeLayout(false);
            this.statusStripTasks.PerformLayout();
            this.TaskEditorPanel.ResumeLayout(false);
            this.TaskEditorPanel.PerformLayout();
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
        private System.Windows.Forms.Label FilterByLabel;
        private System.Windows.Forms.Button SearchDirectoryButton;
        private System.Windows.Forms.Button RefreshDirectoryButton;
        private System.Windows.Forms.Label TaskDirectoryLabel;
        private System.Windows.Forms.ComboBox FilterByComboBox;
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
        private System.Windows.Forms.StatusStrip statusStripTasks;
        private System.Windows.Forms.ToolStripStatusLabel TaskDirectoryStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel DatabaseStatusMessage;
        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Button ReturnToDashboardButton;
        private System.Windows.Forms.Panel TaskEditorPanel;
        private System.Windows.Forms.Label EditorStatusMessageLabel;
        private System.Windows.Forms.Label TaskEditorTitleLabel;
    }
}