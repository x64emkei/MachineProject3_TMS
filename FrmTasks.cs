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

            // Wire up buttons
            AddEditorButton.Click += AddEditorButton_Click;
            UpdateEditorButton.Click += UpdateEditorButton_Click;
            DeleteEditorButton.Click += DeleteEditorButton_Click;
            ClearEditorButton.Click += ClearEditorButton_Click; // implemented below
            SearchDirectoryButton.Click += SearchDirectoryButton_Click;
            RefreshDirectoryButton.Click += RefreshDirectoryButton_Click;

            // Wire up grid click
            TaskDirectoryDataGridView.CellClick += TaskDirectoryDataGridView_CellClick;

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
                if (row.DataGridView != null && row.DataGridView.Columns.Contains(name) && row.Cells[name].Value != null)
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
        }

        private void LoadCategories()
        {
            DataTable dt = CategoryFunctions.GetAllCategories();
            // Expecting columns: category_id, category_name
            CategoryComboBox.DataSource = dt;
            CategoryComboBox.DisplayMember = "category_name";
            CategoryComboBox.ValueMember = "category_id";
            CategoryComboBox.SelectedIndex = -1;
        }

        private void RefreshGrid()
        {
            try
            {
                TaskDirectoryDataGridView.DataSource = TaskFunctions.GetAllTasks();
            }
            catch (Exception)
            {
                // If DB fails, enable demo mode and use demo data
                DbConnection.EnableDemoMode();
                TaskDirectoryDataGridView.DataSource = DbConnection.DemoTasks.Copy();
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
            if (string.IsNullOrWhiteSpace(TaskTitleTextBox.Text) ||
                string.IsNullOrWhiteSpace(AssignedToTextBox.Text) ||
                PriorityComboBox.SelectedIndex == -1 ||
                StatusComboBox.SelectedIndex == -1 ||
                CategoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields: Title, Assigned To, Priority, Status, and Category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AddEditorButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int categoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);

            TaskFunctions.AddTask(TaskTitleTextBox.Text, DescriptionTextBox.Text, DueDatePicker.Value, PriorityComboBox.Text, StatusComboBox.Text, AssignedToTextBox.Text, categoryId);
            MessageBox.Show("Task Successfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGrid();
            ClearFields();
        }

        private void UpdateEditorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TaskIDTextBox.Text))
            {
                MessageBox.Show("Please select a task from the directory to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            int taskId = Convert.ToInt32(TaskIDTextBox.Text);
            int categoryId = Convert.ToInt32(CategoryComboBox.SelectedValue);

            TaskFunctions.UpdateTask(taskId, TaskTitleTextBox.Text, DescriptionTextBox.Text, DueDatePicker.Value, PriorityComboBox.Text, StatusComboBox.Text, AssignedToTextBox.Text, categoryId);
            MessageBox.Show("Task Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGrid();
            ClearFields();
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
                int taskId = Convert.ToInt32(TaskIDTextBox.Text);
                TaskFunctions.DeleteTask(taskId);
                MessageBox.Show("Task Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearFields();
            }
        }

        private void SearchDirectoryButton_Click(object sender, EventArgs e)
        {
            // Use TaskFunctions filtering to search Title and Assigned To when no field is specified
            TaskDirectoryDataGridView.DataSource = TaskFunctions.GetAllTasks("", SearchTextBox.Text.Trim());
            TaskDirectoryStatusMessage.Text = string.IsNullOrWhiteSpace(SearchTextBox.Text) ? "Showing all tasks" : $"Search results for '{SearchTextBox.Text.Trim()}'";
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

        private void TaskDirectoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TaskDirectoryDataGridView.Rows[e.RowIndex];
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
                        CategoryComboBox.SelectedValue = catId;
                    }
                    else
                    {
                        // Fallback: try to set by displayed text
                        CategoryComboBox.SelectedIndex = CategoryComboBox.FindStringExact(categoryIdVal.ToString());
                    }
                }

                EditorStatusMessageLabel.Text = $"Selected task: {TaskTitleTextBox.Text}";
            }
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