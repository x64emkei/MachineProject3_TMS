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
            // Closes About and returns focus to its owner if present without hiding the dashboard.
            try
            {
                if (this.Owner != null)
                {
                    this.Close();
                    return;
                }

                // If no owner is present, simply close the About form. The dashboard remains visible by design.
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }
    }
}
