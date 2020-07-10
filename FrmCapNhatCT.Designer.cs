namespace QuanLyDoiBong
{
    partial class FrmCapNhatCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapNhatCT));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.GridViewCNCauthu = new System.Windows.Forms.DataGridView();
            this.macauthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobanthang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothevang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothedo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solanrasan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmacauthu = new System.Windows.Forms.TextBox();
            this.txtsobanthang = new System.Windows.Forms.TextBox();
            this.txtsothedo = new System.Windows.Forms.TextBox();
            this.txtsothevang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCNCauthu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::QuanLyDoiBong.Properties.Resources.sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(781, 319);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 45);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(781, 429);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 45);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "     Thoát";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // GridViewCNCauthu
            // 
            this.GridViewCNCauthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCNCauthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macauthu,
            this.sobanthang,
            this.sothevang,
            this.sothedo,
            this.solanrasan});
            this.GridViewCNCauthu.Location = new System.Drawing.Point(50, 276);
            this.GridViewCNCauthu.Name = "GridViewCNCauthu";
            this.GridViewCNCauthu.RowHeadersWidth = 51;
            this.GridViewCNCauthu.RowTemplate.Height = 24;
            this.GridViewCNCauthu.Size = new System.Drawing.Size(676, 225);
            this.GridViewCNCauthu.TabIndex = 1;
            this.GridViewCNCauthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCNCauthu_CellClick);
            // 
            // macauthu
            // 
            this.macauthu.DataPropertyName = "macauthu";
            this.macauthu.HeaderText = "Mã cầu thủ";
            this.macauthu.MinimumWidth = 6;
            this.macauthu.Name = "macauthu";
            this.macauthu.Width = 125;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "CẬP NHẬT BẢNG CẦU THỦ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(90, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã cầu thủ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(76, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số bàn thắng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(494, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số thẻ vàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(494, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số thẻ đỏ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtmacauthu
            // 
            this.txtmacauthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmacauthu.Location = new System.Drawing.Point(204, 141);
            this.txtmacauthu.Name = "txtmacauthu";
            this.txtmacauthu.Size = new System.Drawing.Size(100, 28);
            this.txtmacauthu.TabIndex = 3;
            // 
            // txtsobanthang
            // 
            this.txtsobanthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsobanthang.Location = new System.Drawing.Point(204, 203);
            this.txtsobanthang.Name = "txtsobanthang";
            this.txtsobanthang.Size = new System.Drawing.Size(112, 28);
            this.txtsobanthang.TabIndex = 3;
            // 
            // txtsothedo
            // 
            this.txtsothedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsothedo.Location = new System.Drawing.Point(615, 209);
            this.txtsothedo.Name = "txtsothedo";
            this.txtsothedo.Size = new System.Drawing.Size(111, 28);
            this.txtsothedo.TabIndex = 3;
            this.txtsothedo.TextChanged += new System.EventHandler(this.txtsothedo_TextChanged);
            // 
            // txtsothevang
            // 
            this.txtsothevang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsothevang.Location = new System.Drawing.Point(610, 142);
            this.txtsothevang.Name = "txtsothevang";
            this.txtsothevang.Size = new System.Drawing.Size(116, 28);
            this.txtsothevang.TabIndex = 3;
            // 
            // FrmCapNhatCT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(914, 594);
            this.Controls.Add(this.txtsothevang);
            this.Controls.Add(this.txtsothedo);
            this.Controls.Add(this.txtsobanthang);
            this.Controls.Add(this.txtmacauthu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewCNCauthu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCapNhatCT";
            this.Text = "CẬP NHẬP CẦU THỦ";
            this.Load += new System.EventHandler(this.FrmCapNhatCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCNCauthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView GridViewCNCauthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmacauthu;
        private System.Windows.Forms.TextBox txtsobanthang;
        private System.Windows.Forms.TextBox txtsothedo;
        private System.Windows.Forms.TextBox txtsothevang;
        private System.Windows.Forms.DataGridViewTextBoxColumn macauthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobanthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothevang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothedo;
        private System.Windows.Forms.DataGridViewTextBoxColumn solanrasan;
    }
}