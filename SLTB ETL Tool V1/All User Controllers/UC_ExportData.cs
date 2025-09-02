using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLTB_ETL_Tool_V1.All_User_Controllers
{
    public partial class UC_ExportData : UserControl
    {
        public UC_ExportData()
        {
            InitializeComponent();
            CustomizeGridHeader();
        }

        private void CustomizeGridHeader()
        {
            ExportDataGrid.EnableHeadersVisualStyles = false;
            ExportDataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            ExportDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            ExportDataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 10, FontStyle.Bold);
            ExportDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private async void UC_ExportData_Load(object sender, EventArgs e)
        {
            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();
                        string query = "SELECT * FROM ExportDataV1 ORDER BY ShipmentDate DESC";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });
                ExportDataGrid.DataSource = dt;

                lblExportRowCount.Text = $" {ExportDataGrid.Rows.Count.ToString("N0")}";

                ExportDataGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error IN Data Receiving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDataGridToExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Save Excel File",
                FileName = "ExportedData.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create DataTable from DataGridView
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            object cellValue = row.Cells[i].Value;
                            dr[i] = cellValue ?? DBNull.Value;
                        }
                        dt.Rows.Add(dr);
                    }
                }

                // Create Excel file
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "ExportedData");
                    wb.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Export completed successfully!", "Success");
            }
        }

        private void btnSaveAsExcel_Click(object sender, EventArgs e)
        {
            ExportDataGridToExcel(ExportDataGrid);
        }

        private async void btnExportGo_Click(object sender, EventArgs e)
        {
            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();

                        string query = "SELECT * FROM ExportDataV1 WHERE ShipmentDate BETWEEN @from AND @to ORDER BY ShipmentDate DESC";

                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@from", dtExportFrom.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@to", dtExportTo.Value.ToString("yyyy-MM-dd"));

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });


                ExportDataGrid.DataSource = dt;

                lblExportRowCount.Text = $" {ExportDataGrid.Rows.Count.ToString("N0")}";

                ExportDataGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error IN Data Receving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {

            }
        }

        private async void btnExportReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();
                        string query = "SELECT * FROM ExportDataV1 ORDER BY ShipmentDate DESC";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });
                ExportDataGrid.DataSource = dt;

                lblExportRowCount.Text = $" {ExportDataGrid.Rows.Count.ToString("N0")}";

                ExportDataGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error IN Data Receiving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportSearch_Click(object sender, EventArgs e)
        {
            string searchValue = ExportSearchBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in ExportDataGrid.Rows)
            {
                // Skip new rows
                if (row.IsNewRow) continue;

                // Check each cell in the row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                        ExportDataGrid.FirstDisplayedScrollingRowIndex = row.Index; // Scroll to row
                        found = true;
                        break; // Found in this row, no need to check other cells
                    }
                }

                if (found) break; // Stop once first match found
            }

            if (!found)
            {
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
