using System;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void ReturnToDashboardButton_Click(object sender, EventArgs e)
        {
            // If this form was opened with an owner (e.g. ShowDialog(this) or owner set), the owner will become visible again.
            if (this.Owner != null)
            {
                this.Close();
                return;
            }

            // Try common dashboard form names among open forms and show the first match.
            string[] dashboardNames = { "FrmDashboard", "DashboardForm", "MainForm", "FrmMain" };
            foreach (Form f in Application.OpenForms)
            {
                foreach (var name in dashboardNames)
                {
                    if (string.Equals(f.Name, name, StringComparison.OrdinalIgnoreCase))
                    {
                        f.Show();
                        f.BringToFront();
                        this.Close();
                        return;
                    }
                }
            }

            // Fallback: just close the about form.
            this.Close();
        }
    }
}
