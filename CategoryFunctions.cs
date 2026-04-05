// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ordenes_Baarde_Tumbaga_MP3
{
    /// <summary>
    /// Encapsulates CRUD operations for Category records.
    /// </summary>
    public static class CategoryFunctions
    {
        /// <summary>
        /// Fetches all categories.
        /// </summary>
        public static DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM categories";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Adds a new category.
        /// </summary>
        public static void AddCategory(string name, string desc)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO categories (category_name, description) VALUES (@name, @desc)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Updates a category.
        /// </summary>
        public static void UpdateCategory(int id, string name, string desc)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE categories SET category_name=@name, description=@desc WHERE category_id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Deletes a category. Foreign key constraints in tasks table will apply.
        /// </summary>
        public static void DeleteCategory(int id)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM categories WHERE category_id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}