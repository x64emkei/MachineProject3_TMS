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
        // Stores last schema creation summary for display
        private string _lastSchemaSummary = string.Empty;
        public FrmDBConnect()
        {
            InitializeComponent();
            // Wire designer buttons to their handlers so the form is responsive at runtime
            if (LoginButton != null) LoginButton.Click += LoginButton_Click;
            if (ReturnToDashboardButton != null) ReturnToDashboardButton.Click += ReturnToDashboardButton_Click;
            if (ShowPassLoginButtonLabel != null) ShowPassLoginButtonLabel.Click += ShowPassLoginButtonLabel_Click;

            // Keyboard helpers
            try
            {
                if (UsernameTextBox != null) UsernameTextBox.KeyDown += UsernameTextBox_KeyDown;
                if (PasswordTextBox != null) PasswordTextBox.KeyDown += PasswordTextBox_KeyDown;
                if (LoginButton != null) this.AcceptButton = LoginButton;
            }
            catch { }

            // Wire checkbox events
            if (SaveConfigCheckBox != null) SaveConfigCheckBox.CheckedChanged += SaveConfigCheckBox_CheckedChanged;
            if (DemoModeCheckBox != null) DemoModeCheckBox.CheckedChanged += DemoModeCheckBox_CheckedChanged;
            if (CreateNewDataBaseButton != null) CreateNewDataBaseButton.Click += CreateNewDataBaseButton_Click;

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
                string serverOnly = string.Join(";", serverParts) + ";";

                // Connect to server and create database
                using (var conn = new MySqlConnection(serverOnly))
                {
                    conn.Open();
                    // Auto-save server-only credentials so fields remain stored
                    try { SaveConfigCheckBox.Checked = true; SaveConfig(serverOnly); } catch { }
                    string createDb = $"CREATE DATABASE IF NOT EXISTS `{dbName}` CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;";
                    using (var cmd = new MySqlCommand(createDb, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Update application connection string to include database (recompose)
                DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";";

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


        /// <summary>
        /// Handles SaveConfig checkbox changes by asking for confirmation when being unchecked.
        /// </summary>
        /// <summary>
        /// Handler for CreateNewDataBaseButton click. Attempts to create the database and ensure schema, then reports result.
        /// </summary>
        private void CreateNewDataBaseButton_Click(object sender, EventArgs e)
        {
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

            DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";";

            try
            {
                var result = TryCreateDatabaseAndSchema();
                bool ok = result.Item1;
                string msg = result.Item2 ?? string.Empty;

                if (ok)
                {
                    MessageBox.Show("Database and schema ensured:\r\n" + msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Auto-save server credentials and keep box checked
                    try { SaveConfigCheckBox.Checked = true; SaveConfig(DbConnection.ConnectionString); } catch { }
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

            string dbName = "task_management_db";
            string serverOnly = $"Server=localhost;Uid={user};Pwd={pass};";

            // First, try connecting to the server (no database selected)
            try
            {
                using (var conn = new MySqlConnection(serverOnly))
                {
                    conn.Open();

                    // Server reachable. Check if the target database exists.
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM information_schema.schemata WHERE schema_name = @db", conn))
                    {
                        cmd.Parameters.AddWithValue("@db", dbName);
                        var exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;

                        if (exists)
                        {
                            // Database exists. Ask user whether to overwrite or migrate.
                            var ask = MessageBox.Show($"Database '{dbName}' was found on the server.\r\n\r\nChoose Yes to overwrite (drop existing tables and recreate schema).\r\nChoose No to attempt a non-destructive migration (create missing tables).\r\nChoose Cancel to abort.",
                                "Database Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                            if (ask == DialogResult.Cancel)
                            {
                                return;
                            }

                            // Set connection string to the database for schema operations
                            DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";";
                            if (ask == DialogResult.Yes)
                            {
                                // Overwrite: offer backup then drop known tables then recreate
                                try
                                {
                                    var backupAnswer = MessageBox.Show("Would you like to backup existing data before overwriting?", "Backup Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (backupAnswer == DialogResult.Yes)
                                    {
                                        // perform backup into backup_{table}_{timestamp} tables
                                        string ts = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                                        using (var c3 = new MySqlConnection(DbConnection.ConnectionString))
                                        {
                                            c3.Open();
                                            foreach (var t in new[] { "users", "categories", "tasks", "schema_migrations" })
                                            {
                                                try
                                                {
                                                    // Check if table exists
                                                    using (var chk = new MySqlCommand("SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = DATABASE() AND table_name = @t", c3))
                                                    {
                                                        chk.Parameters.AddWithValue("@t", t);
                                                        var cnt = Convert.ToInt32(chk.ExecuteScalar());
                                                        if (cnt == 0) continue; // nothing to backup
                                                    }

                                                    string backupName = $"backup_{t}_{ts}";
                                                    string bkSql = $"CREATE TABLE `{backupName}` AS SELECT * FROM `{t}`;";
                                                    using (var bk = new MySqlCommand(bkSql, c3)) { bk.ExecuteNonQuery(); }
                                                }
                                                catch (Exception ex)
                                                {
                                                    var cont = MessageBox.Show($"Failed to backup table {t}: {ex.Message}\r\nContinue with overwrite?", "Backup Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                                    if (cont == DialogResult.No)
                                                    {
                                                        return;
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    using (var c2 = new MySqlConnection(DbConnection.ConnectionString))
                                    {
                                        c2.Open();
                                        using (var drop = new MySqlCommand(@"SET FOREIGN_KEY_CHECKS=0; DROP TABLE IF EXISTS tasks; DROP TABLE IF EXISTS categories; DROP TABLE IF EXISTS users; DROP TABLE IF EXISTS schema_migrations; SET FOREIGN_KEY_CHECKS=1;", c2))
                                        {
                                            drop.ExecuteNonQuery();
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Failed to drop existing tables: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                var ok = EnsureDatabaseSchema();
                                if (ok)
                                {
                                    MessageBox.Show("Database schema overwritten and created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to recreate database schema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                // Migrate: non-destructive ensure
                                var ok = EnsureDatabaseSchema();
                                if (ok)
                                {
                                    MessageBox.Show("Database checked and missing tables were created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to ensure database schema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            // Persist settings if requested
                            if (SaveConfigCheckBox.Checked)
                            {
                                try { SaveConfig(DbConnection.ConnectionString); } catch { }
                            }

                            DbConnection.DisableDemoMode();
                            UpdateDbStatusLabel();

                            // After schema is present, check for users
                            bool hasUsers = false;
                            try
                            {
                                using (var conn2 = new MySqlConnection(DbConnection.ConnectionString))
                                {
                                    conn2.Open();
                                    using (var cmd2 = new MySqlCommand("SELECT COUNT(*) FROM users", conn2))
                                    {
                                        var val = cmd2.ExecuteScalar();
                                        hasUsers = val != DBNull.Value && Convert.ToInt32(val) > 0;
                                    }
                                }
                            }
                            catch { hasUsers = false; }

                            FrmLogin loginForm = new FrmLogin();
                            if (!hasUsers)
                            {
                                try
                                {
                                    this.Hide();
                                    using (var dlg = new SchemaSummaryForm("Schema Creation Summary", _lastSchemaSummary)) { try { dlg.ShowDialog(this); } catch { } }
                                    loginForm.Show();
                                    loginForm.ShowCreateAccountPanel();
                                    return;
                                }
                                catch { }
                            }

                            try
                            {
                                if (!string.IsNullOrEmpty(_lastSchemaSummary))
                                {
                                    using (var dlg = new SchemaSummaryForm("Schema Creation Summary", _lastSchemaSummary)) { try { dlg.ShowDialog(this); } catch { } }
                                }
                            }
                            catch { }

                            loginForm.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            // Database not found on server
                            var create = MessageBox.Show($"Connected to server, but database '{dbName}' was not found.\r\nWould you like to create it now?", "Database Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (create == DialogResult.Yes)
                            {
                                DbConnection.ConnectionString = serverOnly + "Database=" + dbName + ";";
                                var res = TryCreateDatabaseAndSchema();
                                if (res.Item1)
                                {
                                    MessageBox.Show("Database created and schema applied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (SaveConfigCheckBox.Checked) { try { SaveConfig(DbConnection.ConnectionString); } catch { } }
                                    DbConnection.DisableDemoMode();
                                    UpdateDbStatusLabel();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to create database: " + res.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                // User chose not to create DB now. Keep server-only connection string so user can create manually later.
                                DbConnection.ConnectionString = serverOnly;
                                UpdateDbStatusLabel();
                                MessageBox.Show("Connected to server. You may create the database later using the Create Database button.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return;
                        }
                    }
                }
            }
            catch (MySqlException mex)
            {
                MessageBox.Show($"Server connection failed: {mex.Message}", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error checking server/database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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