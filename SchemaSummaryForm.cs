using System;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    public class SchemaSummaryForm : Form
    {
        private TextBox _textBox;
        private Button _ok;

        public SchemaSummaryForm(string title, string message)
        {
            this.Text = title ?? "Schema Initialization";
            this.Width = 600;
            this.Height = 400;
            this.StartPosition = FormStartPosition.CenterParent;

            _textBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Top,
                Height = this.ClientSize.Height - 50,
                Text = message ?? string.Empty
            };

            _ok = new Button
            {
                Text = "OK",
                Dock = DockStyle.Bottom,
                Height = 30
            };
            _ok.Click += (s, e) => this.Close();

            this.Controls.Add(_textBox);
            this.Controls.Add(_ok);
            // Set OK as the accept button so Enter closes the dialog
            this.AcceptButton = _ok;
        }
    }
}
