// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace MachineProject3_TMS
{
    /// <summary>
    /// Handles database connection strings and maintains the current user session.
    /// </summary>
    public static class DbConnection
    {
        // Stores the active connection string.
        public static string ConnectionString { get; set; } = "Server=localhost;Database=task_management_db;Uid=root;Pwd=XV770D2_sql!;";

        // Stores information about the currently logged-in user.
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentName { get; set; }
        public static string CurrentEmail { get; set; }
        public static DateTime CurrentLoginTime { get; set; }

        // If true the application runs without contacting the database allowing UI testing
        public static bool DemoMode { get; set; } = false;

        // In-memory demo datasets used when DemoMode is active to allow UI testing without DB.
        public static DataTable DemoCategories { get; private set; }
        public static DataTable DemoTasks { get; private set; }

        /// <summary>
        /// Initializes in-memory demo data and enables demo mode.
        /// </summary>
        public static void EnableDemoMode()
        {
            DemoMode = true;

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
            return new MySqlConnection(ConnectionString);
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
            DemoMode = false;
        }

        /// <summary>
        /// Disables demo mode and clears in-memory demo datasets so the application uses the real database.
        /// </summary>
        public static void DisableDemoMode()
        {
            // Disables demo flag and releases demo data to ensure real DB is used for testing.
            DemoMode = false;
            DemoCategories = null;
            DemoTasks = null;
        }
    }
}