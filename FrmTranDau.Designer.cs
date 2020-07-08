﻿namespace QuanLyDoiBong
{
    partial class FrmTranDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTranDau));
            this.GridViewTranDau = new System.Windows.Forms.DataGridView();
            this.matrandau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luotdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vongdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madoikhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthangdoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthuadoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothevangdoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothedodoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothevangdoikhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothedodoikhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLuotDau = new System.Windows.Forms.TextBox();
            this.txtVongDau = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cmbMaDoiKhach = new System.Windows.Forms.ComboBox();
            this.cmbMaDoiNha = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBanThangDN = new System.Windows.Forms.TextBox();
            this.txtTheDoDN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTranDau)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewTranDau
            // 
            this.GridViewTranDau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTranDau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrandau,
            this.luotdau,
            this.vongdau,
            this.madoinha,
            this.madoikhach,
            this.sobanthangdoinha,
            this.sobanthuadoinha,
            this.sothevangdoinha,
            this.sothedodoinha,
            this.sothevangdoikhach,
            this.sothedodoikhach,
            this.ghichu});
            this.GridViewTranDau.Location = new System.Drawing.Point(87, 279);
            this.GridViewTranDau.Name = "GridViewTranDau";
            this.GridViewTranDau.RowHeadersWidth = 51;
            this.GridViewTranDau.RowTemplate.Height = 24;
            this.GridViewTranDau.Size = new System.Drawing.Size(813, 197);
            this.GridViewTranDau.TabIndex = 1;
            this.GridViewTranDau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewTranDau_CellClick);
            // 
            // matrandau
            // 
            this.matrandau.DataPropertyName = "matrandau";
            this.matrandau.HeaderText = "Mã trận đấu";
            this.matrandau.MinimumWidth = 6;
            this.matrandau.Name = "matrandau";
            this.matrandau.Width = 125;
            // 
            // luotdau
            // 
            this.luotdau.DataPropertyName = "luotdau";
            this.luotdau.HeaderText = "Lượt đấu";
            this.luotdau.MinimumWidth = 6;
            this.luotdau.Name = "luotdau";
            this.luotdau.Width = 125;
            // 
            // vongdau
            // 
            this.vongdau.DataPropertyName = "vongdau";
            this.vongdau.HeaderText = "Vòng đấu";
            this.vongdau.MinimumWidth = 6;
            this.vongdau.Name = "vongdau";
            this.vongdau.Width = 125;
            // 
            // madoinha
            // 
            this.madoinha.DataPropertyName = "madoinha";
            this.madoinha.HeaderText = "Mã đội nhà";
            this.madoinha.MinimumWidth = 6;
            this.madoinha.Name = "madoinha";
            this.madoinha.Width = 125;
            // 
            // madoikhach
            // 
            this.madoikhach.DataPropertyName = "madoikhach";
            this.madoikhach.HeaderText = "Mã đội khách";
            this.madoikhach.MinimumWidth = 6;
            this.madoikhach.Name = "madoikhach";
            this.madoikhach.Width = 125;
            // 
            // sobanthangdoinha
            // 
            this.sobanthangdoinha.DataPropertyName = "sobanthangdoinha";
            this.sobanthangdoinha.HeaderText = "Số bàn thắng đội nhà";
            this.sobanthangdoinha.MinimumWidth = 6;
            this.sobanthangdoinha.Name = "sobanthangdoinha";
            this.sobanthangdoinha.Width = 125;
            // 
            // sobanthuadoinha
            // 
            this.sobanthuadoinha.DataPropertyName = "sobanthuadoinha";
            this.sobanthuadoinha.HeaderText = "Số bàn thua đội nhà";
            this.sobanthuadoinha.MinimumWidth = 6;
            this.sobanthuadoinha.Name = "sobanthuadoinha";
            this.sobanthuadoinha.Width = 125;
            // 
            // sothevangdoinha
            // 
            this.sothevangdoinha.DataPropertyName = "sothevangdoinha";
            this.sothevangdoinha.HeaderText = "Số thẻ vàng đội nhà";
            this.sothevangdoinha.MinimumWidth = 6;
            this.sothevangdoinha.Name = "sothevangdoinha";
            this.sothevangdoinha.Width = 125;
            // 
            // sothedodoinha
            // 
            this.sothedodoinha.DataPropertyName = "sothedodoinha";
            this.sothedodoinha.HeaderText = "Số thẻ đỏ đội nhà";
            this.sothedodoinha.MinimumWidth = 6;
            this.sothedodoinha.Name = "sothedodoinha";
            this.sothedodoinha.Width = 125;
            // 
            // sothevangdoikhach
            // 
            this.sothevangdoikhach.DataPropertyName = "sothevangdoikhach";
            this.sothevangdoikhach.HeaderText = "Số thẻ vàng đội khách";
            this.sothevangdoikhach.MinimumWidth = 6;
            this.sothevangdoikhach.Name = "sothevangdoikhach";
            this.sothevangdoikhach.Width = 125;
            // 
            // sothedodoikhach
            // 
            this.sothedodoikhach.DataPropertyName = "sothedodoikhach";
            this.sothedodoikhach.HeaderText = "Số thẻ đỏ đội khách ";
            this.sothedodoikhach.MinimumWidth = 6;
            this.sothedodoikhach.Name = "sothedodoikhach";
            this.sothedodoikhach.Width = 125;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(51, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã trận đấu :";
            // 
            // txtMaTran
            // 
            this.txtMaTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTran.Location = new System.Drawing.Point(177, 125);
            this.txtMaTran.Name = "txtMaTran";
            this.txtMaTran.Size = new System.Drawing.Size(130, 26);
            this.txtMaTran.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(51, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lượt đấu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(51, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vòng đấu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(375, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã đội khách :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(722, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã đội nhà :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(375, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ghi chú :";
            // 
            // txtLuotDau
            // 
            this.txtLuotDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuotDau.Location = new System.Drawing.Point(177, 175);
            this.txtLuotDau.Name = "txtLuotDau";
            this.txtLuotDau.Size = new System.Drawing.Size(130, 26);
            this.txtLuotDau.TabIndex = 3;
            // 
            // txtVongDau
            // 
            this.txtVongDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtVongDau.Location = new System.Drawing.Point(177, 219);
            this.txtVongDau.Name = "txtVongDau";
            this.txtVongDau.Size = new System.Drawing.Size(130, 26);
            this.txtVongDau.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(516, 194);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(122, 26);
            this.txtGhiChu.TabIndex = 3;
            // 
            // cmbMaDoiKhach
            // 
            this.cmbMaDoiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaDoiKhach.FormattingEnabled = true;
            this.cmbMaDoiKhach.Location = new System.Drawing.Point(516, 129);
            this.cmbMaDoiKhach.Name = "cmbMaDoiKhach";
            this.cmbMaDoiKhach.Size = new System.Drawing.Size(122, 28);
            this.cmbMaDoiKhach.TabIndex = 4;
            // 
            // cmbMaDoiNha
            // 
            this.cmbMaDoiNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaDoiNha.FormattingEnabled = true;
            this.cmbMaDoiNha.Location = new System.Drawing.Point(870, 128);
            this.cmbMaDoiNha.Name = "cmbMaDoiNha";
            this.cmbMaDoiNha.Size = new System.Drawing.Size(139, 28);
            this.cmbMaDoiNha.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(366, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 39);
            this.label7.TabIndex = 5;
            this.label7.Text = "TRẬN ĐẤU";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Image = global::QuanLyDoiBong.Properties.Resources.tìm;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(669, 503);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(139, 39);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "     Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(853, 503);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 39);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "    Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Image = global::QuanLyDoiBong.Properties.Resources.lưu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(514, 503);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 39);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QuanLyDoiBong.Properties.Resources.sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(363, 503);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 39);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::QuanLyDoiBong.Properties.Resources.xóa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(201, 503);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 39);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::QuanLyDoiBong.Properties.Resources.thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(48, 503);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(722, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số bàn thắng đội nhà :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(722, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số thẻ đỏ đội nhà :";
            // 
            // txtBanThangDN
            // 
            this.txtBanThangDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBanThangDN.Location = new System.Drawing.Point(929, 176);
            this.txtBanThangDN.Name = "txtBanThangDN";
            this.txtBanThangDN.Size = new System.Drawing.Size(80, 26);
            this.txtBanThangDN.TabIndex = 3;
            // 
            // txtTheDoDN
            // 
            this.txtTheDoDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTheDoDN.Location = new System.Drawing.Point(929, 219);
            this.txtTheDoDN.Name = "txtTheDoDN";
            this.txtTheDoDN.Size = new System.Drawing.Size(80, 26);
            this.txtTheDoDN.TabIndex = 3;
            // 
            // FrmTranDau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1060, 599);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMaDoiNha);
            this.Controls.Add(this.cmbMaDoiKhach);
            this.Controls.Add(this.txtTheDoDN);
            this.Controls.Add(this.txtBanThangDN);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtVongDau);
            this.Controls.Add(this.txtLuotDau);
            this.Controls.Add(this.txtMaTran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewTranDau);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTranDau";
            this.Text = "TRẬN ĐẤU ";
            this.Load += new System.EventHandler(this.FrmTranDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTranDau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView GridViewTranDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtLuotDau;
        private System.Windows.Forms.TextBox txtVongDau;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cmbMaDoiKhach;
        private System.Windows.Forms.ComboBox cmbMaDoiNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrandau;
        private System.Windows.Forms.DataGridViewTextBoxColumn luotdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn vongdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoikhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthangdoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthuadoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothevangdoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothedodoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothevangdoikhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothedodoikhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBanThangDN;
        private System.Windows.Forms.TextBox txtTheDoDN;
    }
}