// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace MachineProject3_TMS
{
    /// <summary>
    /// Handles database connection strings and maintains the current user session.
    /// </summary>
    public static class DbConnection
    {
        private static readonly object ConnectionSync = new object();
        private static MySqlConnection _activeConnection;

        // Stores the active connection string.
        public static string ConnectionString { get; set; } = "Server=localhost;Database=task_management_db;Uid=root;Pwd=XV770D2_sql!;";

        // Stores information about the currently logged-in user.
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentName { get; set; }
        public static string CurrentEmail { get; set; }
        public static DateTime CurrentLoginTime { get; set; }

        // If true the application runs without contacting the database allowing UI testing
        // Demo mode is only enabled when the user explicitly requests it.
        public static bool DemoMode => DemoHelper.IsDemoMode;

        // When true allows EnableDemoMode to actually enable demo data. This prevents accidental enabling.
        public static bool DemoAllowed { get; set; } = false;

        // In-memory demo datasets used when DemoMode is active to allow UI testing without DB.
        public static DataTable DemoCategories { get; private set; }
        public static DataTable DemoTasks { get; private set; }

        /// <summary>
        /// Initializes in-memory demo data and enables demo mode.
        /// </summary>
        public static void EnableDemoMode()
        {
            // Only enable demo mode when explicitly allowed by the user via the DB Connect form.
            if (!DemoAllowed) return;
            DemoHelper.EnableDemoMode();

            // Initialize demo categories
            if (DemoCategories == null)
            {
                DemoCategories = new DataTable();
                DemoCategories.Columns.Add("category_id", typeof(int));
                DemoCategories.Columns.Add("category_name", typeof(string));
                DemoCategories.Columns.Add("description", typeof(string));

                DemoCategories.Rows.Add(1, "General", "General tasks");
                DemoCategories.Rows.Add(2, "Work", "Work related tasks");
                DemoCategories.Rows.Add(3, "Personal", "Personal errands");
            }

            // Initialize demo tasks
            if (DemoTasks == null)
            {
                DemoTasks = new DataTable();
                DemoTasks.Columns.Add("task_id", typeof(int));
                DemoTasks.Columns.Add("task_title", typeof(string));
                DemoTasks.Columns.Add("description", typeof(string));
                DemoTasks.Columns.Add("due_date", typeof(DateTime));
                DemoTasks.Columns.Add("priority", typeof(string));
                DemoTasks.Columns.Add("status", typeof(string));
                DemoTasks.Columns.Add("assigned_to", typeof(string));
                DemoTasks.Columns.Add("category_name", typeof(string));
                DemoTasks.Columns.Add("category_id", typeof(int));

                DemoTasks.Rows.Add(1, "Buy groceries", "Milk, Eggs, Bread", DateTime.Now.AddDays(1), "Low", "Pending", "Demo User", "Personal", 3);
                DemoTasks.Rows.Add(2, "Finish report", "Complete the monthly report", DateTime.Now.AddDays(2), "High", "Pending", "Demo User", "Work", 2);
                DemoTasks.Rows.Add(3, "Plan trip", "Outline itinerary", DateTime.Now.AddDays(7), "Medium", "Completed", "Demo User", "General", 1);
            }
        }

        /// <summary>
        /// Attempts to open a test connection to verify database availability.
        /// </summary>
        public static bool TestConnection()
        {
            // When running in demo mode we consider the DB "available" for UI testing.
            if (DemoMode) return true;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Retrieves a new MySQL connection object.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(ConnectionString);
            connection.StateChange += Connection_StateChange;
            return connection;
        }

        private static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            var connection = sender as MySqlConnection;
            if (connection == null) return;

            lock (ConnectionSync)
            {
                if (e.CurrentState == ConnectionState.Open)
                {
                    _activeConnection = connection;
                }
                else if (ReferenceEquals(_activeConnection, connection) &&
                         (e.CurrentState == ConnectionState.Closed || e.CurrentState == ConnectionState.Broken))
                {
                    _activeConnection = null;
                }
            }
        }

        public static void Disconnect()
        {
            lock (ConnectionSync)
            {
                try
                {
                    if (_activeConnection != null)
                    {
                        if (_activeConnection.State != ConnectionState.Closed)
                        {
                            _activeConnection.Close();
                        }
                        _activeConnection.Dispose();
                        _activeConnection = null;
                    }
                }
                catch
                {
                }

                try
                {
                    MySqlConnection.ClearAllPools();
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Clears the current user session upon logout.
        /// </summary>
        public static void ClearSession()
        {
            CurrentUserId = 0;
            CurrentUsername = string.Empty;
            CurrentName = string.Empty;
            CurrentEmail = string.Empty;
            CurrentLoginTime = DateTime.MinValue;
            DemoHelper.DisableDemoMode();
        }

        /// <summary>
        /// Disables demo mode and clears in-memory demo datasets so the application uses the real database.
        /// </summary>
        public static void DisableDemoMode()
        {
            // Disables demo flag and releases demo data to ensure real DB is used for testing.
            DemoHelper.DisableDemoMode();
            DemoCategories = null;
            DemoTasks = null;
        }
    }
}