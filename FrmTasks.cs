using System;
using System.Data;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    public partial class FrmTasks : Form
    {
        public FrmTasks()
        {
            InitializeComponent();
            // Ensures form load logic executes when the form is shown so categories populate immediately.
            this.Load -= FrmTasks_Load;
            this.Load += FrmTasks_Load;

            // Populates category dropdown immediately so UI shows data when opened.
            try
            {
                LoadCategories();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            // Wire up buttons
            AddEditorButton.Click += AddEditorButton_Click;
            UpdateEditorButton.Click += UpdateEditorButton_Click;
            DeleteEditorButton.Click += DeleteEditorButton_Click;
            ClearEditorButton.Click += ClearEditorButton_Click; // implemented below
            SearchDirectoryButton.Click += SearchDirectoryButton_Click;
            RefreshDirectoryButton.Click += RefreshDirectoryButton_Click;

            // Wire up grid click
            TaskDirectoryDataGridView.CellClick += TaskDirectoryDataGridView_CellClick;

            // Wire up menu items and keyboard shortcuts defensively.
            WireMenuItems();

            // Optional Form settings
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Task Loading, UI helpers, and status messages

        /// <summary>
        /// Tries multiple possible column names to retrieve a cell value from a row.
        /// This allows the UI to work with both friendly headers and raw DB column names.
        /// </summary>
        private object TryGetCellValue(DataGridViewRow row, params string[] possibleNames)
        {
            foreach (string name in possibleNames)
            {
                // Attempts to retrieve the cell value by common column names.
                if (row?.DataGridView != null && row.DataGridView.Columns.Contains(name) && row.Cells[name].Value != null)
                    return row.Cells[name].Value;
            }
            // fallback to first non-null cell
            foreach (DataGridViewCell c in row.Cells)
            {
                if (c.Value != null) return c.Value;
            }
            return null;
        }

        #endregion

        private void FrmTasks_Load(object sender, EventArgs e)
        {
            LoadCategories();
            RefreshGrid();

            // Synchronizes counters on load.
            try
            {
                int total, pending, completed;
                TaskFunctions.GetTaskStats(out total, out pending, out completed);
                if (TotalTasksCounterLabel != null) TotalTasksCounterLabel.Text = total.ToString();
                if (PendingTasksCounterLabel != null) PendingTasksCounterLabel.Text = pending.ToString();
                if (CompletedTasksCounterLabel != null) CompletedTasksCounterLabel.Text = completed.ToString();
            }
            catch
            {
                // Suppresses errors to avoid breaking UI during load; demo mode handled elsewhere.
            }
        }

        /// <summary>
        /// Wires menu strip commands to their corresponding actions and sets keyboard shortcuts.
        /// </summary>
        private void WireMenuItems()
        {
            // Configures keyboard shortcuts. MenuStrip items are optional and are not assumed to exist.
            this.KeyPreview = true;
            this.KeyDown -= FrmTasks_KeyDown;
            this.KeyDown += FrmTasks_KeyDown;
        }

        private void FrmTasks_KeyDown(object sender, KeyEventArgs e)
        {
            // Activates About with F1
            if (e.KeyCode == Keys.F1)
            {
                ReturnToDashboardButton_Click(sender, EventArgs.Empty);
                e.Handled = true;
            }
        }

        private void LoadCategories()
        {
            try
            {
                DataTable dt = CategoryFunctions.GetAllCategories();
                // Expecting columns: category_id, category_name
                CategoryComboBox.DataSource = dt;
                CategoryComboBox.DisplayMember = "category_name";
                CategoryComboBox.ValueMember = "category_id";
                CategoryComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Enables demo categories when DB fails to respond.
                System.Diagnostics.Debug.WriteLine(ex.Message);
                DbConnection.EnableDemoMode();
                var demo = DbConnection.DemoCategories != null ? DbConnection.DemoCategories.Copy() : new DataTable();
                CategoryComboBox.DataSource = demo;
                CategoryComboBox.DisplayMember = demo.Columns.Contains("category_name") ? "category_name" : string.Empty;
                CategoryComboBox.ValueMember = demo.Columns.Contains("category_id") ? "category_id" : string.Empty;
                CategoryComboBox.SelectedIndex = -1;
                EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                EditorStatusMessageLabel.Text = "Failed to load categories from database.";
            }
        }

        private void RefreshGrid()
        {
            try
            {
                var dt = TaskFunctions.GetAllTasks();
                TaskDirectoryDataGridView.DataSource = dt;
                UpdateLiveStatistics(dt);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                // If demo mode was explicitly enabled by the user, show demo data.
                if (DbConnection.DemoMode && DbConnection.DemoTasks != null)
                {
                    var demo = DbConnection.DemoTasks.Copy();
                    TaskDirectoryDataGridView.DataSource = demo;
                    UpdateLiveStatistics(demo);
                }
                else
                {
                    // Reports the error to the user instead of auto-enabling demo mode.
                    TaskDirectoryStatusMessage.Text = "Database error: " + ex.Message;
                }
            }

            // Hide the raw category ID column if it exists, since we show Category Name
            if (TaskDirectoryDataGridView.Columns.Contains("category_id"))
            {
                TaskDirectoryDataGridView.Columns["category_id"].Visible = false;
            }

            // Ensure columns fill the available width
            TaskDirectoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearFields()
        {
            TaskIDTextBox.Clear();
            TaskTitleTextBox.Clear();
            DescriptionTextBox.Clear();
            AssignedToTextBox.Clear();
            DueDatePicker.Value = DateTime.Now;
            PriorityComboBox.SelectedIndex = -1;
            StatusComboBox.SelectedIndex = -1;
            CategoryComboBox.SelectedIndex = -1;
        }

        private bool ValidateInputs()
        {
            // Validates that required fields are present.
            if (string.IsNullOrWhiteSpace(TaskTitleTextBox.Text) || string.IsNullOrWhiteSpace(AssignedToTextBox.Text))
            {
                EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                EditorStatusMessageLabel.Text = "Validation Error: Title and Assigned To are required.";
                return false;
            }

            if (PriorityComboBox.SelectedIndex == -1 || StatusComboBox.SelectedIndex == -1 || CategoryComboBox.SelectedIndex == -1)
            {
                EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                EditorStatusMessageLabel.Text = "Validation Error: Priority, Status and Category must be selected.";
                return false;
            }

            // Prevents setting due date to past for new tasks (TaskID empty).
            if (string.IsNullOrWhiteSpace(TaskIDTextBox.Text))
            {
                if (DueDatePicker.Value.Date < DateTime.Now.Date)
                {
                    EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    EditorStatusMessageLabel.Text = "Validation Error: Due date cannot be in the past for new tasks.";
                    return false;
                }
            }

            return true;
        }

        private void AddEditorButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int categoryId = 0;
            if (CategoryComboBox.SelectedValue != null && int.TryParse(CategoryComboBox.SelectedValue.ToString(), out var cid)) categoryId = cid;

            try
            {
                TaskFunctions.AddTask(TaskTitleTextBox.Text.Trim(), DescriptionTextBox.Text.Trim(), DueDatePicker.Value, PriorityComboBox.Text, StatusComboBox.Text, AssignedToTextBox.Text.Trim(), categoryId);
                // Updates status label for non-intrusive feedback.
                EditorStatusMessageLabel.ForeColor = System.Drawing.Color.SeaGreen;
                EditorStatusMessageLabel.Text = "Task successfully added.";
                RefreshGrid();
                // Synchronizes counters after CRUD operation.
                try
                {
                    int total, pending, completed;
                    TaskFunctions.GetTaskStats(out total, out pending, out completed);
                    if (TotalTasksCounterLabel != null) TotalTasksCounterLabel.Text = total.ToString();
                    if (PendingTasksCounterLabel != null) PendingTasksCounterLabel.Text = pending.ToString();
                    if (CompletedTasksCounterLabel != null) CompletedTasksCounterLabel.Text = completed.ToString();
                }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
                ClearFields();
            }
            catch (Exception ex)
            {
                EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                EditorStatusMessageLabel.Text = "Error adding task. See logs for details.";
                // Allows debugging by throwing critical exception messages via MessageBox only.
                MessageBox.Show($"Critical Error adding task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEditorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TaskIDTextBox.Text))
            {
                MessageBox.Show("Please select a task from the directory to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            if (!int.TryParse(TaskIDTextBox.Text, out int taskId))
            {
                EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                EditorStatusMessageLabel.Text = "Invalid task selected.";
                return;
            }

            int categoryId = 0;
            if (CategoryComboBox.SelectedValue != null && int.TryParse(CategoryComboBox.SelectedValue.ToString(), out var cid2)) categoryId = cid2;

            try
            {
                TaskFunctions.UpdateTask(taskId, TaskTitleTextBox.Text.Trim(), DescriptionTextBox.Text.Trim(), DueDatePicker.Value, PriorityComboBox.Text, StatusComboBox.Text, AssignedToTextBox.Text.Trim(), categoryId);
                EditorStatusMessageLabel.ForeColor = System.Drawing.Color.SeaGreen;
                EditorStatusMessageLabel.Text = "Task successfully updated.";
                RefreshGrid();
                // Synchronizes counters after CRUD operation.
                try
                {
                    int total, pending, completed;
                    TaskFunctions.GetTaskStats(out total, out pending, out completed);
                    if (TotalTasksCounterLabel != null) TotalTasksCounterLabel.Text = total.ToString();
                    if (PendingTasksCounterLabel != null) PendingTasksCounterLabel.Text = pending.ToString();
                    if (CompletedTasksCounterLabel != null) CompletedTasksCounterLabel.Text = completed.ToString();
                }
                catch
                {
                    // Suppresses counter sync failures to avoid disturbing the user flow.
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                EditorStatusMessageLabel.Text = "Error updating task.";
                MessageBox.Show($"Critical Error updating task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteEditorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TaskIDTextBox.Text))
            {
                MessageBox.Show("Please select a task from the directory to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to permanently delete this task?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!int.TryParse(TaskIDTextBox.Text, out int taskId))
                {
                    EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    EditorStatusMessageLabel.Text = "Invalid task selected for deletion.";
                    return;
                }

                try
                {
                    TaskFunctions.DeleteTask(taskId);
                    EditorStatusMessageLabel.ForeColor = System.Drawing.Color.SeaGreen;
                    EditorStatusMessageLabel.Text = "Task deleted.";
                    RefreshGrid();
                    // Synchronizes counters after CRUD operation.
                    try
                    {
                        int total, pending, completed;
                        TaskFunctions.GetTaskStats(out total, out pending, out completed);
                        if (TotalTasksCounterLabel != null) TotalTasksCounterLabel.Text = total.ToString();
                        if (PendingTasksCounterLabel != null) PendingTasksCounterLabel.Text = pending.ToString();
                        if (CompletedTasksCounterLabel != null) CompletedTasksCounterLabel.Text = completed.ToString();
                    }
                    catch
                    {
                        // Suppresses counter sync failures to avoid disturbing the user flow.
                    }
                    ClearFields();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    EditorStatusMessageLabel.Text = "Error deleting task.";
                    MessageBox.Show($"Critical Error deleting task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchDirectoryButton_Click(object sender, EventArgs e)
        {
            // Use TaskFunctions filtering to search Title and Assigned To when no field is specified.
            try
            {
                var dt = TaskFunctions.GetAllTasks(SearchTextBox.Text.Trim());
                TaskDirectoryDataGridView.DataSource = dt;
                UpdateLiveStatistics(dt);
                TaskDirectoryStatusMessage.Text = string.IsNullOrWhiteSpace(SearchTextBox.Text) ? "Showing all tasks" : $"Search results for '{SearchTextBox.Text.Trim()}'";
            }
            catch (Exception ex)
            {
                if (DbConnection.DemoMode && DbConnection.DemoTasks != null)
                {
                    var demo = DbConnection.DemoTasks.Copy();
                    TaskDirectoryDataGridView.DataSource = demo;
                    UpdateLiveStatistics(demo);
                    TaskDirectoryStatusMessage.Text = "Showing demo data (demo mode).";
                }
                else
                {
                    TaskDirectoryStatusMessage.Text = "Database error while searching.";
                    EditorStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    EditorStatusMessageLabel.Text = "Database error while searching.";
                }
            }
        }

        private void ClearEditorButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RefreshDirectoryButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            SearchTextBox.Clear();
            TaskDirectoryStatusMessage.Text = "Grid refreshed";
        }

        /// <summary>
        /// Updates live counters in the UI from the provided DataTable.
        /// </summary>
        private void UpdateLiveStatistics(DataTable dt)
        {
            try
            {
                if (dt == null) dt = new DataTable();
                int total = dt.Rows.Count;
                int pending = 0;
                int completed = 0;
                int inProgress = 0;

                foreach (DataRow r in dt.Rows)
                {
                    var status = r.Table.Columns.Contains("status") ? (r["status"]?.ToString() ?? string.Empty) : string.Empty;
                    if (string.Equals(status, "Pending", StringComparison.OrdinalIgnoreCase)) pending++;
                    if (string.Equals(status, "Completed", StringComparison.OrdinalIgnoreCase)) completed++;
                    if (string.Equals(status, "In Progress", StringComparison.OrdinalIgnoreCase) || string.Equals(status, "InProgress", StringComparison.OrdinalIgnoreCase) || string.Equals(status, "In-Progress", StringComparison.OrdinalIgnoreCase)) inProgress++;
                }

                // Update labels gently.
                if (TotalTasksCounterLabel != null) TotalTasksCounterLabel.Text = total.ToString();
                if (PendingTasksCounterLabel != null) PendingTasksCounterLabel.Text = pending.ToString();
                if (CompletedTasksCounterLabel != null) CompletedTasksCounterLabel.Text = completed.ToString();
                if (InProgressCounterLabel != null) InProgressCounterLabel.Text = inProgress.ToString();
            }
            catch
            {
                // Suppresses errors to avoid breaking grid refresh.
            }
        }

        private void TaskDirectoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignores header clicks defensively.

            if (e.RowIndex >= TaskDirectoryDataGridView.Rows.Count) return; // Prevents out-of-range access.

            DataGridViewRow row = TaskDirectoryDataGridView.Rows[e.RowIndex];
            if (row == null || row.IsNewRow) return; // Ignores new rows.
                // Use tolerant retrieval for both DB and displayed column headers
                object idVal = TryGetCellValue(row, "task_id", "Task ID", "task_id ");
                object titleVal = TryGetCellValue(row, "task_title", "Title");
                object descVal = TryGetCellValue(row, "description", "Description");
                object dueVal = TryGetCellValue(row, "due_date", "Due Date");
                object priorityVal = TryGetCellValue(row, "priority", "Priority");
                object statusVal = TryGetCellValue(row, "status", "Status");
                object assignedVal = TryGetCellValue(row, "assigned_to", "Assigned To");
                object categoryIdVal = TryGetCellValue(row, "category_id", "category_id");

                TaskIDTextBox.Text = idVal?.ToString() ?? "";
                TaskTitleTextBox.Text = titleVal?.ToString() ?? "";
                DescriptionTextBox.Text = descVal?.ToString() ?? "";

                if (dueVal != null && dueVal != DBNull.Value)
                {
                    DateTime parsed;
                    if (DateTime.TryParse(dueVal.ToString(), out parsed))
                        DueDatePicker.Value = parsed;
                    else
                        DueDatePicker.Value = DateTime.Now;
                }
                else
                {
                    DueDatePicker.Value = DateTime.Now;
                }

                PriorityComboBox.Text = priorityVal?.ToString() ?? "";
                StatusComboBox.Text = statusVal?.ToString() ?? "";
                AssignedToTextBox.Text = assignedVal?.ToString() ?? "";

                // Try to set Category ComboBox by value (category_id) or by category_name
                if (categoryIdVal != null && categoryIdVal != DBNull.Value)
                {
                    int catId;
                    if (int.TryParse(categoryIdVal.ToString(), out catId))
                    {
                        try
                        {
                            CategoryComboBox.SelectedValue = catId;
                        }
                        catch
                        {
                            // Fallback: try to set by displayed text
                            CategoryComboBox.SelectedIndex = CategoryComboBox.FindStringExact(categoryIdVal.ToString());
                        }
                    }
                    else
                    {
                        // Fallback: try to set by displayed text
                        CategoryComboBox.SelectedIndex = CategoryComboBox.FindStringExact(categoryIdVal.ToString());
                    }
                }

                EditorStatusMessageLabel.Text = $"Selected task: {TaskTitleTextBox.Text}";
            }

        private void ReturnToDashboardButton_Click(object sender, EventArgs e)
        {
            // Navigate back to the main dashboard. Show the dashboard and close/hide this form.
            try
            {
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open dashboard: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}