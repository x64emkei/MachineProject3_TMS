using System;
using System.Linq;
using System.Windows.Forms;

namespace MachineProject3_TMS.Helpers
{
    public static class InputHelpers
    {
        /// <summary>
        /// Wires all TextBox controls on the form so that Enter advances focus to the next control (like Tab).
        /// It walks nested controls as well.
        /// </summary>
        public static void WireEnterToAdvance(Form form)
        {
            if (form == null) return;

            foreach (Control c in form.Controls)
            {
                WireControlRecursive(form, c);
            }
        }

        private static void WireControlRecursive(Form form, Control control)
        {
            if (control is TextBox tb)
            {
                tb.KeyDown -= TextBox_KeyDown;
                tb.KeyDown += TextBox_KeyDown;
            }

            // Recurse into child controls
            foreach (Control child in control.Controls)
            {
                WireControlRecursive(form, child);
            }
        }

        private static void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (sender is Control c && c.Parent != null)
                {
                    // Advance to the next control in tab order
                    c.Parent.SelectNextControl(c, true, true, true, true);
                }
            }
        }
    }
}
