// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the application context that manages main form switching
            var ctx = new AppContext();
            AppController.Initialize(ctx);
            Application.Run(ctx);
        }
    }

    // Application-level controller used to switch the main form safely.
    public static class AppController
        {
            private static AppContext _context;
            public static void Initialize(AppContext ctx) => _context = ctx;

            public static void SwitchTo(Form newMain)
            {
                if (_context == null) throw new InvalidOperationException("AppController not initialized.");
                // If switching to a login form, ensure its LoginSucceeded event is wired to open dashboard
                if (newMain is FrmLogin fl)
                {
                    // Remove existing to avoid duplicate handlers
                    fl.LoginSucceeded -= Fl_LoginSucceeded;
                    fl.LoginSucceeded += Fl_LoginSucceeded;
                }

                _context.SwitchMainForm(newMain);
            }

            private static void Fl_LoginSucceeded(object sender, EventArgs e)
            {
                try
                {
                    // Create dashboard and switch to it
                    var dash = new FrmDashboard();
                    _context.SwitchMainForm(dash);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error opening dashboard from login: " + ex.Message);
                }
            }
        }

        public class AppContext : ApplicationContext
        {
            public AppContext()
            {
                // Start with the login form as the main form
                var login = new FrmLogin();
                MainForm = login;
                login.Show();
            }

            public void SwitchMainForm(Form newMain)
            {
                if (newMain == null) return;

                if (ReferenceEquals(MainForm, newMain))
                {
                    return;
                }

                var old = MainForm;

                // IMPORTANT: assign MainForm first so closing the old main form
                // does not terminate the app message loop.
                MainForm = newMain;

                // Show the new main form first so the message loop stays active
                try
                {
                    newMain.Show();
                }
                catch
                {
                    // If show fails, do not change main form
                    MainForm = old;
                    try { newMain.Dispose(); } catch { }
                    return;
                }

                // Close and dispose the old main form if it exists and is not the same
                if (old != null && old != newMain)
                {
                    try { old.Close(); } catch { }
                    try { old.Dispose(); } catch { }
                }
            }
        }
}