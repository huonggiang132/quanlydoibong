namespace QuanLyDoiBong
{
    partial class FrmCapNhatĐB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapNhatĐB));
            this.GridViewCapNhatĐB = new System.Windows.Forms.DataGridView();
            this.madoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.txtsobanthang = new System.Windows.Forms.TextBox();
            this.txtsobanthua = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbmadoi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCapNhatĐB)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewCapNhatĐB
            // 
            this.GridViewCapNhatĐB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCapNhatĐB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madoi,
            this.diem,
            this.sobanthang,
            this.sobanthua});
            this.GridViewCapNhatĐB.Location = new System.Drawing.Point(162, 299);
            this.GridViewCapNhatĐB.Name = "GridViewCapNhatĐB";
            this.GridViewCapNhatĐB.RowHeadersWidth = 51;
            this.GridViewCapNhatĐB.RowTemplate.Height = 24;
            this.GridViewCapNhatĐB.Size = new System.Drawing.Size(551, 178);
            this.GridViewCapNhatĐB.TabIndex = 1;
            this.GridViewCapNhatĐB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCapNhatĐB_CellClick);
            // 
            // madoi
            // 
            this.madoi.DataPropertyName = "madoi";
            this.madoi.HeaderText = "Mã đội bóng";
            this.madoi.MinimumWidth = 6;
            this.madoi.Name = "madoi";
            this.madoi.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(94, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đội:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(101, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(473, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số bàn thắng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(250, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "CẬP NHẬT BẢNG ĐỘI BÓNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(473, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số bàn thua:";
            // 
            // txtdiem
            // 
            this.txtdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdiem.Location = new System.Drawing.Point(171, 188);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(121, 28);
            this.txtdiem.TabIndex = 3;
            // 
            // txtsobanthang
            // 
            this.txtsobanthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsobanthang.Location = new System.Drawing.Point(638, 165);
            this.txtsobanthang.Name = "txtsobanthang";
            this.txtsobanthang.Size = new System.Drawing.Size(100, 28);
            this.txtsobanthang.TabIndex = 3;
            // 
            // txtsobanthua
            // 
            this.txtsobanthua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsobanthua.Location = new System.Drawing.Point(638, 108);
            this.txtsobanthua.Name = "txtsobanthua";
            this.txtsobanthua.Size = new System.Drawing.Size(100, 28);
            this.txtsobanthua.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QuanLyDoiBong.Properties.Resources.sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(865, 330);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 50);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(865, 428);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 49);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "    Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbmadoi
            // 
            this.cmbmadoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbmadoi.FormattingEnabled = true;
            this.cmbmadoi.Location = new System.Drawing.Point(171, 124);
            this.cmbmadoi.Name = "cmbmadoi";
            this.cmbmadoi.Size = new System.Drawing.Size(121, 30);
            this.cmbmadoi.TabIndex = 4;
            // 
            // FrmCapNhatĐB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1021, 546);
            this.Controls.Add(this.cmbmadoi);
            this.Controls.Add(this.txtsobanthua);
            this.Controls.Add(this.txtsobanthang);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewCapNhatĐB);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCapNhatĐB";
            this.Text = "Cập nhật đội bóng";
            this.Load += new System.EventHandler(this.FrmCapNhatĐB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCapNhatĐB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridViewCapNhatĐB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.TextBox txtsobanthang;
        private System.Windows.Forms.TextBox txtsobanthua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbmadoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthua;
    }
}