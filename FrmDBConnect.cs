// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MachineProject3_TMS
{
    public partial class FrmDBConnect : Form
    {
        // Stores last schema creation summary for display
        private string _lastSchemaSummary = string.Empty;

        public FrmDBConnect()
        {
            InitializeComponent();
            this.Load += FrmDBConnect_Load;

            // Wire designer buttons to their handlers so the form is responsive at runtime
            if (DemoModeButton != null) DemoModeButton.Click += DemoModeButton_Click;
            if (StartServiceButton != null) StartServiceButton.Click += async (s, e) => await ManageServiceAsync("start");
            if (RestartServiceButton != null) RestartServiceButton.Click += async (s, e) => await ManageServiceAsync("restart");
            if (StopServiceButton != null) StopServiceButton.Click += async (s, e) => await ManageServiceAsync("stop");
            if (LoginButton != null) LoginButton.Click += LoginButton_Click;
            if (ServerLookupButton != null) ServerLookupButton.Click += ServerLookupButton_Click;
            if (CheckStatusButton != null) CheckStatusButton.Click += async (s, e) => await CheckAllStatusesAsync();
            if (RefreshStatusButton != null) RefreshStatusButton.Click += async (s, e) => await CheckAllStatusesAsync();

            // Keyboard helpers
            try
            {
                if (UsernameTextBox != null) UsernameTextBox.KeyDown += UsernameTextBox_KeyDown;
                if (PasswordTextBox != null) PasswordTextBox.KeyDown += PasswordTextBox_KeyDown;
                if (LoginButton != null) this.AcceptButton = LoginButton;
            }
            catch { }

            // Loads saved DB config (if any) and updates status label.
            try
            {
                LoadSavedConfig();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void FrmDBConnect_Load(object sender, EventArgs e)
        {
            // Remember Credentials Check
            try
            {
                if (Properties.Settings.Default.RememberMe)
                {
                    if (UsernameTextBox != null) UsernameTextBox.Text = Properties.Settings.Default.DbUsername;
                    if (PasswordTextBox != null) PasswordTextBox.Text = Properties.Settings.Default.DbPassword;
                    if (RememberCredentialsCheckBox != null) RememberCredentialsCheckBox.Checked = true;
                }
            }
            catch { }
        }

        private void DemoModeButton_Click(object sender, EventArgs e)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 400;
                prompt.Height = 200;
                prompt.Text = "Enable Demo Mode";
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;

                Label warningLabel = new Label() { Left = 20, Top = 20, Width = 350, Height = 40, Text = "Warning: You are about to enter Demo Mode. The database connection will be disabled." };
                Label countdownLabel = new Label() { Left = 20, Top = 60, Width = 350, Text = "Please wait 10 seconds..." };
                Button enableButton = new Button() { Text = "Enable Demo", Left = 50, Top = 100, Width = 120, Enabled = false };
                Button cancelButton = new Button() { Text = "Cancel", Left = 200, Top = 100, Width = 100 };

                prompt.Controls.Add(warningLabel);
                prompt.Controls.Add(countdownLabel);
                prompt.Controls.Add(enableButton);
                prompt.Controls.Add(cancelButton);

                int timeLeft = 10;
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (s, args) =>
                {
                    timeLeft--;
                    countdownLabel.Text = $"Please wait {timeLeft} seconds...";
                    if (timeLeft <= 0)
                    {
                        timer.Stop();
                        countdownLabel.Text = "You can now enable demo mode.";
                        enableButton.Enabled = true;
                    }
                };

                enableButton.Click += (s, args) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };
                cancelButton.Click += (s, args) => { prompt.DialogResult = DialogResult.Cancel; prompt.Close(); };

                timer.Start();
                var result = prompt.ShowDialog(this);
                timer.Stop();

                if (result == DialogResult.OK)
                {
                    DbConnection.DemoAllowed = true;
                    DemoHelper.EnableDemoMode();
                    DbConnection.EnableDemoMode();
                    DbConnection.CurrentUserId = 0;
                    DbConnection.CurrentUsername = "demo";
                    DbConnection.CurrentName = "Demo User";
                    DbConnection.CurrentEmail = "demo@local";
                    DbConnection.CurrentLoginTime = DateTime.Now;

                    FrmDashboard dashboard = new FrmDashboard();
                    dashboard.Show();
                    this.Hide();
                }
            }
        }

        private async Task ManageServiceAsync(string action)
        {
            string title;
            string description;
            switch ((action ?? string.Empty).ToLowerInvariant())
            {
                case "start":
                    title = "Start MySQL Service";
                    description = "Starts the local MySQL Windows Service. Disabled in Demo Mode.";
                    break;
                case "stop":
                    title = "Stop MySQL Service";
                    description = "Stops the local MySQL Windows Service. Disabled in Demo Mode.";
                    break;
                default:
                    title = "Restart MySQL Service";
                    description = "Restarts the local MySQL Windows Service. Disabled in Demo Mode.";
                    break;
            }

            if (DemoHelper.InterceptAction(title, description)) return;

            SetProgressMarquee(true);
            try
            {
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, $"Executing {action}...", "Checking...");
                await Task.Run(() =>
                {
                    string fileName = "net.exe";
                    string arguments = $"{action} mysql";
                    if (string.Equals(action, "restart", StringComparison.OrdinalIgnoreCase))
                    {
                        fileName = "cmd.exe";
                        arguments = "/c net stop mysql && net start mysql";
                    }

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = fileName,
                        Arguments = arguments,
                        Verb = "runas",
                        UseShellExecute = true,
                        CreateNoWindow = true
                    };
                    using (Process p = Process.Start(psi))
                    {
                        if (p != null) p.WaitForExit();
                    }
                });
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, $"Service {action} completed.", "Running");
            }
            catch (Win32Exception ex) when (ex.NativeErrorCode == 1223)
            {
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, "Service action cancelled by user.", "Failed");
            }
            catch (Exception)
            {
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, "Service action cancelled or failed.", "Failed");
            }
            finally
            {
                SetProgressMarquee(false);
            }
        }

        private async void ServerLookupButton_Click(object sender, EventArgs e)
        {
            if (DemoHelper.InterceptAction("Server Lookup", "This button looks up the default local MySQL configuration. Disabled in Demo Mode.")) return;

            string host = string.Empty;
            string port = string.Empty;
            SetProgressMarquee(true);
            try
            {
                UpdateStatusLabel(ServerStatusOutputLabel, "Looking up server...", "Checking...");

                await Task.Run(() =>
                {
                    host = "127.0.0.1";
                    port = "3306";
                });
            }
            finally
            {
                SetProgressMarquee(false);
            }

            var answer = MessageBox.Show($"Is Host: {host} and Port: {port} correct for this environment?", "Server Lookup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                UpdateStatusLabel(ServerStatusOutputLabel, $"Host: {host}:{port}", "Valid");
                if (ServerDetailsOutputLabel != null) ServerDetailsOutputLabel.Text = $"{(host)}:{(port)}";
            }
            else
            {
                UpdateStatusLabel(ServerStatusOutputLabel, "Lookup rejected", "Failed");
            }
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (DemoHelper.InterceptAction("Database Connect", "This button attempts to connect to the MySQL database. Disabled in Demo Mode.")) return;

            string user = UsernameTextBox?.Text?.Trim() ?? "";
            string pass = PasswordTextBox?.Text ?? "";

            bool success = false;
            string errorMessage = string.Empty;
            SetProgressMarquee(true);
            try
            {
                UpdateStatusLabel(ConnectionStatusOutputLabel, "Connecting...", "Checking...");

                await Task.Run(() =>
                {
                    string serverOnly = $"Server=localhost;Uid={user};Pwd={pass};";
                    try
                    {
                        using (var conn = new MySqlConnection(serverOnly))
                        {
                            conn.Open();
                            success = true;
                        }
                        DbConnection.ConnectionString = serverOnly + "Database=task_management_db;";
                    }
                    catch (Exception ex)
                    {
                        success = false;
                        errorMessage = ex.Message;
                    }
                });
            }
            finally
            {
                SetProgressMarquee(false);
            }

            if (success)
            {
                UpdateStatusLabel(ConnectionStatusOutputLabel, "Connected", "Connected");
                UpdateStatusLabel(CredentialStatusOutputLabel, "Credentials Valid", "Valid");

                if (RememberCredentialsCheckBox != null)
                {
                    try
                    {
                        if (RememberCredentialsCheckBox.Checked)
                        {
                            Properties.Settings.Default.DbUsername = user;
                            Properties.Settings.Default.DbPassword = pass;
                            Properties.Settings.Default.RememberMe = true;
                        }
                        else
                        {
                            Properties.Settings.Default.DbUsername = "";
                            Properties.Settings.Default.DbPassword = "";
                            Properties.Settings.Default.RememberMe = false;
                        }
                        Properties.Settings.Default.Save();
                    }
                    catch { }
                }

                DbConnection.DisableDemoMode();
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                UpdateStatusLabel(ConnectionStatusOutputLabel, "Connection Failed", "Failed");
                UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid Credentials", "Failed");
                MessageBox.Show(string.IsNullOrWhiteSpace(errorMessage) ? "Failed to connect to the database." : $"Failed to connect to the database.\n\n{errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CheckAllStatusesAsync()
        {
            if (DemoHelper.InterceptAction("Check Status", "This button checks the database and service status. Disabled in Demo Mode.")) return;

            SetProgressMarquee(true);
            try
            {
                UpdateStatusLabel(DatabaseStatusOutputLabel, "Checking...", "Checking...");
                UpdateStatusLabel(ServerStatusOutputLabel, "Checking...", "Checking...");
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, "Checking...", "Checking...");

                string serviceStatus = await GetMySqlServiceStatusAsync();
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, serviceStatus, serviceStatus == "Running" ? "Running" : "Stopped");

                bool dbConnected = await Task.Run(() => DbConnection.TestConnection());
                UpdateStatusLabel(DatabaseStatusOutputLabel, dbConnected ? "Connected" : "Disconnected", dbConnected ? "Connected" : "Disconnected");
                UpdateStatusLabel(ConnectionStatusOutputLabel, dbConnected ? "Connected" : "Disconnected", dbConnected ? "Connected" : "Disconnected");

                bool hasUser = !string.IsNullOrWhiteSpace(UsernameTextBox?.Text);
                bool hasPass = !string.IsNullOrWhiteSpace(PasswordTextBox?.Text);
                UpdateStatusLabel(CredentialStatusOutputLabel, (hasUser && hasPass) ? "Credentials Present" : "Credentials Missing", (hasUser && hasPass) ? "Valid" : "Failed");
            }
            catch
            {
                UpdateStatusLabel(DatabaseStatusOutputLabel, "Failed", "Failed");
                UpdateStatusLabel(ServerStatusOutputLabel, "Failed", "Failed");
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, "Failed", "Failed");
            }
            finally
            {
                SetProgressMarquee(false);
            }
        }

        private async Task<string> GetMySqlServiceStatusAsync()
        {
            return await Task.Run(() =>
            {
                try
                {
                    using (var service = new ServiceController("mysql"))
                    {
                        return service.Status == ServiceControllerStatus.Running ? "Running" : "Stopped";
                    }
                }
                catch
                {
                    return "Stopped";
                }
            });
        }

        private void SetProgressMarquee(bool isMarquee)
        {
            if (StatusProgressBar != null)
            {
                if (isMarquee)
                {
                    StatusProgressBar.Style = ProgressBarStyle.Marquee;
                }
                else
                {
                    StatusProgressBar.Style = ProgressBarStyle.Blocks;
                    StatusProgressBar.Value = 0;
                }
            }
        }

        private void UpdateStatusLabel(Label label, string text, string stateType)
        {
            if (label == null) return;
            label.Text = text;

            switch (stateType)
            {
                case "Running":
                case "Connected":
                case "Valid":
                    label.ForeColor = Color.LimeGreen;
                    break;
                case "Stopped":
                case "Failed":
                case "Disconnected":
                    label.ForeColor = Color.Red;
                    break;
                case "Checking...":
                    label.ForeColor = Color.Orange;
                    break;
                default:
                    label.ForeColor = SystemColors.ControlText;
                    break;
            }
        }

        /// <summary>
        /// Attempts to create the configured database if it doesn't exist and then ensures schema.
        /// Returns (success, message)
        /// </summary>
        public (bool, string) TryCreateDatabaseAndSchema()
        {
            try
            {
                // Parse connection string for Database name
                var cs = DbConnection.ConnectionString ?? string.Empty;
                if (string.IsNullOrWhiteSpace(cs)) return (false, "No connection string configured.");

                // Extract database name
                string dbName = null;
                var parts = cs.Split(';');
                var serverParts = new System.Collections.Generic.List<string>();
                foreach (var p in parts)
                {
                    if (string.IsNullOrWhiteSpace(p)) continue;
                    var kv = p.Split(new[] { '=' }, 2);
                    if (kv.Length != 2) continue;
                    var key = kv[0].Trim();
                    var val = kv[1].Trim();
                    if (string.Equals(key, "Database", StringComparison.OrdinalIgnoreCase) || string.Equals(key, "Initial Catalog", StringComparison.OrdinalIgnoreCase))
                    {
                        dbName = val;
                        continue;
                    }
                    serverParts.Add(p);
                }

                if (string.IsNullOrWhiteSpace(dbName)) return (false, "No database name found in connection string.");

                // Validate dbName (simple allow alnum and underscore)
                foreach (char c in dbName)
                {
                    if (!(char.IsLetterOrDigit(c) || c == '_' || c == '-'))
                        return (false, "Invalid database name.");
                }

                // Build server-only connection string (no Database)
                string serverOnly = string.Join(";", serverParts) + ";" ;

                // Connect to server and create database
                using (var conn = new MySqlConnection(serverOnly))
                {
                    conn.Open();
                    try { if (RememberCredentialsCheckBox != null) RememberCredentialsCheckBox.Checked = true; SaveConfig(serverOnly); } catch { }
                    string createDb = $"CREATE DATABASE IF NOT EXISTS `{dbName}` CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;";
                    using (var cmd = new MySqlCommand(createDb, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Update application connection string to include database (recompose)
                DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";" ;

                // Ensure schema/tables
                bool ok = EnsureDatabaseSchema();
                if (!ok) return (false, "Failed to ensure database schema.");

                // Insert initial migration row if none exists
                try
                {
                    using (var conn = new MySqlConnection(DbConnection.ConnectionString))
                    {
                        conn.Open();
                        using (var check = new MySqlCommand("SELECT COUNT(*) FROM schema_migrations", conn))
                        {
                            var cnt = Convert.ToInt32(check.ExecuteScalar());
                            if (cnt == 0)
                            {
                                using (var ins = new MySqlCommand("INSERT INTO schema_migrations (version) VALUES (@v)", conn))
                                {
                                    ins.Parameters.AddWithValue("@v", "initial");
                                    ins.ExecuteNonQuery();
                                }
                                _lastSchemaSummary += "initial migration recorded\r\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Non-fatal: record failure in summary
                    _lastSchemaSummary += "failed to record migration: " + ex.Message + "\r\n";
                }

                return (true, _lastSchemaSummary);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        /// <summary>
        /// Ensures required schema exists; creates database tables if they are missing.
        /// Returns true when initialization succeeded or already present.
        /// </summary>
        private bool EnsureDatabaseSchema()
        {
            try
            {
                using (var conn = new MySqlConnection(DbConnection.ConnectionString))
                {
                    conn.Open();

                    // Create users
                    string usersSql = @"CREATE TABLE IF NOT EXISTS users (
                        user_id INT PRIMARY KEY AUTO_INCREMENT,
                        username VARCHAR(50) NOT NULL UNIQUE,
                        password VARCHAR(100) NOT NULL,
                        name VARCHAR(100),
                        email VARCHAR(100) UNIQUE
                    );";

                    // Create categories
                    string categoriesSql = @"CREATE TABLE IF NOT EXISTS categories (
                        category_id INT PRIMARY KEY AUTO_INCREMENT,
                        category_name VARCHAR(100) NOT NULL,
                        description VARCHAR(255)
                    );";

                    // Create tasks
                    string tasksSql = @"CREATE TABLE IF NOT EXISTS tasks (
                        task_id INT PRIMARY KEY AUTO_INCREMENT,
                        task_title VARCHAR(100) NOT NULL,
                        description VARCHAR(255),
                        due_date DATE,
                        priority VARCHAR(20),
                        status VARCHAR(20),
                        assigned_to VARCHAR(100),
                        category_id INT,
                        FOREIGN KEY (category_id) REFERENCES categories(category_id) ON DELETE RESTRICT
                    );";

                    string summary = "";
                    using (var cmd = new MySqlCommand(usersSql, conn)) { cmd.ExecuteNonQuery(); summary += "users table ensured\r\n"; }
                    using (var cmd = new MySqlCommand(categoriesSql, conn)) { cmd.ExecuteNonQuery(); summary += "categories table ensured\r\n"; }
                    using (var cmd = new MySqlCommand(tasksSql, conn)) { cmd.ExecuteNonQuery(); summary += "tasks table ensured\r\n"; }

                    // Migration/version table
                    string migrationSql = @"CREATE TABLE IF NOT EXISTS schema_migrations (
                        id INT PRIMARY KEY AUTO_INCREMENT,
                        version VARCHAR(50) NOT NULL,
                        applied_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                    );";
                    using (var cmd = new MySqlCommand(migrationSql, conn)) { cmd.ExecuteNonQuery(); summary += "schema_migrations table ensured\r\n"; }

                    // Return the summary via Tag property on the connection object is not appropriate; instead store in a local field
                    _lastSchemaSummary = summary;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void CreateNewDataBaseButton_Click(object sender, EventArgs e)
        {
            if (DemoHelper.InterceptAction("Create Database Schema", "In a live environment, this creates the MySQL database and required tables. Disabled in Demo Mode.")) return;

            string user = UsernameTextBox?.Text?.Trim() ?? string.Empty;
            string pass = PasswordTextBox?.Text ?? string.Empty;
            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Please enter a database username before creating a database.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dbName = "task_management_db";
            string serverOnly = $"Server=localhost;Uid={user};Pwd={pass};";
            // Test credentials against server first
            try
            {
                using (var test = new MySqlConnection(serverOnly))
                {
                    test.Open();
                }
            }
            catch (MySqlException mex)
            {
                MessageBox.Show($"Server connection failed: {mex.Message}", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";" ;

            try
            {
                var result = TryCreateDatabaseAndSchema();
                bool ok = result.Item1;
                string msg = result.Item2 ?? string.Empty;

                if (ok)
                {
                    MessageBox.Show("Database and schema ensured:\r\n" + msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try { if (RememberCredentialsCheckBox != null) RememberCredentialsCheckBox.Checked = true; SaveConfig(DbConnection.ConnectionString); } catch { }
                }
                else
                {
                    MessageBox.Show("Failed to create database/schema: " + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try { UpdateDbStatusLabel(); } catch { }
        }

        private void SaveConfigCheckBox_CheckedChanged(object sender, EventArgs e) { }
        private void DemoModeCheckBox_CheckedChanged(object sender, EventArgs e) { }

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
                        if (RememberCredentialsCheckBox != null) RememberCredentialsCheckBox.Checked = true;
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
                    var cs = DbConnection.ConnectionString ?? string.Empty;
                    bool hasDb = cs.IndexOf("Database=", StringComparison.OrdinalIgnoreCase) >= 0 || cs.IndexOf("Initial Catalog", StringComparison.OrdinalIgnoreCase) >= 0;
                    bool ok = DbConnection.TestConnection();
                    if (!ok)
                    {
                        status = "DB Unavailable";
                    }
                    else
                    {
                        status = hasDb ? "Connected - Ready" : "Connected to server (no database selected)";
                    }
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

                if (ConnectionStatusOutputLabel != null) ConnectionStatusOutputLabel.Text = string.IsNullOrWhiteSpace(configInfo) ? status : $"{(status)} | {(configInfo)}";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                if (ConnectionStatusOutputLabel != null) ConnectionStatusOutputLabel.Text = "DB Status Unknown";
            }
        }

        /// <summary>
        /// Toggles password visibility.
        /// </summary>
        private void ShowPassLoginButtonLabel_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;
        }

        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try { PasswordTextBox?.Focus(); } catch { }
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try { LoginButton_Click(LoginButton, EventArgs.Empty); } catch { }
            }
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

namespace MachineProject3_TMS.Properties
{
    internal sealed partial class Settings
    {
        [System.Configuration.UserScopedSettingAttribute()]
        [System.Configuration.DefaultSettingValueAttribute("")]
        public string DbUsername 
        {
            get { try { return (string)this["DbUsername"]; } catch { return ""; } }
            set { this["DbUsername"] = value; }
        }

        [System.Configuration.UserScopedSettingAttribute()]
        [System.Configuration.DefaultSettingValueAttribute("")]
        public string DbPassword 
        {
            get { try { return (string)this["DbPassword"]; } catch { return ""; } }
            set { this["DbPassword"] = value; }
        }

        [System.Configuration.UserScopedSettingAttribute()]
        [System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RememberMe 
        {
            get { try { return (bool)this["RememberMe"]; } catch { return false; } }
            set { this["RememberMe"] = value; }
        }
    }
}
