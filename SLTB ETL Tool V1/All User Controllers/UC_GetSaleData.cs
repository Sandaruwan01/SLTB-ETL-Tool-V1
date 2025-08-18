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
                        
                        string query = "SELECT SaleType,Factory,Mark,FactoryName,Elevation,SubElevation,ManagementType," +
                                       "ManagementDes,ProcessingMethod,ATCRegion,Buyer,Grade, CASE WHEN IsMainGrade = 1 THEN 'Yes' ELSE 'No' END AS IsMainGrade,NetWeight,Price,NetValue,SaleDate," +
                                       "Broker,LotNo,InvoiceNo,SellingMark FROM SaleDataV1 WHERE SaleDate BETWEEN @from AND @to ORDER BY SaleDate DESC";

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


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error IN Data Receving : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }
    }
}
