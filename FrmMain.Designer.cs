namespace QuanLyDoiBong
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cầuThủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độiBóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trậnĐấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trậnĐấuCầuThủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trậnĐấuThẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trậnĐấuBànThắngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cầuThủToolStripMenuItem,
            this.độiBóngToolStripMenuItem,
            this.trậnĐấuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cầuThủToolStripMenuItem
            // 
            this.cầuThủToolStripMenuItem.Name = "cầuThủToolStripMenuItem";
            this.cầuThủToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.cầuThủToolStripMenuItem.Text = "Cầu thủ";
            this.cầuThủToolStripMenuItem.Click += new System.EventHandler(this.cầuThủToolStripMenuItem_Click);
            // 
            // độiBóngToolStripMenuItem
            // 
            this.độiBóngToolStripMenuItem.Name = "độiBóngToolStripMenuItem";
            this.độiBóngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.độiBóngToolStripMenuItem.Text = "Đội bóng";
            this.độiBóngToolStripMenuItem.Click += new System.EventHandler(this.độiBóngToolStripMenuItem_Click);
            // 
            // trậnĐấuToolStripMenuItem
            // 
            this.trậnĐấuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trậnĐấuCầuThủToolStripMenuItem,
            this.trậnĐấuThẻToolStripMenuItem,
            this.trậnĐấuBànThắngToolStripMenuItem});
            this.trậnĐấuToolStripMenuItem.Name = "trậnĐấuToolStripMenuItem";
            this.trậnĐấuToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.trậnĐấuToolStripMenuItem.Text = "Trận đấu";
            this.trậnĐấuToolStripMenuItem.Click += new System.EventHandler(this.trậnĐấuToolStripMenuItem_Click);
            // 
            // trậnĐấuCầuThủToolStripMenuItem
            // 
            this.trậnĐấuCầuThủToolStripMenuItem.Name = "trậnĐấuCầuThủToolStripMenuItem";
            this.trậnĐấuCầuThủToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.trậnĐấuCầuThủToolStripMenuItem.Text = "Trận đấu - Cầu thủ";
            this.trậnĐấuCầuThủToolStripMenuItem.Click += new System.EventHandler(this.trậnĐấuCầuThủToolStripMenuItem_Click);
            // 
            // trậnĐấuThẻToolStripMenuItem
            // 
            this.trậnĐấuThẻToolStripMenuItem.Name = "trậnĐấuThẻToolStripMenuItem";
            this.trậnĐấuThẻToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.trậnĐấuThẻToolStripMenuItem.Text = "Trận đấu - Thẻ";
            this.trậnĐấuThẻToolStripMenuItem.Click += new System.EventHandler(this.trậnĐấuThẻToolStripMenuItem_Click);
            // 
            // trậnĐấuBànThắngToolStripMenuItem
            // 
            this.trậnĐấuBànThắngToolStripMenuItem.Name = "trậnĐấuBànThắngToolStripMenuItem";
            this.trậnĐấuBànThắngToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.trậnĐấuBànThắngToolStripMenuItem.Text = "Trận đấu - Bàn thắng";
            this.trậnĐấuBànThắngToolStripMenuItem.Click += new System.EventHandler(this.trậnĐấuBànThắngToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(221, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý bóng đá Việt Nam trong giải TPHCM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1096, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Quản lý đội bóng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cầuThủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độiBóngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trậnĐấuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem trậnĐấuCầuThủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trậnĐấuThẻToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trậnĐấuBànThắngToolStripMenuItem;
    }
}

