// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Windows.Forms;

namespace Ordenes_Baarde_Tumbaga_MP3
{
    internal static class Program
    {
        /// <summary>
        /// Defines the main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Checks the database connection on startup.
            if (DbConnection.TestConnection())
            {
                Application.Run(new FrmLogin());
            }
            else
            {
                // Redirects to DB Connect form if connection fails.
                Application.Run(new FrmDBConnect());
            }
        }
    }
}