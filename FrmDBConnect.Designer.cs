namespace MachineProject3_TMS
{
    partial class FrmDBConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBConnect));
            System.Windows.Forms.PictureBox BannerPictureBox;
            this.ShowPassLoginButtonLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SaveConfigCheckBox = new System.Windows.Forms.CheckBox();
            this.DemoModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfigGuideLabel = new System.Windows.Forms.Label();
            this.DBStatusLabel = new System.Windows.Forms.Label();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            BannerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(BannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPassLoginButtonLabel
            // 
            resources.ApplyResources(this.ShowPassLoginButtonLabel, "ShowPassLoginButtonLabel");
            this.ShowPassLoginButtonLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowPassLoginButtonLabel.Name = "ShowPassLoginButtonLabel";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.UsernameTextBox, "UsernameTextBox");
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UsernameTextBox.Name = "UsernameTextBox";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // SaveConfigCheckBox
            // 
            resources.ApplyResources(this.SaveConfigCheckBox, "SaveConfigCheckBox");
            this.SaveConfigCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveConfigCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SaveConfigCheckBox.Name = "SaveConfigCheckBox";
            this.SaveConfigCheckBox.UseVisualStyleBackColor = true;
            // 
            // DemoModeCheckBox
            // 
            resources.ApplyResources(this.DemoModeCheckBox, "DemoModeCheckBox");
            this.DemoModeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DemoModeCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DemoModeCheckBox.Name = "DemoModeCheckBox";
            this.DemoModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfigGuideLabel
            // 
            resources.ApplyResources(this.ConfigGuideLabel, "ConfigGuideLabel");
            this.ConfigGuideLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfigGuideLabel.Name = "ConfigGuideLabel";
            // 
            // DBStatusLabel
            // 
            resources.ApplyResources(this.DBStatusLabel, "DBStatusLabel");
            this.DBStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DBStatusLabel.Name = "DBStatusLabel";
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
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.Image = global::MachineProject3_TMS.Properties.Resources.logingray;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // BannerPictureBox
            // 
            BannerPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.banner;
            resources.ApplyResources(BannerPictureBox, "BannerPictureBox");
            BannerPictureBox.Name = "BannerPictureBox";
            BannerPictureBox.TabStop = false;
            // 
            // FrmDBConnect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.DBStatusLabel);
            this.Controls.Add(this.ConfigGuideLabel);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.Controls.Add(this.DemoModeCheckBox);
            this.Controls.Add(this.SaveConfigCheckBox);
            this.Controls.Add(this.ShowPassLoginButtonLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(BannerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDBConnect";
            ((System.ComponentModel.ISupportInitialize)(BannerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShowPassLoginButtonLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.CheckBox SaveConfigCheckBox;
        private System.Windows.Forms.Button ReturnToDashboardButton;
        private System.Windows.Forms.CheckBox DemoModeCheckBox;
        private System.Windows.Forms.Label ConfigGuideLabel;
        private System.Windows.Forms.Label DBStatusLabel;
    }
}