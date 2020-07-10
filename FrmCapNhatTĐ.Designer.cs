namespace QuanLyDoiBong
{
    partial class FrmCapNhatTĐ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapNhatTĐ));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.GridViewCNTrandau = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmatran = new System.Windows.Forms.TextBox();
            this.txtbanthangDN = new System.Windows.Forms.TextBox();
            this.txtbanthuaDN = new System.Windows.Forms.TextBox();
            this.txtthevangDN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtthedoDN = new System.Windows.Forms.TextBox();
            this.txtthevangDK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtthedoDK = new System.Windows.Forms.TextBox();
            this.matrandau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthangdoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthuadoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothevangdoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothedodoinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothevangdoikhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothedodoikhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCNTrandau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QuanLyDoiBong.Properties.Resources.sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(777, 351);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 47);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(777, 439);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 42);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "     Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // GridViewCNTrandau
            // 
            this.GridViewCNTrandau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCNTrandau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrandau,
            this.sobanthangdoinha,
            this.sobanthuadoinha,
            this.sothevangdoinha,
            this.sothedodoinha,
            this.sothevangdoikhach,
            this.sothedodoikhach});
            this.GridViewCNTrandau.Location = new System.Drawing.Point(64, 314);
            this.GridViewCNTrandau.Name = "GridViewCNTrandau";
            this.GridViewCNTrandau.RowHeadersWidth = 51;
            this.GridViewCNTrandau.RowTemplate.Height = 24;
            this.GridViewCNTrandau.Size = new System.Drawing.Size(672, 198);
            this.GridViewCNTrandau.TabIndex = 2;
            this.GridViewCNTrandau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCNTrandau_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "CẬP NHẬT BẢNG TRẬN ĐẤU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(314, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã trận:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số bàn thắng đội nhà:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(34, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số bàn thua đội nhà:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(34, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số thẻ vàng đội nhà:";
            // 
            // txtmatran
            // 
            this.txtmatran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmatran.Location = new System.Drawing.Point(420, 102);
            this.txtmatran.Name = "txtmatran";
            this.txtmatran.Size = new System.Drawing.Size(100, 26);
            this.txtmatran.TabIndex = 4;
            // 
            // txtbanthangDN
            // 
            this.txtbanthangDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbanthangDN.Location = new System.Drawing.Point(236, 151);
            this.txtbanthangDN.Name = "txtbanthangDN";
            this.txtbanthangDN.Size = new System.Drawing.Size(100, 26);
            this.txtbanthangDN.TabIndex = 4;
            // 
            // txtbanthuaDN
            // 
            this.txtbanthuaDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtbanthuaDN.Location = new System.Drawing.Point(236, 198);
            this.txtbanthuaDN.Name = "txtbanthuaDN";
            this.txtbanthuaDN.Size = new System.Drawing.Size(100, 26);
            this.txtbanthuaDN.TabIndex = 4;
            // 
            // txtthevangDN
            // 
            this.txtthevangDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthevangDN.Location = new System.Drawing.Point(236, 250);
            this.txtthevangDN.Name = "txtthevangDN";
            this.txtthevangDN.Size = new System.Drawing.Size(100, 26);
            this.txtthevangDN.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(488, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số thẻ đỏ đội nhà:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(488, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số thẻ vàng đội khách:";
            // 
            // txtthedoDN
            // 
            this.txtthedoDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthedoDN.Location = new System.Drawing.Point(705, 145);
            this.txtthedoDN.Name = "txtthedoDN";
            this.txtthedoDN.Size = new System.Drawing.Size(100, 26);
            this.txtthedoDN.TabIndex = 4;
            // 
            // txtthevangDK
            // 
            this.txtthevangDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthevangDK.Location = new System.Drawing.Point(705, 191);
            this.txtthevangDK.Name = "txtthevangDK";
            this.txtthevangDK.Size = new System.Drawing.Size(100, 26);
            this.txtthevangDK.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(488, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số thẻ đỏ đội khách:";
            // 
            // txtthedoDK
            // 
            this.txtthedoDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthedoDK.Location = new System.Drawing.Point(705, 244);
            this.txtthedoDK.Name = "txtthedoDK";
            this.txtthedoDK.Size = new System.Drawing.Size(100, 26);
            this.txtthedoDK.TabIndex = 4;
            // 
            // matrandau
            // 
            this.matrandau.DataPropertyName = "matrandau";
            this.matrandau.HeaderText = "Mã trận đấu";
            this.matrandau.MinimumWidth = 6;
            this.matrandau.Name = "matrandau";
            this.matrandau.Width = 125;
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
            // FrmCapNhatTĐ
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(950, 566);
            this.Controls.Add(this.txtthevangDK);
            this.Controls.Add(this.txtthedoDN);
            this.Controls.Add(this.txtthedoDK);
            this.Controls.Add(this.txtthevangDN);
            this.Controls.Add(this.txtbanthuaDN);
            this.Controls.Add(this.txtbanthangDN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmatran);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewCNTrandau);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCapNhatTĐ";
            this.Text = "Cập nhật trận đấu";
            this.Load += new System.EventHandler(this.FrmCapNhatTĐ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCNTrandau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView GridViewCNTrandau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmatran;
        private System.Windows.Forms.TextBox txtbanthangDN;
        private System.Windows.Forms.TextBox txtbanthuaDN;
        private System.Windows.Forms.TextBox txtthevangDN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtthedoDN;
        private System.Windows.Forms.TextBox txtthevangDK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtthedoDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrandau;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthangdoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthuadoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothevangdoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothedodoinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothevangdoikhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothedodoikhach;
    }
}