// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MachineProject3_TMS;
using MachineProject3_TMS.Helpers;

namespace MachineProject3_TMS
{
    public partial class FrmReports : Form
    {
        // Tracks currently active status filter.
        private string _currentStatusFilter;
        // Tracks currently active priority filter.
        private string _currentPriorityFilter;
        // Tracks current search keyword.
        private string _currentKeyword;
        // Holds the currently loaded dataset.
        private DataTable _currentData;
        // Print document used for printing reports.
        private PrintDocument _printDocument;
        // Current row index for printing.
        private int _printRowIndex;

        public FrmReports()
        {
            InitializeComponent();
            // Ensure ReturnToDashboard button wired
            if (ReturnToDashboardButton != null) ReturnToDashboardButton.Click += ReturnToDashboardButton_Click;
            // Initializes default filters and refreshes grid.
            _currentStatusFilter = null;
            _currentPriorityFilter = null;
            _currentKeyword = null;
            RefreshGrid();

            // Initializes printing helpers.
            _printDocument = new PrintDocument();
            _printDocument.PrintPage += PrintDocument_PrintPage;

            try { InputHelpers.WireEnterToAdvance(this); } catch { }
        }
        /// <summary>
        /// Loads tasks using current filter state via the data access layer.
        /// </summary>
        private void LoadTasks()
        {
            try
            {
                // Retrieves tasks using the DAL filtered method which stacks filters.
                var dt = DbConnection.DemoMode ? (DbConnection.DemoTasks != null ? DbConnection.DemoTasks.Copy() : new DataTable()) : TaskFunctions.GetFilteredTasks(_currentKeyword ?? string.Empty, _currentStatusFilter, _currentPriorityFilter);
                _currentData = dt;
                TaskDirectoryDataGridView.DataSource = dt;
                TaskDirectoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                UpdateLiveStats(dt);
                DatabaseStatusMessage.Text = "Reports loaded.";
            }
            catch (Exception ex)
            {
                // Enables demo mode when DB errors occur and uses in-memory demo data.
                DbConnection.EnableDemoMode();
                _currentData = DbConnection.DemoTasks.Copy();
                TaskDirectoryDataGridView.DataSource = _currentData;
                UpdateLiveStats(_currentData);
                DatabaseStatusMessage.Text = "Showing demo data due to DB error.";
                MessageBox.Show($"Error loading reports: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refreshes the directory showing all records.
        /// </summary>
        private void RefreshGrid()
        {
            // Refreshes current dataset using existing filters.
            _currentKeyword = null;
            LoadTasks();
        }
        /// <summary>
        /// Updates live statistics based on the provided DataTable via in-memory calculations.
        /// </summary>
        private void UpdateLiveStats(DataTable dt)
        {
            try
            {
                if (dt == null) dt = new DataTable();

                var rows = dt.AsEnumerable();
                int total = rows.Count();
                int pending = rows.Count(r => string.Equals(Convert.ToString(r["status"]), "Pending", StringComparison.OrdinalIgnoreCase));
                int completed = rows.Count(r => string.Equals(Convert.ToString(r["status"]), "Completed", StringComparison.OrdinalIgnoreCase));
                int overdue = rows.Count(r => {
                    DateTime due;
                    var val = r.Table.Columns.Contains("due_date") ? r["due_date"] : null;
                    if (val == null || val == DBNull.Value) return false;
                    if (DateTime.TryParse(Convert.ToString(val), out due))
                    {
                        return due.Date < DateTime.Now.Date && !string.Equals(Convert.ToString(r["status"]), "Completed", StringComparison.OrdinalIgnoreCase);
                    }
                    return false;
                });

                int high = rows.Count(r => string.Equals(Convert.ToString(r["priority"]), "High", StringComparison.OrdinalIgnoreCase));
                int medium = rows.Count(r => string.Equals(Convert.ToString(r["priority"]), "Medium", StringComparison.OrdinalIgnoreCase));
                int low = rows.Count(r => string.Equals(Convert.ToString(r["priority"]), "Low", StringComparison.OrdinalIgnoreCase));

                if (TotalTasksCounterLabel != null) TotalTasksCounterLabel.Text = total.ToString();
                if (PendingTasksCounterLabel != null) PendingTasksCounterLabel.Text = pending.ToString();
                if (CompletedTasksCounterLabel != null) CompletedTasksCounterLabel.Text = completed.ToString();
                if (OverdueTasksCounterLabel != null) OverdueTasksCounterLabel.Text = overdue.ToString();
                if (HighPriorityTasksCounterLabel != null) HighPriorityTasksCounterLabel.Text = high.ToString();
                if (MediumTasksCounterLabel != null) MediumTasksCounterLabel.Text = medium.ToString();
                if (LowPriorityCounterLabel != null) LowPriorityCounterLabel.Text = low.ToString();
            }
            catch
            {
                // Suppresses statistical errors to maintain UI stability.
            }
        }

        // --- FILTER BUTTONS ---

        private void AllTasksButton_Click(object sender, EventArgs e)
        {
            // Resets filters and reloads all tasks.
            _currentStatusFilter = null;
            _currentPriorityFilter = null;
            _currentKeyword = null;
            LoadTasks();
        }

        private void DoneTasksButton_Click(object sender, EventArgs e)
        {
            // Sets status filter to Completed and reloads.
            _currentStatusFilter = "Completed";
            LoadTasks();
        }

        private void PendingTasksButton_Click(object sender, EventArgs e)
        {
            // Sets status filter to Pending and reloads.
            _currentStatusFilter = "Pending";
            LoadTasks();
        }

        private void OverdueTasksButton_Click(object sender, EventArgs e)
        {
            // Sets status filter to overdue via keyword and reloads.
            _currentStatusFilter = null;
            _currentKeyword = null;
            // Overdue filter will be applied in-memory by UpdateLiveStats; reload full set.
            LoadTasks();
        }

        private void HighPriorityButton_Click(object sender, EventArgs e)
        {
            // Sets priority filter to High and reloads.
            _currentPriorityFilter = "High";
            LoadTasks();
        }

        private void MediumPriorityButton_Click(object sender, EventArgs e)
        {
            // Sets priority filter to Medium and reloads.
            _currentPriorityFilter = "Medium";
            LoadTasks();
        }

        private void LowPriorityButton_Click(object sender, EventArgs e)
        {
            // Sets priority filter to Low and reloads.
            _currentPriorityFilter = "Low";
            LoadTasks();
        }

        /// <summary>
        /// Handles basic searching dynamically matching by Title or Assigned Person.
        /// </summary>
        private void SearchDirectoryButton_Click(object sender, EventArgs e)
        {
            // Saves keyword and reloads via DAL to support combined filters.
            _currentKeyword = SearchTextBox.Text.Trim();
            LoadTasks();
        }

        private void RefreshDirectoryButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            SearchTextBox.Clear();
        }

        private void ReturnToDashboardButton_Click(object sender, EventArgs e)
        {
            // Navigate back to dashboard and hide reports form
            try
            {
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to navigate to dashboard: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Exports the current DataGridView contents to a basic CSV file.
        /// </summary>
        private void ExportReportButton_Click(object sender, EventArgs e)
        {
            // Exports current grid to TXT or CSV depending on user selection.
            if (_currentData == null || _currentData.Rows.Count == 0)
            {
                DatabaseStatusMessage.Text = "No data to export.";
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text File|*.txt|CSV File|*.csv",
                Title = "Export Report",
                FileName = $"Task_Report_{DateTime.Now:yyyyMMdd_HHmm}.txt"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var ext = Path.GetExtension(sfd.FileName).ToLowerInvariant();
                if (ext == ".csv")
                {
                    // Writes CSV.
                    using (var sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        var cols = _currentData.Columns.Cast<DataColumn>().Select(c => c.ColumnName);
                        sw.WriteLine(string.Join(",", cols));
                        foreach (DataRow row in _currentData.Rows)
                        {
                            var vals = _currentData.Columns.Cast<DataColumn>().Select(c => (row[c] ?? string.Empty).ToString().Replace(",", ";"));
                            sw.WriteLine(string.Join(",", vals));
                        }
                    }
                }
                else
                {
                    // Writes formatted TXT.
                    using (var sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        // Writes header summary.
                        sw.WriteLine("Task Report");
                        sw.WriteLine($"Generated: {DateTime.Now}");
                        sw.WriteLine(new string('-', 80));

                        foreach (DataRow row in _currentData.Rows)
                        {
                            var id = row.Table.Columns.Contains("task_id") ? row["task_id"] : string.Empty;
                            var title = row.Table.Columns.Contains("task_title") ? row["task_title"] : string.Empty;
                            var status = row.Table.Columns.Contains("status") ? row["status"] : string.Empty;
                            var priority = row.Table.Columns.Contains("priority") ? row["priority"] : string.Empty;
                            var due = row.Table.Columns.Contains("due_date") ? row["due_date"] : string.Empty;
                            var assigned = row.Table.Columns.Contains("assigned_to") ? row["assigned_to"] : string.Empty;

                            sw.WriteLine($"ID: {id}");
                            sw.WriteLine($"Title: {title}");
                            sw.WriteLine($"Status: {status}");
                            sw.WriteLine($"Priority: {priority}");
                            sw.WriteLine($"Due: {due}");
                            sw.WriteLine($"Assigned: {assigned}");
                            sw.WriteLine(new string('-', 80));
                        }
                    }
                }

                DatabaseStatusMessage.Text = "Export completed.";
            }
            catch (Exception ex)
            {
                DatabaseStatusMessage.Text = "Export failed.";
                MessageBox.Show($"Export failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Placeholder print instruction dialog.
        /// </summary>
        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            // Defensively checks for data existence before printing.
            if (_currentData == null || _currentData.Rows.Count == 0)
            {
                DatabaseStatusMessage.Text = "No data to print.";
                return;
            }

            try
            {
                using (PrintPreviewDialog ppd = new PrintPreviewDialog())
                {
                    ppd.Document = _printDocument;
                    _printRowIndex = 0;
                    ppd.Width = 800;
                    ppd.Height = 600;
                    ppd.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print preview failed: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Prints rows from _currentData with simple formatting.
            int y = 20;
            int lineHeight = 20;
            var font = new Font("Arial", 10);

            while (_printRowIndex < _currentData.Rows.Count)
            {
                var row = _currentData.Rows[_printRowIndex];
                string line = $"{row["task_id"]} | {row["task_title"]} | {row["status"]} | {row["priority"]} | {row["assigned_to"]}";
                e.Graphics.DrawString(line, font, Brushes.Black, 10, y);
                y += lineHeight;
                _printRowIndex++;
                if (y + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}