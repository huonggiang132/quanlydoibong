namespace QuanLyDoiBong
{
    partial class FrmTimKiemTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemTD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbthedo = new System.Windows.Forms.RadioButton();
            this.rbbanthang = new System.Windows.Forms.RadioButton();
            this.rbmadoinha = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.GridViewTimKiemTD = new System.Windows.Forms.DataGridView();
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemTD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbthedo);
            this.groupBox1.Controls.Add(this.rbbanthang);
            this.groupBox1.Controls.Add(this.rbmadoinha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(57, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn cách tìm kiếm";
            // 
            // rbthedo
            // 
            this.rbthedo.AutoSize = true;
            this.rbthedo.Location = new System.Drawing.Point(557, 43);
            this.rbthedo.Name = "rbthedo";
            this.rbthedo.Size = new System.Drawing.Size(209, 30);
            this.rbthedo.TabIndex = 0;
            this.rbthedo.TabStop = true;
            this.rbthedo.Text = "Số thẻ đỏ đội nhà ";
            this.rbthedo.UseVisualStyleBackColor = true;
            // 
            // rbbanthang
            // 
            this.rbbanthang.AutoSize = true;
            this.rbbanthang.Location = new System.Drawing.Point(239, 43);
            this.rbbanthang.Name = "rbbanthang";
            this.rbbanthang.Size = new System.Drawing.Size(239, 30);
            this.rbbanthang.TabIndex = 0;
            this.rbbanthang.TabStop = true;
            this.rbbanthang.Text = "Số bàn thắng đội nhà";
            this.rbbanthang.UseVisualStyleBackColor = true;
            // 
            // rbmadoinha
            // 
            this.rbmadoinha.AutoSize = true;
            this.rbmadoinha.Location = new System.Drawing.Point(33, 43);
            this.rbmadoinha.Name = "rbmadoinha";
            this.rbmadoinha.Size = new System.Drawing.Size(140, 30);
            this.rbmadoinha.TabIndex = 0;
            this.rbmadoinha.TabStop = true;
            this.rbmadoinha.Text = "Mã đội nhà";
            this.rbmadoinha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(190, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập :";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhap.Location = new System.Drawing.Point(284, 217);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(277, 30);
            this.txtNhap.TabIndex = 2;
            // 
            // GridViewTimKiemTD
            // 
            this.GridViewTimKiemTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTimKiemTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.GridViewTimKiemTD.Location = new System.Drawing.Point(51, 276);
            this.GridViewTimKiemTD.Name = "GridViewTimKiemTD";
            this.GridViewTimKiemTD.RowHeadersWidth = 51;
            this.GridViewTimKiemTD.RowTemplate.Height = 24;
            this.GridViewTimKiemTD.Size = new System.Drawing.Size(825, 246);
            this.GridViewTimKiemTD.TabIndex = 3;
            // 
            // matrandau
            // 
            this.matrandau.DataPropertyName = "matrandau";
            this.matrandau.HeaderText = "Mã trận đấu ";
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
            this.vongdau.HeaderText = "Vòng đấu ";
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
            this.sothedodoikhach.HeaderText = "Số thẻ đỏ đội khách";
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
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(843, 534);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 34);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Image = global::QuanLyDoiBong.Properties.Resources.tìm;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(583, 209);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(132, 42);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "      Tìm kiếm ";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "TÌM KIẾM TRẬN ĐẤU ";
            // 
            // FrmTimKiemTD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(958, 574);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.GridViewTimKiemTD);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTimKiemTD";
            this.Text = "TÌM KIẾM TRẬN ĐẤU ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbthedo;
        private System.Windows.Forms.RadioButton rbbanthang;
        private System.Windows.Forms.RadioButton rbmadoinha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.DataGridView GridViewTimKiemTD;
        private System.Windows.Forms.Button btnTim;
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
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
    }
}