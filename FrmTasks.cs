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
            TaskDirectoryDataGridView.DataSource = TaskFunctions.GetAllTasks();

            // Hide the raw category ID column if it exists, since we show Category Name
            if (TaskDirectoryDataGridView.Columns.Contains("category_id"))
            {
                TaskDirectoryDataGridView.Columns["category_id"].Visible = false;
            }
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
            TaskDirectoryDataGridView.DataSource = TaskFunctions.GetAllTasks("", SearchTextBox.Text);
        }

        private void ClearEditorButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RefreshDirectoryButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            SearchTextBox.Clear();
        }

        private void TaskDirectoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TaskDirectoryDataGridView.Rows[e.RowIndex];

                TaskIDTextBox.Text = row.Cells["Task ID"].Value.ToString();
                TaskTitleTextBox.Text = row.Cells["Title"].Value.ToString();
                DescriptionTextBox.Text = row.Cells["Description"].Value.ToString();

                if (row.Cells["Due Date"].Value != DBNull.Value)
                    DueDatePicker.Value = Convert.ToDateTime(row.Cells["Due Date"].Value);

                PriorityComboBox.Text = row.Cells["Priority"].Value.ToString();
                StatusComboBox.Text = row.Cells["Status"].Value.ToString();
                AssignedToTextBox.Text = row.Cells["Assigned To"].Value.ToString();

                // Set ComboBox by ValueMember
                if (row.Cells["category_id"].Value != DBNull.Value)
                    CategoryComboBox.SelectedValue = row.Cells["category_id"].Value;
            }
        }
    }
}