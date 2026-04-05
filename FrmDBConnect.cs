// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
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
                    // In a production app, saves this securely to App.config or Settings.
                }

                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database. Please check your credentials and ensure MySQL is running.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Application.Exit();
        }
    }
}