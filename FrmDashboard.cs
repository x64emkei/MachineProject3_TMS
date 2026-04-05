// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using MachineProject3_TMS;
using System;
using System.Windows.Forms;

namespace Ordenes_Baarde_Tumbaga_MP3
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            LoadUserData();
        }

        /// <summary>
        /// Populates the dashboard with the active user's details.
        /// </summary>
        private void LoadUserData()
        {
            WelcomeLabel.Text = $"Welcome, {DbConnection.CurrentUsername}!";
            AboutUserButton.Text = DbConnection.CurrentName;
            DbConnectionStatusLabel.Text = "Connected to MySQL";
        }

        /// <summary>
        /// Opens the Task Management form.
        /// </summary>
        private void TaskManagementButton_Click(object sender, EventArgs e)
        {
            FrmTasks tasksForm = new FrmTasks();
            tasksForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Opens the Categories management form.
        /// </summary>
        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            FrmCategories categoryForm = new FrmCategories();
            categoryForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Opens the Reports viewing form.
        /// </summary>
        private void ReportTaskButton_Click(object sender, EventArgs e)
        {
            FrmReports reportsForm = new FrmReports();
            reportsForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Opens the About page.
        /// </summary>
        private void AboutButton_Click(object sender, EventArgs e)
        {
            FrmAbout aboutForm = new FrmAbout();
            aboutForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Shows user session details in a dialog box.
        /// </summary>
        private void AboutUserButton_Click(object sender, EventArgs e)
        {
            string details = $"Name: {DbConnection.CurrentName}\n" +
                             $"Username: {DbConnection.CurrentUsername}\n" +
                             $"Email: {DbConnection.CurrentEmail}\n" +
                             $"Session Started: {DbConnection.CurrentLoginTime}";
            MessageBox.Show(details, "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the logout process safely with user confirmation.
        /// </summary>
        private void LogoutSystemButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to logout. Any unsaved data will not be saved. Continue?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DbConnection.ClearSession();
                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();
                this.Hide();
            }
        }

        // --- MENU STRIP HANDLERS ---

        private void logoutSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogoutSystemButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void taskManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManagementButton_Click(sender, e);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesButton_Click(sender, e);
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportTaskButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutButton_Click(sender, e);
        }
    }
}