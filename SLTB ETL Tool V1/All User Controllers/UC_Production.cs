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
    }
}
