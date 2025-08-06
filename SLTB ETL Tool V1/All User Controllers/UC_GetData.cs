using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SLTB_ETL_Tool_V1.All_User_Controllers
{
    public partial class UC_GetData : UserControl
    {
        public UC_GetData()
        {
            InitializeComponent();
            CustomizeGridHeader();

            
        }

        private void CustomizeGridHeader()
        {
            getDataGrid.EnableHeadersVisualStyles = false;
            getDataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            getDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            getDataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 10, FontStyle.Bold);
            getDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (dataTypeBox.SelectedItem.ToString() == "Sales Data")
            {
                //Call This Method to fetch Sale Data
                LoadSaleData();
            }

            if (dataTypeBox.SelectedItem.ToString() == "Production Data")
            {
                // Call This to fetch Customer Data
                LoadproductionData();
            }
            if (dataTypeBox.SelectedItem.ToString() == "Export Data")
            {
                // Call This Method to fetch Customer Data
                LoadCustomerData();
            }
        }

        //Method to get data from stored procedure
        private DataTable GetDataFromSP(string spName, int year, string fromDate, string toDate)
        {
            using (SqlConnection conn = new SqlConnection("Server=192.168.15.7;Database=SLTB;User Id=sa;Password=sa@123;TrustServerCertificate=True;"))
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MinSaleDate", fromDate);
                cmd.Parameters.AddWithValue("@MaxSaleDate", toDate);
                cmd.Parameters.AddWithValue("@Year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        //Method to load Sale Data
        public void LoadSaleData()
           {
               DateTime startDate = dtSaleFrom.Value.Date;
               DateTime endDate = dtSaleTo.Value.Date;
               int year = endDate.Year;

               DataTable auctionData = GetDataFromSP("spGetRawDataAuctionSaleWithRefuse_v3", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
               DataTable directData = GetDataFromSP("spGetRawDataDirectSaleWithRefuse_V3", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
               DataTable privateData = GetDataFromSP("spGetRawDataPrivateSaleWithRefuse_V4", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

               // Create unified DataTable
               DataTable unified = new DataTable();
               unified.Columns.Add("RowNumber", typeof(int));
               unified.Columns.Add("SaleType"); // Extra column to indicate type
               unified.Columns.Add("Factory");
               unified.Columns.Add("Mark");
               unified.Columns.Add("FactoryName");
               unified.Columns.Add("Elevation");
               unified.Columns.Add("SubElevation");
               unified.Columns.Add("ManagementType");
               unified.Columns.Add("ManagementDes");
               unified.Columns.Add("ProcessingMethod");
               unified.Columns.Add("ATCRegion");
               unified.Columns.Add("Buyer");
               unified.Columns.Add("Grade");
               unified.Columns.Add("IsMainGrade");
               unified.Columns.Add("NetWeight");
               unified.Columns.Add("Price");
               unified.Columns.Add("NetValue");
               unified.Columns.Add("SaleDate");
               unified.Columns.Add("Broker");
               unified.Columns.Add("LotNo");
               unified.Columns.Add("InvoiceNo");
               unified.Columns.Add("SellingMark");


            
                int rowNumber = 1;
                // Map rows from auction
            foreach (DataRow row in auctionData.Rows)
               {
                   unified.Rows.Add( 
                       rowNumber++,
                       row["Sale_Type"],
                       row["Factory"],
                       row["Mark"],
                       row["FactoryName"],
                       row["Elevation"] == DBNull.Value ? "Various" : row["Elevation"], 
                       row["SubElevation"] == DBNull.Value ? "Various" : row["SubElevation"],
                       row["ManagementType"]== DBNull.Value ? "NOT DEFINED" : row["ManagementType"],
                       row["ManagementDes"]==DBNull.Value ? "NOT DEFINED" : row["ManagementDes"],
                       row["processingMethod"],
                       row["ATCRegion"],
                       row["buyer"],
                       row["Grade"],
                       row["IsMainGrade"],
                       row["NetWeight"], 
                       row["Price"],
                       row["NetValue"], 
                       row["SaleDate"],
                       row["broker"],
                       row["LotNo"],
                       row["InvoiceNo"],
                       row["SellingMark"]);
               }

               // Map rows from direct
               foreach (DataRow row in directData.Rows)
               {
                   unified.Rows.Add(
                       rowNumber++,
                       row["Sale_Type"],
                       row["Factory"],
                       row["Factory"], //Duplicated because of mark and the factory code are same here
                       row["FactoryName"],
                       row["Elevation"] == DBNull.Value ? "Various" : row["Elevation"],
                       row["SubElevation"] == DBNull.Value ? "Various" : row["SubElevation"],
                       row["ManagementType"] == DBNull.Value ? "NOT DEFINED" : row["ManagementType"],
                       row["ManagementDes"]== DBNull.Value ? "NOT DEFINED" : row["ManagementDes"],
                       row["processingMethod"],
                       row["ATCRegion"],
                       row["ExporterDesCrip"],
                       row["Grade"],
                       row["IsMainGrade"],
                       row["Quantity"],
                       row["PriceByPanal"],
                       row["Value"],
                       row["SaleDate"],
                       "DIRECT",
                       "NO LOT NO",
                       "NO INVOICE",
                       row["SellingMark"]);
               }

               // Map rows from private
               foreach (DataRow row in privateData.Rows)
               {
                   unified.Rows.Add(
                       rowNumber++,
                       row["Sale_Type"],
                       row["Factory"],
                       row["Mark"],
                       row["FactoryName"],
                       row["Elevation"] == DBNull.Value ? "Various" : row["Elevation"],
                       row["SubElevation"] == DBNull.Value ? "Various" : row["SubElevation"],
                       row["ManagementType"]== DBNull.Value ? "NOT DEFINED" : row["ManagementType"],
                       row["ManagementDes"]== DBNull.Value ? "NOT DEFINED" : row["ManagementDes"],
                       row["processingMethod"],
                       row["ATCRegion"],
                       row["BuyerName"],
                       row["Grade"],
                       row["IsMainGrade"],
                       row["NetWeight"],
                       row["Price"],
                       row["NetValue"],
                       row["SaleDateVal"],
                       row["broker"],
                       row["LotNo"],
                       row["InvoiceNo"],
                       row["SellingMark"]);
               }

               // Bind to DataGridView
               getDataGrid.DataSource = unified;

            // ---- Null detection & reporting block ----
            Dictionary<string, int> nullCounts = new Dictionary<string, int>();
            foreach (DataColumn col in unified.Columns)
            {
                nullCounts[col.ColumnName] = 0;
            }

            foreach (DataRow row in unified.Rows)
            {
                foreach (DataColumn col in unified.Columns)
                {
                    if (row.IsNull(col))
                    {
                        nullCounts[col.ColumnName]++;
                    }
                }
            }

            foreach (DataGridViewRow row in getDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == DBNull.Value || string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        cell.Style.BackColor = Color.Red;
                        cell.Style.ForeColor = Color.White;
                        cell.ReadOnly = false; // Let user edit only null fields
                    }
                    else
                    {
                        cell.ReadOnly = true; // Optional: make valid cells read-only
                    }
                }
            }


            //show in a DataGridView report
            DataTable reportTable = new DataTable();
            reportTable.Columns.Add("Column");
            reportTable.Columns.Add("RowNumber");

            foreach (DataRow row in unified.Rows)
            {
                foreach (DataColumn col in unified.Columns)
                {
                    if (col.ColumnName == "RowNumber") continue; // skip self

                    if (row.IsNull(col))
                    {
                        reportTable.Rows.Add(col.ColumnName, row["RowNumber"]);
                    }
                }
            }


            nullReportGrid.DataSource = reportTable;

            lblRowCount.Text = $" {getDataGrid.Rows.Count}";

            getDataGrid.AllowUserToAddRows = false;
        } 

        

       

        public void LoadproductionData()
        {
            // Logic to load production data from the database or any source
            // This is a placeholder for actual data loading logic
            MessageBox.Show("Production Data Loaded Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadCustomerData()
        {
            // Logic to load customer data from the database or any source
            // This is a placeholder for actual data loading logic
            MessageBox.Show("Customer Data Loaded Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            getDataGrid.DataSource = null;
            nullReportGrid.DataSource = null;
            lblRowCount.Text = "0";
            dtSaleFrom.Value = DateTime.Now;
            dtSaleTo.Value = DateTime.Now;
            dataTypeBox.SelectedIndex = -1; // Reset the dropdown selection

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before saving
            DialogResult result = MessageBox.Show("Are you sure you want to save the data to the database?", 
                "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return; // Cancel the operation

            string connStr = "Data Source=SLTBDataV1.db;Version=3;";
            int insertedCount = 0;
            int totalRows = 0;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = @"INSERT OR IGNORE INTO SaleDataV1 
        (SaleType,Factory,Mark,FactoryName,Elevation,SubElevation,ManagementType,ManagementDes,
            ProcessingMethod, ATCRegion, Buyer, Grade, IsMainGrade, NetWeight, Price, NetValue, SaleDate, Broker, LotNo, 
            InvoiceNo, SellingMark) 
        VALUES (@SaleType, @Factory, @Mark, @FactoryName, @Elevation, @SubElevation, @ManagementType, @ManagementDes,
            @ProcessingMethod, @ATCRegion, @Buyer, @Grade, @IsMainGrade, @NetWeight, @Price, @NetValue, @SaleDate, @Broker, @LotNo, 
            @InvoiceNo, @SellingMark);";

                    // Add parameters once
                    cmd.Parameters.Add("@SaleType", DbType.String);
                    cmd.Parameters.Add("@Factory", DbType.String);
                    cmd.Parameters.Add("@Mark", DbType.String);
                    cmd.Parameters.Add("@FactoryName", DbType.String);
                    cmd.Parameters.Add("@Elevation", DbType.String);
                    cmd.Parameters.Add("@SubElevation", DbType.String);
                    cmd.Parameters.Add("@ManagementType", DbType.String);
                    cmd.Parameters.Add("@ManagementDes", DbType.String);
                    cmd.Parameters.Add("@ProcessingMethod", DbType.String);
                    cmd.Parameters.Add("@ATCRegion", DbType.String);
                    cmd.Parameters.Add("@Buyer", DbType.String);
                    cmd.Parameters.Add("@Grade", DbType.String);
                    cmd.Parameters.Add("@IsMainGrade", DbType.Boolean);
                    cmd.Parameters.Add("@NetWeight", DbType.Decimal);
                    cmd.Parameters.Add("@Price", DbType.Decimal);
                    cmd.Parameters.Add("@NetValue", DbType.Decimal);
                    cmd.Parameters.Add("@SaleDate", DbType.DateTime);
                    cmd.Parameters.Add("@Broker", DbType.String);
                    cmd.Parameters.Add("@LotNo", DbType.String);
                    cmd.Parameters.Add("@InvoiceNo", DbType.String);
                    cmd.Parameters.Add("@SellingMark", DbType.String);

                    foreach (DataGridViewRow row in getDataGrid.Rows)
                    {
                        if (row.IsNewRow) continue;

                        totalRows++;

                        cmd.Parameters["@SaleType"].Value = row.Cells["SaleType"].Value;
                        cmd.Parameters["@Factory"].Value = row.Cells["Factory"].Value;
                        cmd.Parameters["@Mark"].Value = row.Cells["Mark"].Value;
                        cmd.Parameters["@FactoryName"].Value = row.Cells["FactoryName"].Value;
                        cmd.Parameters["@Elevation"].Value = row.Cells["Elevation"].Value;
                        cmd.Parameters["@SubElevation"].Value = row.Cells["Subelevation"].Value;
                        cmd.Parameters["@ManagementType"].Value = row.Cells["ManagementType"].Value;
                        cmd.Parameters["@ManagementDes"].Value = row.Cells["ManagementDes"].Value;
                        cmd.Parameters["@ProcessingMethod"].Value = row.Cells["ProcessingMethod"].Value;
                        cmd.Parameters["@ATCRegion"].Value = row.Cells["ATCRegion"].Value;
                        cmd.Parameters["@Buyer"].Value = row.Cells["Buyer"].Value;
                        cmd.Parameters["@Grade"].Value = row.Cells["Grade"].Value;
                        var isMainGradeValue = row.Cells["IsMainGrade"].Value?.ToString();
                        bool isMainGrade = isMainGradeValue == "1" || isMainGradeValue?.ToLower() == "true";
                        cmd.Parameters["@IsMainGrade"].Value = isMainGrade;
                        cmd.Parameters["@NetWeight"].Value = row.Cells["NetWeight"].Value;
                        cmd.Parameters["@Price"].Value = row.Cells["Price"].Value;
                        cmd.Parameters["@NetValue"].Value = row.Cells["NetValue"].Value;
                        
                        string saleDateStr = row.Cells["Saledate"].Value?.ToString();
                        DateTime saleDate;
                        if (!DateTime.TryParse(saleDateStr, out saleDate))
                        {
                            // Handle parse error (e.g., skip row, set to default, or show error)
                            continue;
                        }
                        cmd.Parameters["@SaleDate"].Value = saleDate;
                        
                        cmd.Parameters["@Broker"].Value = row.Cells["Broker"].Value;
                        cmd.Parameters["@LotNo"].Value = row.Cells["LotNo"].Value;
                        cmd.Parameters["@InvoiceNo"].Value = row.Cells["InvoiceNo"].Value;
                        cmd.Parameters["@SellingMark"].Value = row.Cells["SellingMark"].Value;

                        insertedCount += cmd.ExecuteNonQuery(); // 1 = inserted, 0 = ignored
                    }

                    transaction.Commit();
                }
            }

            int ignoredCount = totalRows - insertedCount;

            MessageBox.Show($"Save completed!\n\nInserted: {insertedCount} rows\nIgnored (duplicates): {ignoredCount} rows",
                "Operation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
 
    }
}
