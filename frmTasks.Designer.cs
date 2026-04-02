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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTasks));
            this.menuTasks = new System.Windows.Forms.MenuStrip();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelResults = new System.Windows.Forms.Panel();
            this.statusStripTasks = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSearchHeader = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.lblPanelTaskDetails = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.statusStripTasks.SuspendLayout();
            this.panelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTasks
            // 
            this.menuTasks.Location = new System.Drawing.Point(0, 0);
            this.menuTasks.Name = "menuTasks";
            this.menuTasks.Size = new System.Drawing.Size(1159, 24);
            this.menuTasks.TabIndex = 0;
            this.menuTasks.Text = "menuTasks";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(390, 65);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Task Management";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panelMain.Controls.Add(this.panelResults);
            this.panelMain.Controls.Add(this.panelInputs);
            this.panelMain.Location = new System.Drawing.Point(0, 112);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1159, 560);
            this.panelMain.TabIndex = 6;
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelResults.Controls.Add(this.statusStripTasks);
            this.panelResults.Controls.Add(this.lblSearchHeader);
            this.panelResults.Controls.Add(this.dgvTasks);
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelResults.Location = new System.Drawing.Point(399, 20);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(740, 520);
            this.panelResults.TabIndex = 0;
            // 
            // statusStripTasks
            // 
            this.statusStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStripTasks.Location = new System.Drawing.Point(0, 498);
            this.statusStripTasks.Name = "statusStripTasks";
            this.statusStripTasks.Size = new System.Drawing.Size(740, 22);
            this.statusStripTasks.TabIndex = 1;
            this.statusStripTasks.Text = "statusStripTasks";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // lblSearchHeader
            // 
            this.lblSearchHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSearchHeader.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchHeader.Location = new System.Drawing.Point(0, 0);
            this.lblSearchHeader.Name = "lblSearchHeader";
            this.lblSearchHeader.Size = new System.Drawing.Size(740, 44);
            this.lblSearchHeader.TabIndex = 0;
            this.lblSearchHeader.Text = "Search";
            this.lblSearchHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputs.Controls.Add(this.txtDescription);
            this.panelInputs.Controls.Add(this.lblDescription);
            this.panelInputs.Controls.Add(this.txtTaskTitle);
            this.panelInputs.Controls.Add(this.lblTaskTitle);
            this.panelInputs.Controls.Add(this.txtTaskID);
            this.panelInputs.Controls.Add(this.lblTaskID);
            this.panelInputs.Controls.Add(this.lblPanelTaskDetails);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInputs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelInputs.Location = new System.Drawing.Point(20, 20);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(373, 520);
            this.panelInputs.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(18, 148);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(341, 29);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(14, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 21);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTitle.Location = new System.Drawing.Point(163, 92);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(195, 29);
            this.txtTaskTitle.TabIndex = 3;
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaskTitle.Location = new System.Drawing.Point(159, 68);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(72, 21);
            this.lblTaskTitle.TabIndex = 2;
            this.lblTaskTitle.Text = "Task Title";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskID.Location = new System.Drawing.Point(17, 92);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.ReadOnly = true;
            this.txtTaskID.Size = new System.Drawing.Size(136, 29);
            this.txtTaskID.TabIndex = 3;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaskID.Location = new System.Drawing.Point(13, 68);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(58, 21);
            this.lblTaskID.TabIndex = 2;
            this.lblTaskID.Text = "Task ID";
            // 
            // lblPanelTaskDetails
            // 
            this.lblPanelTaskDetails.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPanelTaskDetails.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelTaskDetails.Location = new System.Drawing.Point(0, 0);
            this.lblPanelTaskDetails.Name = "lblPanelTaskDetails";
            this.lblPanelTaskDetails.Size = new System.Drawing.Size(379, 44);
            this.lblPanelTaskDetails.TabIndex = 0;
            this.lblPanelTaskDetails.Text = "Task Details";
            this.lblPanelTaskDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTasks
            // 
            this.dgvTasks.Location = new System.Drawing.Point(5, 165);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(730, 319);
            this.dgvTasks.TabIndex = 3;
            // 
            // FrmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1159, 671);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuTasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTasks;
            this.Name = "FrmTasks";
            this.Text = "Tasks";
            this.panelMain.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.statusStripTasks.ResumeLayout(false);
            this.statusStripTasks.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTasks;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.StatusStrip statusStripTasks;
        private System.Windows.Forms.Label lblSearchHeader;
        private System.Windows.Forms.Label lblPanelTaskDetails;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridView dgvTasks;
    }
}
