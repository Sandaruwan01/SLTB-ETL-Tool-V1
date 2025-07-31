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

namespace SLTB_ETL_Tool_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createTables();
            this.uC_Home1.Visible = true;
            this.uC_Home1.BringToFront();
            this.uC_GetData1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_GetData1.Visible = false;
        }

        private void createTables()
        {
            //remove this before publish
            string connectionString = @"Data Source=C:\Users\SANDARUWAN\source\repos\SLTB ETL Tool V1 -base\SLTB ETL Tool V1\bin\Debug\SLTBDataV1.db; Version=3;";
            

            //enable this before publish
            // string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "mydatabase.db");
            //string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string createSaleDataTableQuery = @"
                CREATE TABLE IF NOT EXISTS SaleDataV1 (
                
                SaleType TEXT,
                Factory TEXT,
                Mark TEXT,
                FactoryName TEXT,
                Elevation TEXT,
                SubElevation TEXT,
                ManagementType TEXT,
                ManagementDes TEXT,
                ProcessingMethod TEXT,
                ATCRegion TEXT,
                Buyer TEXT,
                Grade TEXT,
                IsMainGrade BLOB,
                NetWeight REAL,
                Price REAL,
                NetValue REAL,
                SaleDate TEXT,
                Broker TEXT,
                LotNo TEXT,
                InvoiceNo TEXT,
                SellingMark TEXT,
                PRIMARY KEY (Factory, NetWeight, NetValue, Price, Grade,Buyer ,SaleDate, LotNo, InvoiceNo, SellingMark)
                 );";


                using (SQLiteCommand cmd = new SQLiteCommand(createSaleDataTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? 
                FormWindowState.Normal : FormWindowState.Maximized;
        }

       

        private void btnMini_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            this.uC_GetData1.Visible = true;
            this.uC_GetData1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.uC_Home1.Visible = true;
            this.uC_Home1.BringToFront();
        }

       
    }
}
