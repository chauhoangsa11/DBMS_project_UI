﻿namespace WindowsFormsApp1
{
    partial class frmdatdonhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdatdonhang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thanhtoan = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_dathang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_tongtien = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_chitiet = new System.Windows.Forms.DataGridView();
            this.dtg_doan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_xemdon = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doan)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(623, 15);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_thanhtoan);
            this.panel1.Controls.Add(this.btn_dathang);
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtg_chitiet);
            this.panel1.Location = new System.Drawing.Point(87, 256);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 379);
            this.panel1.TabIndex = 6;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.ActiveBorderThickness = 1;
            this.btn_thanhtoan.ActiveCornerRadius = 40;
            this.btn_thanhtoan.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_thanhtoan.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_thanhtoan.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_thanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_thanhtoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_thanhtoan.BackgroundImage")));
            this.btn_thanhtoan.ButtonText = "Thanh toán";
            this.btn_thanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.IdleBorderThickness = 1;
            this.btn_thanhtoan.IdleCornerRadius = 40;
            this.btn_thanhtoan.IdleFillColor = System.Drawing.Color.White;
            this.btn_thanhtoan.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_thanhtoan.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_thanhtoan.Location = new System.Drawing.Point(344, 292);
            this.btn_thanhtoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(160, 60);
            this.btn_thanhtoan.TabIndex = 78;
            this.btn_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dathang
            // 
            this.btn_dathang.ActiveBorderThickness = 1;
            this.btn_dathang.ActiveCornerRadius = 40;
            this.btn_dathang.ActiveFillColor = System.Drawing.Color.White;
            this.btn_dathang.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_dathang.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_dathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_dathang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dathang.BackgroundImage")));
            this.btn_dathang.ButtonText = "Đặt hàng";
            this.btn_dathang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dathang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dathang.ForeColor = System.Drawing.Color.White;
            this.btn_dathang.IdleBorderThickness = 1;
            this.btn_dathang.IdleCornerRadius = 40;
            this.btn_dathang.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_dathang.IdleForecolor = System.Drawing.Color.White;
            this.btn_dathang.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_dathang.Location = new System.Drawing.Point(160, 292);
            this.btn_dathang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_dathang.Name = "btn_dathang";
            this.btn_dathang.Size = new System.Drawing.Size(160, 60);
            this.btn_dathang.TabIndex = 77;
            this.btn_dathang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.txt_tongtien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_tongtien.BackgroundImage")));
            this.txt_tongtien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_tongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.txt_tongtien.Icon = ((System.Drawing.Image)(resources.GetObject("txt_tongtien.Icon")));
            this.txt_tongtien.Location = new System.Drawing.Point(293, 209);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(197, 52);
            this.txt_tongtien.TabIndex = 59;
            this.txt_tongtien.text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tổng tiền: ";
            // 
            // dtg_chitiet
            // 
            this.dtg_chitiet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtg_chitiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtg_chitiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_chitiet.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_chitiet.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_chitiet.Location = new System.Drawing.Point(36, 15);
            this.dtg_chitiet.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_chitiet.Name = "dtg_chitiet";
            this.dtg_chitiet.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_chitiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_chitiet.RowHeadersWidth = 51;
            this.dtg_chitiet.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtg_chitiet.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dtg_chitiet.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_chitiet.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dtg_chitiet.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtg_chitiet.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_chitiet.Size = new System.Drawing.Size(456, 178);
            this.dtg_chitiet.TabIndex = 41;
            // 
            // dtg_doan
            // 
            this.dtg_doan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtg_doan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtg_doan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_doan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_doan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_doan.Location = new System.Drawing.Point(86, 13);
            this.dtg_doan.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_doan.Name = "dtg_doan";
            this.dtg_doan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_doan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_doan.RowHeadersWidth = 51;
            this.dtg_doan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtg_doan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dtg_doan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_doan.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dtg_doan.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtg_doan.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_doan.Size = new System.Drawing.Size(493, 142);
            this.dtg_doan.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 32);
            this.label3.TabIndex = 60;
            this.label3.Text = "Số lượng khách: ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.comboBox1.BorderRadius = 45;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.comboBox1.Items = new string[0];
            this.comboBox1.Location = new System.Drawing.Point(300, 205);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.comboBox1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.comboBox1.selectedIndex = -1;
            this.comboBox1.Size = new System.Drawing.Size(107, 43);
            this.comboBox1.TabIndex = 61;
            // 
            // btn_xemdon
            // 
            this.btn_xemdon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xemdon.color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xemdon.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xemdon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xemdon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemdon.ForeColor = System.Drawing.Color.White;
            this.btn_xemdon.Image = ((System.Drawing.Image)(resources.GetObject("btn_xemdon.Image")));
            this.btn_xemdon.ImagePosition = 14;
            this.btn_xemdon.ImageZoom = 50;
            this.btn_xemdon.LabelPosition = 30;
            this.btn_xemdon.LabelText = "Xem đơn";
            this.btn_xemdon.Location = new System.Drawing.Point(513, 155);
            this.btn_xemdon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xemdon.Name = "btn_xemdon";
            this.btn_xemdon.Size = new System.Drawing.Size(103, 93);
            this.btn_xemdon.TabIndex = 62;
            // 
            // frmdatdonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(708, 650);
            this.Controls.Add(this.btn_xemdon);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtg_doan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmdatdonhang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_chitiet;
        private System.Windows.Forms.DataGridView dtg_doan;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox txt_tongtien;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown comboBox1;
        private Bunifu.Framework.UI.BunifuTileButton btn_xemdon;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_dathang;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_thanhtoan;
    }
}

