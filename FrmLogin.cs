// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MachineProject3_TMS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            SetupForm();
        }

        /// <summary>
        /// Initializes the default form state.
        /// </summary>
        private void SetupForm()
        {
            CreateAcctPanel.Visible = false;
            AccountRecoveryPanel.Visible = false;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordInputTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordInputTextBox.UseSystemPasswordChar = true;
            NewPasswordTextBox.UseSystemPasswordChar = true;
            ConfirmNewPasswordTextBox.UseSystemPasswordChar = true;
        }

        // --- MAIN LOGIN LOGIC ---

        /// <summary>
        /// Authenticates the user and navigates to the dashboard.
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password must not be blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Local bypass credentials for quick UI testing without DB access
            // Username: admin  Password: adminpass
            if (username == "admin" && password == "adminpass")
            {
                DbConnection.CurrentUserId = -1;
                DbConnection.CurrentUsername = "admin";
                DbConnection.CurrentName = "Administrator";
                DbConnection.CurrentEmail = "";
                DbConnection.CurrentLoginTime = DateTime.Now;
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
                return;
            }

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    // Assumes DB schema extended with 'name' and 'email' based on project UI requirements.
                    string query = "SELECT user_id, username, name, email FROM users WHERE username = @user AND password = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DbConnection.CurrentUserId = reader.GetInt32("user_id");
                                DbConnection.CurrentUsername = reader.GetString("username");
                                DbConnection.CurrentName = reader.IsDBNull(reader.GetOrdinal("name")) ? username : reader.GetString("name");
                                DbConnection.CurrentEmail = reader.IsDBNull(reader.GetOrdinal("email")) ? "" : reader.GetString("email");
                                DbConnection.CurrentLoginTime = DateTime.Now;

                                FrmDashboard dashboard = new FrmDashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clears the login fields.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            UsernameTextBox.Focus();
        }

        /// <summary>
        /// Toggles password visibility in the login panel.
        /// </summary>
        private void ShowPassLoginButtonLabel_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void MainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- CREATE ACCOUNT PANEL LOGIC ---

        private void CreateAcctButton_Click(object sender, EventArgs e)
        {
            CreateAcctPanel.Visible = true;
            LoginPanel.Enabled = false;
        }

        private void CreateAcctCloseButton_Click(object sender, EventArgs e)
        {
            CreateAcctPanel.Visible = false;
            LoginPanel.Enabled = true;
        }

        /// <summary>
        /// Validates and registers a new user in the database.
        /// </summary>
        private void CreateAccountPanelButton_Click(object sender, EventArgs e)
        {
            string name = NameInputTextBox.Text.Trim();
            string username = AcctUsernameInputTextBox.Text.Trim();
            string email = EmailAccountInputTextBox.Text.Trim();
            string pass = PasswordInputTextBox.Text;
            string confirmPass = ConfirmPasswordInputTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please fill out all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    // Check uniqueness of username and email first to provide specific feedback
                    using (MySqlCommand checkUser = new MySqlCommand("SELECT COUNT(*) FROM users WHERE username = @user", conn))
                    {
                        checkUser.Parameters.AddWithValue("@user", username);
                        var userCount = Convert.ToInt32(checkUser.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        using (MySqlCommand checkEmail = new MySqlCommand("SELECT COUNT(*) FROM users WHERE email = @em", conn))
                        {
                            checkEmail.Parameters.AddWithValue("@em", email);
                            var emailCount = Convert.ToInt32(checkEmail.ExecuteScalar());
                            if (emailCount > 0)
                            {
                                MessageBox.Show("Email address is already registered. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    string query = "INSERT INTO users (username, password, name, email) VALUES (@user, @pass, @name, @email)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", pass); // Ideally hash in real app
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account successfully created! You may now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CreateAcctCloseButton_Click(null, null);
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Duplicate entry
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPasswordButtonLabel_Click(object sender, EventArgs e)
        {
            PasswordInputTextBox.UseSystemPasswordChar = !PasswordInputTextBox.UseSystemPasswordChar;
            ConfirmPasswordInputTextBox.UseSystemPasswordChar = !ConfirmPasswordInputTextBox.UseSystemPasswordChar;
        }

        // --- ACCOUNT RECOVERY LOGIC ---

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            AccountRecoveryPanel.Visible = true;
            LoginPanel.Enabled = false;
        }

        private void RecoverAcctCloseButton_Click(object sender, EventArgs e)
        {
            AccountRecoveryPanel.Visible = false;
            LoginPanel.Enabled = true;
            ChangePasswordButton.Enabled = false;
        }

        /// <summary>
        /// Looks up the user in the database to allow password change.
        /// </summary>
        private void CheckUserButton_Click(object sender, EventArgs e)
        {
            string username = AccountUsernameCheckTextBox.Text.Trim();
            string email = EmailCheckTextBox.Text.Trim();

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT user_id, name FROM users WHERE username = @user AND email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show($"User record found for {reader.GetString("name")}. You may now change your password.", "User Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ChangePasswordButton.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("No matching user found with the provided details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validates the confirmation prompt and updates the user's password.
        /// </summary>
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string newPass = NewPasswordTextBox.Text;
            string confirmPass = ConfirmNewPasswordTextBox.Text;
            string username = AccountUsernameCheckTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPass) || newPass != confirmPass)
            {
                MessageBox.Show("Passwords cannot be blank and must match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm with Yes/No dialog
            var confirm = MessageBox.Show("Are you sure you want to change your password?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DbConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "UPDATE users SET password = @pass WHERE username = @user";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@pass", newPass);
                            cmd.Parameters.AddWithValue("@user", username);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Password successfully updated! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecoverAcctCloseButton_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password change aborted.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowPassARButtonLabel_Click(object sender, EventArgs e)
        {
            NewPasswordTextBox.UseSystemPasswordChar = !NewPasswordTextBox.UseSystemPasswordChar;
            ConfirmNewPasswordTextBox.UseSystemPasswordChar = !ConfirmNewPasswordTextBox.UseSystemPasswordChar;
        }
    }
}