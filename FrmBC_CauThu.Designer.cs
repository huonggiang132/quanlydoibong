﻿namespace QuanLyDoiBong
{
    partial class FrmBC_CauThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBC_CauThu));
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewBC_Cauthu = new System.Windows.Forms.DataGridView();
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBC_Cauthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(206, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO DANH SÁCH CẦU THỦ";
            // 
            // GridViewBC_Cauthu
            // 
            this.GridViewBC_Cauthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBC_Cauthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.GridViewBC_Cauthu.Location = new System.Drawing.Point(74, 178);
            this.GridViewBC_Cauthu.Name = "GridViewBC_Cauthu";
            this.GridViewBC_Cauthu.RowHeadersWidth = 51;
            this.GridViewBC_Cauthu.RowTemplate.Height = 24;
            this.GridViewBC_Cauthu.Size = new System.Drawing.Size(811, 179);
            this.GridViewBC_Cauthu.TabIndex = 2;
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
            this.madoi.HeaderText = "Mã đội bóng";
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
            this.soao.HeaderText = "Số áo ";
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
            this.sothedo.HeaderText = "Số thẻ đỏ ";
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
            this.solanrasan.HeaderText = "Số lần ra sân ";
            this.solanrasan.MinimumWidth = 6;
            this.solanrasan.Name = "solanrasan";
            this.solanrasan.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::QuanLyDoiBong.Properties.Resources.đóng__thoát;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(664, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 43);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "     Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIn.Image = global::QuanLyDoiBong.Properties.Resources._in;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(374, 396);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(159, 43);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "   In Báo Cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click_1);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHienThi.Image = global::QuanLyDoiBong.Properties.Resources.hiển_thị;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(143, 396);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(124, 43);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "      Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click_1);
            // 
            // FrmBC_CauThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(960, 513);
            this.Controls.Add(this.GridViewBC_Cauthu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHienThi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBC_CauThu";
            this.Text = "Báo cáo danh sách cầu thủ";
            this.Load += new System.EventHandler(this.FrmBC_CauThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBC_Cauthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridViewBC_Cauthu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
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
    }
}