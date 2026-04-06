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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
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
            this.SearchLabel = new System.Windows.Forms.Label();
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
            this.ClearEditorButton = new System.Windows.Forms.Button();
            this.SearchDirectoryButton = new System.Windows.Forms.Button();
            this.DeleteEditorButton = new System.Windows.Forms.Button();
            this.RefreshDirectoryButton = new System.Windows.Forms.Button();
            this.UpdateEditorButton = new System.Windows.Forms.Button();
            this.AddEditorButton = new System.Windows.Forms.Button();
            this.ProgramLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.CategoryViewerPanel.SuspendLayout();
            this.statusStripTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryViewerDataGridView)).BeginInit();
            this.CategoryDetailsPanel.SuspendLayout();
            this.menuTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // MainPanel
            // 
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.Controls.Add(this.CategoryViewerPanel);
            this.MainPanel.Controls.Add(this.CategoryDetailsPanel);
            this.MainPanel.Name = "MainPanel";
            // 
            // CategoryViewerPanel
            // 
            resources.ApplyResources(this.CategoryViewerPanel, "CategoryViewerPanel");
            this.CategoryViewerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CategoryViewerPanel.Controls.Add(this.statusStripTasks);
            this.CategoryViewerPanel.Controls.Add(this.TaskDirectoryLabel);
            this.CategoryViewerPanel.Controls.Add(this.CategoryViewerDataGridView);
            this.CategoryViewerPanel.Name = "CategoryViewerPanel";
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
            // TaskDirectoryLabel
            // 
            resources.ApplyResources(this.TaskDirectoryLabel, "TaskDirectoryLabel");
            this.TaskDirectoryLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.TaskDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskDirectoryLabel.Name = "TaskDirectoryLabel";
            // 
            // CategoryViewerDataGridView
            // 
            this.CategoryViewerDataGridView.AllowUserToAddRows = false;
            this.CategoryViewerDataGridView.AllowUserToDeleteRows = false;
            this.CategoryViewerDataGridView.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.CategoryViewerDataGridView, "CategoryViewerDataGridView");
            this.CategoryViewerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryViewerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.CategoryViewerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CategoryViewerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryViewerDataGridView.MultiSelect = false;
            this.CategoryViewerDataGridView.Name = "CategoryViewerDataGridView";
            this.CategoryViewerDataGridView.ReadOnly = true;
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
            this.CategoryDetailsPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.CategoryDetailsPanel, "CategoryDetailsPanel");
            this.CategoryDetailsPanel.Name = "CategoryDetailsPanel";
            // 
            // DetailStatusMessageLabel
            // 
            this.DetailStatusMessageLabel.CausesValidation = false;
            this.DetailStatusMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.DetailStatusMessageLabel, "DetailStatusMessageLabel");
            this.DetailStatusMessageLabel.Name = "DetailStatusMessageLabel";
            // 
            // SearchLabel
            // 
            resources.ApplyResources(this.SearchLabel, "SearchLabel");
            this.SearchLabel.ForeColor = System.Drawing.Color.Silver;
            this.SearchLabel.Name = "SearchLabel";
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
            // CategoryDetailsLabel
            // 
            this.CategoryDetailsLabel.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.CategoryDetailsLabel, "CategoryDetailsLabel");
            this.CategoryDetailsLabel.Name = "CategoryDetailsLabel";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.DescriptionTextBox, "DescriptionTextBox");
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            // 
            // DescriptionLabel
            // 
            resources.ApplyResources(this.DescriptionLabel, "DescriptionLabel");
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Silver;
            this.DescriptionLabel.Name = "DescriptionLabel";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.CategoryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CategoryNameTextBox, "CategoryNameTextBox");
            this.CategoryNameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            // 
            // CategoryIDLabel
            // 
            resources.ApplyResources(this.CategoryIDLabel, "CategoryIDLabel");
            this.CategoryIDLabel.ForeColor = System.Drawing.Color.Silver;
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            // 
            // CategoryIDTextBox
            // 
            this.CategoryIDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.CategoryIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CategoryIDTextBox, "CategoryIDTextBox");
            this.CategoryIDTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.CategoryIDTextBox.Name = "CategoryIDTextBox";
            this.CategoryIDTextBox.ReadOnly = true;
            this.CategoryIDTextBox.TabStop = false;
            // 
            // CategoryNameLabel
            // 
            resources.ApplyResources(this.CategoryNameLabel, "CategoryNameLabel");
            this.CategoryNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            // 
            // MainTitleLabel
            // 
            resources.ApplyResources(this.MainTitleLabel, "MainTitleLabel");
            this.MainTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainTitleLabel.ForeColor = System.Drawing.Color.White;
            this.MainTitleLabel.Name = "MainTitleLabel";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
            // 
            // categoryManagementToolStripMenuItem
            // 
            this.categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            resources.ApplyResources(this.categoryManagementToolStripMenuItem, "categoryManagementToolStripMenuItem");
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
            this.addCategoryToolStripMenuItem,
            this.updateCategoryToolStripMenuItem,
            this.deleteCategoryToolStripMenuItem,
            this.toolStripMenuItem4,
            this.clearFormToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            resources.ApplyResources(this.recordToolStripMenuItem, "recordToolStripMenuItem");
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            resources.ApplyResources(this.addCategoryToolStripMenuItem, "addCategoryToolStripMenuItem");
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            resources.ApplyResources(this.updateCategoryToolStripMenuItem, "updateCategoryToolStripMenuItem");
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            resources.ApplyResources(this.deleteCategoryToolStripMenuItem, "deleteCategoryToolStripMenuItem");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            resources.ApplyResources(this.clearFormToolStripMenuItem, "clearFormToolStripMenuItem");
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
            // ClearEditorButton
            // 
            this.ClearEditorButton.BackColor = System.Drawing.Color.DimGray;
            this.ClearEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearEditorButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ClearEditorButton, "ClearEditorButton");
            this.ClearEditorButton.Image = global::MachineProject3_TMS.Properties.Resources.clear;
            this.ClearEditorButton.Name = "ClearEditorButton";
            this.ClearEditorButton.UseVisualStyleBackColor = false;
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
            this.SearchDirectoryButton.Click += new System.EventHandler(this.SearchCategoryButton_Click);
            // 
            // DeleteEditorButton
            // 
            this.DeleteEditorButton.BackColor = System.Drawing.Color.Firebrick;
            this.DeleteEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteEditorButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.DeleteEditorButton, "DeleteEditorButton");
            this.DeleteEditorButton.Image = global::MachineProject3_TMS.Properties.Resources.delete;
            this.DeleteEditorButton.Name = "DeleteEditorButton";
            this.DeleteEditorButton.UseVisualStyleBackColor = false;
            this.DeleteEditorButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
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
            // 
            // UpdateEditorButton
            // 
            this.UpdateEditorButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.UpdateEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateEditorButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.UpdateEditorButton, "UpdateEditorButton");
            this.UpdateEditorButton.Image = global::MachineProject3_TMS.Properties.Resources.update;
            this.UpdateEditorButton.Name = "UpdateEditorButton";
            this.UpdateEditorButton.UseVisualStyleBackColor = false;
            this.UpdateEditorButton.Click += new System.EventHandler(this.UpdateCategoryButton_Click);
            // 
            // AddEditorButton
            // 
            this.AddEditorButton.BackColor = System.Drawing.Color.SeaGreen;
            this.AddEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEditorButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.AddEditorButton, "AddEditorButton");
            this.AddEditorButton.Image = global::MachineProject3_TMS.Properties.Resources.add;
            this.AddEditorButton.Name = "AddEditorButton";
            this.AddEditorButton.UseVisualStyleBackColor = false;
            this.AddEditorButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // ProgramLogoPictureBox
            // 
            resources.ApplyResources(this.ProgramLogoPictureBox, "ProgramLogoPictureBox");
            this.ProgramLogoPictureBox.BackColor = System.Drawing.Color.SeaGreen;
            this.ProgramLogoPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.logo;
            this.ProgramLogoPictureBox.Name = "ProgramLogoPictureBox";
            this.ProgramLogoPictureBox.TabStop = false;
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
            // FrmCategories
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.CancelButton = this.ClearEditorButton;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ProgramLogoPictureBox);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.Controls.Add(this.menuTasks);
            this.Controls.Add(this.MainTitleLabel);
            this.MainMenuStrip = this.menuTasks;
            this.Name = "FrmCategories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.CategoryViewerPanel.ResumeLayout(false);
            this.CategoryViewerPanel.PerformLayout();
            this.statusStripTasks.ResumeLayout(false);
            this.statusStripTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryViewerDataGridView)).EndInit();
            this.CategoryDetailsPanel.ResumeLayout(false);
            this.CategoryDetailsPanel.PerformLayout();
            this.menuTasks.ResumeLayout(false);
            this.menuTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogoPictureBox)).EndInit();
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
