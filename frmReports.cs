// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using MachineProject3_TMS;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Ordenes_Baarde_Tumbaga_MP3
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
            RefreshGrid();
        }

        /// <summary>
        /// Retrieves records based on specific status or conditions.
        /// </summary>
        private void LoadTasksByCondition(string condition)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                string query = $@"SELECT t.task_id, t.task_title, t.description, t.due_date, t.priority, t.status, t.assigned_to, c.category_name 
                                  FROM tasks t 
                                  LEFT JOIN categories c ON t.category_id = c.category_id 
                                  {condition}";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            TaskDirectoryDataGridView.DataSource = dt;
            UpdateLiveStats();
        }

        /// <summary>
        /// Refreshes the directory showing all records.
        /// </summary>
        private void RefreshGrid()
        {
            LoadTasksByCondition("");
        }

        /// <summary>
        /// Updates the live statistics indicators on the dashboard based on real-time database state.
        /// </summary>
        private void UpdateLiveStats()
        {
            TotalTasksCounterLabel.Text = TaskFunctions.GetTaskCount().ToString();
            PendingTasksCounterLabel.Text = TaskFunctions.GetTaskCount("WHERE status = 'Pending'").ToString();
            CompletedTasksCounterLabel.Text = TaskFunctions.GetTaskCount("WHERE status = 'Completed'").ToString();
            OverdueTasksCounterLabel.Text = TaskFunctions.GetTaskCount("WHERE due_date < CURDATE() AND status != 'Completed'").ToString();

            HighPriorityTasksCounterLabel.Text = TaskFunctions.GetTaskCount("WHERE priority = 'High'").ToString();
            MediumTasksCounterLabel.Text = TaskFunctions.GetTaskCount("WHERE priority = 'Medium'").ToString();
            LowPriorityCounterLabel.Text = TaskFunctions.GetTaskCount("WHERE priority = 'Low'").ToString();

            DatabaseStatusMessage.Text = "Reports Active";
        }

        // --- FILTER BUTTONS ---

        private void AllTasksButton_Click(object sender, EventArgs e) => LoadTasksByCondition("");
        private void DoneTasksButton_Click(object sender, EventArgs e) => LoadTasksByCondition("WHERE t.status = 'Completed'");
        private void PendingTasksButton_Click(object sender, EventArgs e) => LoadTasksByCondition("WHERE t.status = 'Pending'");
        private void OverdueTasksButton_Click(object sender, EventArgs e) => LoadTasksByCondition("WHERE t.due_date < CURDATE() AND t.status != 'Completed'");

        private void HighPriorityButton_Click(object sender, EventArgs e) => LoadTasksByCondition("WHERE t.priority = 'High'");
        private void MediumPriorityButton_Click(object sender, EventArgs e) => LoadTasksByCondition("WHERE t.priority = 'Medium'");
        private void LowPriorityButton_Click(object sender, EventArgs e) => LoadTasksByCondition("WHERE t.priority = 'Low'");

        /// <summary>
        /// Handles basic searching dynamically matching by Title or Assigned Person.
        /// </summary>
        private void SearchDirectoryButton_Click(object sender, EventArgs e)
        {
            string keyword = SearchTextBox.Text.Trim();
            string condition = $"WHERE t.task_title LIKE '%{keyword}%' OR t.assigned_to LIKE '%{keyword}%'";
            LoadTasksByCondition(condition);
        }

        private void RefreshDirectoryButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            SearchTextBox.Clear();
        }

        private void ReturnToDashboardButton_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Hide();
        }

        /// <summary>
        /// Exports the current DataGridView contents to a basic CSV file.
        /// </summary>
        private void ExportReportButton_Click(object sender, EventArgs e)
        {
            if (TaskDirectoryDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV File|*.csv",
                Title = "Export Report",
                FileName = $"Task_Report_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder csv = new StringBuilder();

                    // Adding Headers
                    foreach (DataGridViewColumn column in TaskDirectoryDataGridView.Columns)
                    {
                        csv.Append(column.HeaderText + ",");
                    }
                    csv.AppendLine();

                    // Adding Data
                    foreach (DataGridViewRow row in TaskDirectoryDataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                csv.Append(cell.Value?.ToString().Replace(",", ";") + ",");
                            }
                            csv.AppendLine();
                        }
                    }

                    File.WriteAllText(sfd.FileName, csv.ToString());
                    MessageBox.Show("Data successfully exported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Placeholder print instruction dialog.
        /// </summary>
        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To print, please export the report to CSV and print via Excel or Word.", "Print Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}