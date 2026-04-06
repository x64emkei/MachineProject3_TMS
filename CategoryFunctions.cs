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
    /// Encapsulates CRUD operations for Category records.
    /// </summary>
    public static class CategoryFunctions
    {
        /// <summary>
        /// Fetches all categories.
        /// </summary>
        /// <summary>
        /// Fetches all categories.
        /// </summary>
        public static DataTable GetAllCategories()
        {
            try
            {
                if (DbConnection.DemoMode && DbConnection.DemoCategories != null)
                {
                    return DbConnection.DemoCategories.Copy();
                }

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
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while retrieving categories.", ex);
            }
        }

        /// <summary>
        /// Adds a new category.
        /// </summary>
        /// <summary>
        /// Adds a new category.
        /// </summary>
        public static void AddCategory(string name, string desc)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO categories (category_name, description) VALUES (@name, @desc)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name ?? string.Empty);
                        cmd.Parameters.AddWithValue("@desc", desc ?? string.Empty);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while adding a category.", ex);
            }
        }

        /// <summary>
        /// Updates a category.
        /// </summary>
        /// <summary>
        /// Updates a category.
        /// </summary>
        public static void UpdateCategory(int id, string name, string desc)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE categories SET category_name=@name, description=@desc WHERE category_id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name ?? string.Empty);
                        cmd.Parameters.AddWithValue("@desc", desc ?? string.Empty);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while updating a category.", ex);
            }
        }

        /// <summary>
        /// Deletes a category. Foreign key constraints in tasks table will apply.
        /// </summary>
        /// <summary>
        /// Deletes a category. Foreign key constraints in tasks table will apply.
        /// </summary>
        public static void DeleteCategory(int id)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while deleting a category.", ex);
            }
        }

        /// <summary>
        /// Calculates category statistics (total count).
        /// </summary>
        public static int GetCategoryCount()
        {
            try
            {
                if (DbConnection.DemoMode && DbConnection.DemoCategories != null)
                {
                    return DbConnection.DemoCategories.Rows.Count;
                }

                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string q = "SELECT COUNT(*) FROM categories";
                    using (MySqlCommand cmd = new MySqlCommand(q, conn))
                    {
                        var val = cmd.ExecuteScalar();
                        return val != DBNull.Value ? Convert.ToInt32(val) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while calculating category statistics.", ex);
            }
        }

        /// <summary>
        /// Calculates category statistics (total, can be extended later).
        /// </summary>
        public static void GetCategoryStats(out int total)
        {
            total = 0;
            try
            {
                total = GetCategoryCount();
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while retrieving category statistics.", ex);
            }
        }
    }
}