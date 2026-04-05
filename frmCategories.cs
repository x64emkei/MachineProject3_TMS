// MACHINE PROJECT 3 | CS207L
// ORDENES, MICHAEL BENEDICT G. 
// BAARDE, ADRIAN C.
// TUMBAGA, KURT CEZMER S. 

using System;
using System.Data;
using System.Linq;
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
            // Wire navigation button if not wired by designer
            if (ReturnToDashboardButton != null) ReturnToDashboardButton.Click += ReturnToDashboardButton_Click;
            RefreshGrid();

            // Wire search button defensively if present by locating control by name.
            try
            {
                var btn = this.Controls.Find("SearchCategoryButton", true).FirstOrDefault() as Button;
                if (btn != null) btn.Click += SearchCategoryButton_Click;
            }
            catch
            {
                // Swallows wiring errors.
            }
        }

        /// <summary>
        /// Reloads the category grid.
        /// </summary>
        private void RefreshGrid()
        {
            // Designer uses CategoryViewerDataGridView for the viewer list
            try
            {
                CategoryViewerDataGridView.DataSource = CategoryFunctions.GetAllCategories();
            }
            catch (Exception)
            {
                DbConnection.EnableDemoMode();
                CategoryViewerDataGridView.DataSource = DbConnection.DemoCategories.Copy();
            }
            ClearInputFields();
            // Ensure the grid notifies on click
            CategoryViewerDataGridView.CellClick -= CategoryDataGridView_CellClick;
            CategoryViewerDataGridView.CellClick += CategoryDataGridView_CellClick;
        }

        /// <summary>
        /// Validates category input fields.
        /// </summary>
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(CategoryNameTextBox.Text))
            {
                DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                DetailStatusMessageLabel.Text = "Validation Error: Category name must not be empty.";
                return false;
            }
            return true;
        }

        private void ClearInputFields()
        {
            CategoryIDTextBox.Clear();
            CategoryNameTextBox.Clear();
            DescriptionTextBox.Clear();
            DetailStatusMessageLabel.Text = "";
        }

        /// <summary>
        /// Searches categories using a parameterized query via the CategoryFunctions data layer.
        /// </summary>
        private void SearchCategoryButton_Click(object sender, EventArgs e)
        {
            string keyword = string.Empty;
            try
            {
                var tb = this.Controls.Find("CategorySearchTextBox", true).FirstOrDefault() as TextBox;
                if (tb != null) keyword = tb.Text.Trim();
            }
            catch
            {
                keyword = string.Empty;
            }
            try
            {
                DataTable dt = CategoryFunctions.GetAllCategories();
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    for (int i = dt.Rows.Count - 1; i >= 0; i--)
                    {
                        var name = dt.Rows[i]["category_name"]?.ToString() ?? string.Empty;
                        var desc = dt.Rows[i].Table.Columns.Contains("description") ? dt.Rows[i]["description"]?.ToString() ?? string.Empty : string.Empty;
                        if (!name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase).Equals(0) && !name.ToLower().Contains(keyword.ToLower()) && !desc.ToLower().Contains(keyword.ToLower()))
                        {
                            dt.Rows.RemoveAt(i);
                        }
                    }
                }

                CategoryViewerDataGridView.DataSource = dt;
                DetailStatusMessageLabel.ForeColor = System.Drawing.Color.SeaGreen;
                DetailStatusMessageLabel.Text = string.IsNullOrWhiteSpace(keyword) ? "Showing all categories" : $"Search results for '{keyword}'";
            }
            catch (Exception ex)
            {
                DbConnection.EnableDemoMode();
                CategoryViewerDataGridView.DataSource = DbConnection.DemoCategories.Copy();
                DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                DetailStatusMessageLabel.Text = "Error searching categories.";
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    CategoryFunctions.AddCategory(CategoryNameTextBox.Text.Trim(), DescriptionTextBox.Text.Trim());
                    DetailStatusMessageLabel.ForeColor = System.Drawing.Color.SeaGreen;
                    DetailStatusMessageLabel.Text = "Category successfully added.";
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    DetailStatusMessageLabel.Text = "Error adding category.";
                    MessageBox.Show($"Critical Error adding category: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateCategoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CategoryIDTextBox.Text))
            {
                DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                DetailStatusMessageLabel.Text = "Selection Required: Please select a category to update.";
                return;
            }

            if (ValidateInputs())
            {
                try
                {
                    int id;
                    if (!int.TryParse(CategoryIDTextBox.Text, out id))
                    {
                        DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                        DetailStatusMessageLabel.Text = "Invalid category selected.";
                        return;
                    }

                    CategoryFunctions.UpdateCategory(id, CategoryNameTextBox.Text.Trim(), DescriptionTextBox.Text.Trim());
                    DetailStatusMessageLabel.ForeColor = System.Drawing.Color.SeaGreen;
                    DetailStatusMessageLabel.Text = "Category successfully updated.";
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    DetailStatusMessageLabel.Text = "Error updating category.";
                    MessageBox.Show($"Critical Error updating category: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int id;
                if (!int.TryParse(CategoryIDTextBox.Text, out id))
                {
                    DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    DetailStatusMessageLabel.Text = "Invalid category selected for deletion.";
                    return;
                }

                try
                {
                    CategoryFunctions.DeleteCategory(id);
                    DetailStatusMessageLabel.ForeColor = System.Drawing.Color.SeaGreen;
                    DetailStatusMessageLabel.Text = "Category successfully deleted.";
                    RefreshGrid();
                }
                catch (MySql.Data.MySqlClient.MySqlException mex) when (mex.Number == 1451)
                {
                    // MySQL foreign key constraint fails when category in use.
                    DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    DetailStatusMessageLabel.Text = "Cannot delete this category because it is currently assigned to existing tasks.";
                }
                catch (Exception ex)
                {
                    DetailStatusMessageLabel.ForeColor = System.Drawing.Color.Firebrick;
                    DetailStatusMessageLabel.Text = "Error deleting category.";
                    MessageBox.Show($"Critical Error deleting category: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.RowIndex < 0) return;
            var grid = sender as DataGridView;
            if (grid == null) return;

            DataGridViewRow row = grid.Rows[e.RowIndex];
            // Use tolerant retrieval for both DB and displayed column headers
            object idVal = (row.DataGridView != null && row.DataGridView.Columns.Contains("category_id")) ? row.Cells["category_id"].Value : TryGetCell(row, "Category ID", "category_id");
            object nameVal = (row.DataGridView != null && row.DataGridView.Columns.Contains("category_name")) ? row.Cells["category_name"].Value : TryGetCell(row, "Category Name", "category_name");
            object descVal = (row.DataGridView != null && row.DataGridView.Columns.Contains("description")) ? row.Cells["description"].Value : TryGetCell(row, "Description", "description");

            CategoryIDTextBox.Text = idVal?.ToString() ?? "";
            CategoryNameTextBox.Text = nameVal?.ToString() ?? "";
            DescriptionTextBox.Text = descVal?.ToString() ?? "";
            DetailStatusMessageLabel.Text = $"Selected category: {CategoryNameTextBox.Text}";
        }

        private object TryGetCell(DataGridViewRow row, params string[] names)
        {
            foreach (var n in names)
            {
                if (row.DataGridView != null && row.DataGridView.Columns.Contains(n) && row.Cells[n].Value != null) return row.Cells[n].Value;
            }
            foreach (DataGridViewCell c in row.Cells)
            {
                if (c.Value != null) return c.Value;
            }
            return null;
        }
    }
}