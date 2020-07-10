using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyDoiBong
{
    public partial class FrmBaoCaoTranDau : Form
    {
        DataTable trandau;
        public FrmBaoCaoTranDau()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoTranDau_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            //GridViewBCtrandau.DataSource = null;
            DAO.CloseConnetion();

        }
        
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adap = new SqlDataAdapter(" select * from trandau "
                +"where matrandau like '%" + txtmatrandau.Text + "%'", DAO.conn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "trandau");
            GridViewBCtrandau.DataSource = ds.Tables["trandau"].DefaultView;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable trandau;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["E2:H2"].Font.Size = 16;
            exRange.Range["E2:H2"].Font.Name = "Times new roman";
            exRange.Range["E2:H2"].Font.Bold = true;
            exRange.Range["E2:H2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["E2:H2"].MergeCells = true;
            exRange.Range["E2:H2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["E2:H2"].Value = "Báo cáo thông tin kết quả trận đấu";
            //Lấy thông tin các mặt hàng
            sql = "SELECT * FROM trandau where matrandau like '%" + txtmatrandau.Text + "%'";
            trandau = DAO.LoadDataTable(sql);

            //Tạo dòng tiêu đề bảng
            exRange.Range["A4:L4"].Font.Bold = true;
            exRange.Range["A4:L4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:L4"].ColumnWidth = 16;
            exRange.Range["A4:A4"].Value = "STT";
            exRange.Range["B4:B4"].Value = "Mã trận đấu";
            exRange.Range["C4:C4"].Value = "Lượt đấu";
            exRange.Range["D4:D4"].Value = "Vòng đấu ";
            exRange.Range["E4:E4"].Value = "Mã đội nhà";

            exRange.Range["F4:F4"].Value = "Mã đội khách";
            exRange.Range["G4:G4"].Value = "Số bàn thắng đội nhà ";
            exRange.Range["H4:H4"].Value = "Số bàn thua đội nhà";
            exRange.Range["I4:I4"].Value = "Số thẻ vàng đội nhà";
            exRange.Range["J4:J4"].Value = "Số thẻ đỏ đội nhà";
            exRange.Range["K4:K4"].Value = "Số thẻ vàng đội khách";
            exRange.Range["L4:L4"].Value = "Số thẻ thỏ đội khách";
            exRange.Range["M4:M4"].Value = "Ghi chú";
            for (hang = 0; hang <= trandau.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 5
                exSheet.Cells[1][hang + 5] = hang + 1;
                for (cot = 0; cot <= trandau.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 5
                    exSheet.Cells[cot + 2][hang + 5] = trandau.Rows[hang][cot].ToString();
            }
            exSheet.Name = "Báo cáo 2";
            exApp.Visible = true;
        }
    }
}
