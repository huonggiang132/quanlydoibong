using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoiBong
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmCauThu());
            Application.Run(new FrmLogin());
            //Application.Run(new FrmBaoCaoTranDau());
            //Application.Run(new FrmTrandau_Cauthu());
            //Application.Run(new FrmTranDau());
            //Application.Run(new FrmTrandau_The());
        }
    }
}
