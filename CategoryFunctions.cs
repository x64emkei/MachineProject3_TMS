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
        public static DataTable GetAllCategories()
        {
            if (DemoHelper.IsDemoMode) return new DataTable();

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
        /// Returns filtered categories using parameterized LIKE queries on name and description.
        /// </summary>
        public static DataTable GetFilteredCategories(string keyword)
        {
            if (DemoHelper.IsDemoMode) return new DataTable();

            try
            {
                if (DbConnection.DemoMode && DbConnection.DemoCategories != null)
                {
                    var copy = DbConnection.DemoCategories.Copy();
                    if (string.IsNullOrWhiteSpace(keyword)) return copy;
                    for (int i = copy.Rows.Count - 1; i >= 0; i--)
                    {
                        var name = Convert.ToString(copy.Rows[i]["category_name"] ?? string.Empty);
                        var desc = copy.Rows[i].Table.Columns.Contains("description") ? Convert.ToString(copy.Rows[i]["description"] ?? string.Empty) : string.Empty;
                        if (!name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase).Equals(0) && !name.ToLower().Contains(keyword.ToLower()) && !desc.ToLower().Contains(keyword.ToLower()))
                        {
                            copy.Rows.RemoveAt(i);
                        }
                    }
                    return copy;
                }

                DataTable dt = new DataTable();
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string q = "SELECT * FROM categories WHERE category_name LIKE @kw OR description LIKE @kw";
                    using (MySqlCommand cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while filtering categories.", ex);
            }
        }

        /// <summary>
        /// Adds a new category.
        /// </summary>
        public static void AddCategory(string name, string desc)
        {
            if (DemoHelper.IsDemoMode) return;

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
        public static void UpdateCategory(int id, string name, string desc)
        {
            if (DemoHelper.IsDemoMode) return;

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
                        int affected = cmd.ExecuteNonQuery();
                        if (affected == 0)
                        {
                            throw new InvalidOperationException("No category record found to update.");
                        }
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
        public static void DeleteCategory(int id)
        {
            if (DemoHelper.IsDemoMode) return;

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM categories WHERE category_id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int affected = cmd.ExecuteNonQuery();
                        if (affected == 0)
                        {
                            throw new InvalidOperationException("No category record found to delete.");
                        }
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
            if (DemoHelper.IsDemoMode) return 0;

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
            if (DemoHelper.IsDemoMode) return;

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