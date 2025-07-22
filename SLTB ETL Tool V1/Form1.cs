using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_GetData1.Visible = false;
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

        
    }
}
