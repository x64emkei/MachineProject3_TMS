namespace MachineProject3_TMS
{
    partial class FrmTasks
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
        /// Initializes the form components.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTasks));
            this.menuTasks = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TaskDirectoryPanel = new System.Windows.Forms.Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PendingLabel = new System.Windows.Forms.Label();
            this.InProgressLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.InProgressCounterLabel = new System.Windows.Forms.Label();
            this.CompletedTasksCounterLabel = new System.Windows.Forms.Label();
            this.PendingTasksCounterLabel = new System.Windows.Forms.Label();
            this.TotalTasksCounterLabel = new System.Windows.Forms.Label();
            this.SearchDirectoryButton = new System.Windows.Forms.Button();
            this.RefreshDirectoryButton = new System.Windows.Forms.Button();
            this.TaskDirectoryLabel = new System.Windows.Forms.Label();
            this.TaskDirectoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.statusStripTasks = new System.Windows.Forms.StatusStrip();
            this.TaskDirectoryStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatabaseStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.TaskEditorPanel = new System.Windows.Forms.Panel();
            this.EditorStatusMessageLabel = new System.Windows.Forms.Label();
            this.ClearEditorButton = new System.Windows.Forms.Button();
            this.DeleteEditorButton = new System.Windows.Forms.Button();
            this.UpdateEditorButton = new System.Windows.Forms.Button();
            this.AddEditorButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.DueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AssignedToTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TaskTitleTextBox = new System.Windows.Forms.TextBox();
            this.TaskIDTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.AssignedToLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TaskTitleLabel = new System.Windows.Forms.Label();
            this.TaskIDLabel = new System.Windows.Forms.Label();
            this.TaskEditorTitleLabel = new System.Windows.Forms.Label();
            this.ProgramLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            this.menuTasks.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TaskDirectoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDirectoryDataGridView)).BeginInit();
            this.statusStripTasks.SuspendLayout();
            this.TaskEditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.menuTasks.Size = new System.Drawing.Size(1456, 25);
            this.menuTasks.TabIndex = 0;
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
            this.addTaskToolStripMenuItem,
            this.updateTaskToolStripMenuItem,
            this.deleteTaskToolStripMenuItem,
            this.toolStripMenuItem4});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.recordToolStripMenuItem.Text = "&Record";
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addTaskToolStripMenuItem.Text = "&Add Task";
            // 
            // updateTaskToolStripMenuItem
            // 
            this.updateTaskToolStripMenuItem.Name = "updateTaskToolStripMenuItem";
            this.updateTaskToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.updateTaskToolStripMenuItem.Text = "&Update Task";
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteTaskToolStripMenuItem.Text = "&Delete Task";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 6);
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
            this.MainTitleLabel.Size = new System.Drawing.Size(390, 65);
            this.MainTitleLabel.TabIndex = 5;
            this.MainTitleLabel.Text = "Task Management";
            this.MainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.Controls.Add(this.TaskDirectoryPanel);
            this.MainPanel.Controls.Add(this.TaskEditorPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 90);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.MainPanel.Size = new System.Drawing.Size(1456, 606);
            this.MainPanel.TabIndex = 6;
            // 
            // TaskDirectoryPanel
            // 
            this.TaskDirectoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskDirectoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TaskDirectoryPanel.Controls.Add(this.TotalLabel);
            this.TaskDirectoryPanel.Controls.Add(this.PendingLabel);
            this.TaskDirectoryPanel.Controls.Add(this.InProgressLabel);
            this.TaskDirectoryPanel.Controls.Add(this.CompletedLabel);
            this.TaskDirectoryPanel.Controls.Add(this.InProgressCounterLabel);
            this.TaskDirectoryPanel.Controls.Add(this.CompletedTasksCounterLabel);
            this.TaskDirectoryPanel.Controls.Add(this.PendingTasksCounterLabel);
            this.TaskDirectoryPanel.Controls.Add(this.TotalTasksCounterLabel);
            this.TaskDirectoryPanel.Controls.Add(this.SearchDirectoryButton);
            this.TaskDirectoryPanel.Controls.Add(this.RefreshDirectoryButton);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryLabel);
            this.TaskDirectoryPanel.Controls.Add(this.TaskDirectoryDataGridView);
            this.TaskDirectoryPanel.Controls.Add(this.SearchLabel);
            this.TaskDirectoryPanel.Controls.Add(this.SearchTextBox);
            this.TaskDirectoryPanel.Controls.Add(this.statusStripTasks);
            this.TaskDirectoryPanel.Location = new System.Drawing.Point(405, 20);
            this.TaskDirectoryPanel.Name = "TaskDirectoryPanel";
            this.TaskDirectoryPanel.Size = new System.Drawing.Size(1031, 566);
            this.TaskDirectoryPanel.TabIndex = 0;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.TotalLabel.ForeColor = System.Drawing.Color.Silver;
            this.TotalLabel.Location = new System.Drawing.Point(18, 99);
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
            this.PendingLabel.Location = new System.Drawing.Point(22, 177);
            this.PendingLabel.Name = "PendingLabel";
            this.PendingLabel.Size = new System.Drawing.Size(57, 15);
            this.PendingLabel.TabIndex = 2;
            this.PendingLabel.Text = "PENDING";
            // 
            // InProgressLabel
            // 
            this.InProgressLabel.AutoSize = true;
            this.InProgressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InProgressLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.InProgressLabel.ForeColor = System.Drawing.Color.Silver;
            this.InProgressLabel.Location = new System.Drawing.Point(18, 251);
            this.InProgressLabel.Name = "InProgressLabel";
            this.InProgressLabel.Size = new System.Drawing.Size(78, 15);
            this.InProgressLabel.TabIndex = 2;
            this.InProgressLabel.Text = "IN PROGRESS";
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompletedLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.CompletedLabel.ForeColor = System.Drawing.Color.Silver;
            this.CompletedLabel.Location = new System.Drawing.Point(18, 327);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(72, 15);
            this.CompletedLabel.TabIndex = 2;
            this.CompletedLabel.Text = "COMPLETED";
            // 
            // InProgressCounterLabel
            // 
            this.InProgressCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InProgressCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InProgressCounterLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.InProgressCounterLabel.Location = new System.Drawing.Point(13, 207);
            this.InProgressCounterLabel.Name = "InProgressCounterLabel";
            this.InProgressCounterLabel.Size = new System.Drawing.Size(164, 64);
            this.InProgressCounterLabel.TabIndex = 10;
            this.InProgressCounterLabel.Text = "--";
            this.InProgressCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CompletedTasksCounterLabel
            // 
            this.CompletedTasksCounterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompletedTasksCounterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedTasksCounterLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CompletedTasksCounterLabel.Location = new System.Drawing.Point(13, 282);
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
            this.PendingTasksCounterLabel.Location = new System.Drawing.Point(13, 132);
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
            this.TotalTasksCounterLabel.Location = new System.Drawing.Point(13, 57);
            this.TotalTasksCounterLabel.Name = "TotalTasksCounterLabel";
            this.TotalTasksCounterLabel.Size = new System.Drawing.Size(164, 64);
            this.TotalTasksCounterLabel.TabIndex = 10;
            this.TotalTasksCounterLabel.Text = "--";
            this.TotalTasksCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.SearchDirectoryButton.Location = new System.Drawing.Point(13, 424);
            this.SearchDirectoryButton.Name = "SearchDirectoryButton";
            this.SearchDirectoryButton.Size = new System.Drawing.Size(164, 51);
            this.SearchDirectoryButton.TabIndex = 9;
            this.SearchDirectoryButton.Text = "SEARCH";
            this.SearchDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SearchDirectoryButton.UseVisualStyleBackColor = false;
            this.SearchDirectoryButton.Click += new System.EventHandler(this.SearchDirectoryButton_Click);
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
            this.RefreshDirectoryButton.Location = new System.Drawing.Point(13, 481);
            this.RefreshDirectoryButton.Name = "RefreshDirectoryButton";
            this.RefreshDirectoryButton.Size = new System.Drawing.Size(164, 51);
            this.RefreshDirectoryButton.TabIndex = 7;
            this.RefreshDirectoryButton.Text = "REFRESH";
            this.RefreshDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RefreshDirectoryButton.UseVisualStyleBackColor = false;
            this.RefreshDirectoryButton.Click += new System.EventHandler(this.RefreshDirectoryButton_Click);
            // 
            // TaskDirectoryLabel
            // 
            this.TaskDirectoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskDirectoryLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TaskDirectoryLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskDirectoryLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskDirectoryLabel.Name = "TaskDirectoryLabel";
            this.TaskDirectoryLabel.Size = new System.Drawing.Size(1039, 44);
            this.TaskDirectoryLabel.TabIndex = 0;
            this.TaskDirectoryLabel.Text = "Task Directory";
            this.TaskDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskDirectoryDataGridView
            // 
            this.TaskDirectoryDataGridView.AllowUserToAddRows = false;
            this.TaskDirectoryDataGridView.AllowUserToDeleteRows = false;
            this.TaskDirectoryDataGridView.AllowUserToOrderColumns = true;
            this.TaskDirectoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskDirectoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskDirectoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TaskDirectoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TaskDirectoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDirectoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskDirectoryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TaskDirectoryDataGridView.EnableHeadersVisualStyles = false;
            this.TaskDirectoryDataGridView.Location = new System.Drawing.Point(187, 57);
            this.TaskDirectoryDataGridView.Name = "TaskDirectoryDataGridView";
            this.TaskDirectoryDataGridView.ReadOnly = true;
            this.TaskDirectoryDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDirectoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TaskDirectoryDataGridView.Size = new System.Drawing.Size(829, 475);
            this.TaskDirectoryDataGridView.TabIndex = 3;
            this.TaskDirectoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskDirectoryDataGridView_CellClick);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Silver;
            this.SearchLabel.Location = new System.Drawing.Point(9, 362);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 21);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.CausesValidation = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchTextBox.Location = new System.Drawing.Point(13, 386);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(164, 29);
            this.SearchTextBox.TabIndex = 3;
            // 
            // statusStripTasks
            // 
            this.statusStripTasks.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskDirectoryStatusMessage,
            this.DatabaseStatusMessage});
            this.statusStripTasks.Location = new System.Drawing.Point(0, 544);
            this.statusStripTasks.Name = "statusStripTasks";
            this.statusStripTasks.Size = new System.Drawing.Size(1031, 22);
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
            // TaskEditorPanel
            // 
            this.TaskEditorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TaskEditorPanel.Controls.Add(this.EditorStatusMessageLabel);
            this.TaskEditorPanel.Controls.Add(this.ClearEditorButton);
            this.TaskEditorPanel.Controls.Add(this.DeleteEditorButton);
            this.TaskEditorPanel.Controls.Add(this.UpdateEditorButton);
            this.TaskEditorPanel.Controls.Add(this.AddEditorButton);
            this.TaskEditorPanel.Controls.Add(this.CategoryComboBox);
            this.TaskEditorPanel.Controls.Add(this.PriorityComboBox);
            this.TaskEditorPanel.Controls.Add(this.StatusComboBox);
            this.TaskEditorPanel.Controls.Add(this.DueDatePicker);
            this.TaskEditorPanel.Controls.Add(this.AssignedToTextBox);
            this.TaskEditorPanel.Controls.Add(this.DescriptionTextBox);
            this.TaskEditorPanel.Controls.Add(this.TaskTitleTextBox);
            this.TaskEditorPanel.Controls.Add(this.TaskIDTextBox);
            this.TaskEditorPanel.Controls.Add(this.StatusLabel);
            this.TaskEditorPanel.Controls.Add(this.CategoryLabel);
            this.TaskEditorPanel.Controls.Add(this.PriorityLabel);
            this.TaskEditorPanel.Controls.Add(this.AssignedToLabel);
            this.TaskEditorPanel.Controls.Add(this.DueDateLabel);
            this.TaskEditorPanel.Controls.Add(this.DescriptionLabel);
            this.TaskEditorPanel.Controls.Add(this.TaskTitleLabel);
            this.TaskEditorPanel.Controls.Add(this.TaskIDLabel);
            this.TaskEditorPanel.Controls.Add(this.TaskEditorTitleLabel);
            this.TaskEditorPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskEditorPanel.Location = new System.Drawing.Point(20, 20);
            this.TaskEditorPanel.Name = "TaskEditorPanel";
            this.TaskEditorPanel.Size = new System.Drawing.Size(377, 566);
            this.TaskEditorPanel.TabIndex = 0;
            // 
            // EditorStatusMessageLabel
            // 
            this.EditorStatusMessageLabel.CausesValidation = false;
            this.EditorStatusMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorStatusMessageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorStatusMessageLabel.Location = new System.Drawing.Point(17, 324);
            this.EditorStatusMessageLabel.Name = "EditorStatusMessageLabel";
            this.EditorStatusMessageLabel.Size = new System.Drawing.Size(342, 29);
            this.EditorStatusMessageLabel.TabIndex = 10;
            this.EditorStatusMessageLabel.Text = "--";
            this.EditorStatusMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearEditorButton
            // 
            this.ClearEditorButton.BackColor = System.Drawing.Color.DimGray;
            this.ClearEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearEditorButton.FlatAppearance.BorderSize = 0;
            this.ClearEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearEditorButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEditorButton.Image = global::MachineProject3_TMS.Properties.Resources.clear;
            this.ClearEditorButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ClearEditorButton.Location = new System.Drawing.Point(191, 458);
            this.ClearEditorButton.Name = "ClearEditorButton";
            this.ClearEditorButton.Size = new System.Drawing.Size(168, 90);
            this.ClearEditorButton.TabIndex = 9;
            this.ClearEditorButton.Text = "CLEAR";
            this.ClearEditorButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ClearEditorButton.UseVisualStyleBackColor = false;
            this.ClearEditorButton.Click += new System.EventHandler(this.ClearEditorButton_Click);
            // 
            // DeleteEditorButton
            // 
            this.DeleteEditorButton.BackColor = System.Drawing.Color.Firebrick;
            this.DeleteEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteEditorButton.FlatAppearance.BorderSize = 0;
            this.DeleteEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEditorButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEditorButton.Image = global::MachineProject3_TMS.Properties.Resources.delete;
            this.DeleteEditorButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.DeleteEditorButton.Location = new System.Drawing.Point(17, 458);
            this.DeleteEditorButton.Name = "DeleteEditorButton";
            this.DeleteEditorButton.Size = new System.Drawing.Size(168, 90);
            this.DeleteEditorButton.TabIndex = 8;
            this.DeleteEditorButton.Text = "DELETE";
            this.DeleteEditorButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DeleteEditorButton.UseVisualStyleBackColor = false;
            this.DeleteEditorButton.Click += new System.EventHandler(this.DeleteEditorButton_Click);
            // 
            // UpdateEditorButton
            // 
            this.UpdateEditorButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.UpdateEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateEditorButton.FlatAppearance.BorderSize = 0;
            this.UpdateEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEditorButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEditorButton.Image = global::MachineProject3_TMS.Properties.Resources.update;
            this.UpdateEditorButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.UpdateEditorButton.Location = new System.Drawing.Point(191, 362);
            this.UpdateEditorButton.Name = "UpdateEditorButton";
            this.UpdateEditorButton.Size = new System.Drawing.Size(168, 90);
            this.UpdateEditorButton.TabIndex = 7;
            this.UpdateEditorButton.Text = "UPDATE";
            this.UpdateEditorButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UpdateEditorButton.UseVisualStyleBackColor = false;
            this.UpdateEditorButton.Click += new System.EventHandler(this.UpdateEditorButton_Click);
            // 
            // AddEditorButton
            // 
            this.AddEditorButton.BackColor = System.Drawing.Color.SeaGreen;
            this.AddEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEditorButton.FlatAppearance.BorderSize = 0;
            this.AddEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEditorButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEditorButton.Image = global::MachineProject3_TMS.Properties.Resources.add;
            this.AddEditorButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddEditorButton.Location = new System.Drawing.Point(17, 362);
            this.AddEditorButton.Name = "AddEditorButton";
            this.AddEditorButton.Size = new System.Drawing.Size(168, 90);
            this.AddEditorButton.TabIndex = 6;
            this.AddEditorButton.Text = "ADD";
            this.AddEditorButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AddEditorButton.UseVisualStyleBackColor = false;
            this.AddEditorButton.Click += new System.EventHandler(this.AddEditorButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.CategoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CategoryComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(219, 275);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(140, 29);
            this.CategoryComboBox.TabIndex = 5;
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.PriorityComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PriorityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriorityComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PriorityComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.PriorityComboBox.Location = new System.Drawing.Point(138, 223);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(105, 25);
            this.PriorityComboBox.TabIndex = 5;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.StatusComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed"});
            this.StatusComboBox.Location = new System.Drawing.Point(249, 223);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(110, 25);
            this.StatusComboBox.TabIndex = 5;
            // 
            // DueDatePicker
            // 
            this.DueDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DueDatePicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DueDatePicker.Location = new System.Drawing.Point(16, 223);
            this.DueDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DueDatePicker.Name = "DueDatePicker";
            this.DueDatePicker.Size = new System.Drawing.Size(116, 25);
            this.DueDatePicker.TabIndex = 4;
            // 
            // AssignedToTextBox
            // 
            this.AssignedToTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.AssignedToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssignedToTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedToTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.AssignedToTextBox.Location = new System.Drawing.Point(16, 275);
            this.AssignedToTextBox.Name = "AssignedToTextBox";
            this.AssignedToTextBox.Size = new System.Drawing.Size(195, 29);
            this.AssignedToTextBox.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.DescriptionTextBox.Location = new System.Drawing.Point(16, 148);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(343, 29);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // TaskTitleTextBox
            // 
            this.TaskTitleTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.TaskTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskTitleTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.TaskTitleTextBox.Location = new System.Drawing.Point(110, 92);
            this.TaskTitleTextBox.Name = "TaskTitleTextBox";
            this.TaskTitleTextBox.Size = new System.Drawing.Size(249, 29);
            this.TaskTitleTextBox.TabIndex = 3;
            // 
            // TaskIDTextBox
            // 
            this.TaskIDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.TaskIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskIDTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.TaskIDTextBox.Location = new System.Drawing.Point(16, 92);
            this.TaskIDTextBox.Name = "TaskIDTextBox";
            this.TaskIDTextBox.ReadOnly = true;
            this.TaskIDTextBox.Size = new System.Drawing.Size(88, 29);
            this.TaskIDTextBox.TabIndex = 3;
            this.TaskIDTextBox.TabStop = false;
            this.TaskIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Silver;
            this.StatusLabel.Location = new System.Drawing.Point(245, 199);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 21);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.ForeColor = System.Drawing.Color.Silver;
            this.CategoryLabel.Location = new System.Drawing.Point(215, 251);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(73, 21);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityLabel.ForeColor = System.Drawing.Color.Silver;
            this.PriorityLabel.Location = new System.Drawing.Point(134, 199);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(61, 21);
            this.PriorityLabel.TabIndex = 2;
            this.PriorityLabel.Text = "Priority";
            // 
            // AssignedToLabel
            // 
            this.AssignedToLabel.AutoSize = true;
            this.AssignedToLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedToLabel.ForeColor = System.Drawing.Color.Silver;
            this.AssignedToLabel.Location = new System.Drawing.Point(12, 251);
            this.AssignedToLabel.Name = "AssignedToLabel";
            this.AssignedToLabel.Size = new System.Drawing.Size(92, 21);
            this.AssignedToLabel.TabIndex = 2;
            this.AssignedToLabel.Text = "Assigned To";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.ForeColor = System.Drawing.Color.Silver;
            this.DueDateLabel.Location = new System.Drawing.Point(12, 199);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(74, 21);
            this.DueDateLabel.TabIndex = 2;
            this.DueDateLabel.Text = "Due Date";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Silver;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 124);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 21);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // TaskTitleLabel
            // 
            this.TaskTitleLabel.AutoSize = true;
            this.TaskTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskTitleLabel.ForeColor = System.Drawing.Color.Silver;
            this.TaskTitleLabel.Location = new System.Drawing.Point(106, 68);
            this.TaskTitleLabel.Name = "TaskTitleLabel";
            this.TaskTitleLabel.Size = new System.Drawing.Size(72, 21);
            this.TaskTitleLabel.TabIndex = 2;
            this.TaskTitleLabel.Text = "Task Title";
            // 
            // TaskIDLabel
            // 
            this.TaskIDLabel.AutoSize = true;
            this.TaskIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskIDLabel.ForeColor = System.Drawing.Color.Silver;
            this.TaskIDLabel.Location = new System.Drawing.Point(12, 68);
            this.TaskIDLabel.Name = "TaskIDLabel";
            this.TaskIDLabel.Size = new System.Drawing.Size(58, 21);
            this.TaskIDLabel.TabIndex = 2;
            this.TaskIDLabel.Text = "Task ID";
            // 
            // TaskEditorTitleLabel
            // 
            this.TaskEditorTitleLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TaskEditorTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskEditorTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskEditorTitleLabel.Name = "TaskEditorTitleLabel";
            this.TaskEditorTitleLabel.Size = new System.Drawing.Size(379, 44);
            this.TaskEditorTitleLabel.TabIndex = 0;
            this.TaskEditorTitleLabel.Text = "Task Editor";
            this.TaskEditorTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProgramLogoPictureBox
            // 
            this.ProgramLogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramLogoPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            this.ProgramLogoPictureBox.Location = new System.Drawing.Point(1391, 37);
            this.ProgramLogoPictureBox.Name = "ProgramLogoPictureBox";
            this.ProgramLogoPictureBox.Size = new System.Drawing.Size(45, 45);
            this.ProgramLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProgramLogoPictureBox.TabIndex = 14;
            this.ProgramLogoPictureBox.TabStop = false;
            // 
            // ReturnToDashboardButton
            // 
            this.ReturnToDashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnToDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToDashboardButton.Image = global::MachineProject3_TMS.Properties.Resources.arrow_back;
            this.ReturnToDashboardButton.Location = new System.Drawing.Point(20, 37);
            this.ReturnToDashboardButton.Name = "ReturnToDashboardButton";
            this.ReturnToDashboardButton.Size = new System.Drawing.Size(45, 45);
            this.ReturnToDashboardButton.TabIndex = 15;
            this.ReturnToDashboardButton.UseVisualStyleBackColor = false;
            this.ReturnToDashboardButton.Click += new System.EventHandler(this.ReturnToDashboardButton_Click);
            // 
            // FrmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1456, 696);
            this.Controls.Add(this.ProgramLogoPictureBox);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.Controls.Add(this.menuTasks);
            this.Controls.Add(this.MainTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTasks;
            this.Name = "FrmTasks";
            this.Text = "Task Management System | Tasks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuTasks.ResumeLayout(false);
            this.menuTasks.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.TaskDirectoryPanel.ResumeLayout(false);
            this.TaskDirectoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDirectoryDataGridView)).EndInit();
            this.statusStripTasks.ResumeLayout(false);
            this.statusStripTasks.PerformLayout();
            this.TaskEditorPanel.ResumeLayout(false);
            this.TaskEditorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTasks;
        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TaskDirectoryPanel;
        private System.Windows.Forms.Panel TaskEditorPanel;
        private System.Windows.Forms.StatusStrip statusStripTasks;
        private System.Windows.Forms.Label TaskDirectoryLabel;
        private System.Windows.Forms.Label TaskEditorTitleLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox TaskTitleTextBox;
        private System.Windows.Forms.Label TaskTitleLabel;
        private System.Windows.Forms.TextBox TaskIDTextBox;
        private System.Windows.Forms.Label TaskIDLabel;
        private System.Windows.Forms.ToolStripStatusLabel TaskDirectoryStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel DatabaseStatusMessage;
        private System.Windows.Forms.DataGridView TaskDirectoryDataGridView;
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
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.DateTimePicker DueDatePicker;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Button ClearEditorButton;
        private System.Windows.Forms.Button DeleteEditorButton;
        private System.Windows.Forms.Button UpdateEditorButton;
        private System.Windows.Forms.Button AddEditorButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox AssignedToTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AssignedToLabel;
        private System.Windows.Forms.Button SearchDirectoryButton;
        private System.Windows.Forms.Button RefreshDirectoryButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label CompletedTasksCounterLabel;
        private System.Windows.Forms.Label PendingTasksCounterLabel;
        private System.Windows.Forms.Label TotalTasksCounterLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PendingLabel;
        private System.Windows.Forms.Label CompletedLabel;
        private System.Windows.Forms.Label EditorStatusMessageLabel;
        private System.Windows.Forms.PictureBox ProgramLogoPictureBox;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Button ReturnToDashboardButton;
        private System.Windows.Forms.Label InProgressLabel;
        private System.Windows.Forms.Label InProgressCounterLabel;
    }
}
