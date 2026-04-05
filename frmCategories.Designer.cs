namespace MachineProject3_TMS
{
    partial class FrmCategories
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CategoryViewerPanel = new System.Windows.Forms.Panel();
            this.statusStripTasks = new System.Windows.Forms.StatusStrip();
            this.TaskDirectoryStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatabaseStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.TaskDirectoryLabel = new System.Windows.Forms.Label();
            this.CategoryViewerDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryDetailsPanel = new System.Windows.Forms.Panel();
            this.DetailStatusMessageLabel = new System.Windows.Forms.Label();
            this.ClearEditorButton = new System.Windows.Forms.Button();
            this.SearchDirectoryButton = new System.Windows.Forms.Button();
            this.DeleteEditorButton = new System.Windows.Forms.Button();
            this.RefreshDirectoryButton = new System.Windows.Forms.Button();
            this.UpdateEditorButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.AddEditorButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CategoryDetailsLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryIDLabel = new System.Windows.Forms.Label();
            this.CategoryIDTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            this.categoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTasks = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainPanel.SuspendLayout();
            this.CategoryViewerPanel.SuspendLayout();
            this.statusStripTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryViewerDataGridView)).BeginInit();
            this.CategoryDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).BeginInit();
            this.menuTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
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
            this.MainPanel.Controls.Add(this.CategoryViewerPanel);
            this.MainPanel.Controls.Add(this.CategoryDetailsPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 90);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.MainPanel.Size = new System.Drawing.Size(1126, 660);
            this.MainPanel.TabIndex = 16;
            // 
            // CategoryViewerPanel
            // 
            this.CategoryViewerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CategoryViewerPanel.Controls.Add(this.statusStripTasks);
            this.CategoryViewerPanel.Controls.Add(this.TaskDirectoryLabel);
            this.CategoryViewerPanel.Controls.Add(this.CategoryViewerDataGridView);
            this.CategoryViewerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CategoryViewerPanel.Location = new System.Drawing.Point(398, 20);
            this.CategoryViewerPanel.Name = "CategoryViewerPanel";
            this.CategoryViewerPanel.Size = new System.Drawing.Size(708, 620);
            this.CategoryViewerPanel.TabIndex = 0;
            // 
            // statusStripTasks
            // 
            this.statusStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskDirectoryStatusMessage,
            this.DatabaseStatusMessage});
            this.statusStripTasks.Location = new System.Drawing.Point(0, 598);
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
            // TaskDirectoryLabel
            // 
            this.TaskDirectoryLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.TaskDirectoryLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskDirectoryLabel.Location = new System.Drawing.Point(0, 0);
            this.TaskDirectoryLabel.Name = "TaskDirectoryLabel";
            this.TaskDirectoryLabel.Size = new System.Drawing.Size(708, 44);
            this.TaskDirectoryLabel.TabIndex = 0;
            this.TaskDirectoryLabel.Text = "Category Viewer";
            this.TaskDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoryViewerDataGridView
            // 
            this.CategoryViewerDataGridView.AllowUserToAddRows = false;
            this.CategoryViewerDataGridView.AllowUserToDeleteRows = false;
            this.CategoryViewerDataGridView.AllowUserToOrderColumns = true;
            this.CategoryViewerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.CategoryViewerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.CategoryViewerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CategoryViewerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryViewerDataGridView.Location = new System.Drawing.Point(15, 57);
            this.CategoryViewerDataGridView.Name = "CategoryViewerDataGridView";
            this.CategoryViewerDataGridView.Size = new System.Drawing.Size(679, 519);
            this.CategoryViewerDataGridView.TabIndex = 3;
            // 
            // CategoryDetailsPanel
            // 
            this.CategoryDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CategoryDetailsPanel.Controls.Add(this.DetailStatusMessageLabel);
            this.CategoryDetailsPanel.Controls.Add(this.ClearEditorButton);
            this.CategoryDetailsPanel.Controls.Add(this.SearchDirectoryButton);
            this.CategoryDetailsPanel.Controls.Add(this.DeleteEditorButton);
            this.CategoryDetailsPanel.Controls.Add(this.RefreshDirectoryButton);
            this.CategoryDetailsPanel.Controls.Add(this.UpdateEditorButton);
            this.CategoryDetailsPanel.Controls.Add(this.SearchLabel);
            this.CategoryDetailsPanel.Controls.Add(this.AddEditorButton);
            this.CategoryDetailsPanel.Controls.Add(this.SearchTextBox);
            this.CategoryDetailsPanel.Controls.Add(this.CategoryDetailsLabel);
            this.CategoryDetailsPanel.Controls.Add(this.DescriptionTextBox);
            this.CategoryDetailsPanel.Controls.Add(this.DescriptionLabel);
            this.CategoryDetailsPanel.Controls.Add(this.CategoryNameTextBox);
            this.CategoryDetailsPanel.Controls.Add(this.CategoryIDLabel);
            this.CategoryDetailsPanel.Controls.Add(this.CategoryIDTextBox);
            this.CategoryDetailsPanel.Controls.Add(this.CategoryNameLabel);
            this.CategoryDetailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoryDetailsPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryDetailsPanel.Location = new System.Drawing.Point(20, 20);
            this.CategoryDetailsPanel.Name = "CategoryDetailsPanel";
            this.CategoryDetailsPanel.Size = new System.Drawing.Size(360, 620);
            this.CategoryDetailsPanel.TabIndex = 0;
            // 
            // DetailStatusMessageLabel
            // 
            this.DetailStatusMessageLabel.CausesValidation = false;
            this.DetailStatusMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailStatusMessageLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailStatusMessageLabel.Location = new System.Drawing.Point(15, 375);
            this.DetailStatusMessageLabel.Name = "DetailStatusMessageLabel";
            this.DetailStatusMessageLabel.Size = new System.Drawing.Size(333, 29);
            this.DetailStatusMessageLabel.TabIndex = 10;
            this.DetailStatusMessageLabel.Text = "--";
            this.DetailStatusMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ClearEditorButton.Location = new System.Drawing.Point(180, 512);
            this.ClearEditorButton.Name = "ClearEditorButton";
            this.ClearEditorButton.Size = new System.Drawing.Size(168, 90);
            this.ClearEditorButton.TabIndex = 9;
            this.ClearEditorButton.Text = "CLEAR";
            this.ClearEditorButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ClearEditorButton.UseVisualStyleBackColor = false;
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
            this.SearchDirectoryButton.Location = new System.Drawing.Point(18, 275);
            this.SearchDirectoryButton.Name = "SearchDirectoryButton";
            this.SearchDirectoryButton.Size = new System.Drawing.Size(156, 51);
            this.SearchDirectoryButton.TabIndex = 9;
            this.SearchDirectoryButton.Text = "&SEARCH";
            this.SearchDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SearchDirectoryButton.UseVisualStyleBackColor = false;
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
            this.DeleteEditorButton.Location = new System.Drawing.Point(15, 512);
            this.DeleteEditorButton.Name = "DeleteEditorButton";
            this.DeleteEditorButton.Size = new System.Drawing.Size(159, 90);
            this.DeleteEditorButton.TabIndex = 8;
            this.DeleteEditorButton.Text = "DELETE";
            this.DeleteEditorButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DeleteEditorButton.UseVisualStyleBackColor = false;
            this.DeleteEditorButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
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
            this.RefreshDirectoryButton.Location = new System.Drawing.Point(180, 275);
            this.RefreshDirectoryButton.Name = "RefreshDirectoryButton";
            this.RefreshDirectoryButton.Size = new System.Drawing.Size(168, 51);
            this.RefreshDirectoryButton.TabIndex = 7;
            this.RefreshDirectoryButton.Text = "&REFRESH";
            this.RefreshDirectoryButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RefreshDirectoryButton.UseVisualStyleBackColor = false;
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
            this.UpdateEditorButton.Location = new System.Drawing.Point(180, 416);
            this.UpdateEditorButton.Name = "UpdateEditorButton";
            this.UpdateEditorButton.Size = new System.Drawing.Size(168, 90);
            this.UpdateEditorButton.TabIndex = 7;
            this.UpdateEditorButton.Text = "UPDATE";
            this.UpdateEditorButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UpdateEditorButton.UseVisualStyleBackColor = false;
            this.UpdateEditorButton.Click += new System.EventHandler(this.UpdateCategoryButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SearchLabel.ForeColor = System.Drawing.Color.Silver;
            this.SearchLabel.Location = new System.Drawing.Point(14, 217);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(53, 20);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search";
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
            this.AddEditorButton.Location = new System.Drawing.Point(15, 416);
            this.AddEditorButton.Name = "AddEditorButton";
            this.AddEditorButton.Size = new System.Drawing.Size(159, 90);
            this.AddEditorButton.TabIndex = 6;
            this.AddEditorButton.Text = "ADD";
            this.AddEditorButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AddEditorButton.UseVisualStyleBackColor = false;
            this.AddEditorButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Gray;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.CausesValidation = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchTextBox.Location = new System.Drawing.Point(18, 240);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(330, 29);
            this.SearchTextBox.TabIndex = 3;
            // 
            // CategoryDetailsLabel
            // 
            this.CategoryDetailsLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.CategoryDetailsLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDetailsLabel.Location = new System.Drawing.Point(0, 0);
            this.CategoryDetailsLabel.Name = "CategoryDetailsLabel";
            this.CategoryDetailsLabel.Size = new System.Drawing.Size(360, 44);
            this.CategoryDetailsLabel.TabIndex = 0;
            this.CategoryDetailsLabel.Text = "Category Details";
            this.CategoryDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.Gray;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionTextBox.Location = new System.Drawing.Point(18, 144);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(330, 29);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Silver;
            this.DescriptionLabel.Location = new System.Drawing.Point(14, 120);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 21);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.BackColor = System.Drawing.Color.Gray;
            this.CategoryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTextBox.ForeColor = System.Drawing.Color.White;
            this.CategoryNameTextBox.Location = new System.Drawing.Point(165, 88);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(183, 29);
            this.CategoryNameTextBox.TabIndex = 3;
            // 
            // CategoryIDLabel
            // 
            this.CategoryIDLabel.AutoSize = true;
            this.CategoryIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryIDLabel.ForeColor = System.Drawing.Color.Silver;
            this.CategoryIDLabel.Location = new System.Drawing.Point(14, 64);
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            this.CategoryIDLabel.Size = new System.Drawing.Size(92, 21);
            this.CategoryIDLabel.TabIndex = 2;
            this.CategoryIDLabel.Text = "Category ID";
            // 
            // CategoryIDTextBox
            // 
            this.CategoryIDTextBox.BackColor = System.Drawing.Color.Gray;
            this.CategoryIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryIDTextBox.ForeColor = System.Drawing.Color.White;
            this.CategoryIDTextBox.Location = new System.Drawing.Point(18, 88);
            this.CategoryIDTextBox.Name = "CategoryIDTextBox";
            this.CategoryIDTextBox.ReadOnly = true;
            this.CategoryIDTextBox.Size = new System.Drawing.Size(141, 29);
            this.CategoryIDTextBox.TabIndex = 3;
            this.CategoryIDTextBox.TabStop = false;
            this.CategoryIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.CategoryNameLabel.Location = new System.Drawing.Point(161, 64);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(119, 21);
            this.CategoryNameLabel.TabIndex = 2;
            this.CategoryNameLabel.Text = "Category Name";
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
            this.MainTitleLabel.Location = new System.Drawing.Point(67, 24);
            this.MainTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(496, 65);
            this.MainTitleLabel.TabIndex = 15;
            this.MainTitleLabel.Text = "Category Management";
            this.MainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // ProgramLogoPictureBox
            // 
            this.ProgramLogoPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            this.ProgramLogoPictureBox.Location = new System.Drawing.Point(1058, 34);
            this.ProgramLogoPictureBox.Name = "ProgramLogoPictureBox";
            this.ProgramLogoPictureBox.Size = new System.Drawing.Size(45, 50);
            this.ProgramLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProgramLogoPictureBox.TabIndex = 17;
            this.ProgramLogoPictureBox.TabStop = false;
            // 
            // ReturnToDashboardButton
            // 
            this.ReturnToDashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnToDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToDashboardButton.Image = global::MachineProject3_TMS.Properties.Resources.arrow_back;
            this.ReturnToDashboardButton.Location = new System.Drawing.Point(19, 37);
            this.ReturnToDashboardButton.Name = "ReturnToDashboardButton";
            this.ReturnToDashboardButton.Size = new System.Drawing.Size(45, 45);
            this.ReturnToDashboardButton.TabIndex = 18;
            this.ReturnToDashboardButton.UseVisualStyleBackColor = false;
            // 
            // categoryManagementToolStripMenuItem
            // 
            this.categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            this.categoryManagementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.categoryManagementToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.categoryManagementToolStripMenuItem.Text = "Category Management";
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
            this.menuTasks.TabIndex = 14;
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
            this.addCategoryToolStripMenuItem,
            this.updateCategoryToolStripMenuItem,
            this.deleteCategoryToolStripMenuItem,
            this.toolStripMenuItem4,
            this.clearFormToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.recordToolStripMenuItem.Text = "&Record";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addCategoryToolStripMenuItem.Text = "&Add Category";
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            this.updateCategoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateCategoryToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.updateCategoryToolStripMenuItem.Text = "&Update Category";
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            this.deleteCategoryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.deleteCategoryToolStripMenuItem.Text = "&Delete Category";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(219, 6);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clearFormToolStripMenuItem.Text = "&Clear Form";
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
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1124, 751);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ProgramLogoPictureBox);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.Controls.Add(this.menuTasks);
            this.Controls.Add(this.MainTitleLabel);
            this.Name = "FrmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.MainPanel.ResumeLayout(false);
            this.CategoryViewerPanel.ResumeLayout(false);
            this.CategoryViewerPanel.PerformLayout();
            this.statusStripTasks.ResumeLayout(false);
            this.statusStripTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryViewerDataGridView)).EndInit();
            this.CategoryDetailsPanel.ResumeLayout(false);
            this.CategoryDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).EndInit();
            this.menuTasks.ResumeLayout(false);
            this.menuTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel CategoryViewerPanel;
        private System.Windows.Forms.StatusStrip statusStripTasks;
        private System.Windows.Forms.ToolStripStatusLabel TaskDirectoryStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel DatabaseStatusMessage;
        private System.Windows.Forms.Label TaskDirectoryLabel;
        private System.Windows.Forms.DataGridView CategoryViewerDataGridView;
        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox ProgramLogoPictureBox;
        private System.Windows.Forms.Button ReturnToDashboardButton;
        private System.Windows.Forms.ToolStripMenuItem categoryManagementToolStripMenuItem;
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
        private System.Windows.Forms.Panel CategoryDetailsPanel;
        private System.Windows.Forms.Button SearchDirectoryButton;
        private System.Windows.Forms.Button RefreshDirectoryButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label CategoryDetailsLabel;
        private System.Windows.Forms.Label DetailStatusMessageLabel;
        private System.Windows.Forms.Button ClearEditorButton;
        private System.Windows.Forms.Button DeleteEditorButton;
        private System.Windows.Forms.Button UpdateEditorButton;
        private System.Windows.Forms.Button AddEditorButton;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Label CategoryIDLabel;
        private System.Windows.Forms.TextBox CategoryIDTextBox;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}
