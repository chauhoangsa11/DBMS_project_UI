﻿namespace WindowsFormsApp1
{
    partial class frmdsnhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdsnhanvien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timkiem = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_idnv = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_hovaten = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_nsinh = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txt_search = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_sdt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_cmnd = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_user = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_timid = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuTileButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_dilam = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_sua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_them = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_quenmk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Id nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(452, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cmnd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(455, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sdt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(455, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_timkiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_timkiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.ForeColor = System.Drawing.Color.White;
            this.txt_timkiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_timkiem.Location = new System.Drawing.Point(150, 23);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(157, 31);
            this.txt_timkiem.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel2.Location = new System.Drawing.Point(150, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 1);
            this.panel2.TabIndex = 70;
            // 
            // txt_idnv
            // 
            this.txt_idnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_idnv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_idnv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idnv.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idnv.ForeColor = System.Drawing.Color.White;
            this.txt_idnv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_idnv.Location = new System.Drawing.Point(159, 69);
            this.txt_idnv.Name = "txt_idnv";
            this.txt_idnv.Size = new System.Drawing.Size(109, 31);
            this.txt_idnv.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel1.Location = new System.Drawing.Point(159, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 1);
            this.panel1.TabIndex = 72;
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_hovaten.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_hovaten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hovaten.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hovaten.ForeColor = System.Drawing.Color.White;
            this.txt_hovaten.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_hovaten.Location = new System.Drawing.Point(159, 120);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(225, 31);
            this.txt_hovaten.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel3.Location = new System.Drawing.Point(159, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 1);
            this.panel3.TabIndex = 74;
            // 
            // dt_nsinh
            // 
            this.dt_nsinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dt_nsinh.BorderRadius = 45;
            this.dt_nsinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.dt_nsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_nsinh.FormatCustom = null;
            this.dt_nsinh.Location = new System.Drawing.Point(176, 172);
            this.dt_nsinh.Margin = new System.Windows.Forms.Padding(9);
            this.dt_nsinh.Name = "dt_nsinh";
            this.dt_nsinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dt_nsinh.Size = new System.Drawing.Size(220, 44);
            this.dt_nsinh.TabIndex = 76;
            this.dt_nsinh.Value = new System.DateTime(2020, 12, 6, 22, 43, 10, 50);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_search.Location = new System.Drawing.Point(578, 20);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(236, 31);
            this.txt_search.TabIndex = 78;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel4.Location = new System.Drawing.Point(578, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 77;
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_sdt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.ForeColor = System.Drawing.Color.White;
            this.txt_sdt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_sdt.Location = new System.Drawing.Point(578, 74);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(157, 31);
            this.txt_sdt.TabIndex = 80;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel5.Location = new System.Drawing.Point(578, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 1);
            this.panel5.TabIndex = 79;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_cmnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_cmnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cmnd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.ForeColor = System.Drawing.Color.White;
            this.txt_cmnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_cmnd.Location = new System.Drawing.Point(578, 136);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(157, 31);
            this.txt_cmnd.TabIndex = 82;
            this.txt_cmnd.TextChanged += new System.EventHandler(this.txt_cmnd_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel6.Location = new System.Drawing.Point(578, 169);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 1);
            this.panel6.TabIndex = 81;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_user.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_user.Location = new System.Drawing.Point(578, 188);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(157, 31);
            this.txt_user.TabIndex = 84;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel7.Location = new System.Drawing.Point(578, 221);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(157, 1);
            this.panel7.TabIndex = 83;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btn_timid
            // 
            this.btn_timid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_timid.color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_timid.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_timid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timid.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_timid.Image = ((System.Drawing.Image)(resources.GetObject("btn_timid.Image")));
            this.btn_timid.ImagePosition = 14;
            this.btn_timid.ImageZoom = 50;
            this.btn_timid.LabelPosition = 0;
            this.btn_timid.LabelText = "";
            this.btn_timid.Location = new System.Drawing.Point(56, 4);
            this.btn_timid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_timid.Name = "btn_timid";
            this.btn_timid.Size = new System.Drawing.Size(72, 66);
            this.btn_timid.TabIndex = 85;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.color = System.Drawing.Color.White;
            this.btn_refresh.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImagePosition = 14;
            this.btn_refresh.ImageZoom = 50;
            this.btn_refresh.LabelPosition = 45;
            this.btn_refresh.LabelText = "Refresh";
            this.btn_refresh.Location = new System.Drawing.Point(43, 221);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(87, 102);
            this.btn_refresh.TabIndex = 86;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(38, 320);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 314);
            this.dataGridView1.TabIndex = 87;
            // 
            // btn_dilam
            // 
            this.btn_dilam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_dilam.color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_dilam.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dilam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dilam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dilam.ForeColor = System.Drawing.Color.White;
            this.btn_dilam.Image = ((System.Drawing.Image)(resources.GetObject("btn_dilam.Image")));
            this.btn_dilam.ImagePosition = 14;
            this.btn_dilam.ImageZoom = 50;
            this.btn_dilam.LabelPosition = 30;
            this.btn_dilam.LabelText = "Set đi làm";
            this.btn_dilam.Location = new System.Drawing.Point(952, 38);
            this.btn_dilam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dilam.Name = "btn_dilam";
            this.btn_dilam.Size = new System.Drawing.Size(100, 99);
            this.btn_dilam.TabIndex = 88;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 14;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 30;
            this.bunifuTileButton1.LabelText = "Reset";
            this.bunifuTileButton1.Location = new System.Drawing.Point(460, 221);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(87, 91);
            this.bunifuTileButton1.TabIndex = 89;
            // 
            // btn_xoa
            // 
            this.btn_xoa.ActiveBorderThickness = 1;
            this.btn_xoa.ActiveCornerRadius = 40;
            this.btn_xoa.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.BackgroundImage")));
            this.btn_xoa.ButtonText = "Xóa";
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.IdleBorderThickness = 1;
            this.btn_xoa.IdleCornerRadius = 40;
            this.btn_xoa.IdleFillColor = System.Drawing.Color.White;
            this.btn_xoa.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.Location = new System.Drawing.Point(936, 246);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(138, 60);
            this.btn_xoa.TabIndex = 92;
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_sua
            // 
            this.btn_sua.ActiveBorderThickness = 1;
            this.btn_sua.ActiveCornerRadius = 40;
            this.btn_sua.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sua.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.BackgroundImage")));
            this.btn_sua.ButtonText = "Sửa";
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.IdleBorderThickness = 1;
            this.btn_sua.IdleCornerRadius = 40;
            this.btn_sua.IdleFillColor = System.Drawing.Color.White;
            this.btn_sua.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.Location = new System.Drawing.Point(759, 246);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(138, 60);
            this.btn_sua.TabIndex = 91;
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_them
            // 
            this.btn_them.ActiveBorderThickness = 1;
            this.btn_them.ActiveCornerRadius = 40;
            this.btn_them.ActiveFillColor = System.Drawing.Color.White;
            this.btn_them.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_them.BackgroundImage")));
            this.btn_them.ButtonText = "Thêm";
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.IdleBorderThickness = 1;
            this.btn_them.IdleCornerRadius = 40;
            this.btn_them.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.IdleForecolor = System.Drawing.Color.White;
            this.btn_them.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.Location = new System.Drawing.Point(582, 246);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(138, 60);
            this.btn_them.TabIndex = 90;
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_quenmk
            // 
            this.btn_quenmk.ActiveBorderThickness = 1;
            this.btn_quenmk.ActiveCornerRadius = 40;
            this.btn_quenmk.ActiveFillColor = System.Drawing.Color.White;
            this.btn_quenmk.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_quenmk.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_quenmk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_quenmk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_quenmk.BackgroundImage")));
            this.btn_quenmk.ButtonText = "Mật khẩu theo username";
            this.btn_quenmk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quenmk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quenmk.ForeColor = System.Drawing.Color.White;
            this.btn_quenmk.IdleBorderThickness = 1;
            this.btn_quenmk.IdleCornerRadius = 40;
            this.btn_quenmk.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_quenmk.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_quenmk.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_quenmk.Location = new System.Drawing.Point(767, 176);
            this.btn_quenmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_quenmk.Name = "btn_quenmk";
            this.btn_quenmk.Size = new System.Drawing.Size(304, 60);
            this.btn_quenmk.TabIndex = 93;
            this.btn_quenmk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(402, 25);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(36, 298);
            this.bunifuSeparator1.TabIndex = 94;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // frmdsnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1200, 665);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btn_quenmk);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.btn_dilam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_timid);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dt_nsinh);
            this.Controls.Add(this.txt_hovaten);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_idnv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmdsnhanvien";
            this.Text = "frmdsnhanvien";
            this.Load += new System.EventHandler(this.frmdsnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_timkiem;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_idnv;
        private System.Windows.Forms.Panel panel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_hovaten;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDatepicker dt_nsinh;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_search;
        private System.Windows.Forms.Panel panel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_sdt;
        private System.Windows.Forms.Panel panel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_cmnd;
        private System.Windows.Forms.Panel panel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_user;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuTileButton btn_timid;
        private Bunifu.Framework.UI.BunifuTileButton btn_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuTileButton btn_dilam;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_xoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_sua;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_them;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_quenmk;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}