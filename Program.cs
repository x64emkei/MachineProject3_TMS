// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using Ordenes_Baarde_Tumbaga_MP3;
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

            // DB Configuration Route Check
            bool isDbConfigured = CheckDatabaseConfig();

            if (!isDbConfigured)
            {
                // If false config, redirect to FrmDBConnect first
                Application.Run(new FrmDBConnect());
            }
            else
            {
                // Otherwise load normal login
                Application.Run(new FrmLogin());
            }
        }

        static bool CheckDatabaseConfig()
        {
            // TODO: Use DbConnection.cs to test if Settings.Default values successfully open a MySqlConnection
            // Return true if connected, false if failed/not configured.
            return false; // Forced to FrmDBConnect initially
        }
    }
}