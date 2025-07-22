using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            getDataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            getDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (dataTypeBox.SelectedItem.ToString() == "Sale Data")
            {
                // Logic to fetch Sale Data
                LoadSaleData();
            }

            if (dataTypeBox.SelectedItem.ToString() == "Production Data")
            {
                // Logic to fetch Customer Data
                LoadproductionData();
            }
            if (dataTypeBox.SelectedItem.ToString() == "Export Data")
            {
                // Logic to fetch Customer Data
                LoadCustomerData();
            }
        }

        public void LoadSaleData()
        {
            // Logic to load sale data from the database or any source
            // This is a placeholder for actual data loading logic
            MessageBox.Show("Sale Data Loaded Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
