using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            getDataGrid.EnableHeadersVisualStyles = false; // Important to allow custom styles
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

        //keep this commented out if you don't want to use it
        /*   public void LoadSaleData()
           {
               DateTime startDate = dtFrom.Value.Date;
               DateTime endDate = dtTo.Value.Date;
               int year = endDate.Year;

               DataTable auctionData = GetDataFromSP("spGetRawDataAuctionSaleWithRefuse_v3", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
               DataTable directData = GetDataFromSP("spGetRawDataDirectSaleWithRefuse_V3", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
               DataTable privateData = GetDataFromSP("spGetRawDataPrivateSaleWithRefuse_V4", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

               // Create unified DataTable
               DataTable unified = new DataTable();
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
               unified.Columns.Add("SellingMark");

               // Map rows from auction
               foreach (DataRow row in auctionData.Rows)
               {
                   unified.Rows.Add( 
                       row["Sale_Type"],
                       row["Factory"],
                       row["Mark"],
                       row["FactoryName"],
                       row["Elevation"], 
                       row["SubElevation"],
                       row["ManagementType"],
                       row["ManagementDes"],
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
                       row["SellingMark"]);
               }

               // Map rows from direct
               foreach (DataRow row in directData.Rows)
               {
                   unified.Rows.Add(
                       row["Sale_Type"],
                       row["Factory"],
                       row["Factory"], //Duplicated because of mark and the factory code are same here
                       row["FactoryName"],
                       row["Elevation"],
                       row["SubElevation"],
                       row["ManagementType"],
                       row["ManagementDes"],
                       row["processingMethod"],
                       row["ATCRegion"],
                       row["ExporterDesCrip"],
                       row["Grade"],
                       row["IsMainGrade"],
                       row["Quantity"],
                       row["PriceByPanal"],
                       row["Value"],
                       row["SaleDate"],

                       row["SellingMark"]);
               }

               // Map rows from private
               foreach (DataRow row in privateData.Rows)
               {
                   unified.Rows.Add(
                       row["Sale_Type"],
                       row["Factory"],
                       row["Mark"],
                       row["FactoryName"],
                       row["Elevation"],
                       row["SubElevation"],
                       row["ManagementType"],
                       row["ManagementDes"],
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
                       row["SellingMark"]);
               }

               // Bind to DataGridView
               getDataGrid.DataSource = unified;


           } */

        private DataTable GetLocalFactoryTable()
        {
            DataTable factoryTable = new DataTable();

            // SQLite connection string
            string sqliteConnectionString = "Data Source=C:\\Users\\SANDARUWAN\\source\\repos\\SLTB ETL Tool V1 -base\\SLTB ETL Tool V1\\bin\\Debug\\factorydb.db";

            using (SQLiteConnection conn = new SQLiteConnection(sqliteConnectionString))
            {
                conn.Open();

                string query = "SELECT FactoryCode, Elevation, SubElevation FROM factory";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(factoryTable);
                    }
                }

                conn.Close();
            }

            return factoryTable;
        }

        public void LoadSaleData()
        {
            DateTime startDate = dtFrom.Value.Date;
            DateTime endDate = dtTo.Value.Date;
            int year = endDate.Year;

            // Load SP data
            DataTable auctionData = GetDataFromSP("spGetRawDataAuctionSaleWithRefuse_v3", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
            DataTable directData = GetDataFromSP("spGetRawDataDirectSaleWithRefuse_V3", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
            DataTable privateData = GetDataFromSP("spGetRawDataPrivateSaleWithRefuse_V4", year, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

            // Load local factory table (assume you've loaded this beforehand)
            DataTable localFactoryTable = GetLocalFactoryTable(); 

            

            // Create unified structure
            DataTable unified = new DataTable();
            unified.Columns.Add("SaleType");
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
            unified.Columns.Add("SellingMark");

            // Convert local factory table to list for LINQ
            var factoryLookup = localFactoryTable.AsEnumerable()
                .ToDictionary(
                    row => row["FactoryCode"].ToString(),
                    row => new {
                        Elevation = row["Elevation"]?.ToString(),
                        SubElevation = row["SubElevation"]?.ToString()
                    });

            // Auction rows
            foreach (DataRow row in auctionData.Rows)
            {
                var factoryCode = row["Factory"].ToString();
                var factoryData = factoryLookup.ContainsKey(factoryCode) ? factoryLookup[factoryCode] : new { Elevation = "", SubElevation = "" };

                unified.Rows.Add(
                    row["Sale_Type"],
                    factoryCode,
                    row["Mark"],
                    row["FactoryName"],
                    factoryData.Elevation, // override
                    factoryData.SubElevation, // override
                    row["ManagementType"],
                    row["ManagementDes"],
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
                    row["SellingMark"]);
            }

            // Direct rows
            foreach (DataRow row in directData.Rows)
            {
                var factoryCode = row["Factory"].ToString();
                var factoryData = factoryLookup.ContainsKey(factoryCode) ? factoryLookup[factoryCode] : new { Elevation = "", SubElevation = "" };

                unified.Rows.Add(
                    row["Sale_Type"],
                    factoryCode,
                    factoryCode, // Mark same as factory
                    row["FactoryName"],
                    factoryData.Elevation,
                    factoryData.SubElevation,
                    row["ManagementType"],
                    row["ManagementDes"],
                    row["processingMethod"],
                    row["ATCRegion"],
                    row["ExporterDesCrip"], // Buyer
                    row["Grade"],
                    row["IsMainGrade"],
                    row["Quantity"],
                    row["PriceByPanal"],
                    row["Value"],
                    row["SaleDate"],
                    "Default Broker", // Default value
                    row["SellingMark"]);
            }

            // Private rows
            foreach (DataRow row in privateData.Rows)
            {
                var factoryCode = row["Factory"].ToString();
                var factoryData = factoryLookup.ContainsKey(factoryCode) ? factoryLookup[factoryCode] : new { Elevation = "", SubElevation = "" };

                unified.Rows.Add(
                    row["Sale_Type"],
                    factoryCode,
                    row["Mark"],
                    row["FactoryName"],
                    factoryData.Elevation,
                    factoryData.SubElevation,
                    row["ManagementType"],
                    row["ManagementDes"],
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
                    row["SellingMark"]);
            }

            getDataGrid.DataSource = unified;
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

        
    }
}
