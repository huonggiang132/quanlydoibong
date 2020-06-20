namespace QuanLyDoiBong
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
            this.btnThem = new System.Windows.Forms.Button();
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtLuotDau = new System.Windows.Forms.TextBox();
            this.txtVongDau = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cmbMaDoiKhach = new System.Windows.Forms.ComboBox();
            this.cmbMaDoiNha = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTranDau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(73, 416);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.GridViewTranDau.Location = new System.Drawing.Point(38, 219);
            this.GridViewTranDau.Name = "GridViewTranDau";
            this.GridViewTranDau.RowHeadersWidth = 51;
            this.GridViewTranDau.RowTemplate.Height = 24;
            this.GridViewTranDau.Size = new System.Drawing.Size(797, 150);
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
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã trận đấu ";
            // 
            // txtMaTran
            // 
            this.txtMaTran.Location = new System.Drawing.Point(168, 34);
            this.txtMaTran.Name = "txtMaTran";
            this.txtMaTran.Size = new System.Drawing.Size(100, 22);
            this.txtMaTran.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lượt đấu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vòng đấu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã đội khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã đội nhà";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ghi chú";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(193, 416);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(331, 416);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(457, 416);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(607, 416);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtLuotDau
            // 
            this.txtLuotDau.Location = new System.Drawing.Point(168, 84);
            this.txtLuotDau.Name = "txtLuotDau";
            this.txtLuotDau.Size = new System.Drawing.Size(100, 22);
            this.txtLuotDau.TabIndex = 3;
            // 
            // txtVongDau
            // 
            this.txtVongDau.Location = new System.Drawing.Point(168, 136);
            this.txtVongDau.Name = "txtVongDau";
            this.txtVongDau.Size = new System.Drawing.Size(100, 22);
            this.txtVongDau.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(477, 138);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 22);
            this.txtGhiChu.TabIndex = 3;
            // 
            // cmbMaDoiKhach
            // 
            this.cmbMaDoiKhach.FormattingEnabled = true;
            this.cmbMaDoiKhach.Location = new System.Drawing.Point(477, 39);
            this.cmbMaDoiKhach.Name = "cmbMaDoiKhach";
            this.cmbMaDoiKhach.Size = new System.Drawing.Size(121, 24);
            this.cmbMaDoiKhach.TabIndex = 4;
            // 
            // cmbMaDoiNha
            // 
            this.cmbMaDoiNha.FormattingEnabled = true;
            this.cmbMaDoiNha.Location = new System.Drawing.Point(477, 84);
            this.cmbMaDoiNha.Name = "cmbMaDoiNha";
            this.cmbMaDoiNha.Size = new System.Drawing.Size(121, 24);
            this.cmbMaDoiNha.TabIndex = 4;
            // 
            // FrmTranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 483);
            this.Controls.Add(this.cmbMaDoiNha);
            this.Controls.Add(this.cmbMaDoiKhach);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtVongDau);
            this.Controls.Add(this.txtLuotDau);
            this.Controls.Add(this.txtMaTran);
            this.Controls.Add(this.label6);
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
            this.Name = "FrmTranDau";
            this.Text = "FrmTranDau";
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
    }
}