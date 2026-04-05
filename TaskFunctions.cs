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
    /// Encapsulates CRUD operations for Task records.
    /// </summary>
    public static class TaskFunctions
    {
        /// <summary>
        /// Retrieves all tasks, optionally filtered by keyword and field.
        /// </summary>
        public static DataTable GetAllTasks(string filterQuery = "", string keyword = "")
        {
            // If in demo mode return in-memory demo tasks
            if (DbConnection.DemoMode)
            {
                DataTable demo = DbConnection.DemoTasks.Copy();
                if (!string.IsNullOrEmpty(keyword))
                {
                    // Simple filter to mimic search behavior
                    string lower = keyword.ToLower();
                    for (int i = demo.Rows.Count - 1; i >= 0; i--)
                    {
                        var title = demo.Rows[i]["task_title"]?.ToString().ToLower() ?? "";
                        var assigned = demo.Rows[i]["assigned_to"]?.ToString().ToLower() ?? "";
                        if (!title.Contains(lower) && !assigned.Contains(lower))
                            demo.Rows.RemoveAt(i);
                    }
                }
                return demo;
            }

            DataTable dt = new DataTable();
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                // Build base query
                string query = @"SELECT t.task_id, t.task_title, t.description, t.due_date, t.priority, t.status, t.assigned_to, c.category_name, t.category_id
                                 FROM tasks t
                                 LEFT JOIN categories c ON t.category_id = c.category_id";

                // If keyword provided and no specific filterQuery, search title and assigned_to
                if (!string.IsNullOrEmpty(keyword) && string.IsNullOrEmpty(filterQuery))
                {
                    query += " WHERE t.task_title LIKE @keyword OR t.assigned_to LIKE @keyword";
                }
                else if (!string.IsNullOrEmpty(filterQuery))
                {
                    query += $" WHERE {filterQuery} LIKE @keyword";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Inserts a new task into the database.
        /// </summary>
        public static void AddTask(string title, string desc, DateTime dueDate, string priority, string status, string assignedTo, int categoryId)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO tasks (task_title, description, due_date, priority, status, assigned_to, category_id) VALUES (@title, @desc, @dueDate, @priority, @status, @assignedTo, @categoryId)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@dueDate", dueDate);
                    cmd.Parameters.AddWithValue("@priority", priority);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@assignedTo", assignedTo);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Updates an existing task record.
        /// </summary>
        public static void UpdateTask(int id, string title, string desc, DateTime dueDate, string priority, string status, string assignedTo, int categoryId)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE tasks SET task_title=@title, description=@desc, due_date=@dueDate, priority=@priority, status=@status, assigned_to=@assignedTo, category_id=@categoryId WHERE task_id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@dueDate", dueDate);
                    cmd.Parameters.AddWithValue("@priority", priority);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@assignedTo", assignedTo);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Removes a task from the database.
        /// </summary>
        public static void DeleteTask(int id)
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

        /// <summary>
        /// Returns specific task statistics for the dashboard/counters.
        /// </summary>
        public static int GetTaskCount(string condition = "")
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tasks " + condition;
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}