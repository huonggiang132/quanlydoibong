using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoiBong
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void cầuThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCauThu f1 = new FrmCauThu();
            f1.Show();
        }

        private void độiBóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiBong f1 = new FrmDoiBong();
            f1.Show();
        }

        private void trậnĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTranDau f1 = new FrmTranDau();
            f1.Show();

        }

        private void trậnĐấuCầuThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrandau_Cauthu f1 = new FrmTrandau_Cauthu();
            f1.Show();
        }

        private void trậnĐấuThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrandau_The f1 = new FrmTrandau_The();
            f1.Show();
        }

        private void trậnĐấuBànThắngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrandau_Banthang f1 = new FrmTrandau_Banthang();
            f1.Show();
        }
    }
}
