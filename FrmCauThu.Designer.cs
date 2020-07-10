namespace QuanLyDoiBong
{
    partial class FrmCauThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCauThu));
            this.GridViewCauThu = new System.Windows.Forms.DataGridView();
            this.macauthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencauthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothevang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothedo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquoctich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solanrasan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtMaQuocTich = new System.Windows.Forms.TextBox();
            this.txtSoAo = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.cmbMaDoi = new System.Windows.Forms.ComboBox();
            this.lable8 = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSobanthang = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.picAnhCT = new System.Windows.Forms.PictureBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoTheVang = new System.Windows.Forms.TextBox();
            this.txtsolanrasan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoTheDo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCauThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhCT)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewCauThu
            // 
            this.GridViewCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCauThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macauthu,
            this.madoi,
            this.tencauthu,
            this.vitri,
            this.ngaysinh,
            this.soao,
            this.sobanthang,
            this.sothevang,
            this.sothedo,
            this.maquoctich,
            this.solanrasan});
            this.GridViewCauThu.Location = new System.Drawing.Point(114, 362);
            this.GridViewCauThu.Name = "GridViewCauThu";
            this.GridViewCauThu.RowHeadersWidth = 51;
            this.GridViewCauThu.RowTemplate.Height = 24;
            this.GridViewCauThu.Size = new System.Drawing.Size(821, 173);
            this.GridViewCauThu.TabIndex = 0;
            this.GridViewCauThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCauThu_CellClick);
            // 
            // macauthu
            // 
            this.macauthu.DataPropertyName = "macauthu";
            this.macauthu.HeaderText = "Mã cầu thủ";
            this.macauthu.MinimumWidth = 6;
            this.macauthu.Name = "macauthu";
            this.macauthu.Width = 125;
            // 
            // madoi
            // 
            this.madoi.DataPropertyName = "madoi";
            this.madoi.HeaderText = "Mã đội bóng ";
            this.madoi.MinimumWidth = 6;
            this.madoi.Name = "madoi";
            this.madoi.Width = 125;
            // 
            // tencauthu
            // 
            this.tencauthu.DataPropertyName = "tencauthu";
            this.tencauthu.HeaderText = "Tên cầu thủ";
            this.tencauthu.MinimumWidth = 6;
            this.tencauthu.Name = "tencauthu";
            this.tencauthu.Width = 125;
            // 
            // vitri
            // 
            this.vitri.DataPropertyName = "vitri";
            this.vitri.HeaderText = "Vị trí";
            this.vitri.MinimumWidth = 6;
            this.vitri.Name = "vitri";
            this.vitri.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // soao
            // 
            this.soao.DataPropertyName = "soao";
            this.soao.HeaderText = "Số áo";
            this.soao.MinimumWidth = 6;
            this.soao.Name = "soao";
            this.soao.Width = 125;
            // 
            // sobanthang
            // 
            this.sobanthang.DataPropertyName = "sobanthang";
            this.sobanthang.HeaderText = "Số bàn thắng";
            this.sobanthang.MinimumWidth = 6;
            this.sobanthang.Name = "sobanthang";
            this.sobanthang.Width = 125;
            // 
            // sothevang
            // 
            this.sothevang.DataPropertyName = "sothevang";
            this.sothevang.HeaderText = "Số thẻ vàng";
            this.sothevang.MinimumWidth = 6;
            this.sothevang.Name = "sothevang";
            this.sothevang.Width = 125;
            // 
            // sothedo
            // 
            this.sothedo.DataPropertyName = "sothedo";
            this.sothedo.HeaderText = "Số thẻ đỏ";
            this.sothedo.MinimumWidth = 6;
            this.sothedo.Name = "sothedo";
            this.sothedo.Width = 125;
            // 
            // maquoctich
            // 
            this.maquoctich.DataPropertyName = "maquoctich";
            this.maquoctich.HeaderText = "Mã quốc tịch";
            this.maquoctich.MinimumWidth = 6;
            this.maquoctich.Name = "maquoctich";
            this.maquoctich.Width = 125;
            // 
            // solanrasan
            // 
            this.solanrasan.DataPropertyName = "solanrasan";
            this.solanrasan.HeaderText = "Số lần ra sân";
            this.solanrasan.MinimumWidth = 6;
            this.solanrasan.Name = "solanrasan";
            this.solanrasan.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã cầu thủ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(29, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đội:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(364, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên cầu thủ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(30, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vị trí:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(29, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(365, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số áo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(365, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã quốc tịch:";
            // 
            // txtTenCT
            // 
            this.txtTenCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenCT.Location = new System.Drawing.Point(494, 102);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(131, 26);
            this.txtTenCT.TabIndex = 3;
            // 
            // txtMaQuocTich
            // 
            this.txtMaQuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaQuocTich.Location = new System.Drawing.Point(497, 161);
            this.txtMaQuocTich.Name = "txtMaQuocTich";
            this.txtMaQuocTich.Size = new System.Drawing.Size(128, 26);
            this.txtMaQuocTich.TabIndex = 3;
            // 
            // txtSoAo
            // 
            this.txtSoAo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoAo.Location = new System.Drawing.Point(497, 219);
            this.txtSoAo.Name = "txtSoAo";
            this.txtSoAo.Size = new System.Drawing.Size(128, 26);
            this.txtSoAo.TabIndex = 3;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgaySinh.Location = new System.Drawing.Point(158, 218);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(143, 26);
            this.txtNgaySinh.TabIndex = 3;
            // 
            // txtViTri
            // 
            this.txtViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtViTri.Location = new System.Drawing.Point(158, 275);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(143, 26);
            this.txtViTri.TabIndex = 3;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaCT.Location = new System.Drawing.Point(158, 100);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(143, 26);
            this.txtMaCT.TabIndex = 3;
            this.txtMaCT.TextChanged += new System.EventHandler(this.txtMaCT_TextChanged);
            // 
            // cmbMaDoi
            // 
            this.cmbMaDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaDoi.FormattingEnabled = true;
            this.cmbMaDoi.Location = new System.Drawing.Point(158, 163);
            this.cmbMaDoi.Name = "cmbMaDoi";
            this.cmbMaDoi.Size = new System.Drawing.Size(143, 28);
            this.cmbMaDoi.TabIndex = 4;
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lable8.Location = new System.Drawing.Point(365, 277);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(50, 24);
            this.lable8.TabIndex = 1;
            this.lable8.Text = "Ảnh:";
            // 
            // txtAnh
            // 
            this.txtAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAnh.Location = new System.Drawing.Point(497, 277);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(128, 26);
            this.txtAnh.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(490, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "CẦU THỦ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(662, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số bàn thắng:";
            // 
            // txtSobanthang
            // 
            this.txtSobanthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSobanthang.Location = new System.Drawing.Point(795, 104);
            this.txtSobanthang.Name = "txtSobanthang";
            this.txtSobanthang.Size = new System.Drawing.Size(146, 26);
            this.txtSobanthang.TabIndex = 9;
            this.txtSobanthang.TextChanged += new System.EventHandler(this.txtSobanthang_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Image = global::QuanLyDoiBong.Properties.Resources.tìm;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(808, 577);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(136, 45);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "      Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(990, 577);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 45);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "     Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Image = global::QuanLyDoiBong.Properties.Resources.lưu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(515, 577);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 45);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QuanLyDoiBong.Properties.Resources.sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(368, 577);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 45);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpen.Image = global::QuanLyDoiBong.Properties.Resources.ẢNH;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(1017, 249);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 34);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "     Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::QuanLyDoiBong.Properties.Resources.xóa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(221, 577);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 45);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::QuanLyDoiBong.Properties.Resources.thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(74, 577);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 45);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // picAnhCT
            // 
            this.picAnhCT.Location = new System.Drawing.Point(995, 65);
            this.picAnhCT.Name = "picAnhCT";
            this.picAnhCT.Size = new System.Drawing.Size(135, 152);
            this.picAnhCT.TabIndex = 2;
            this.picAnhCT.TabStop = false;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHienThi.Image = global::QuanLyDoiBong.Properties.Resources.hiển_thị;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(644, 577);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(131, 45);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "     Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(662, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số thẻ vàng:";
            // 
            // txtSoTheVang
            // 
            this.txtSoTheVang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTheVang.Location = new System.Drawing.Point(795, 163);
            this.txtSoTheVang.Name = "txtSoTheVang";
            this.txtSoTheVang.Size = new System.Drawing.Size(146, 26);
            this.txtSoTheVang.TabIndex = 9;
            // 
            // txtsolanrasan
            // 
            this.txtsolanrasan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsolanrasan.Location = new System.Drawing.Point(795, 277);
            this.txtsolanrasan.Name = "txtsolanrasan";
            this.txtsolanrasan.Size = new System.Drawing.Size(146, 26);
            this.txtsolanrasan.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(662, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Số lần ra sân:";
            // 
            // txtSoTheDo
            // 
            this.txtSoTheDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTheDo.Location = new System.Drawing.Point(795, 219);
            this.txtSoTheDo.Name = "txtSoTheDo";
            this.txtSoTheDo.Size = new System.Drawing.Size(146, 26);
            this.txtSoTheDo.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(662, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Số thẻ đỏ:";
            // 
            // FrmCauThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1142, 634);
            this.Controls.Add(this.txtSoTheVang);
            this.Controls.Add(this.txtsolanrasan);
            this.Controls.Add(this.txtSoTheDo);
            this.Controls.Add(this.txtSobanthang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbMaDoi);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtMaCT);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.txtSoAo);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.txtMaQuocTich);
            this.Controls.Add(this.txtTenCT);
            this.Controls.Add(this.picAnhCT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lable8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewCauThu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCauThu";
            this.Text = "Cầu Thủ";
            this.Load += new System.EventHandler(this.FrmCauThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCauThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewCauThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picAnhCT;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtMaQuocTich;
        private System.Windows.Forms.TextBox txtSoAo;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.ComboBox cmbMaDoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn macauthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencauthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothevang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothedo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquoctich;
        private System.Windows.Forms.DataGridViewTextBoxColumn solanrasan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSobanthang;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoTheVang;
        private System.Windows.Forms.TextBox txtsolanrasan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoTheDo;
        private System.Windows.Forms.Label label11;
    }
}