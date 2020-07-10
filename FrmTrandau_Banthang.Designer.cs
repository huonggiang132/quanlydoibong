namespace QuanLyDoiBong
{
    partial class FrmTrandau_Banthang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrandau_Banthang));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatran = new System.Windows.Forms.TextBox();
            this.GridViewTrandau_Banthang = new System.Windows.Forms.DataGridView();
            this.matrandau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macauthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianphut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMacauthu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThoigian = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.sobanthangdoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTrandau_Banthang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(135, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã trận đấu:";
            // 
            // txtMatran
            // 
            this.txtMatran.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatran.Location = new System.Drawing.Point(256, 122);
            this.txtMatran.Name = "txtMatran";
            this.txtMatran.Size = new System.Drawing.Size(127, 28);
            this.txtMatran.TabIndex = 2;
            // 
            // GridViewTrandau_Banthang
            // 
            this.GridViewTrandau_Banthang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTrandau_Banthang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrandau,
            this.macauthu,
            this.thoigianphut,
            this.ghichu,
            this.sobanthangdoinha});
            this.GridViewTrandau_Banthang.Location = new System.Drawing.Point(126, 258);
            this.GridViewTrandau_Banthang.Name = "GridViewTrandau_Banthang";
            this.GridViewTrandau_Banthang.RowHeadersWidth = 51;
            this.GridViewTrandau_Banthang.RowTemplate.Height = 24;
            this.GridViewTrandau_Banthang.Size = new System.Drawing.Size(683, 179);
            this.GridViewTrandau_Banthang.TabIndex = 3;
            this.GridViewTrandau_Banthang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewTrandau_Banthang_CellContentClick);
            // 
            // matrandau
            // 
            this.matrandau.DataPropertyName = "matrandau";
            this.matrandau.HeaderText = "Mã trận đấu ";
            this.matrandau.MinimumWidth = 6;
            this.matrandau.Name = "matrandau";
            this.matrandau.Width = 125;
            // 
            // macauthu
            // 
            this.macauthu.DataPropertyName = "macauthu";
            this.macauthu.HeaderText = "Mã cầu thủ";
            this.macauthu.MinimumWidth = 6;
            this.macauthu.Name = "macauthu";
            this.macauthu.Width = 125;
            // 
            // thoigianphut
            // 
            this.thoigianphut.DataPropertyName = "thoigianphut";
            this.thoigianphut.HeaderText = "Thời gian phút";
            this.thoigianphut.MinimumWidth = 6;
            this.thoigianphut.Name = "thoigianphut";
            this.thoigianphut.Width = 125;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(135, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã cầu thủ:";
            // 
            // txtMacauthu
            // 
            this.txtMacauthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMacauthu.Location = new System.Drawing.Point(256, 180);
            this.txtMacauthu.Name = "txtMacauthu";
            this.txtMacauthu.Size = new System.Drawing.Size(127, 28);
            this.txtMacauthu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(494, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian phút:";
            // 
            // txtThoigian
            // 
            this.txtThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThoigian.Location = new System.Drawing.Point(636, 123);
            this.txtThoigian.Name = "txtThoigian";
            this.txtThoigian.Size = new System.Drawing.Size(139, 28);
            this.txtThoigian.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(498, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ghi chú:";
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtghichu.Location = new System.Drawing.Point(636, 177);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(139, 28);
            this.txtghichu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(246, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "TRẬN ĐẤU - BÀN THẮNG";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHienThi.Image = global::QuanLyDoiBong.Properties.Resources.hiển_thị;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(471, 471);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(130, 44);
            this.btnHienThi.TabIndex = 4;
            this.btnHienThi.Text = "     Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(806, 471);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 44);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "    Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Image = global::QuanLyDoiBong.Properties.Resources.lưu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(648, 471);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 44);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::QuanLyDoiBong.Properties.Resources.xóa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(329, 471);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 44);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QuanLyDoiBong.Properties.Resources.sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(180, 471);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 44);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(30, 471);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // sobanthangdoinha
            // 
            this.sobanthangdoinha.HeaderText = "số bàn thắng đội nhà";
            this.sobanthangdoinha.MinimumWidth = 6;
            this.sobanthangdoinha.Name = "sobanthangdoinha";
            this.sobanthangdoinha.Width = 125;
            // 
            // FrmTrandau_Banthang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1016, 566);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.GridViewTrandau_Banthang);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThoigian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMacauthu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatran);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTrandau_Banthang";
            this.Text = "Trận đấu - Bàn thắng";
            this.Load += new System.EventHandler(this.FrmTrandau_Banthang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTrandau_Banthang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatran;
        private System.Windows.Forms.DataGridView GridViewTrandau_Banthang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMacauthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThoigian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrandau;
        private System.Windows.Forms.DataGridViewTextBoxColumn macauthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianphut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthangdoinha;
    }
}