using OfficeOpenXml;
using System;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLTB_ETL_Tool_V1.All_User_Controllers
{
    public partial class UC_GetSaleData : UserControl
    {
        public UC_GetSaleData()
        {
            InitializeComponent();
            CustomizeGridHeader();
        }

        private void CustomizeGridHeader()
        {
            SaleDataGrid.EnableHeadersVisualStyles = false;
            SaleDataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            SaleDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            SaleDataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 10, FontStyle.Bold);
            SaleDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private async void UC_GetSaleData_Load(object sender, EventArgs e)
        {
            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();
                        string query = "SELECT * FROM SaleDataV1 ORDER BY SaleDate DESC";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });

                
                SaleDataGrid.DataSource = dt;

                lblSaleRowCount.Text = $" {SaleDataGrid.Rows.Count.ToString("N0")}";

                SaleDataGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error IN Data Receving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                
            }
            
        }
        private async void btnSaleGo_Click(object sender, EventArgs e)
        {
            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();
                        
                        string query = "SELECT * FROM SaleDataV1 WHERE SaleDate BETWEEN @from AND @to ORDER BY SaleDate DESC";

                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@from", dtSaleFrom.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@to", dtSaleTo.Value.ToString("yyyy-MM-dd"));

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });


                SaleDataGrid.DataSource = dt;

                lblSaleRowCount.Text = $" {SaleDataGrid.Rows.Count.ToString("N0")}";

                SaleDataGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error IN Data Receving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {

            }
        }

        private async void btnSaleReset_Click(object sender, EventArgs e)
        {
            dtSaleFrom.Value = DateTime.Now;
            dtSaleTo.Value = DateTime.Now;

            try
            {
                // Task run the background thread 
                DataTable dt = await Task.Run(() =>
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                    {
                        conn.Open();
                        string query = "SELECT SaleType,Factory,Mark,FactoryName,Elevation,SubElevation,ManagementType," +
                                       "ManagementDes,ProcessingMethod,ATCRegion,Buyer,Grade, CASE WHEN IsMainGrade = 1 THEN 'Yes' ELSE 'No' END AS IsMainGrade,NetWeight,Price,NetValue,SaleDate," +
                                       "Broker,LotNo,InvoiceNo,SellingMark FROM SaleDataV1 ORDER BY SaleDate DESC";
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                });


                SaleDataGrid.DataSource = dt;
                lblSaleRowCount.Text = $" {SaleDataGrid.Rows.Count.ToString("N0")}";
                SaleDataGrid.AllowUserToAddRows = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error IN Data Receving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = SearchBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in SaleDataGrid.Rows)
            {
                // Skip new rows
                if (row.IsNewRow) continue;

                // Check each cell in the row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                        SaleDataGrid.FirstDisplayedScrollingRowIndex = row.Index; // Scroll to row
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

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            if (FilterSaleType.SelectedItem.ToString() == "Auction Sale")
            {
                try
                {
                    // Task run the background thread 
                    DataTable dt = await Task.Run(() =>
                    {
                        using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                        {
                            conn.Open();
                            string query = "SELECT * FROM SaleDataV1 WHERE SaleType ='Auction Sale' ORDER BY SaleDate DESC";
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    });


                    SaleDataGrid.DataSource = dt;
                    lblSaleRowCount.Text = $" {SaleDataGrid.Rows.Count.ToString("N0")}";
                    SaleDataGrid.AllowUserToAddRows = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error IN Data Receving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            if (FilterSaleType.SelectedItem.ToString() == "Private Sale")
            {
                try
                {
                    // Task run the background thread 
                    DataTable dt = await Task.Run(() =>
                    {
                        using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                        {
                            conn.Open();
                            string query = "SELECT * FROM SaleDataV1 WHERE SaleType ='Private Sale' ORDER BY SaleDate DESC";
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    });


                    SaleDataGrid.DataSource = dt;
                    lblSaleRowCount.Text = $" {SaleDataGrid.Rows.Count.ToString("N0")}";
                    SaleDataGrid.AllowUserToAddRows = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error IN Data Receving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (FilterSaleType.SelectedItem.ToString() == "Direct Sale")
            {
                try
                {
                    // Task run the background thread 
                    DataTable dt = await Task.Run(() =>
                    {
                        using (SQLiteConnection conn = new SQLiteConnection("Data Source=SLTBDataV1.db;Version=3;"))
                        {
                            conn.Open();
                            string query = "SELECT * FROM SaleDataV1 WHERE SaleType ='Direct Sale' ORDER BY SaleDate DESC";
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    });


                    SaleDataGrid.DataSource = dt;
                    lblSaleRowCount.Text = $" {SaleDataGrid.Rows.Count.ToString("N0")}";
                    SaleDataGrid.AllowUserToAddRows = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error IN Data Receving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                FileName = "ExportedSaleData.xlsx"
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
                    wb.Worksheets.Add(dt, "ExportedSaleData");
                    wb.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Export completed successfully!", "Success");
            }
        }


        private void btnSaveAsExcel_Click(object sender, EventArgs e)
        {
            ExportDataGridToExcel(SaleDataGrid);
        }

      
    }
}
