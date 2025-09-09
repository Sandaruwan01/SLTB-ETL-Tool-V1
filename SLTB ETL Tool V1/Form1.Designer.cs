namespace SLTB_ETL_Tool_V1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPannel = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.btnSale = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoadData = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduction = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.TopHomePannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.HomePnannel = new System.Windows.Forms.Panel();
            this.uC_Production1 = new SLTB_ETL_Tool_V1.All_User_Controllers.UC_Production();
            this.uC_ExportData1 = new SLTB_ETL_Tool_V1.All_User_Controllers.UC_ExportData();
            this.uC_GetSaleData1 = new SLTB_ETL_Tool_V1.All_User_Controllers.UC_GetSaleData();
            this.uC_GetData1 = new SLTB_ETL_Tool_V1.All_User_Controllers.UC_GetData();
            this.uC_Home1 = new SLTB_ETL_Tool_V1.All_User_Controllers.UC_Home();
            this.ElipseHome = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseFactory = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SaleDataElips = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ExportElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ProductionElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.TopHomePannel.SuspendLayout();
            this.HomePnannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPannel
            // 
            this.btnPannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPannel.BackColor = System.Drawing.Color.Indigo;
            this.btnPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPannel.BackgroundImage")));
            this.btnPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPannel.Controls.Add(this.btnExport);
            this.btnPannel.Controls.Add(this.btnSale);
            this.btnPannel.Controls.Add(this.btnLoadData);
            this.btnPannel.Controls.Add(this.btnProduction);
            this.btnPannel.Controls.Add(this.btnHome);
            this.btnPannel.Controls.Add(this.pictureBox1);
            this.btnPannel.Location = new System.Drawing.Point(5, 6);
            this.btnPannel.Name = "btnPannel";
            this.btnPannel.Size = new System.Drawing.Size(291, 803);
            this.btnPannel.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Animated = true;
            this.btnExport.AnimatedGIF = true;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExport.BorderRadius = 15;
            this.btnExport.BorderThickness = 1;
            this.btnExport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExport.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExport.CheckedState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.Transparent;
            this.btnExport.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnExport.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExport.Location = new System.Drawing.Point(27, 403);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(252, 50);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Data";
            this.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSale
            // 
            this.btnSale.Animated = true;
            this.btnSale.AnimatedGIF = true;
            this.btnSale.BackColor = System.Drawing.Color.Transparent;
            this.btnSale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSale.BorderRadius = 15;
            this.btnSale.BorderThickness = 1;
            this.btnSale.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSale.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSale.CheckedState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSale.FillColor = System.Drawing.Color.Transparent;
            this.btnSale.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSale.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSale.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSale.Location = new System.Drawing.Point(27, 568);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(252, 50);
            this.btnSale.TabIndex = 4;
            this.btnSale.Text = "Sales Data";
            this.btnSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Animated = true;
            this.btnLoadData.AnimatedGIF = true;
            this.btnLoadData.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLoadData.BorderRadius = 15;
            this.btnLoadData.BorderThickness = 1;
            this.btnLoadData.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLoadData.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoadData.CheckedState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLoadData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadData.FillColor = System.Drawing.Color.Transparent;
            this.btnLoadData.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnLoadData.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLoadData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadData.Image")));
            this.btnLoadData.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoadData.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoadData.Location = new System.Drawing.Point(27, 325);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(252, 50);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnProduction
            // 
            this.btnProduction.Animated = true;
            this.btnProduction.AnimatedGIF = true;
            this.btnProduction.BackColor = System.Drawing.Color.Transparent;
            this.btnProduction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProduction.BorderRadius = 15;
            this.btnProduction.BorderThickness = 1;
            this.btnProduction.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProduction.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProduction.CheckedState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduction.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProduction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduction.FillColor = System.Drawing.Color.Transparent;
            this.btnProduction.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduction.ForeColor = System.Drawing.Color.White;
            this.btnProduction.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnProduction.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduction.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnProduction.Image = ((System.Drawing.Image)(resources.GetObject("btnProduction.Image")));
            this.btnProduction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduction.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProduction.Location = new System.Drawing.Point(27, 485);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(252, 50);
            this.btnProduction.TabIndex = 2;
            this.btnProduction.Text = "Production Data";
            this.btnProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.AnimatedGIF = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.BorderRadius = 15;
            this.btnHome.BorderThickness = 1;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHome.CheckedState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnHome.HoverState.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(27, 252);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(252, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "H o m e";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(961, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(30, 30);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 2;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click_1);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(988, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(32, 30);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1016, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TopHomePannel
            // 
            this.TopHomePannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopHomePannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TopHomePannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopHomePannel.BackgroundImage")));
            this.TopHomePannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopHomePannel.Controls.Add(this.label1);
            this.TopHomePannel.Controls.Add(this.btnMini);
            this.TopHomePannel.Controls.Add(this.btnExit);
            this.TopHomePannel.Controls.Add(this.btnMax);
            this.TopHomePannel.Location = new System.Drawing.Point(302, 6);
            this.TopHomePannel.Name = "TopHomePannel";
            this.TopHomePannel.Size = new System.Drawing.Size(1048, 128);
            this.TopHomePannel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "E T L   T O O L";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.HomePnannel;
            // 
            // HomePnannel
            // 
            this.HomePnannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePnannel.AutoScroll = true;
            this.HomePnannel.BackColor = System.Drawing.Color.MidnightBlue;
            this.HomePnannel.Controls.Add(this.uC_Production1);
            this.HomePnannel.Controls.Add(this.uC_ExportData1);
            this.HomePnannel.Controls.Add(this.uC_GetSaleData1);
            this.HomePnannel.Controls.Add(this.uC_GetData1);
            this.HomePnannel.Controls.Add(this.uC_Home1);
            this.HomePnannel.Location = new System.Drawing.Point(302, 140);
            this.HomePnannel.Name = "HomePnannel";
            this.HomePnannel.Size = new System.Drawing.Size(1048, 669);
            this.HomePnannel.TabIndex = 1;
            // 
            // uC_Production1
            // 
            this.uC_Production1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Production1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uC_Production1.BackColor = System.Drawing.Color.Black;
            this.uC_Production1.Location = new System.Drawing.Point(0, 0);
            this.uC_Production1.Name = "uC_Production1";
            this.uC_Production1.Size = new System.Drawing.Size(1048, 669);
            this.uC_Production1.TabIndex = 7;
            // 
            // uC_ExportData1
            // 
            this.uC_ExportData1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_ExportData1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uC_ExportData1.BackColor = System.Drawing.Color.Black;
            this.uC_ExportData1.Location = new System.Drawing.Point(0, 0);
            this.uC_ExportData1.Name = "uC_ExportData1";
            this.uC_ExportData1.Size = new System.Drawing.Size(1048, 669);
            this.uC_ExportData1.TabIndex = 6;
            // 
            // uC_GetSaleData1
            // 
            this.uC_GetSaleData1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_GetSaleData1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uC_GetSaleData1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uC_GetSaleData1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_GetSaleData1.Location = new System.Drawing.Point(-3, 0);
            this.uC_GetSaleData1.Name = "uC_GetSaleData1";
            this.uC_GetSaleData1.Size = new System.Drawing.Size(1048, 669);
            this.uC_GetSaleData1.TabIndex = 5;
            // 
            // uC_GetData1
            // 
            this.uC_GetData1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_GetData1.AutoScroll = true;
            this.uC_GetData1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uC_GetData1.BackColor = System.Drawing.Color.MidnightBlue;
            this.uC_GetData1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_GetData1.BackgroundImage")));
            this.uC_GetData1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_GetData1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_GetData1.Location = new System.Drawing.Point(0, 0);
            this.uC_GetData1.Name = "uC_GetData1";
            this.uC_GetData1.Size = new System.Drawing.Size(1048, 669);
            this.uC_GetData1.TabIndex = 4;
            // 
            // uC_Home1
            // 
            this.uC_Home1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Home1.BackgroundImage")));
            this.uC_Home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_Home1.Location = new System.Drawing.Point(0, 0);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1045, 669);
            this.uC_Home1.TabIndex = 1;
            // 
            // ElipseHome
            // 
            this.ElipseHome.TargetControl = this.HomePnannel;
            // 
            // ElipseFactory
            // 
            this.ElipseFactory.TargetControl = this.HomePnannel;
            // 
            // SaleDataElips
            // 
            this.SaleDataElips.TargetControl = this.HomePnannel;
            // 
            // ExportElipse
            // 
            this.ExportElipse.TargetControl = this.HomePnannel;
            // 
            // ProductionElipse
            // 
            this.ProductionElipse.TargetControl = this.HomePnannel;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1357, 815);
            this.Controls.Add(this.TopHomePannel);
            this.Controls.Add(this.HomePnannel);
            this.Controls.Add(this.btnPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.TopHomePannel.ResumeLayout(false);
            this.TopHomePannel.PerformLayout();
            this.HomePnannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnPannel;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.Panel TopHomePannel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnLoadData;
        private Guna.UI2.WinForms.Guna2Button btnProduction;
        private Guna.UI2.WinForms.Guna2Button btnSale;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel HomePnannel;
        private Guna.UI2.WinForms.Guna2Elipse ElipseHome;
        private All_User_Controllers.UC_Home uC_Home1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseFactory;
       
        private All_User_Controllers.UC_GetData uC_GetData1;
        private Guna.UI2.WinForms.Guna2Elipse SaleDataElips;
        private All_User_Controllers.UC_GetSaleData uC_GetSaleData1;
        private Guna.UI2.WinForms.Guna2Elipse ExportElipse;
        private All_User_Controllers.UC_ExportData uC_ExportData1;
        private Guna.UI2.WinForms.Guna2Elipse ProductionElipse;
        private All_User_Controllers.UC_Production uC_Production1;
    }
}

