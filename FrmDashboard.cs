// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

            // Ensure controls are wired to their handlers in case the designer did not hook them up
            if (TaskManagementButton != null) TaskManagementButton.Click += TaskManagementButton_Click;
            if (CategoriesButton != null) CategoriesButton.Click += CategoriesButton_Click;
            if (ReportTaskButton != null) ReportTaskButton.Click += ReportTaskButton_Click;
            if (AboutButton != null) AboutButton.Click += AboutButton_Click;
            if (LogoutSystemButton != null) LogoutSystemButton.Click += LogoutSystemButton_Click;
            if (AboutUserButton != null) AboutUserButton.Click += AboutUserButton_Click;
            // Database connection button (open DB config from dashboard)
            if (DatabaseConnectionButton != null) DatabaseConnectionButton.Click += DatabaseConnectionButton_Click;

            // Menu strip items
            if (taskManagementToolStripMenuItem != null) taskManagementToolStripMenuItem.Click += taskManagementToolStripMenuItem_Click;
            if (categoriesToolStripMenuItem != null) categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            if (viewTasksToolStripMenuItem != null) viewTasksToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            if (aboutToolStripMenuItem != null) aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            if (LogoutSystemToolStripMenuItem != null) LogoutSystemToolStripMenuItem.Click += logoutSystemToolStripMenuItem_Click;
            if (exitToolStripMenuItem != null) exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;

            LoadUserData();

            // Wire hover descriptors for dashboard buttons to update DescriptorLabel on mouse enter/leave.
            try
            {
                if (TaskManagementButton != null)
                {
                    TaskManagementButton.MouseEnter += (s, e) => DescriptorLabel.Text = "Opens Task Management module.";
                    TaskManagementButton.MouseLeave += (s, e) => DescriptorLabel.Text = string.Empty;
                }
                if (CategoriesButton != null)
                {
                    CategoriesButton.MouseEnter += (s, e) => DescriptorLabel.Text = "Opens Category Management.";
                    CategoriesButton.MouseLeave += (s, e) => DescriptorLabel.Text = string.Empty;
                }
                if (ReportTaskButton != null)
                {
                    ReportTaskButton.MouseEnter += (s, e) => DescriptorLabel.Text = "Opens Reports viewer.";
                    ReportTaskButton.MouseLeave += (s, e) => DescriptorLabel.Text = string.Empty;
                }
                if (AboutButton != null)
                {
                    AboutButton.MouseEnter += (s, e) => DescriptorLabel.Text = "Shows application information.";
                    AboutButton.MouseLeave += (s, e) => DescriptorLabel.Text = string.Empty;
                }
            }
            catch
            {
                // Swallows wiring errors.
            }
        }

        /// <summary>
        /// Opens the database connection configuration form from the dashboard.
        /// </summary>
        private void DatabaseConnectionButton_Click(object sender, EventArgs e)
        {
            FrmDBConnect dbForm = new FrmDBConnect();
            dbForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Populates the dashboard with the active user's details.
        /// </summary>
        private void LoadUserData()
        {
            // Swap: show full name in welcome, username on AboutUserButton
            WelcomeLabel.Text = $"Welcome, {DbConnection.CurrentName}!";
            AboutUserButton.Text = DbConnection.CurrentUsername;
            // Display connection status using TestConnection or DemoMode
            if (DbConnection.DemoMode)
            {
                DbConnectionStatusLabel.Text = "Demo Mode (no DB)";
            }
            else
            {
                try
                {
                    DbConnectionStatusLabel.Text = DbConnection.TestConnection() ? "Connected to MySQL - Ready" : "DB Unavailable";
                }
                catch
                {
                    DbConnectionStatusLabel.Text = "DB Status Unknown";
                }
            }
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
            // Shows about without hiding the dashboard so the user retains context.
            try
            {
                FrmAbout aboutForm = new FrmAbout();
                aboutForm.Owner = this;
                aboutForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open About: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                // Clears session data.
                DbConnection.ClearSession();

                // Try to find an existing hidden Login form created by Application.Run.
                FrmLogin existingLogin = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f is FrmLogin)
                    {
                        existingLogin = f as FrmLogin;
                        break;
                    }
                }

                FrmLogin loginForm;
                if (existingLogin != null)
                {
                    // Reuse the existing main login form so the application main loop remains intact.
                    loginForm = existingLogin;
                    try { loginForm.Show(); loginForm.BringToFront(); } catch { }
                }
                else
                {
                    // No existing login form found, create a new one.
                    loginForm = new FrmLogin();
                    loginForm.Show();
                }

                // Close all other open forms except the login form we will keep.
                var openForms = new List<Form>();
                foreach (Form f in Application.OpenForms)
                {
                    openForms.Add(f);
                }

                foreach (var f in openForms)
                {
                    try
                    {
                        if (f == loginForm) continue; // Keep the login form alive
                        if (f.IsDisposed) continue;
                        f.Close();
                    }
                    catch
                    {
                        // Suppresses close errors to ensure login remains visible.
                    }
                }
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