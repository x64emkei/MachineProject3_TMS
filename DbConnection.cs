using MySql.Data.MySqlClient;
using System;

namespace MachineProject3_TMS
{
    public static class DbConnection
    {
        // Provides a method to create a MySqlConnection using the project's default connection string
        public static MySqlConnection Create(string connectionString)
        {
            return new MySqlConnection(connectionString);
        }
    }
}
