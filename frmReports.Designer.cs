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
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TaskDirectoryPanel = new System.Windows.Forms.Panel();
            this.TaskEditorPanel = new System.Windows.Forms.Panel();
            this.EditorStatusMessageLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TaskEditorTitleLabel = new System.Windows.Forms.Label();
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.FilterByLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStripTasks = new System.Windows.Forms.StatusStrip();
            this.TaskDirectoryStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatabaseStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.ProgramLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SearchDirectoryButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RefreshDirectoryButton = new System.Windows.Forms.Button();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDirectoryDataGridView)).BeginInit();
            this.menuTasks.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TaskDirectoryPanel.SuspendLayout();
            this.TaskEditorPanel.SuspendLayout();
            this.statusStripTasks.SuspendLayout();
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
            this.CompletedLabel.Location = new System.Drawing.Point(187, 554);
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
            this.CompletedTasksCounterLabel.Location = new System.Drawing.Point(182, 513);
            this.CompletedTasksCounterLabel.Name = "CompletedTasksCounterLabel";
            this.CompletedTasksCounterLabel.Size = new System.Drawing.Size(149, 59);
            this.CompletedTasksCounterLabel.TabIndex = 10;
            this.CompletedTasksCounterLabel.Text = "--";
            this.CompletedTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PendingTasksCounterLabel
            // 
            this.PendingTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PendingTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingTasksCounterLabel.ForeColor = System.Drawing.Color.Crimson;
            this.PendingTasksCounterLabel.Location = new System.Drawing.Point(27, 513);
            this.PendingTasksCounterLabel.Name = "PendingTasksCounterLabel";
            this.PendingTasksCounterLabel.Size = new System.Drawing.Size(149, 59);
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
            this.TaskDirectoryDataGridView.Location = new System.Drawing.Point(13, 57);
            this.TaskDirectoryDataGridView.Name = "TaskDirectoryDataGridView";
            this.TaskDirectoryDataGridView.Size = new System.Drawing.Size(679, 564);
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
            this.menuTasks.Size = new System.Drawing.Size(1124, 25);
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
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.Controls.Add(this.TaskDirectoryPanel);
            this.MainPanel.Controls.Add(this.TaskEditorPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 93);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.MainPanel.Size = new System.Drawing.Size(1126, 724);
            this.MainPanel.TabIndex = 11;
            // 
            // TaskDirectoryPanel
            // 
            this.TaskDirectoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TaskDirectoryPanel.Controls.Add(this.statusStripTasks);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryLabel);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryDataGridView);
            this.TaskDirectoryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TaskDirectoryPanel.Location = new System.Drawing.Point(398, 20);
            this.TaskDirectoryPanel.Name = "TaskDirectoryPanel";
            this.TaskDirectoryPanel.Size = new System.Drawing.Size(708, 684);
            this.TaskDirectoryPanel.TabIndex = 0;
            // 
            // TaskEditorPanel
            // 
            this.TaskEditorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TaskEditorPanel.Controls.Add(this.button8);
            this.TaskEditorPanel.Controls.Add(this.button7);
            this.TaskEditorPanel.Controls.Add(this.button3);
            this.TaskEditorPanel.Controls.Add(this.button6);
            this.TaskEditorPanel.Controls.Add(this.button2);
            this.TaskEditorPanel.Controls.Add(this.button1);
            this.TaskEditorPanel.Controls.Add(this.TotalLabel);
            this.TaskEditorPanel.Controls.Add(this.label10);
            this.TaskEditorPanel.Controls.Add(this.label2);
            this.TaskEditorPanel.Controls.Add(this.EditorStatusMessageLabel);
            this.TaskEditorPanel.Controls.Add(this.label8);
            this.TaskEditorPanel.Controls.Add(this.label7);
            this.TaskEditorPanel.Controls.Add(this.label6);
            this.TaskEditorPanel.Controls.Add(this.PendingLabel);
            this.TaskEditorPanel.Controls.Add(this.CompletedLabel);
            this.TaskEditorPanel.Controls.Add(this.CompletedTasksCounterLabel);
            this.TaskEditorPanel.Controls.Add(this.label5);
            this.TaskEditorPanel.Controls.Add(this.label4);
            this.TaskEditorPanel.Controls.Add(this.label3);
            this.TaskEditorPanel.Controls.Add(this.PendingTasksCounterLabel);
            this.TaskEditorPanel.Controls.Add(this.TotalTasksCounterLabel);
            this.TaskEditorPanel.Controls.Add(this.label1);
            this.TaskEditorPanel.Controls.Add(this.label9);
            this.TaskEditorPanel.Controls.Add(this.FilterByLabel);
            this.TaskEditorPanel.Controls.Add(this.button5);
            this.TaskEditorPanel.Controls.Add(this.SearchDirectoryButton);
            this.TaskEditorPanel.Controls.Add(this.button4);
            this.TaskEditorPanel.Controls.Add(this.RefreshDirectoryButton);
            this.TaskEditorPanel.Controls.Add(this.SearchLabel);
            this.TaskEditorPanel.Controls.Add(this.SearchTextBox);
            this.TaskEditorPanel.Controls.Add(this.TaskEditorTitleLabel);
            this.TaskEditorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TaskEditorPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskEditorPanel.Location = new System.Drawing.Point(20, 20);
            this.TaskEditorPanel.Name = "TaskEditorPanel";
            this.TaskEditorPanel.Size = new System.Drawing.Size(360, 684);
            this.TaskEditorPanel.TabIndex = 0;
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
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Gray;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.CausesValidation = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchTextBox.Location = new System.Drawing.Point(27, 102);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(304, 29);
            this.SearchTextBox.TabIndex = 3;
            // 
            // TaskEditorTitleLabel
            // 
            this.TaskEditorTitleLabel.BackColor = System.Drawing.Color.Orange;
            this.TaskEditorTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskEditorTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskEditorTitleLabel.Name = "TaskEditorTitleLabel";
            this.TaskEditorTitleLabel.Size = new System.Drawing.Size(379, 44);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "A&LL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(131, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "CO&MPLETED";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(235, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "&PENDING";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(23, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quick Priority";
            // 
            // label2
            // 
            this.label2.CausesValidation = false;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(27, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "LIVE STATUS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(27, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 81);
            this.label3.TabIndex = 10;
            this.label3.Text = "--";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(131, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 81);
            this.label4.TabIndex = 10;
            this.label4.Text = "--";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(235, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 81);
            this.label5.TabIndex = 10;
            this.label5.Text = "--";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(32, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "HIGH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(136, 642);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "MEDIUM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(240, 642);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "LOW";
            // 
            // label10
            // 
            this.label10.CausesValidation = false;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(24, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(307, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "EXPORT TOOLS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStripTasks
            // 
            this.statusStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskDirectoryStatusMessage,
            this.DatabaseStatusMessage});
            this.statusStripTasks.Location = new System.Drawing.Point(0, 662);
            this.statusStripTasks.Name = "statusStripTasks";
            this.statusStripTasks.Size = new System.Drawing.Size(708, 22);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(23, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Save the report to a file or print:";
            // 
            // ProgramLogoPictureBox
            // 
            this.ProgramLogoPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            this.ProgramLogoPictureBox.Location = new System.Drawing.Point(1059, 35);
            this.ProgramLogoPictureBox.Name = "ProgramLogoPictureBox";
            this.ProgramLogoPictureBox.Size = new System.Drawing.Size(45, 50);
            this.ProgramLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProgramLogoPictureBox.TabIndex = 12;
            this.ProgramLogoPictureBox.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::MachineProject3_TMS.Properties.Resources.export;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.Location = new System.Drawing.Point(27, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 51);
            this.button5.TabIndex = 9;
            this.button5.Text = "&EXPORT";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.UseVisualStyleBackColor = false;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::MachineProject3_TMS.Properties.Resources.print;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.Location = new System.Drawing.Point(182, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "&PRINT";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = false;
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
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Firebrick;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(27, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 25);
            this.button6.TabIndex = 11;
            this.button6.Text = "&HIGH";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(131, 274);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 25);
            this.button7.TabIndex = 11;
            this.button7.Text = "&MEDIUM";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(235, 274);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 25);
            this.button8.TabIndex = 11;
            this.button8.Text = "&LOW";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1124, 815);
            this.Controls.Add(this.ProgramLogoPictureBox);
            this.Controls.Add(this.menuTasks);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainTitleLabel);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.Name = "FrmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TaskDirectoryDataGridView)).EndInit();
            this.menuTasks.ResumeLayout(false);
            this.menuTasks.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.TaskDirectoryPanel.ResumeLayout(false);
            this.TaskDirectoryPanel.PerformLayout();
            this.TaskEditorPanel.ResumeLayout(false);
            this.TaskEditorPanel.PerformLayout();
            this.statusStripTasks.ResumeLayout(false);
            this.statusStripTasks.PerformLayout();
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
        private System.Windows.Forms.Panel TaskEditorPanel;
        private System.Windows.Forms.Label EditorStatusMessageLabel;
        private System.Windows.Forms.Label TaskEditorTitleLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FilterByLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStripTasks;
        private System.Windows.Forms.ToolStripStatusLabel TaskDirectoryStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel DatabaseStatusMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}