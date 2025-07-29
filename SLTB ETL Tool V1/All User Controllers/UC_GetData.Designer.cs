namespace SLTB_ETL_Tool_V1.All_User_Controllers
{
    partial class UC_GetData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GetData));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnGo = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.ElipseGetData = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.getDataGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.getDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "G e t  D a t a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Date Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(751, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select Data Type";
            // 
            // dataTypeBox
            // 
            this.dataTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTypeBox.AutoRoundedCorners = true;
            this.dataTypeBox.BackColor = System.Drawing.Color.Black;
            this.dataTypeBox.BorderColor = System.Drawing.Color.White;
            this.dataTypeBox.BorderRadius = 17;
            this.dataTypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dataTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataTypeBox.FillColor = System.Drawing.Color.DodgerBlue;
            this.dataTypeBox.FocusedColor = System.Drawing.Color.White;
            this.dataTypeBox.FocusedState.BorderColor = System.Drawing.Color.White;
            this.dataTypeBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataTypeBox.FocusedState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTypeBox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.dataTypeBox.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.dataTypeBox.ForeColor = System.Drawing.Color.White;
            this.dataTypeBox.HoverState.FillColor = System.Drawing.Color.Aqua;
            this.dataTypeBox.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTypeBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.dataTypeBox.ItemHeight = 30;
            this.dataTypeBox.Items.AddRange(new object[] {
            "Export Data",
            "Production Data",
            "Sales Data"});
            this.dataTypeBox.ItemsAppearance.BackColor = System.Drawing.Color.Transparent;
            this.dataTypeBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.dataTypeBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Transparent;
            this.dataTypeBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTypeBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.dataTypeBox.Location = new System.Drawing.Point(762, 99);
            this.dataTypeBox.Name = "dataTypeBox";
            this.dataTypeBox.Size = new System.Drawing.Size(222, 36);
            this.dataTypeBox.StartIndex = 0;
            this.dataTypeBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.dataTypeBox.TabIndex = 7;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Animated = true;
            this.btnGo.AnimatedGIF = true;
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.BorderColor = System.Drawing.Color.White;
            this.btnGo.BorderRadius = 10;
            this.btnGo.BorderThickness = 1;
            this.btnGo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGo.FillColor = System.Drawing.Color.Transparent;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnGo.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnGo.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGo.Location = new System.Drawing.Point(762, 151);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(222, 39);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Animated = true;
            this.btnReset.AnimatedGIF = true;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderColor = System.Drawing.Color.White;
            this.btnReset.BorderRadius = 10;
            this.btnReset.BorderThickness = 1;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnReset.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReset.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReset.Location = new System.Drawing.Point(803, 584);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(181, 38);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(808, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Row Count";
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRowCount.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowCount.ForeColor = System.Drawing.Color.White;
            this.lblRowCount.Location = new System.Drawing.Point(901, 527);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(22, 25);
            this.lblRowCount.TabIndex = 12;
            this.lblRowCount.Text = "0";
            // 
            // ElipseGetData
            // 
            this.ElipseGetData.TargetControl = this;
            // 
            // getDataGrid
            // 
            this.getDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.getDataGrid.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.getDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.getDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.getDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.getDataGrid.Location = new System.Drawing.Point(63, 220);
            this.getDataGrid.Name = "getDataGrid";
            this.getDataGrid.RowHeadersWidth = 51;
            this.getDataGrid.RowTemplate.Height = 24;
            this.getDataGrid.Size = new System.Drawing.Size(921, 279);
            this.getDataGrid.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Animated = true;
            this.btnSave.AnimatedGIF = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSave.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(616, 584);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save To Local";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mean Of Data Set";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(138, 644);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(726, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "..............................Please Make Sure Factory Table Has Been Updated For" +
    " Accurate Data Collection.................................";
            // 
            // dtFrom
            // 
            this.dtFrom.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtFrom.Checked = true;
            this.dtFrom.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtFrom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dtFrom.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtFrom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.ForeColor = System.Drawing.Color.White;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFrom.Location = new System.Drawing.Point(122, 109);
            this.dtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(275, 36);
            this.dtFrom.TabIndex = 17;
            this.dtFrom.Value = new System.DateTime(2025, 7, 29, 14, 48, 58, 754);
            // 
            // dtTo
            // 
            this.dtTo.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtTo.Checked = true;
            this.dtTo.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtTo.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dtTo.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtTo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.ForeColor = System.Drawing.Color.White;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTo.Location = new System.Drawing.Point(122, 154);
            this.dtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(275, 36);
            this.dtTo.TabIndex = 18;
            this.dtTo.Value = new System.DateTime(2025, 7, 29, 14, 48, 58, 754);
            // 
            // UC_GetData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.getDataGrid);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.dataTypeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_GetData";
            this.Size = new System.Drawing.Size(1048, 669);
            ((System.ComponentModel.ISupportInitialize)(this.getDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox dataTypeBox;
        private Guna.UI2.WinForms.Guna2Button btnGo;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRowCount;
        private Guna.UI2.WinForms.Guna2Elipse ElipseGetData;
        private System.Windows.Forms.DataGridView getDataGrid;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
    }
}
