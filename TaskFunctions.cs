// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MachineProject3_TMS
{
    /// <summary>
    /// Encapsulates CRUD operations for Task records.
    /// </summary>
    public static class TaskFunctions
    {
        /// <summary>
        /// Retrieves all tasks using explicit parameters to avoid SQL injection.
        /// </summary>
        /// <param name="keyword">Searches Title and AssignedTo when provided.</param>
        /// <param name="statusFilter">Filters by exact status when provided.</param>
        /// <param name="priorityFilter">Filters by exact priority when provided.</param>
        /// <param name="categoryId">Filters by category id when provided.</param>
        /// <summary>
        /// Retrieves all tasks with optional filters. Builds parameterized WHERE clauses depending on inputs.
        /// </summary>
        public static DataTable GetAllTasks(string keyword = "", string statusFilter = null, string priorityFilter = null, int? categoryId = null)
        {
            // Returns demo-mode tasks when demo mode is enabled.
            if (DbConnection.DemoMode)
            {
                DataTable demo = DbConnection.DemoTasks.Copy();
                if (!string.IsNullOrWhiteSpace(keyword) || !string.IsNullOrWhiteSpace(statusFilter) || !string.IsNullOrWhiteSpace(priorityFilter) || categoryId.HasValue)
                {
                    for (int i = demo.Rows.Count - 1; i >= 0; i--)
                    {
                        var row = demo.Rows[i];
                        var title = (row.Table.Columns.Contains("task_title") ? row["task_title"] : "")?.ToString() ?? "";
                        var assigned = (row.Table.Columns.Contains("assigned_to") ? row["assigned_to"] : "")?.ToString() ?? "";
                        var status = (row.Table.Columns.Contains("status") ? row["status"] : "")?.ToString() ?? "";
                        var priority = (row.Table.Columns.Contains("priority") ? row["priority"] : "")?.ToString() ?? "";
                        var cat = (row.Table.Columns.Contains("category_id") ? row["category_id"] : null);

                        bool keep = true;
                        if (!string.IsNullOrWhiteSpace(keyword))
                        {
                            string lower = keyword.ToLower();
                            if (!title.ToLower().Contains(lower) && !assigned.ToLower().Contains(lower)) keep = false;
                        }
                        if (!string.IsNullOrWhiteSpace(statusFilter) && !status.Equals(statusFilter, StringComparison.OrdinalIgnoreCase)) keep = false;
                        if (!string.IsNullOrWhiteSpace(priorityFilter) && !priority.Equals(priorityFilter, StringComparison.OrdinalIgnoreCase)) keep = false;
                        if (categoryId.HasValue && (cat == null || Convert.ToInt32(cat) != categoryId.Value)) keep = false;

                        if (!keep) demo.Rows.RemoveAt(i);
                    }
                }
                return demo;
            }

            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    var sb = new StringBuilder();
                    sb.Append("SELECT t.task_id, t.task_title, t.description, t.due_date, t.priority, t.status, t.assigned_to, c.category_name, t.category_id FROM tasks t LEFT JOIN categories c ON t.category_id = c.category_id");

                    var whereClauses = new List<string>();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        if (!string.IsNullOrWhiteSpace(keyword))
                        {
                            whereClauses.Add("(t.task_title LIKE @keyword OR t.assigned_to LIKE @keyword)");
                            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        }
                        if (!string.IsNullOrWhiteSpace(statusFilter))
                        {
                            whereClauses.Add("t.status = @status");
                            cmd.Parameters.AddWithValue("@status", statusFilter);
                        }
                        if (!string.IsNullOrWhiteSpace(priorityFilter))
                        {
                            whereClauses.Add("t.priority = @priority");
                            cmd.Parameters.AddWithValue("@priority", priorityFilter);
                        }
                        if (categoryId.HasValue)
                        {
                            whereClauses.Add("t.category_id = @categoryId");
                            cmd.Parameters.AddWithValue("@categoryId", categoryId.Value);
                        }

                        if (whereClauses.Count > 0)
                        {
                            sb.Append(" WHERE ");
                            sb.Append(string.Join(" AND ", whereClauses));
                        }

                        cmd.Connection = conn;
                        cmd.CommandText = sb.ToString();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Throws a wrapped exception to allow UI to handle messaging.
                throw new Exception("Database operation failed while retrieving tasks.", ex);
            }

            return dt;
        }

        /// <summary>
        /// Retrieves tasks using explicit filters stacking. Public wrapper for UI reporting filters.
        /// </summary>
        public static DataTable GetFilteredTasks(string keyword, string statusFilter, string priorityFilter)
        {
            // Delegates to GetAllTasks which already supports stacking and parameterization.
            return GetAllTasks(keyword ?? string.Empty, statusFilter, priorityFilter, null);
        }

        /// <summary>
        /// Calculates task statistics (total, pending, completed) using efficient SQL counts.
        /// </summary>
        public static void GetTaskStats(out int total, out int pending, out int completed)
        {
            total = pending = completed = 0;
            try
            {
                if (DbConnection.DemoMode)
                {
                    var dt = DbConnection.DemoTasks;
                    total = dt.Rows.Count;
                    foreach (DataRow r in dt.Rows)
                    {
                        var s = r.Table.Columns.Contains("status") ? Convert.ToString(r["status"]) : string.Empty;
                        if (string.Equals(s, "Pending", StringComparison.OrdinalIgnoreCase)) pending++;
                        if (string.Equals(s, "Completed", StringComparison.OrdinalIgnoreCase)) completed++;
                    }
                    return;
                }

                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string q = "SELECT COUNT(*) AS total, SUM(status='Pending') AS pending, SUM(status='Completed') AS completed FROM tasks";
                    using (MySqlCommand cmd = new MySqlCommand(q, conn))
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                total = rdr["total"] != DBNull.Value ? Convert.ToInt32(rdr["total"]) : 0;
                                pending = rdr["pending"] != DBNull.Value ? Convert.ToInt32(rdr["pending"]) : 0;
                                completed = rdr["completed"] != DBNull.Value ? Convert.ToInt32(rdr["completed"]) : 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while calculating task statistics.", ex);
            }
        }

        /// <summary>
        /// Inserts a new task into the database.
        /// </summary>
        public static void AddTask(string title, string desc, DateTime dueDate, string priority, string status, string assignedTo, int categoryId)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO tasks (task_title, description, due_date, priority, status, assigned_to, category_id) VALUES (@title, @desc, @dueDate, @priority, @status, @assignedTo, @categoryId)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title ?? string.Empty);
                        cmd.Parameters.AddWithValue("@desc", desc ?? string.Empty);
                        cmd.Parameters.AddWithValue("@dueDate", dueDate);
                        cmd.Parameters.AddWithValue("@priority", priority ?? string.Empty);
                        cmd.Parameters.AddWithValue("@status", status ?? string.Empty);
                        cmd.Parameters.AddWithValue("@assignedTo", assignedTo ?? string.Empty);
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while adding a task.", ex);
            }
        }

        /// <summary>
        /// Updates an existing task record.
        /// </summary>
        public static void UpdateTask(int id, string title, string desc, DateTime dueDate, string priority, string status, string assignedTo, int categoryId)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE tasks SET task_title=@title, description=@desc, due_date=@dueDate, priority=@priority, status=@status, assigned_to=@assignedTo, category_id=@categoryId WHERE task_id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@title", title ?? string.Empty);
                        cmd.Parameters.AddWithValue("@desc", desc ?? string.Empty);
                        cmd.Parameters.AddWithValue("@dueDate", dueDate);
                        cmd.Parameters.AddWithValue("@priority", priority ?? string.Empty);
                        cmd.Parameters.AddWithValue("@status", status ?? string.Empty);
                        cmd.Parameters.AddWithValue("@assignedTo", assignedTo ?? string.Empty);
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while updating a task.", ex);
            }
        }

        /// <summary>
        /// Removes a task from the database.
        /// </summary>
        public static void DeleteTask(int id)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM tasks WHERE task_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database operation failed while deleting a task.", ex);
            }
        }
    }
}
