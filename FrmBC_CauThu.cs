using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyDoiBong
{
    public partial class FrmBC_CauThu : Form
    {
        DataTable cauthu;
        public FrmBC_CauThu()
        {
            InitializeComponent();
        }

     
        private void FrmBC_CauThu_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            GridViewBC_Cauthu.DataSource = null;
            DAO.CloseConnetion();
        }
       
    

        private void btnHienThi_Click_1(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM cauthu";
            cauthu = DAO.GetDataToTable(sql);
            GridViewBC_Cauthu.DataSource = cauthu;
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable cauthu;
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
            exRange.Range["E2:H2"].Value = "Báo cáo danh sách các cầu thủ";
            //Lấy thông tin các mặt hàng
            sql = "SELECT * FROM cauthu";
            cauthu = DAO.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A4:L4"].Font.Bold = true;
            exRange.Range["A4:L4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:L4"].ColumnWidth = 16;
            exRange.Range["A4:A4"].Value = "STT";
            exRange.Range["B4:B4"].Value = "Mã cầu thủ";
            exRange.Range["C4:C4"].Value = "Mã đội";
            exRange.Range["D4:D4"].Value = "Tên cầu thủ";
            exRange.Range["E4:E4"].Value = "Vị trí";

            exRange.Range["F4:F4"].Value = "Ngày sinh";
            exRange.Range["G4:G4"].Value = "Số áo";
            exRange.Range["H4:H4"].Value = "Số bàn thắng";
            exRange.Range["I4:I4"].Value = "Số thẻ vàng";
            exRange.Range["J4:J4"].Value = "Số thẻ đỏ";
            exRange.Range["K4:K4"].Value = "Mã quốc tịch";
            exRange.Range["L4:L4"].Value = "Số lần ra sân";
            for (hang = 0; hang <= cauthu.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 5
                exSheet.Cells[1][hang + 5] = hang + 1;
                for (cot = 0; cot <= cauthu.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 5
                    exSheet.Cells[cot + 2][hang + 5] = cauthu.Rows[hang][cot].ToString();
            }
            exSheet.Name = "Báo cáo 1";
            exApp.Visible = true;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
