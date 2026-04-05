// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using MachineProject3_TMS;
using System;
using System.Windows.Forms;

namespace Ordenes_Baarde_Tumbaga_MP3
{
    public partial class FrmDBConnect : Form
    {
        public FrmDBConnect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tests the connection using the provided credentials.
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
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