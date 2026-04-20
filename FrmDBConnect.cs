// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
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
        private bool _hasVerifiedConnection;
        private string _currentHost = "127.0.0.1";
        private string _currentPort = "3306";

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
            if (CheckStatusButton != null) CheckStatusButton.Click += CheckStatusButton_Click;
            if (RefreshStatusButton != null) RefreshStatusButton.Click += RefreshStatusButton_Click;

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

        private async void FrmDBConnect_Load(object sender, EventArgs e)
        {
            try
            {
                _currentHost = ReadConfiguredHost();
                _currentPort = ReadConfiguredPort();

                if (RememberCredentialsCheckBox != null) RememberCredentialsCheckBox.Checked = Properties.Settings.Default.RememberMe;

                if (Properties.Settings.Default.RememberMe)
                {
                    if (UsernameTextBox != null) UsernameTextBox.Text = Properties.Settings.Default.DbUsername;
                    if (PasswordTextBox != null) PasswordTextBox.Text = Properties.Settings.Default.DbPassword;
                }

                if (ServerDetailsOutputLabel != null) ServerDetailsOutputLabel.Text = _currentHost + ":" + _currentPort;

                await RunSilentInitialStatusCheckAsync();
            }
            catch { }
        }

        private void DemoModeButton_Click(object sender, EventArgs e)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 460;
                prompt.Height = 230;
                prompt.Text = "Demo Mode Controls";
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;

                Label warningLabel = new Label() { Left = 20, Top = 20, Width = 410, Height = 40, Text = "Warning: Demo Mode disconnects all database access and limits actions to preview-only behavior." };
                Label countdownLabel = new Label() { Left = 20, Top = 65, Width = 410, Text = "Enable Demo available in 10 seconds..." };
                Button enableButton = new Button() { Text = "Enable Demo", Left = 20, Top = 110, Width = 120, Enabled = false };
                Button disableButton = new Button() { Text = "Disable Demo", Left = 155, Top = 110, Width = 120, Enabled = true };
                Button cancelButton = new Button() { Text = "Cancel", Left = 290, Top = 110, Width = 120 };

                prompt.Controls.Add(warningLabel);
                prompt.Controls.Add(countdownLabel);
                prompt.Controls.Add(enableButton);
                prompt.Controls.Add(disableButton);
                prompt.Controls.Add(cancelButton);

                int timeLeft = 10;
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (s, args) =>
                {
                    timeLeft--;
                    countdownLabel.Text = $"Enable Demo available in {timeLeft} seconds...";
                    if (timeLeft <= 0)
                    {
                        timer.Stop();
                        countdownLabel.Text = "You can now enable demo mode.";
                        enableButton.Enabled = true;
                    }
                };

                enableButton.Click += (s, args) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };
                disableButton.Click += (s, args) => { prompt.DialogResult = DialogResult.Retry; prompt.Close(); };
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
                    NavigateBackToLogin();
                }
                else if (result == DialogResult.Retry)
                {
                    DemoHelper.DisableDemoMode();
                    DbConnection.DisableDemoMode();
                    NavigateBackToLogin();
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
                await UpdateServiceStatusAsync();
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

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            SetConnectInputsLocked(true);
            SetProgressMarquee(true);
            try
            {
                string user = (UsernameTextBox?.Text ?? string.Empty).Trim();
                string pass = (PasswordTextBox?.Text ?? string.Empty).Trim();

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Please enter both username and password before connecting.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DemoHelper.InterceptAction("Connect to Database", "Connects the application to the MySQL server. Disabled in Demo Mode.")) return;

                string host = ReadConfiguredHost();
                string port = ReadConfiguredPort();
                string dbName = "task_management_db";
                string serverOnly = BuildServerConnectionString(host, port, user, pass);

                _currentHost = host;
                _currentPort = port;

                UpdateStatusLabel(ConnectionStatusOutputLabel, "Connecting...", "Checking...");
                UpdateStatusLabel(ServerStatusOutputLabel, "Checking...", "Checking...");
                UpdateStatusLabel(CredentialStatusOutputLabel, "Checking...", "Checking...");
                UpdateStatusLabel(DatabaseStatusOutputLabel, "Checking...", "Checking...");
                if (ServerDetailsOutputLabel != null) ServerDetailsOutputLabel.Text = host + ":" + port;

                string serviceStatus = await GetLocalMySqlServiceStateAsync();
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, serviceStatus, serviceStatus);

                if (serviceStatus == "Stopped")
                {
                    var continuePrompt = MessageBox.Show(
                        "The MySQL Service appears to be stopped. Do you want to try connecting anyway?",
                        "Service Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (continuePrompt == DialogResult.No)
                    {
                        return;
                    }
                }

                bool serverReachable = await TryPingServerAsync(host, port);
                if (!serverReachable)
                {
                    UpdateStatusLabel(ServerStatusOutputLabel, "Failed", "Failed");
                    UpdateStatusLabel(ConnectionStatusOutputLabel, "Connection Failed", "Failed");
                    MessageBox.Show($"Cannot reach the server at {host}:{port}. Please check your server address and ensure the MySQL service is running.", "Server Unreachable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UpdateStatusLabel(ServerStatusOutputLabel, "Active", "Active");

                using (var conn = new MySqlConnection(serverOnly))
                {
                    try
                    {
                        await conn.OpenAsync();
                    }
                    catch (MySqlException mex) when (mex.Number == 1045)
                    {
                        UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid", "Invalid");
                        UpdateStatusLabel(ConnectionStatusOutputLabel, "Connection Failed", "Failed");
                        MessageBox.Show($"Access denied for user '{user}'. Please check your credentials.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    catch (MySqlException mex) when (mex.Number == 1042)
                    {
                        UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid", "Invalid");
                        UpdateStatusLabel(ConnectionStatusOutputLabel, "Connection Failed", "Failed");
                        MessageBox.Show("Unable to reach the MySQL server (Error 1042). Please verify host, port, and service state.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    catch
                    {
                        UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid", "Invalid");
                        UpdateStatusLabel(ConnectionStatusOutputLabel, "Connection Failed", "Failed");
                        MessageBox.Show($"Access denied for user '{user}'. Please check your credentials.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    UpdateStatusLabel(CredentialStatusOutputLabel, "Valid", "Valid");

                    bool databasePresent = await IsDatabaseSchemaPresentAsync(conn, dbName);
                    if (databasePresent)
                    {
                        UpdateStatusLabel(DatabaseStatusOutputLabel, "Present", "Present");
                        MessageBox.Show("Successfully connected. The database is already present and linked.", "Database Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        UpdateStatusLabel(DatabaseStatusOutputLabel, "Missing", "Missing");
                        var schemaPrompt = MessageBox.Show(
                            "Connection successful, but the database schema is missing. Would you like to initialize the required full database schema now?",
                            "Initialize Schema",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (schemaPrompt == DialogResult.Yes)
                        {
                            DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";";
                            var schemaResult = await Task.Run(() => TryCreateDatabaseAndSchema());
                            if (!schemaResult.Item1)
                            {
                                UpdateStatusLabel(DatabaseStatusOutputLabel, "Missing", "Missing");
                                MessageBox.Show("Schema initialization failed: " + schemaResult.Item2, "Schema Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            UpdateStatusLabel(DatabaseStatusOutputLabel, "Present", "Present");
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";";
                _hasVerifiedConnection = true;
                UpdateStatusLabel(ConnectionStatusOutputLabel, "Connected", "Connected");

                var savePrompt = MessageBox.Show(
                    "Connection fully verified. Save this server configuration?",
                    "Save Configuration",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (savePrompt == DialogResult.Yes)
                {
                    try
                    {
                        Properties.Settings.Default.DbHost = host;
                        Properties.Settings.Default.DbPort = port;
                        Properties.Settings.Default.DbUsername = user;
                        Properties.Settings.Default.DbPassword = pass;
                        Properties.Settings.Default.RememberMe = true;
                        Properties.Settings.Default.Setting = DbConnection.ConnectionString;
                        Properties.Settings.Default.Save();
                        if (RememberCredentialsCheckBox != null) RememberCredentialsCheckBox.Checked = true;
                        SaveConfig(Properties.Settings.Default.Setting);

                        UpdateStatusLabel(ServerStatusOutputLabel, "Active", "Active");
                        UpdateStatusLabel(CredentialStatusOutputLabel, "Valid", "Valid");
                        UpdateStatusLabel(DatabaseStatusOutputLabel, "Present", "Present");
                        UpdateStatusLabel(ConnectionStatusOutputLabel, "Connected", "Connected");
                        UpdateStatusLabel(WindowsServiceStatusOutputLabel, "Verified", "Valid");

                        MessageBox.Show(
                            "Configuration saved successfully. You may now use the back arrow to return to the login screen.",
                            "Configuration Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch { }
                }
                else
                {
                    if (RememberCredentialsCheckBox != null) RememberCredentialsCheckBox.Checked = false;
                    MessageBox.Show(
                        "Connection verified. You may now use the back arrow to return to the login screen.",
                        "Connection Verified",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                UpdateStatusLabel(ConnectionStatusOutputLabel, "Connection Failed", "Failed");
                MessageBox.Show("Failed to connect to the database.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetProgressMarquee(false);
                SetConnectInputsLocked(false);
            }
        }

        private async void RefreshStatusButton_Click(object sender, EventArgs e)
        {
            if (DemoHelper.InterceptAction("Refresh Service Status", "This button refreshes the local MySQL Windows Service status. Disabled in Demo Mode.")) return;

            SetProgressMarquee(true);
            try
            {
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, "Checking...", "Checking...");
                string serviceState = await GetLocalMySqlServiceStateAsync();
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, serviceState, serviceState);

                MessageBox.Show(
                    "Service Status Updated.\n\nCurrent State: " + serviceState,
                    "Service Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                UpdateStatusLabel(WindowsServiceStatusOutputLabel, "Failed", "Failed");
            }
            finally
            {
                SetProgressMarquee(false);
            }
        }

        private async void CheckStatusButton_Click(object sender, EventArgs e)
        {
            if (DemoHelper.InterceptAction("Check Status", "This button checks server, credentials, and database status. Disabled in Demo Mode.")) return;

            SetProgressMarquee(true);
            try
            {
                string user = (UsernameTextBox?.Text ?? string.Empty).Trim();
                string pass = (PasswordTextBox?.Text ?? string.Empty).Trim();
                string host = ReadConfiguredHost();
                string port = ReadConfiguredPort();
                string dbName = "task_management_db";

                _currentHost = host;
                _currentPort = port;
                if (ServerDetailsOutputLabel != null) ServerDetailsOutputLabel.Text = host + ":" + port;

                string serverState = "Unreachable";
                string credentialState = "Invalid";
                string databaseState = "Missing";

                bool serverReachable = await TryPingServerAsync(host, port);
                if (serverReachable)
                {
                    serverState = "Active";
                    UpdateStatusLabel(ServerStatusOutputLabel, "Active", "Active");

                    if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
                    {
                        string serverOnly = BuildServerConnectionString(host, port, user, pass);
                        using (var conn = new MySqlConnection(serverOnly))
                        {
                            try
                            {
                                await conn.OpenAsync();
                                credentialState = "Valid";
                                UpdateStatusLabel(CredentialStatusOutputLabel, "Valid", "Valid");

                                bool databasePresent = await IsDatabaseSchemaPresentAsync(conn, dbName);
                                databaseState = databasePresent ? "Present" : "Missing";
                                UpdateStatusLabel(DatabaseStatusOutputLabel, databaseState, databasePresent ? "Present" : "Missing");
                            }
                            catch
                            {
                                credentialState = "Invalid";
                                UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid", "Invalid");
                                UpdateStatusLabel(DatabaseStatusOutputLabel, "Missing", "Missing");
                            }
                        }
                    }
                    else
                    {
                        credentialState = "Invalid";
                        databaseState = "Missing";
                        UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid", "Invalid");
                        UpdateStatusLabel(DatabaseStatusOutputLabel, "Missing", "Missing");
                    }
                }
                else
                {
                    UpdateStatusLabel(ServerStatusOutputLabel, "Failed", "Failed");
                    UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid", "Invalid");
                    UpdateStatusLabel(DatabaseStatusOutputLabel, "Missing", "Missing");
                }

                string summary =
                    "Connection Test " + ((serverState == "Active" && credentialState == "Valid") ? "Successful" : "Failed") +
                    ".\nServer: " + serverState +
                    "\nCredentials: " + credentialState +
                    "\nDatabase: " + databaseState;

                MessageBox.Show(
                    summary,
                    "Connection Test",
                    MessageBoxButtons.OK,
                    (serverState == "Active" && credentialState == "Valid") ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check current status.\n\n" + ex.Message, "Status Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                SetProgressMarquee(false);
            }
        }

        private async Task UpdateServiceStatusAsync()
        {
            string serviceState = await GetLocalMySqlServiceStateAsync();
            UpdateStatusLabel(WindowsServiceStatusOutputLabel, serviceState, serviceState);
        }

        private async Task<string> GetLocalMySqlServiceStateAsync()
        {
            return await Task.Run(() =>
            {
                string[] serviceNames = { "MySQL", "MySQL80", "mysql" };

                foreach (var serviceName in serviceNames)
                {
                    try
                    {
                        using (var service = new ServiceController(serviceName))
                        {
                            return service.Status == ServiceControllerStatus.Running ? "Running" : "Stopped";
                        }
                    }
                    catch
                    {
                        // Try next known service name.
                    }
                }

                return "Not Found";
            });
        }

        private async Task RunSilentInitialStatusCheckAsync()
        {
            SetProgressMarquee(true);
            try
            {
                await UpdateServiceStatusAsync();

                string host = ReadConfiguredHost();
                string port = ReadConfiguredPort();
                string user = Properties.Settings.Default.DbUsername ?? string.Empty;
                string pass = Properties.Settings.Default.DbPassword ?? string.Empty;
                string dbName = "task_management_db";

                if (ServerDetailsOutputLabel != null) ServerDetailsOutputLabel.Text = host + ":" + port;

                bool serverReachable = await TryPingServerAsync(host, port);
                UpdateStatusLabel(ServerStatusOutputLabel, serverReachable ? "Active" : "Failed", serverReachable ? "Active" : "Failed");

                if (!serverReachable || string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid", "Invalid");
                    UpdateStatusLabel(DatabaseStatusOutputLabel, "Missing", "Missing");
                    UpdateStatusLabel(ConnectionStatusOutputLabel, "Disconnected", "Disconnected");
                    _hasVerifiedConnection = false;
                    return;
                }

                string serverOnly = BuildServerConnectionString(host, port, user, pass);
                using (var conn = new MySqlConnection(serverOnly))
                {
                    try
                    {
                        await conn.OpenAsync();
                        UpdateStatusLabel(CredentialStatusOutputLabel, "Valid", "Valid");

                        bool dbPresent = await IsDatabaseSchemaPresentAsync(conn, dbName);
                        UpdateStatusLabel(DatabaseStatusOutputLabel, dbPresent ? "Present" : "Missing", dbPresent ? "Present" : "Missing");

                        if (dbPresent)
                        {
                            DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";";
                            UpdateStatusLabel(ConnectionStatusOutputLabel, "Connected", "Connected");
                            _hasVerifiedConnection = true;
                        }
                        else
                        {
                            UpdateStatusLabel(ConnectionStatusOutputLabel, "Disconnected", "Disconnected");
                            _hasVerifiedConnection = false;
                        }
                    }
                    catch
                    {
                        UpdateStatusLabel(CredentialStatusOutputLabel, "Invalid", "Invalid");
                        UpdateStatusLabel(DatabaseStatusOutputLabel, "Missing", "Missing");
                        UpdateStatusLabel(ConnectionStatusOutputLabel, "Disconnected", "Disconnected");
                        _hasVerifiedConnection = false;
                    }
                }
            }
            finally
            {
                SetProgressMarquee(false);
            }
        }

        private async Task<bool> TryPingServerAsync(string host, string port)
        {
            int parsedPort;
            if (!int.TryParse(port, out parsedPort)) return false;

            using (var client = new TcpClient())
            {
                var connectTask = client.ConnectAsync(host, parsedPort);
                var timeoutTask = Task.Delay(3000);
                var completed = await Task.WhenAny(connectTask, timeoutTask);
                if (completed != connectTask) return false;

                try
                {
                    await connectTask;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        private async Task<bool> IsDatabaseSchemaPresentAsync(MySqlConnection connection, string dbName)
        {
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM information_schema.SCHEMATA WHERE SCHEMA_NAME = @db", connection))
            {
                cmd.Parameters.AddWithValue("@db", dbName);
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result) > 0;
            }
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
                case "Active":
                case "Present":
                    label.ForeColor = Color.LimeGreen;
                    break;
                case "Stopped":
                case "Failed":
                case "Disconnected":
                case "Invalid":
                    label.ForeColor = Color.Red;
                    break;
                case "Checking...":
                case "Missing":
                case "Not Found":
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
            if (!_hasVerifiedConnection && !DemoHelper.IsDemoMode)
            {
                var prompt = MessageBox.Show(
                    "No database is connected. The application will not function correctly. Are you sure you want to return?",
                    "Connection Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (prompt == DialogResult.No)
                {
                    return;
                }
            }

            NavigateBackToLogin();
        }

        private void SetConnectInputsLocked(bool isLocked)
        {
            if (LoginButton != null) LoginButton.Enabled = !isLocked;
            if (UsernameTextBox != null) UsernameTextBox.Enabled = !isLocked;
            if (PasswordTextBox != null) PasswordTextBox.Enabled = !isLocked;
            if (RememberCredentialsCheckBox != null) RememberCredentialsCheckBox.Enabled = !isLocked;
        }

        private void NavigateBackToLogin()
        {
            try
            {
                AppController.SwitchTo(new FrmLogin());
            }
            catch
            {
                try
                {
                    var login = new FrmLogin();
                    login.Show();
                    this.Hide();
                }
                catch
                {
                    Application.Exit();
                }
            }
        }

        private string ReadConfiguredHost()
        {
            try
            {
                var configured = Properties.Settings.Default.DbHost;
                if (!string.IsNullOrWhiteSpace(configured)) return configured.Trim();
            }
            catch { }

            return "127.0.0.1";
        }

        private string ReadConfiguredPort()
        {
            try
            {
                var configured = Properties.Settings.Default.DbPort;
                if (!string.IsNullOrWhiteSpace(configured)) return configured.Trim();
            }
            catch { }

            return "3306";
        }

        private string BuildServerConnectionString(string host, string port, string user, string pass)
        {
            string normalizedHost = string.IsNullOrWhiteSpace(host) ? "127.0.0.1" : host.Trim();
            string normalizedPort = string.IsNullOrWhiteSpace(port) ? "3306" : port.Trim();
            return $"Server={normalizedHost};Port={normalizedPort};Uid={user};Pwd={pass};";
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

        [System.Configuration.UserScopedSettingAttribute()]
        [System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string DbHost
        {
            get { try { return (string)this["DbHost"]; } catch { return "127.0.0.1"; } }
            set { this["DbHost"] = value; }
        }

        [System.Configuration.UserScopedSettingAttribute()]
        [System.Configuration.DefaultSettingValueAttribute("3306")]
        public string DbPort
        {
            get { try { return (string)this["DbPort"]; } catch { return "3306"; } }
            set { this["DbPort"] = value; }
        }
    }
}
