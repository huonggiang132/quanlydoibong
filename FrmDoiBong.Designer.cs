﻿namespace QuanLyDoiBong
{
    partial class FrmDoiBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiBong));
            this.GridViewDoiBong = new System.Windows.Forms.DataGridView();
            this.madoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongcauthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaDoi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaTinh = new System.Windows.Forms.TextBox();
            this.txtMaSan = new System.Windows.Forms.TextBox();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.txtHLV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.txtsobanthua = new System.Windows.Forms.TextBox();
            this.txtsobanthang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsoluongcauthu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoiBong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewDoiBong
            // 
            this.GridViewDoiBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDoiBong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madoi,
            this.tendoi,
            this.masan,
            this.HLV,
            this.matinh,
            this.diem,
            this.sobanthang,
            this.sobanthua,
            this.soluongcauthu});
            this.GridViewDoiBong.Location = new System.Drawing.Point(115, 353);
            this.GridViewDoiBong.Name = "GridViewDoiBong";
            this.GridViewDoiBong.RowHeadersWidth = 51;
            this.GridViewDoiBong.RowTemplate.Height = 24;
            this.GridViewDoiBong.Size = new System.Drawing.Size(806, 184);
            this.GridViewDoiBong.TabIndex = 0;
            this.GridViewDoiBong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDoiBong_CellClick);
            // 
            // madoi
            // 
            this.madoi.DataPropertyName = "madoi";
            this.madoi.HeaderText = "Mã đội";
            this.madoi.MinimumWidth = 6;
            this.madoi.Name = "madoi";
            this.madoi.Width = 125;
            // 
            // tendoi
            // 
            this.tendoi.DataPropertyName = "tendoi";
            this.tendoi.HeaderText = "Tên đội";
            this.tendoi.MinimumWidth = 6;
            this.tendoi.Name = "tendoi";
            this.tendoi.Width = 125;
            // 
            // masan
            // 
            this.masan.DataPropertyName = "masan";
            this.masan.HeaderText = "Mã sân";
            this.masan.MinimumWidth = 6;
            this.masan.Name = "masan";
            this.masan.Width = 125;
            // 
            // HLV
            // 
            this.HLV.DataPropertyName = "HLV";
            this.HLV.HeaderText = "Huấn luyện viên";
            this.HLV.MinimumWidth = 6;
            this.HLV.Name = "HLV";
            this.HLV.Width = 125;
            // 
            // matinh
            // 
            this.matinh.DataPropertyName = "matinh";
            this.matinh.HeaderText = "Mã tỉnh";
            this.matinh.MinimumWidth = 6;
            this.matinh.Name = "matinh";
            this.matinh.Width = 125;
            // 
            // diem
            // 
            this.diem.DataPropertyName = "diem";
            this.diem.HeaderText = "Điểm";
            this.diem.MinimumWidth = 6;
            this.diem.Name = "diem";
            this.diem.Width = 125;
            // 
            // sobanthang
            // 
            this.sobanthang.DataPropertyName = "sobanthang";
            this.sobanthang.HeaderText = "Số bàn thắng";
            this.sobanthang.MinimumWidth = 6;
            this.sobanthang.Name = "sobanthang";
            this.sobanthang.Width = 125;
            // 
            // sobanthua
            // 
            this.sobanthua.DataPropertyName = "sobanthua";
            this.sobanthua.HeaderText = "Số bàn thua";
            this.sobanthua.MinimumWidth = 6;
            this.sobanthua.Name = "sobanthua";
            this.sobanthua.Width = 125;
            // 
            // soluongcauthu
            // 
            this.soluongcauthu.DataPropertyName = "soluongcauthu";
            this.soluongcauthu.HeaderText = "Số lượng cầu thủ";
            this.soluongcauthu.MinimumWidth = 6;
            this.soluongcauthu.Name = "soluongcauthu";
            this.soluongcauthu.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(36, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đội:";
            // 
            // txtTenDoi
            // 
            this.txtTenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDoi.Location = new System.Drawing.Point(444, 103);
            this.txtTenDoi.Name = "txtTenDoi";
            this.txtTenDoi.Size = new System.Drawing.Size(155, 26);
            this.txtTenDoi.TabIndex = 4;
            this.txtTenDoi.TextChanged += new System.EventHandler(this.txtTenDoi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(319, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đội:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(36, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sân:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(321, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Huấn luyện viên:";
            // 
            // cmbMaDoi
            // 
            this.cmbMaDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaDoi.FormattingEnabled = true;
            this.cmbMaDoi.Location = new System.Drawing.Point(119, 105);
            this.cmbMaDoi.Name = "cmbMaDoi";
            this.cmbMaDoi.Size = new System.Drawing.Size(146, 28);
            this.cmbMaDoi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(36, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã tỉnh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(323, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Logo:";
            // 
            // txtMaTinh
            // 
            this.txtMaTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTinh.Location = new System.Drawing.Point(119, 161);
            this.txtMaTinh.Name = "txtMaTinh";
            this.txtMaTinh.Size = new System.Drawing.Size(146, 26);
            this.txtMaTinh.TabIndex = 4;
            // 
            // txtMaSan
            // 
            this.txtMaSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSan.Location = new System.Drawing.Point(119, 219);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.Size = new System.Drawing.Size(146, 26);
            this.txtMaSan.TabIndex = 4;
            // 
            // txtLogo
            // 
            this.txtLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLogo.Location = new System.Drawing.Point(444, 219);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(155, 26);
            this.txtLogo.TabIndex = 4;
            // 
            // txtHLV
            // 
            this.txtHLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHLV.Location = new System.Drawing.Point(485, 159);
            this.txtHLV.Name = "txtHLV";
            this.txtHLV.Size = new System.Drawing.Size(114, 26);
            this.txtHLV.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(383, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = "ĐỘI BÓNG";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(959, 93);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(154, 154);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpen.Image = global::QuanLyDoiBong.Properties.Resources.ẢNH;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(989, 273);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(101, 31);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "     Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(834, 571);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(103, 40);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "      Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Image = global::QuanLyDoiBong.Properties.Resources.lưu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(648, 571);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 40);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "     Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QuanLyDoiBong.Properties.Resources.sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(449, 571);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::QuanLyDoiBong.Properties.Resources.xóa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(260, 571);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::QuanLyDoiBong.Properties.Resources.thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(69, 571);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(653, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Điểm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(655, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số bàn thắng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(655, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số bàn thua:";
            // 
            // txtdiem
            // 
            this.txtdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdiem.Location = new System.Drawing.Point(791, 93);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(130, 26);
            this.txtdiem.TabIndex = 4;
            this.txtdiem.TextChanged += new System.EventHandler(this.txtTenDoi_TextChanged);
            // 
            // txtsobanthua
            // 
            this.txtsobanthua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsobanthua.Location = new System.Drawing.Point(791, 207);
            this.txtsobanthua.Name = "txtsobanthua";
            this.txtsobanthua.Size = new System.Drawing.Size(128, 26);
            this.txtsobanthua.TabIndex = 4;
            // 
            // txtsobanthang
            // 
            this.txtsobanthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsobanthang.Location = new System.Drawing.Point(791, 149);
            this.txtsobanthang.Name = "txtsobanthang";
            this.txtsobanthang.Size = new System.Drawing.Size(130, 26);
            this.txtsobanthang.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(657, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số lượng cầu thủ:";
            // 
            // txtsoluongcauthu
            // 
            this.txtsoluongcauthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsoluongcauthu.Location = new System.Drawing.Point(821, 260);
            this.txtsoluongcauthu.Name = "txtsoluongcauthu";
            this.txtsoluongcauthu.Size = new System.Drawing.Size(100, 26);
            this.txtsoluongcauthu.TabIndex = 4;
            // 
            // FrmDoiBong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1125, 646);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMaDoi);
            this.Controls.Add(this.txtsobanthang);
            this.Controls.Add(this.txtHLV);
            this.Controls.Add(this.txtsoluongcauthu);
            this.Controls.Add(this.txtsobanthua);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.txtMaSan);
            this.Controls.Add(this.txtMaTinh);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.txtTenDoi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.GridViewDoiBong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoiBong";
            this.Text = "Đội bóng";
            this.Load += new System.EventHandler(this.FrmDoiBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoiBong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewDoiBong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtTenDoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaDoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTinh;
        private System.Windows.Forms.TextBox txtMaSan;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.TextBox txtHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn masan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthua;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongcauthu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.TextBox txtsobanthua;
        private System.Windows.Forms.TextBox txtsobanthang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsoluongcauthu;
    }
}