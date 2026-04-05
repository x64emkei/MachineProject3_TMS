// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Ordenes_Baarde_Tumbaga_MP3
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

        /// <summary>
        /// Attempts to open a test connection to verify database availability.
        /// </summary>
        public static bool TestConnection()
        {
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
        }
    }
}