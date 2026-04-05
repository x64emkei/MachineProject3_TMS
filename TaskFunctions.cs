using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskFunctions.Services
{
    public class TaskExportService
    {
        // Exports DataGridView contents to a standard CSV file
        public bool ExportToCSV(DataGridView dgv, string filePath)
        {
            if (dgv.Rows.Count == 0) throw new InvalidOperationException("No data available to export.");

            try
            {
                StringBuilder sb = new StringBuilder();

                // 1. Write Headers
                var headers = dgv.Columns.Cast<DataGridViewColumn>();
                sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"")));

                // 2. Write Rows (Defensively handling nulls)
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + (cell.Value?.ToString() ?? "") + "\"")));
                    }
                }

                File.WriteAllText(filePath, sb.ToString());
                return true;
            }
            catch (IOException ex)
            {
                throw new Exception("File is in use or inaccessible. Please close the file and try again.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred during CSV export.", ex);
            }
        }

        // Exports DataGridView contents to a formatted TXT file
        public bool ExportToTXT(DataGridView dgv, string filePath)
        {
            if (dgv.Rows.Count == 0) throw new InvalidOperationException("No data available to export.");

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine($"Task ID: {row.Cells["TaskID"].Value}");
                            sw.WriteLine($"Title: {row.Cells["Title"].Value}");
                            sw.WriteLine($"Status: {row.Cells["Status"].Value} | Priority: {row.Cells["Priority"].Value}");
                            sw.WriteLine($"Due: {row.Cells["DueDate"].Value}");
                            sw.WriteLine(new string('-', 50));
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred during TXT export.", ex);
            }
        }
    }
}