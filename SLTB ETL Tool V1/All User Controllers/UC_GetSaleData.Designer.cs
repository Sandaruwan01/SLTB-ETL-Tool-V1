namespace SLTB_ETL_Tool_V1.All_User_Controllers
{
    partial class UC_GetSaleData
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GetSaleData));
            this.label2 = new System.Windows.Forms.Label();
            this.dtSaleTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtSaleFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaleGo = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaleReset = new Guna.UI2.WinForms.Guna2Button();
            this.SaleDataGrid = new System.Windows.Forms.DataGridView();
            this.SaleDataElips = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaleRowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "S A L E   D A T A ";
            // 
            // dtSaleTo
            // 
            this.dtSaleTo.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtSaleTo.Checked = true;
            this.dtSaleTo.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtSaleTo.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dtSaleTo.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtSaleTo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSaleTo.ForeColor = System.Drawing.Color.White;
            this.dtSaleTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtSaleTo.Location = new System.Drawing.Point(138, 171);
            this.dtSaleTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtSaleTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtSaleTo.Name = "dtSaleTo";
            this.dtSaleTo.Size = new System.Drawing.Size(305, 36);
            this.dtSaleTo.TabIndex = 22;
            this.dtSaleTo.Value = new System.DateTime(2025, 7, 29, 14, 48, 58, 754);
            // 
            // dtSaleFrom
            // 
            this.dtSaleFrom.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtSaleFrom.Checked = true;
            this.dtSaleFrom.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtSaleFrom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dtSaleFrom.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtSaleFrom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSaleFrom.ForeColor = System.Drawing.Color.White;
            this.dtSaleFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtSaleFrom.Location = new System.Drawing.Point(138, 126);
            this.dtSaleFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtSaleFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtSaleFrom.Name = "dtSaleFrom";
            this.dtSaleFrom.Size = new System.Drawing.Size(305, 36);
            this.dtSaleFrom.TabIndex = 21;
            this.dtSaleFrom.Value = new System.DateTime(2025, 7, 29, 14, 48, 58, 754);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filter By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "To";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BorderColor = System.Drawing.Color.White;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FillColor = System.Drawing.Color.Transparent;
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Location = new System.Drawing.Point(768, 124);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBox.PlaceholderText = "Search Anything";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(222, 38);
            this.SearchBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchBox.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Animated = true;
            this.btnSearch.AnimatedGIF = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSearch.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(768, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 39);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Go";
            // 
            // btnSaleGo
            // 
            this.btnSaleGo.Animated = true;
            this.btnSaleGo.AnimatedGIF = true;
            this.btnSaleGo.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleGo.BorderColor = System.Drawing.Color.White;
            this.btnSaleGo.BorderRadius = 10;
            this.btnSaleGo.BorderThickness = 1;
            this.btnSaleGo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaleGo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaleGo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaleGo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaleGo.FillColor = System.Drawing.Color.Transparent;
            this.btnSaleGo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleGo.ForeColor = System.Drawing.Color.White;
            this.btnSaleGo.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSaleGo.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaleGo.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleGo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSaleGo.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleGo.Image")));
            this.btnSaleGo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaleGo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSaleGo.Location = new System.Drawing.Point(486, 123);
            this.btnSaleGo.Name = "btnSaleGo";
            this.btnSaleGo.Size = new System.Drawing.Size(150, 39);
            this.btnSaleGo.TabIndex = 26;
            this.btnSaleGo.Text = "Go";
            this.btnSaleGo.Click += new System.EventHandler(this.btnSaleGo_Click);
            // 
            // btnSaleReset
            // 
            this.btnSaleReset.Animated = true;
            this.btnSaleReset.AnimatedGIF = true;
            this.btnSaleReset.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleReset.BorderColor = System.Drawing.Color.White;
            this.btnSaleReset.BorderRadius = 10;
            this.btnSaleReset.BorderThickness = 1;
            this.btnSaleReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaleReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaleReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaleReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaleReset.FillColor = System.Drawing.Color.Transparent;
            this.btnSaleReset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReset.ForeColor = System.Drawing.Color.White;
            this.btnSaleReset.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSaleReset.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaleReset.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReset.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSaleReset.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleReset.Image")));
            this.btnSaleReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaleReset.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSaleReset.Location = new System.Drawing.Point(486, 171);
            this.btnSaleReset.Name = "btnSaleReset";
            this.btnSaleReset.Size = new System.Drawing.Size(150, 36);
            this.btnSaleReset.TabIndex = 27;
            this.btnSaleReset.Text = "Reset";
            this.btnSaleReset.Click += new System.EventHandler(this.btnSaleReset_Click);
            // 
            // SaleDataGrid
            // 
            this.SaleDataGrid.AllowUserToAddRows = false;
            this.SaleDataGrid.AllowUserToDeleteRows = false;
            this.SaleDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleDataGrid.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.SaleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SaleDataGrid.GridColor = System.Drawing.Color.Navy;
            this.SaleDataGrid.Location = new System.Drawing.Point(56, 252);
            this.SaleDataGrid.Name = "SaleDataGrid";
            this.SaleDataGrid.ReadOnly = true;
            this.SaleDataGrid.RowHeadersWidth = 51;
            this.SaleDataGrid.RowTemplate.Height = 24;
            this.SaleDataGrid.Size = new System.Drawing.Size(934, 358);
            this.SaleDataGrid.TabIndex = 28;
            this.SaleDataGrid.VirtualMode = true;
            // 
            // SaleDataElips
            // 
            this.SaleDataElips.TargetControl = this;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(739, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Row Count";
            // 
            // lblSaleRowCount
            // 
            this.lblSaleRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaleRowCount.AutoSize = true;
            this.lblSaleRowCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSaleRowCount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleRowCount.ForeColor = System.Drawing.Color.White;
            this.lblSaleRowCount.Location = new System.Drawing.Point(852, 613);
            this.lblSaleRowCount.Name = "lblSaleRowCount";
            this.lblSaleRowCount.Size = new System.Drawing.Size(23, 28);
            this.lblSaleRowCount.TabIndex = 30;
            this.lblSaleRowCount.Text = "0";
            // 
            // UC_GetSaleData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblSaleRowCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaleDataGrid);
            this.Controls.Add(this.btnSaleReset);
            this.Controls.Add(this.btnSaleGo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtSaleTo);
            this.Controls.Add(this.dtSaleFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UC_GetSaleData";
            this.Size = new System.Drawing.Size(1048, 669);
            this.Load += new System.EventHandler(this.UC_GetSaleData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtSaleTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtSaleFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnSaleGo;
        private Guna.UI2.WinForms.Guna2Button btnSaleReset;
        private System.Windows.Forms.DataGridView SaleDataGrid;
        private Guna.UI2.WinForms.Guna2Elipse SaleDataElips;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaleRowCount;
    }
}
