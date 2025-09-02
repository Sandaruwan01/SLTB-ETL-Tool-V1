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
    public partial class UC_Production : UserControl
    {
        public UC_Production()
        {
            InitializeComponent();
            CustomizeGridHeader();
        }

        private void CustomizeGridHeader()
        {
            ProductionDataGrid.EnableHeadersVisualStyles = false;
            ProductionDataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            ProductionDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            ProductionDataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 10, FontStyle.Bold);
            ProductionDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private async void UC_Production_Load(object sender, EventArgs e)
        {
            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();
                        string query = "SELECT FactoryCode, FactoryName, Elevation, SubElevation, Region, ProdYear, ProdMonth," +
                        "ProcessingMethod,ManOwnLeaf,ManBoughtLeaf,ManOtherEstate,TotalProduction,DuringTheMonth";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });
                ProductionDataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error IN Data Receiving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UC_Production_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();
                        string query = "SELECT FactoryCode, FactoryName, Elevation, SubElevation, Region, ProdYear, ProdMonth," +
                        "ProcessingMethod,ManOwnLeaf,ManBoughtLeaf,ManOtherEstate,TotalProduction,DuringTheMonth FROM ProductionDataV1 ORDER BY ProdYear,ProdMonth DESC";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });
                ProductionDataGrid.DataSource = dt;

                lblProductionRowCount.Text = $" {ProductionDataGrid.Rows.Count.ToString("N0")}";

                ProductionDataGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error IN Data Receiving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        //Export DataGridView to Excel
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
                FileName = "ExportedProductionData.xlsx"
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
                    wb.Worksheets.Add(dt, "ExportedProductionData");
                    wb.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Export completed successfully!", "Success");
            }
        }
        private void btnSaveAsExcel_Click(object sender, EventArgs e)
        {
            ExportDataGridToExcel(ProductionDataGrid);
        }

        private async void btnProductionGo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input
                if (!int.TryParse(prodYear.Text, out int year))
                {
                    MessageBox.Show("Please enter a valid numeric year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(prodMonth.Text, out int month) || month < 1 || month > 12)
                {
                    MessageBox.Show("Please enter a valid month (1-12).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();

                        string query = "SELECT FactoryCode, FactoryName, Elevation, SubElevation, Region, ProdYear, ProdMonth," +
                        "ProcessingMethod, ManOwnLeaf, ManBoughtLeaf, ManOtherEstate, TotalProduction, DuringTheMonth " +
                        "FROM ProductionDataV1 WHERE ProdYear = @year AND ProdMonth = @month ORDER BY ProdYear, ProdMonth DESC";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@year", year);
                            cmd.Parameters.AddWithValue("@month", month);

                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                });

                ProductionDataGrid.DataSource = dt;
                lblProductionRowCount.Text = $" {ProductionDataGrid.Rows.Count:N0}";
                ProductionDataGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in data fetching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnProductionReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();
                        string query = "SELECT FactoryCode, FactoryName, Elevation, SubElevation, Region, ProdYear, ProdMonth," +
                        "ProcessingMethod,ManOwnLeaf,ManBoughtLeaf,ManOtherEstate,TotalProduction,DuringTheMonth FROM ProductionDataV1 ORDER BY ProdYear,ProdMonth DESC";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });
                ProductionDataGrid.DataSource = dt;

                lblProductionRowCount.Text = $" {ProductionDataGrid.Rows.Count.ToString("N0")}";

                ProductionDataGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error IN Data Receiving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductionSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in ProductionDataGrid.Rows)
            {
                // Skip new rows
                if (row.IsNewRow) continue;

                // Check each cell in the row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                        ProductionDataGrid.FirstDisplayedScrollingRowIndex = row.Index; // Scroll to row
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
