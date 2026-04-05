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
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SaveConfigCheckBox = new System.Windows.Forms.CheckBox();
            this.ReturnToDashboardButton = new System.Windows.Forms.Button();
            this.DemoModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfigGuideLabel = new System.Windows.Forms.Label();
            this.DB = new System.Windows.Forms.Label();
            BannerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(BannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BannerPictureBox
            // 
            BannerPictureBox.Image = global::MachineProject3_TMS.Properties.Resources.banner;
            BannerPictureBox.Location = new System.Drawing.Point(-1, -1);
            BannerPictureBox.Name = "BannerPictureBox";
            BannerPictureBox.Size = new System.Drawing.Size(513, 60);
            BannerPictureBox.TabIndex = 0;
            BannerPictureBox.TabStop = false;
            // 
            // ShowPassLoginButtonLabel
            // 
            this.ShowPassLoginButtonLabel.AutoSize = true;
            this.ShowPassLoginButtonLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassLoginButtonLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowPassLoginButtonLabel.Location = new System.Drawing.Point(307, 127);
            this.ShowPassLoginButtonLabel.Name = "ShowPassLoginButtonLabel";
            this.ShowPassLoginButtonLabel.Size = new System.Drawing.Size(36, 15);
            this.ShowPassLoginButtonLabel.TabIndex = 12;
            this.ShowPassLoginButtonLabel.Text = "Show";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.Image = global::MachineProject3_TMS.Properties.Resources.logingray;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.Location = new System.Drawing.Point(349, 127);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(120, 47);
            this.LoginButton.TabIndex = 11;
            this.LoginButton.Text = "Log-in";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PasswordTextBox.Location = new System.Drawing.Point(195, 146);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(148, 27);
            this.PasswordTextBox.TabIndex = 9;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UsernameTextBox.Location = new System.Drawing.Point(45, 146);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(144, 27);
            this.UsernameTextBox.TabIndex = 10;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Location = new System.Drawing.Point(192, 123);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsernameLabel.Location = new System.Drawing.Point(42, 123);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 20);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            // 
            // SaveConfigCheckBox
            // 
            this.SaveConfigCheckBox.AutoSize = true;
            this.SaveConfigCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveConfigCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SaveConfigCheckBox.Location = new System.Drawing.Point(46, 199);
            this.SaveConfigCheckBox.Name = "SaveConfigCheckBox";
            this.SaveConfigCheckBox.Size = new System.Drawing.Size(145, 17);
            this.SaveConfigCheckBox.TabIndex = 13;
            this.SaveConfigCheckBox.Text = "Save this configuration";
            this.SaveConfigCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReturnToDashboardButton
            // 
            this.ReturnToDashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnToDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToDashboardButton.Image = global::MachineProject3_TMS.Properties.Resources.arrow_back;
            this.ReturnToDashboardButton.Location = new System.Drawing.Point(12, 65);
            this.ReturnToDashboardButton.Name = "ReturnToDashboardButton";
            this.ReturnToDashboardButton.Size = new System.Drawing.Size(45, 45);
            this.ReturnToDashboardButton.TabIndex = 16;
            this.ReturnToDashboardButton.UseVisualStyleBackColor = false;
            this.ReturnToDashboardButton.Click += new System.EventHandler(this.ReturnToDashboardButton_Click);
            // 
            // DemoModeCheckBox
            // 
            this.DemoModeCheckBox.AutoSize = true;
            this.DemoModeCheckBox.Checked = true;
            this.DemoModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DemoModeCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemoModeCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DemoModeCheckBox.Location = new System.Drawing.Point(195, 199);
            this.DemoModeCheckBox.Name = "DemoModeCheckBox";
            this.DemoModeCheckBox.Size = new System.Drawing.Size(184, 17);
            this.DemoModeCheckBox.TabIndex = 13;
            this.DemoModeCheckBox.Text = "(DEMO) Disable DB connection";
            this.DemoModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfigGuideLabel
            // 
            this.ConfigGuideLabel.AutoSize = true;
            this.ConfigGuideLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigGuideLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfigGuideLabel.Location = new System.Drawing.Point(101, 65);
            this.ConfigGuideLabel.Name = "ConfigGuideLabel";
            this.ConfigGuideLabel.Size = new System.Drawing.Size(307, 17);
            this.ConfigGuideLabel.TabIndex = 17;
            this.ConfigGuideLabel.Text = "Configure this according to your database settings.";
            // 
            // DB
            // 
            this.DB.AutoSize = true;
            this.DB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DB.Location = new System.Drawing.Point(101, 97);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(67, 13);
            this.DB.TabIndex = 18;
            this.DB.Text = "DB STATUS: ";
            // 
            // FrmDBConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(511, 237);
            this.Controls.Add(this.DB);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDBConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to Database System";
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
        private System.Windows.Forms.Label DB;
    }
}