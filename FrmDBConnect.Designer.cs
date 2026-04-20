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
            System.Windows.Forms.PictureBox BannerPictureBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBConnect));
            this.ShowPassLoginButtonLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ConfigGuideLabel = new System.Windows.Forms.Label();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ServerCredentials = new System.Windows.Forms.GroupBox();
            this.RememberCredentialsCheckBox = new System.Windows.Forms.CheckBox();
            this.DBServerStatus = new System.Windows.Forms.GroupBox();
            this.DemoModeButton = new System.Windows.Forms.Button();
            this.StopServiceButton = new System.Windows.Forms.Button();
            this.RestartServiceButton = new System.Windows.Forms.Button();
            this.StartServiceButton = new System.Windows.Forms.Button();
            this.RefreshStatusButton = new System.Windows.Forms.Button();
            this.CheckStatusButton = new System.Windows.Forms.Button();
            this.WindowsServiceStatusOutputLabel = new System.Windows.Forms.Label();
            this.WindowsServiceLabel = new System.Windows.Forms.Label();
            this.ServerDetailsOutputLabel = new System.Windows.Forms.Label();
            this.DatabaseStatusOutputLabel = new System.Windows.Forms.Label();
            this.ServerDetailsLabel = new System.Windows.Forms.Label();
            this.ConnectionStatusOutputLabel = new System.Windows.Forms.Label();
            this.DatabaseStatusLabel = new System.Windows.Forms.Label();
            this.ServerStatusOutputLabel = new System.Windows.Forms.Label();
            this.CredentialStatusOutputLabel = new System.Windows.Forms.Label();
            this.ServerStatusLabel = new System.Windows.Forms.Label();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.CredentialStatusLabel = new System.Windows.Forms.Label();
            this.StatusProgressBar = new System.Windows.Forms.ProgressBar();
            BannerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(BannerPictureBox)).BeginInit();
            this.ServerCredentials.SuspendLayout();
            this.DBServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // BannerPictureBox
            // 
            BannerPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.banner;
            resources.ApplyResources(BannerPictureBox, "BannerPictureBox");
            BannerPictureBox.Name = "BannerPictureBox";
            BannerPictureBox.TabStop = false;
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
            // ConfigGuideLabel
            // 
            resources.ApplyResources(this.ConfigGuideLabel, "ConfigGuideLabel");
            this.ConfigGuideLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfigGuideLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfigGuideLabel.Name = "ConfigGuideLabel";
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
            // ServerCredentials
            // 
            this.ServerCredentials.Controls.Add(this.RememberCredentialsCheckBox);
            this.ServerCredentials.Controls.Add(this.ConfigGuideLabel);
            this.ServerCredentials.Controls.Add(this.LoginButton);
            this.ServerCredentials.Controls.Add(this.UsernameLabel);
            this.ServerCredentials.Controls.Add(this.PasswordLabel);
            this.ServerCredentials.Controls.Add(this.UsernameTextBox);
            this.ServerCredentials.Controls.Add(this.ShowPassLoginButtonLabel);
            this.ServerCredentials.Controls.Add(this.PasswordTextBox);
            resources.ApplyResources(this.ServerCredentials, "ServerCredentials");
            this.ServerCredentials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServerCredentials.Name = "ServerCredentials";
            this.ServerCredentials.TabStop = false;
            // 
            // RememberCredentialsCheckBox
            // 
            resources.ApplyResources(this.RememberCredentialsCheckBox, "RememberCredentialsCheckBox");
            this.RememberCredentialsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberCredentialsCheckBox.Name = "RememberCredentialsCheckBox";
            this.RememberCredentialsCheckBox.UseVisualStyleBackColor = true;
            // 
            // DBServerStatus
            // 
            this.DBServerStatus.CausesValidation = false;
            this.DBServerStatus.Controls.Add(this.DemoModeButton);
            this.DBServerStatus.Controls.Add(this.StopServiceButton);
            this.DBServerStatus.Controls.Add(this.RestartServiceButton);
            this.DBServerStatus.Controls.Add(this.StartServiceButton);
            this.DBServerStatus.Controls.Add(this.RefreshStatusButton);
            this.DBServerStatus.Controls.Add(this.CheckStatusButton);
            this.DBServerStatus.Controls.Add(this.WindowsServiceStatusOutputLabel);
            this.DBServerStatus.Controls.Add(this.WindowsServiceLabel);
            this.DBServerStatus.Controls.Add(this.ServerDetailsOutputLabel);
            this.DBServerStatus.Controls.Add(this.DatabaseStatusOutputLabel);
            this.DBServerStatus.Controls.Add(this.ServerDetailsLabel);
            this.DBServerStatus.Controls.Add(this.ConnectionStatusOutputLabel);
            this.DBServerStatus.Controls.Add(this.DatabaseStatusLabel);
            this.DBServerStatus.Controls.Add(this.ServerStatusOutputLabel);
            this.DBServerStatus.Controls.Add(this.CredentialStatusOutputLabel);
            this.DBServerStatus.Controls.Add(this.ServerStatusLabel);
            this.DBServerStatus.Controls.Add(this.ConnectionStatusLabel);
            this.DBServerStatus.Controls.Add(this.CredentialStatusLabel);
            this.DBServerStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DBServerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.DBServerStatus, "DBServerStatus");
            this.DBServerStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DBServerStatus.Name = "DBServerStatus";
            this.DBServerStatus.TabStop = false;
            this.DBServerStatus.UseCompatibleTextRendering = true;
            // 
            // DemoModeButton
            // 
            this.DemoModeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DemoModeButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.DemoModeButton, "DemoModeButton");
            this.DemoModeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DemoModeButton.Name = "DemoModeButton";
            this.DemoModeButton.UseVisualStyleBackColor = true;
            // 
            // StopServiceButton
            // 
            this.StopServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.StopServiceButton, "StopServiceButton");
            this.StopServiceButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopServiceButton.Name = "StopServiceButton";
            this.StopServiceButton.UseVisualStyleBackColor = true;
            // 
            // RestartServiceButton
            // 
            this.RestartServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.RestartServiceButton, "RestartServiceButton");
            this.RestartServiceButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RestartServiceButton.Name = "RestartServiceButton";
            this.RestartServiceButton.UseVisualStyleBackColor = true;
            // 
            // StartServiceButton
            // 
            this.StartServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.StartServiceButton, "StartServiceButton");
            this.StartServiceButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartServiceButton.Name = "StartServiceButton";
            this.StartServiceButton.UseVisualStyleBackColor = true;
            // 
            // RefreshStatusButton
            // 
            this.RefreshStatusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.RefreshStatusButton, "RefreshStatusButton");
            this.RefreshStatusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshStatusButton.Name = "RefreshStatusButton";
            this.RefreshStatusButton.UseVisualStyleBackColor = true;
            // 
            // CheckStatusButton
            // 
            this.CheckStatusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.CheckStatusButton, "CheckStatusButton");
            this.CheckStatusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckStatusButton.Name = "CheckStatusButton";
            this.CheckStatusButton.UseVisualStyleBackColor = true;
            // 
            // WindowsServiceStatusOutputLabel
            // 
            this.WindowsServiceStatusOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WindowsServiceStatusOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.WindowsServiceStatusOutputLabel, "WindowsServiceStatusOutputLabel");
            this.WindowsServiceStatusOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WindowsServiceStatusOutputLabel.Name = "WindowsServiceStatusOutputLabel";
            // 
            // WindowsServiceLabel
            // 
            resources.ApplyResources(this.WindowsServiceLabel, "WindowsServiceLabel");
            this.WindowsServiceLabel.Name = "WindowsServiceLabel";
            // 
            // ServerDetailsOutputLabel
            // 
            this.ServerDetailsOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServerDetailsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.ServerDetailsOutputLabel, "ServerDetailsOutputLabel");
            this.ServerDetailsOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ServerDetailsOutputLabel.Name = "ServerDetailsOutputLabel";
            // 
            // DatabaseStatusOutputLabel
            // 
            this.DatabaseStatusOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DatabaseStatusOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.DatabaseStatusOutputLabel, "DatabaseStatusOutputLabel");
            this.DatabaseStatusOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DatabaseStatusOutputLabel.Name = "DatabaseStatusOutputLabel";
            // 
            // ServerDetailsLabel
            // 
            resources.ApplyResources(this.ServerDetailsLabel, "ServerDetailsLabel");
            this.ServerDetailsLabel.Name = "ServerDetailsLabel";
            // 
            // ConnectionStatusOutputLabel
            // 
            this.ConnectionStatusOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ConnectionStatusOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.ConnectionStatusOutputLabel, "ConnectionStatusOutputLabel");
            this.ConnectionStatusOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConnectionStatusOutputLabel.Name = "ConnectionStatusOutputLabel";
            // 
            // DatabaseStatusLabel
            // 
            resources.ApplyResources(this.DatabaseStatusLabel, "DatabaseStatusLabel");
            this.DatabaseStatusLabel.Name = "DatabaseStatusLabel";
            // 
            // ServerStatusOutputLabel
            // 
            this.ServerStatusOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ServerStatusOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.ServerStatusOutputLabel, "ServerStatusOutputLabel");
            this.ServerStatusOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ServerStatusOutputLabel.Name = "ServerStatusOutputLabel";
            // 
            // CredentialStatusOutputLabel
            // 
            this.CredentialStatusOutputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CredentialStatusOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.CredentialStatusOutputLabel, "CredentialStatusOutputLabel");
            this.CredentialStatusOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CredentialStatusOutputLabel.Name = "CredentialStatusOutputLabel";
            // 
            // ServerStatusLabel
            // 
            resources.ApplyResources(this.ServerStatusLabel, "ServerStatusLabel");
            this.ServerStatusLabel.Name = "ServerStatusLabel";
            // 
            // ConnectionStatusLabel
            // 
            resources.ApplyResources(this.ConnectionStatusLabel, "ConnectionStatusLabel");
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            // 
            // CredentialStatusLabel
            // 
            resources.ApplyResources(this.CredentialStatusLabel, "CredentialStatusLabel");
            this.CredentialStatusLabel.Name = "CredentialStatusLabel";
            // 
            // StatusProgressBar
            // 
            resources.ApplyResources(this.StatusProgressBar, "StatusProgressBar");
            this.StatusProgressBar.MarqueeAnimationSpeed = 450;
            this.StatusProgressBar.Name = "StatusProgressBar";
            // 
            // FrmDBConnect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.StatusProgressBar);
            this.Controls.Add(this.DBServerStatus);
            this.Controls.Add(this.ServerCredentials);
            this.Controls.Add(this.ReturnToDashboardButton);
            this.Controls.Add(BannerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDBConnect";
            ((System.ComponentModel.ISupportInitialize)(BannerPictureBox)).EndInit();
            this.ServerCredentials.ResumeLayout(false);
            this.ServerCredentials.PerformLayout();
            this.DBServerStatus.ResumeLayout(false);
            this.DBServerStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ShowPassLoginButtonLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button ReturnToDashboardButton;
        private System.Windows.Forms.Label ConfigGuideLabel;
        private System.Windows.Forms.GroupBox ServerCredentials;
        private System.Windows.Forms.GroupBox DBServerStatus;
        private System.Windows.Forms.Label ConnectionStatusOutputLabel;
        private System.Windows.Forms.Label CredentialStatusOutputLabel;
        private System.Windows.Forms.Label ServerStatusLabel;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Label CredentialStatusLabel;
        private System.Windows.Forms.CheckBox RememberCredentialsCheckBox;
        private System.Windows.Forms.Button CheckStatusButton;
        private System.Windows.Forms.Label DatabaseStatusLabel;
        private System.Windows.Forms.Button DemoModeButton;
        private System.Windows.Forms.Label WindowsServiceStatusOutputLabel;
        private System.Windows.Forms.Label WindowsServiceLabel;
        private System.Windows.Forms.Label DatabaseStatusOutputLabel;
        private System.Windows.Forms.Label ServerStatusOutputLabel;
        private System.Windows.Forms.Button StopServiceButton;
        private System.Windows.Forms.Button StartServiceButton;
        private System.Windows.Forms.Button RestartServiceButton;
        private System.Windows.Forms.Button RefreshStatusButton;
        private System.Windows.Forms.ProgressBar StatusProgressBar;
        private System.Windows.Forms.Label ServerDetailsOutputLabel;
        private System.Windows.Forms.Label ServerDetailsLabel;
    }
}