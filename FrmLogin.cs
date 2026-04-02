using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    public partial class FrmLogin : Form
    {
        // Specifies the MySQL connection string. It requires modification when a password is necessary.
        string connectionString = "Server=localhost;Database=task_management_db;Uid=root;Pwd=;";

        // Specifies UI testing mode. When true, the form runs without connecting to a database.
        // Set to false to enable MySQL connections.
        bool disableMySQL = true;

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Form Initialization & UI Setup

        private void EntryLogin_Load(object sender, EventArgs e)
        {
            // Hides overlay panels on initialization
            CreateAcctPanel.Visible = false;
            AccountRecoveryPanel.Visible = false;

            // Masks password input fields
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordInputTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordInputTextBox.UseSystemPasswordChar = true;
            NewPasswordTextBox.UseSystemPasswordChar = true;
            ConfirmNewPasswordTextBox.UseSystemPasswordChar = true;

            // Disables change password UI until the user verifies ownership
            NewPasswordTextBox.Enabled = false;
            ConfirmNewPasswordTextBox.Enabled = false;
            ChangePasswordButton.Enabled = false;

            // Removes the runtime dark-mode theming call.

            // Attempts to open a MySQL connection when UI testing mode is disabled.
            if (!disableMySQL)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                    conn.Open();
                        // Reports successful connection and optionally updates a status label
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection failed to start: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Removes the dark-mode helper method.

        // Activates the Create Account Panel
        private void CreateAcctButton_Click(object sender, EventArgs e)
        {
            CreateAcctPanel.Visible = true;
            CreateAcctPanel.BringToFront();
            AccountRecoveryPanel.Visible = false;
        }

        // Activates the Account Recovery Panel
        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            AccountRecoveryPanel.Visible = true;
            AccountRecoveryPanel.BringToFront();
            CreateAcctPanel.Visible = false;
        }

        // Closes the Create Account Panel
        private void ClosePanel1Button_Click(object sender, EventArgs e)
        {
            CreateAcctPanel.Visible = false;
            NameInputTextBox.Clear();
            AcctUsernameInputTextBox.Clear();
            EmailAccountInputTextBox.Clear();
            PasswordInputTextBox.Clear();
            ConfirmPasswordInputTextBox.Clear();
        }

        // Closes the Account Recovery Panel
        private void ClosePanel2Button_Click(object sender, EventArgs e)
        {
            ResetRecoveryPanel();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            UsernameTextBox.Focus();
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Toggles password visibility on the Login screen
        private void ShowPassLoginButtonLabel_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;
            ShowPassLoginButtonLabel.Text = PasswordTextBox.UseSystemPasswordChar ? "Show" : "Hide";
        }

        // Toggles password visibility on the Create Account panel
        private void ShowPasswordButtonLabel_Click(object sender, EventArgs e)
        {
            bool isMasked = !PasswordInputTextBox.UseSystemPasswordChar;
            PasswordInputTextBox.UseSystemPasswordChar = isMasked;
            ConfirmPasswordInputTextBox.UseSystemPasswordChar = isMasked;
            ShowPasswordButtonLabel.Text = isMasked ? "Show password" : "Hide password";
        }

        // Toggles password visibility on the Account Recovery panel
        private void ShowPassARButtonLabel_Click(object sender, EventArgs e)
        {
            bool isMasked = !NewPasswordTextBox.UseSystemPasswordChar;
            NewPasswordTextBox.UseSystemPasswordChar = isMasked;
            ConfirmNewPasswordTextBox.UseSystemPasswordChar = isMasked;
            ShowPassARButtonLabel.Text = isMasked ? "Show" : "Hide";
        }

        #endregion

        #region Login & Admin Bypass Logic

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Checks for admin bypass credentials.
            if (CheckAdminBypass(username, password))
            {
                // Opens the dashboard directly when an admin bypass is valid
                OpenDashboard();
                return;
            }

            // Performs standard database login or UI test simulation.
            if (disableMySQL)
            {
                // Opens the dashboard directly when UI testing mode is enabled
                OpenDashboard();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE username = @user AND password = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            OpenDashboard();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckAdminBypass(string username, string password)
        {
            // Validates admin bypass credentials and checks for the bypass file
            if (username == "ADMIN" && password == "32145")
            {
                try
                {
                    // Looks for admbyp.txt in the application startup directory
                    string filePath = Path.Combine(Application.StartupPath, "admbyp.txt");

                    if (File.Exists(filePath))
                    {
                        string content = File.ReadAllText(filePath).Trim();
                        if (content == "ADMIN - 32145")
                        {
                            return true;
                        }
                    }
                }
                catch (Exception)
                {
                    // Ignores file read errors and returns false
                }
            }
            return false;
        }

        private void OpenDashboard()
        {
            // Instantiates and shows the main dashboard after successful login
            var dashboard = new FrmDashboard();
            dashboard.FormClosed += (s, e) => this.Close(); // Ensures that closing the dashboard exits the application
            dashboard.Show();

            this.Hide();
        }

        #endregion

        #region Account Recovery Logic

        private void CheckUserButton_Click(object sender, EventArgs e)
        {
            string username = AccountUsernameCheckTextBox.Text.Trim();
            string email = EmailCheckTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter both Username and Email to check.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool userExists = false;

            if (disableMySQL)
            {
                userExists = true; // Simulate finding the user for UI testing
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        // Queries the database for a matching username and email.
                        string query = "SELECT COUNT(*) FROM users WHERE username = @user AND email = @email";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@user", username);
                            cmd.Parameters.AddWithValue("@email", email);
                            userExists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (userExists)
            {
                // Prompts the user to type YES to confirm ownership of the account.
                string confirmation = PromptForConfirmation("Type YES to confirm you own this account:", "Account Verification");

                if (confirmation == "YES")
                {
                    MessageBox.Show("Account verified. The user may now enter and save a new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Enables password change fields.
                    NewPasswordTextBox.Enabled = true;
                    ConfirmNewPasswordTextBox.Enabled = true;
                    ChangePasswordButton.Enabled = true;

                    // Disables the check fields to prevent mid-process changes.
                    AccountUsernameCheckTextBox.Enabled = false;
                    EmailCheckTextBox.Enabled = false;
                    CheckUserButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Confirmation failed or was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No account matches that username and email combination.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string newPass = NewPasswordTextBox.Text;
            string confPass = ConfirmNewPasswordTextBox.Text;
            string targetUsername = AccountUsernameCheckTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confPass))
            {
                MessageBox.Show("Please fill out both password fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confPass)
            {
                MessageBox.Show("New passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (disableMySQL)
            {
                MessageBox.Show("[UI Test Mode] Password changed successfully. The user can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetRecoveryPanel();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET password = @pass WHERE username = @user";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pass", newPass);
                        cmd.Parameters.AddWithValue("@user", targetUsername);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully. The user can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetRecoveryPanel();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. The user might no longer exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetRecoveryPanel()
        {
            // Resets and hides the account recovery panel.
            AccountRecoveryPanel.Visible = false;
            AccountUsernameCheckTextBox.Enabled = true;
            EmailCheckTextBox.Enabled = true;
            CheckUserButton.Enabled = true;
            NewPasswordTextBox.Enabled = false;
            ConfirmNewPasswordTextBox.Enabled = false;
            ChangePasswordButton.Enabled = false;

            AccountUsernameCheckTextBox.Clear();
            EmailCheckTextBox.Clear();
            NewPasswordTextBox.Clear();
            ConfirmNewPasswordTextBox.Clear();
        }

        // Generates a dialog that prompts the user to type YES for confirmation.
        private string PromptForConfirmation(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 340 };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmation = new Button() { Text = "Confirm", Left = 260, Width = 100, Top = 80, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text.Trim().ToUpper() : "";
        }

        #endregion

        #region Account Creation Logic

        private void CreateAccountPanelButton_Click(object sender, EventArgs e)
        {
            string name = NameInputTextBox.Text.Trim();
            string username = AcctUsernameInputTextBox.Text.Trim();
            string email = EmailAccountInputTextBox.Text.Trim();
            string password = PasswordInputTextBox.Text;
            string confirmPass = ConfirmPasswordInputTextBox.Text;

            // Validates required input fields
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Inserts the new account into the database or simulates insertion in UI test mode
            if (disableMySQL)
            {
                MessageBox.Show("[UI Test Mode] Account successfully created. The user can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields and hide panel
                NameInputTextBox.Clear();
                AcctUsernameInputTextBox.Clear();
                EmailAccountInputTextBox.Clear();
                PasswordInputTextBox.Clear();
                ConfirmPasswordInputTextBox.Clear();

                CreateAcctPanel.Visible = false;
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Note: Your DB structure requires an 'email' and 'name' column in the users table for this to work.
                    // If your DB only has (user_id, username, password), you need to ALTER TABLE users ADD name VARCHAR(100), ADD email VARCHAR(100);
                    string query = "INSERT INTO users (username, password, email, name) VALUES (@user, @pass, @email, @name)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@name", name);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account successfully created! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear fields and hide panel
                        NameInputTextBox.Clear();
                        AcctUsernameInputTextBox.Clear();
                        EmailAccountInputTextBox.Clear();
                        PasswordInputTextBox.Clear();
                        ConfirmPasswordInputTextBox.Clear();

                        CreateAcctPanel.Visible = false;
                    }
                }
                catch (MySqlException sqlEx)
                {
                    // Check for duplicate username (MySQL Error 1062)
                    if (sqlEx.Number == 1062)
                    {
                        MessageBox.Show("That username or email is already taken. Please choose another.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Database Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Application Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}