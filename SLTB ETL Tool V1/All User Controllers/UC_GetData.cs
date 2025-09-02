using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
                // Call This Method to fetch Production Data
                LoadProductionData();
            }
            if (dataTypeBox.SelectedItem.ToString() == "Export Data")
            {
                // Call This Method to fetch Export Data
                LoadExportData();
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
               DateTime startDate = dtFrom.Value.Date;
               DateTime endDate = dtTo.Value.Date;
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

            lblRowCount.Text = $" {getDataGrid.Rows.Count.ToString("N0")}";

            getDataGrid.AllowUserToAddRows = false;
        }


        //Method to fetch Production Data
        public void LoadProductionData()
        {
            DateTime fromDate = dtFrom.Value;
            DateTime toDate = dtTo.Value;

            string connectionString = "Server=192.168.15.7;Database=SLTB;User Id=sa;Password=sa@123;TrustServerCertificate=True;";

            string query = @"
            SELECT 
            F.Factory AS FactoryCode,
            F.Name AS FactoryName,
            E.Name AS Elevation,
            SE.Name AS SubElevation,
            R.Name AS Region,
            MP.ProdYear,
            MP.ProdMonth,
            P.Code AS ProcessingMethod,
            MP.ManOwnLeaf,
            MP.ManBoughtLeaf,
            MP.ManOtherEstate,
            MP.TotalProduction,
            MR.DuringTheMonth AS DuringTheMonth
            FROM MonthlyProduction MP
            INNER JOIN MonthlyRefuseTea MR ON MP.MonthlyProductionID = MR.MonthlyProductionID
            INNER JOIN Factory F ON F.FactoryID = MP.FactoryID
            INNER JOIN Elevation E ON E.ElevationId = F.ElevationId
            INNER JOIN SubElevation SE ON SE.SubElevationId = F.SubElevationId
            INNER JOIN ProcessingMethod P ON P.ProcessingMethodID = MP.ProcessingMethodID
            INNER JOIN ATCRegion R ON R.ATCRegionID = F.ATCRegionID
             WHERE 
            CAST(DATEFROMPARTS(MP.ProdYear, MP.ProdMonth, 1) AS DATE) 
            BETWEEN @FromDate AND @ToDate;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                    cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    getDataGrid.DataSource = dt;

                    // ---- Null detection & reporting block ----
                    Dictionary<string, int> nullCounts = new Dictionary<string, int>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        nullCounts[col.ColumnName] = 0;
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
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

                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }




        public void LoadExportData()
        {
            DateTime fromDate = dtFrom.Value;
            DateTime toDate = dtTo.Value;

            string connectionString = "Server=192.168.15.7;Database=SLTB;User Id=sa;Password=sa@123;TrustServerCertificate=True;";

            string query = @" SELECT Distinct
                            D.Name AS Country,
                            s.ApplicantName,
                            MC.CusYear,
                            MC.CusMonth,
                            CASE WHEN IsExport = 1 THEN 'Export' ELSE 'ReExport' END AS ExportType,
                            HSP.Name AS Process,
                            HPT.Name AS Package,
                            Cod.Code AS HSCode,
                            MC.CusQty AS Qty,
                            MC.CusValue AS Value,
                            E.ShipmentDate,
                            E.Vessel,
                            E.DeliveryTerms,
                            E.ConsigneeName
                            FROM MonthlyCustoms MC
                            INNER JOIN HSCode Cod
                                ON MC.HSCodeID = Cod.HSCodeID
                            INNER JOIN (SELECT * FROM HSCategory WHERE HSProcessID IS NOT NULL) HSC
                                ON Cod.HSCodeID = HSC.HSCodeID
                            INNER JOIN HSProcess HSP
                                ON HSC.HSProcessID = HSP.HSProcessID
                            INNER JOIN HSPackageType HPT
                                ON HSC.HSPackingID = HPT.HSPackageTypeID
                            INNER JOIN Destination D
                                ON D.DestinationID = MC.DestinationID
                            LEFT JOIN (
                                SELECT s.ApplicantName, e.ExporterID
                                FROM SLTBClient s
                                INNER JOIN Exporter e ON s.SLTBClientID = e.SLTBClientID
                                ) s ON s.ExporterID = MC.ExporterID
                                INNER JOIN Export E
                                ON E.ExporterID = MC.ExporterID
                                AND E.DestinationID = MC.DestinationID
                                AND MC.CusYear = YEAR(E.ShipmentDate)
                                AND MC.CusMonth = MONTH(E.ShipmentDate)
                                WHERE
                                 E.ShipmentDate >= @FromDate 
                                 AND E.ShipmentDate <= @ToDate 
                                 AND HPT.HSPackageTypeID <> 7
                                    ORDER BY ShipmentDate;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                    cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    getDataGrid.DataSource = dt;

                    // ---- Null detection & reporting block ----
                    Dictionary<string, int> nullCounts = new Dictionary<string, int>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        nullCounts[col.ColumnName] = 0;
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
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

                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            getDataGrid.DataSource = null;
            nullReportGrid.DataSource = null;
            lblRowCount.Text = "0";
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
            dataTypeBox.SelectedIndex = -1; // Reset the dropdown selection

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataTypeBox.SelectedItem.ToString() == "Sales Data")
            {
                //Call This Method to Save Sale Data To Local Database
                SaveSaleData();
            }

            if (dataTypeBox.SelectedItem.ToString() == "Production Data")
            {
                // Call This Method to Save Production Data
                SaveProductionData();
            }
            if (dataTypeBox.SelectedItem.ToString() == "Export Data")
            {
                // Call This Method to Save Export Data
                SaveExportData();
            }
            

        }

        private void SaveSaleData()
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

        private void SaveProductionData()
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
                    cmd.CommandText = @"INSERT OR IGNORE INTO ProductionDataV1 
        (FactoryCode,FactoryName,Elevation,SubElevation,Region,ProdYear,
            ProdMonth, ProcessingMethod,ManOwnLeaf, ManBoughtLeaf, ManOtherEstate,
            TotalProduction,DuringTheMonth ) 
        VALUES (@FactoryCode, @FactoryName, @Elevation, @SubElevation, @Region, @ProdYear, 
                @ProdMonth, @ProcessingMethod, @ManOwnLeaf, @ManBoughtLeaf, @ManOtherEstate, 
                @TotalProduction, @DuringTheMonth);";

                    // Add parameters once
                    cmd.Parameters.Add("@FactoryCode", DbType.String);
                    cmd.Parameters.Add("@FactoryName", DbType.String);
                    cmd.Parameters.Add("@Elevation", DbType.String);
                    cmd.Parameters.Add("@SubElevation", DbType.String);
                    cmd.Parameters.Add("@Region", DbType.String);
                    cmd.Parameters.Add("@ProdYear", DbType.String);
                    cmd.Parameters.Add("@ProdMonth", DbType.String);
                    cmd.Parameters.Add("@ProcessingMethod", DbType.String);
                    cmd.Parameters.Add("@ManOwnLeaf", DbType.Double);
                    cmd.Parameters.Add("@ManBoughtLeaf", DbType.Double);
                    cmd.Parameters.Add("@ManOtherEstate", DbType.Double);
                    cmd.Parameters.Add("@TotalProduction", DbType.Double);
                    cmd.Parameters.Add("@DuringTheMonth", DbType.Double);
                    

                    foreach (DataGridViewRow row in getDataGrid.Rows)
                    {
                        if (row.IsNewRow) continue;

                        totalRows++;

                        
                        cmd.Parameters["@FactoryCode"].Value = row.Cells["FactoryCode"].Value;
                        cmd.Parameters["@FactoryName"].Value = row.Cells["FactoryName"].Value;
                        cmd.Parameters["@Elevation"].Value = row.Cells["Elevation"].Value;
                        cmd.Parameters["@SubElevation"].Value = row.Cells["Subelevation"].Value;
                        cmd.Parameters["@Region"].Value = row.Cells["Region"].Value;
                        cmd.Parameters["@ProdYear"].Value = row.Cells["ProdYear"].Value;
                        cmd.Parameters["@ProdMonth"].Value = row.Cells["ProdMonth"].Value;
                        cmd.Parameters["@ProcessingMethod"].Value = row.Cells["ProcessingMethod"].Value;
                        cmd.Parameters["@ManOwnLeaf"].Value = row.Cells["ManOwnLeaf"].Value;
                        cmd.Parameters["@ManBoughtLeaf"].Value = row.Cells["ManBoughtLeaf"].Value;
                        cmd.Parameters["@ManOtherEstate"].Value = row.Cells["ManOtherEstate"].Value;
                        cmd.Parameters["@TotalProduction"].Value = row.Cells["TotalProduction"].Value;
                        cmd.Parameters["@DuringTheMonth"].Value = row.Cells["DuringTheMonth"].Value;

                        insertedCount += cmd.ExecuteNonQuery(); // 1 = inserted, 0 = ignored
                    }

                  
                }
            }

            int ignoredCount = totalRows - insertedCount;

            MessageBox.Show($"Save completed!\n\nInserted: {insertedCount} rows\nIgnored (duplicates): {ignoredCount} rows",
                "Operation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SaveExportData()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save the data to the database?",
                "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            string connStr = "Data Source=SLTBDataV1.db;Version=3;";
            int insertedCount = 0;
            int totalRows = 0;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = @"INSERT OR IGNORE INTO ExportDataV1 
                                        (Country, ApplicantName, ExportType, Process, Package, HSCode, Qty, Value, ShipmentDate, Vessel, DeliveryTerms, ConsigneeName) 
                                        VALUES (@Country, @ApplicantName, @ExportType, @Process, @Package, @HSCode, @Qty, @Value, @ShipmentDate, @Vessel, @DeliveryTerms, @ConsigneeName);";
                    cmd.Transaction = transaction;

                    // Define parameters once
                    cmd.Parameters.Add("@Country", DbType.String);
                    cmd.Parameters.Add("@ApplicantName", DbType.String);
                    cmd.Parameters.Add("@ExportType", DbType.String);
                    cmd.Parameters.Add("@Process", DbType.String);
                    cmd.Parameters.Add("@Package", DbType.String);
                    cmd.Parameters.Add("@HSCode", DbType.String);
                    cmd.Parameters.Add("@Qty", DbType.Double);
                    cmd.Parameters.Add("@Value", DbType.Double);
                    cmd.Parameters.Add("@ShipmentDate", DbType.String);  // store as text (yyyy-MM-dd)
                    cmd.Parameters.Add("@Vessel", DbType.String);
                    cmd.Parameters.Add("@DeliveryTerms", DbType.String);
                    cmd.Parameters.Add("@ConsigneeName", DbType.String);

                    foreach (DataGridViewRow row in getDataGrid.Rows)
                    {
                        if (row.IsNewRow) continue;

                        totalRows++;

                        cmd.Parameters["@Country"].Value = row.Cells["Country"].Value ?? DBNull.Value;
                        cmd.Parameters["@ApplicantName"].Value = row.Cells["ApplicantName"].Value ?? DBNull.Value;
                        cmd.Parameters["@ExportType"].Value = row.Cells["ExportType"].Value ?? DBNull.Value;
                        cmd.Parameters["@Process"].Value = row.Cells["Process"].Value ?? DBNull.Value;
                        cmd.Parameters["@Package"].Value = row.Cells["Package"].Value ?? DBNull.Value;
                        cmd.Parameters["@HSCode"].Value = row.Cells["HSCode"].Value ?? DBNull.Value;
                        cmd.Parameters["@Qty"].Value = row.Cells["Qty"].Value ?? DBNull.Value;
                        cmd.Parameters["@Value"].Value = row.Cells["Value"].Value ?? DBNull.Value;

                        // Handle date properly
                        if (row.Cells["ShipmentDate"].Value != null && DateTime.TryParse(row.Cells["ShipmentDate"].Value.ToString(), out DateTime date))
                        {
                            cmd.Parameters["@ShipmentDate"].Value = date.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            cmd.Parameters["@ShipmentDate"].Value = DBNull.Value;
                        }

                        cmd.Parameters["@Vessel"].Value = row.Cells["Vessel"].Value ?? DBNull.Value;
                        cmd.Parameters["@DeliveryTerms"].Value = row.Cells["DeliveryTerms"].Value ?? DBNull.Value;
                        cmd.Parameters["@ConsigneeName"].Value = row.Cells["ConsigneeName"].Value ?? DBNull.Value;

                        insertedCount += cmd.ExecuteNonQuery();
                    }

                    transaction.Commit(); // ✅ commit changes
                }
            }

            int ignoredCount = totalRows - insertedCount;

            MessageBox.Show($"Save completed!\n\nInserted: {insertedCount} rows\nIgnored (duplicates): {ignoredCount} rows",
                "Operation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
