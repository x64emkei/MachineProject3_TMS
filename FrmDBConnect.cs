// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    public partial class FrmDBConnect : Form
    {
        public FrmDBConnect()
        {
            InitializeComponent();
            // Wire designer buttons to their handlers so the form is responsive at runtime
            if (LoginButton != null) LoginButton.Click += LoginButton_Click;
            if (ReturnToDashboardButton != null) ReturnToDashboardButton.Click += ReturnToDashboardButton_Click;
            if (ShowPassLoginButtonLabel != null) ShowPassLoginButtonLabel.Click += ShowPassLoginButtonLabel_Click;

            // Wire checkbox events
            if (SaveConfigCheckBox != null) SaveConfigCheckBox.CheckedChanged += SaveConfigCheckBox_CheckedChanged;
            if (DemoModeCheckBox != null) DemoModeCheckBox.CheckedChanged += DemoModeCheckBox_CheckedChanged;

            // Loads saved DB config (if any) and updates status label.
            try
            {
                LoadSavedConfig();
                UpdateDbStatusLabel();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            // Initialize demo allowed flag from checkbox state
            try
            {
                DbConnection.DemoAllowed = DemoModeCheckBox != null && DemoModeCheckBox.Checked;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Handles SaveConfig checkbox changes by asking for confirmation when being unchecked.
        /// </summary>
        private void SaveConfigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (SaveConfigCheckBox != null && !SaveConfigCheckBox.Checked)
                {
                    var res = MessageBox.Show("Unchecking will remove saved DB configuration from disk. Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            var path = GetConfigFilePath();
                            if (File.Exists(path)) File.Delete(path);
                        }
                        catch { }
                    }
                    else
                    {
                        SaveConfigCheckBox.Checked = true; // Revert
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Handles demo checkbox changes by enabling/disabling DemoAllowed and disabling demo mode when unchecked.
        /// </summary>
        private void DemoModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DbConnection.DemoAllowed = DemoModeCheckBox != null && DemoModeCheckBox.Checked;
                if (!DbConnection.DemoAllowed)
                {
                    DbConnection.DisableDemoMode();
                }
                UpdateDbStatusLabel();
            }
            catch { }
        }

        /// <summary>
        /// Tests the connection using the provided credentials.
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // If demo mode is checked, bypass DB connection and open the dashboard for UI testing
            if (DemoModeCheckBox != null && DemoModeCheckBox.Checked)
            {
                // Set a minimal in-memory session so other forms have user info available
                // Explicitly enable demo mode only when checkbox is checked.
                DbConnection.EnableDemoMode();
                DbConnection.CurrentUserId = 0;
                DbConnection.CurrentUsername = "demo";
                DbConnection.CurrentName = "Demo User";
                DbConnection.CurrentEmail = "demo@local";
                DbConnection.CurrentLoginTime = DateTime.Now;

                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
                return;
            }

            string user = UsernameTextBox.Text.Trim();
            string pass = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Please enter a database username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Updates connection string temporarily
            string testConnString = $"Server=localhost;Database=task_management_db;Uid={user};Pwd={pass};";
            DbConnection.ConnectionString = testConnString;

            if (DbConnection.TestConnection())
            {
                MessageBox.Show("Database connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (SaveConfigCheckBox.Checked)
                {
                    try
                    {
                        SaveConfig(testConnString);
                    }
                    catch
                    {
                        // Swallows save errors but proceeds with connection.
                    }
                }

                // Ensure demo mode is off when real connection succeeds.
                DbConnection.DisableDemoMode();

                // Update status label on this form.
                UpdateDbStatusLabel();

                FrmLogin loginForm = new FrmLogin();
                AppController.SwitchTo(loginForm);
            }
            else
            {
                MessageBox.Show("Failed to connect to the database. Please check your credentials and ensure MySQL is running.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Returns path to saved DB config file in the user's AppData folder.
        /// </summary>
        private string GetConfigFilePath()
        {
            string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MachineProject3_TMS");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            return Path.Combine(dir, "dbconfig.txt");
        }

        /// <summary>
        /// Saves the connection string to a simple config file when user requests.
        /// </summary>
        private void SaveConfig(string connString)
        {
            var path = GetConfigFilePath();
            File.WriteAllText(path, connString);
        }

        /// <summary>
        /// Loads a saved configuration if present and applies it to DbConnection.
        /// </summary>
        private void LoadSavedConfig()
        {
            var path = GetConfigFilePath();
            if (File.Exists(path))
            {
                try
                {
                    string saved = File.ReadAllText(path).Trim();
                    if (!string.IsNullOrWhiteSpace(saved))
                    {
                        DbConnection.ConnectionString = saved;
                        SaveConfigCheckBox.Checked = true;
                        // Try to pre-fill username in the UI if present
                        try
                        {
                            var parts = saved.Split(';');
                            foreach (var p in parts)
                            {
                                if (p.TrimStart().StartsWith("Uid=", StringComparison.OrdinalIgnoreCase))
                                {
                                    var u = p.Substring(p.IndexOf('=') + 1);
                                    UsernameTextBox.Text = u;
                                    break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Updates the DBStatusLabel to reflect current connection state and saved config.
        /// </summary>
        private void UpdateDbStatusLabel()
        {
            try
            {
                string status;
                if (DbConnection.DemoMode)
                {
                    status = "Demo Mode (no DB)";
                }
                else
                {
                    bool ok = DbConnection.TestConnection();
                    status = ok ? "Connected - Ready" : "DB Unavailable";
                }

                // Show brief config info (server and database) if available.
                string configInfo = string.Empty;
                try
                {
                    var cs = DbConnection.ConnectionString ?? string.Empty;
                    foreach (var part in cs.Split(';'))
                    {
                        if (part.TrimStart().StartsWith("Server=", StringComparison.OrdinalIgnoreCase) || part.TrimStart().StartsWith("Database=", StringComparison.OrdinalIgnoreCase))
                        {
                            if (!string.IsNullOrEmpty(configInfo)) configInfo += ";";
                            configInfo += part;
                        }
                    }
                }
                catch { }

                DBStatusLabel.Text = string.IsNullOrWhiteSpace(configInfo) ? status : $"{status} | {configInfo}";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                DBStatusLabel.Text = "DB Status Unknown";
            }
        }

        /// <summary>
        /// Toggles password visibility.
        /// </summary>
        private void ShowPassLoginButtonLabel_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;
        }

        /// <summary>
        /// Closes the application from the connection screen.
        /// </summary>
        private void ReturnToDashboardButton_Click(object sender, EventArgs e)
        {
            // Return to the Dashboard instead of exiting so user can navigate back
            try
            {
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // Fallback to exit if something unexpected occurs
                Application.Exit();
            }
        }
    }
}