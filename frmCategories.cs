// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using System.Windows.Forms;

namespace MachineProject3_TMS
{
    /// <summary>
    /// Note: Exact UI layout not in PDF 1 page 2 visual layout, but functionally 
    /// required per the rubric. The implementation follows standard CRUD logic structures.
    /// </summary>
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
            RefreshGrid();
        }

        /// <summary>
        /// Reloads the category grid.
        /// </summary>
        private void RefreshGrid()
        {
            // Designer uses CategoryViewerDataGridView for the viewer list
            CategoryViewerDataGridView.DataSource = CategoryFunctions.GetAllCategories();
            ClearInputFields();
        }

        /// <summary>
        /// Validates user category inputs.
        /// </summary>
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(CategoryNameTextBox.Text))
            {
                MessageBox.Show("Category name must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearInputFields()
        {
            CategoryIDTextBox.Clear();
            CategoryNameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    CategoryFunctions.AddCategory(CategoryNameTextBox.Text.Trim(), DescriptionTextBox.Text.Trim());
                    MessageBox.Show("Category successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding category: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateCategoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CategoryIDTextBox.Text))
            {
                MessageBox.Show("Please select a category to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateInputs())
            {
                try
                {
                    CategoryFunctions.UpdateCategory(
                        Convert.ToInt32(CategoryIDTextBox.Text),
                        CategoryNameTextBox.Text.Trim(),
                        DescriptionTextBox.Text.Trim()
                    );
                    MessageBox.Show("Category successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating category: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CategoryIDTextBox.Text))
            {
                MessageBox.Show("Please select a category to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Deleting a category may fail if it is assigned to existing tasks. Continue?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    CategoryFunctions.DeleteCategory(Convert.ToInt32(CategoryIDTextBox.Text));
                    MessageBox.Show("Category successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting category (possibly used in tasks): {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnToDashboardButton_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Hide();
        }

        /// <summary>
        /// Binds data fields when row is selected.
        /// </summary>
        private void CategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object CategoryDataGridView = null;
                DataGridViewRow row = CategoryDataGridView.Rows[e.RowIndex];
                CategoryIDTextBox.Text = row.Cells["category_id"].Value.ToString();
                CategoryNameTextBox.Text = row.Cells["category_name"].Value.ToString();
                DescriptionTextBox.Text = row.Cells["description"].Value.ToString();
            }
        }
    }
}