using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            // Initializes the dashboard form and its components.
            WireNavigationEvents();
        }

        private void WireNavigationEvents()
        {
            // Buttons
            this.TaskManagementButton.Click += TaskManagementButton_Click;
            this.ReportTaskButton.Click += ReportTaskButton_Click;
            this.CategoriesButton.Click += CategoriesButton_Click;
            this.AboutButton.Click += AboutButton_Click;
            this.LogoutSystemButton.Click += Logout_Click;

            // Menu items
            this.taskManagementToolStripMenuItem.Click += TaskManagementButton_Click;
            this.viewTasksToolStripMenuItem.Click += ReportTaskButton_Click;
            this.categoriesToolStripMenuItem.Click += CategoriesButton_Click;
            this.aboutToolStripMenuItem.Click += AboutButton_Click;
            this.LogoutSystemToolStripMenuItem.Click += Logout_Click;

            // Exit menu
            this.exitToolStripMenuItem.Click += (s, e) => Application.Exit();
        }

        private void TaskManagementButton_Click(object sender, EventArgs e)
        {
            var f = new FrmTasks();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
            this.Hide();
        }

        private void ReportTaskButton_Click(object sender, EventArgs e)
        {
            var f = new FrmReports();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
            this.Hide();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            var f = new FrmCategories();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
            this.Hide();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var f = new FrmAbout();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
