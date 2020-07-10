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

namespace QuanLyDoiBong
{
    
    public partial class FrmDoiBong : Form
    {
        DataTable doibong;
        public FrmDoiBong()
        {
            InitializeComponent();
        }

        private void FrmDoiBong_Load(object sender, EventArgs e)
        {
            
            DAO.OpenConnection();
            LoadDataToGriview();
            DAO.FillDataToCombo("select madoi from DoiBong", cmbMaDoi, "madoi", "madoi");
            cmbMaDoi.SelectedIndex = -1;
            txtdiem.Text = "0";
            txtsobanthang.Text = "0";
            txtsobanthua.Text = "0";
            txtsoluongcauthu.Text = "0";

            txtdiem.ReadOnly = true;
            txtsobanthang.ReadOnly = true;
            txtsobanthua.ReadOnly = true;
            txtsoluongcauthu.ReadOnly = true;
            DAO.CloseConnetion();
        }
        private void LoadDataToGriview()
        {           

            try
            {

                DAO.OpenConnection();
                string sql = "select * from doibong";
                doibong = DAO.GetDataToTable(sql);
                GridViewDoiBong.DataSource = doibong;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnetion();
            }
        }

        private void GridViewDoiBong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* string ma;*/
            txtMaSan.Text = GridViewDoiBong.CurrentRow.Cells["MaSan"].Value.ToString();
            txtTenDoi.Text = GridViewDoiBong.CurrentRow.Cells["TenDoi"].Value.ToString();
            txtHLV.Text = GridViewDoiBong.CurrentRow.Cells["HLV"].Value.ToString();
            txtMaTinh.Text = GridViewDoiBong.CurrentRow.Cells["MaTinh"].Value.ToString();
            /*ma = GridViewDoiBong.CurrentRow.Cells["MaDoi"].Value.ToString();*/
            cmbMaDoi.Text = GridViewDoiBong.CurrentRow.Cells["MaDoi"].Value.ToString();
            //cmbMaDoi.Text = DAO.GetFieldValues("SELECT tendoi FROM doibong WHERE Madoi = N'" + ma + "'");
            //txtLogo.Text = DAO.GetFieldValues("SELECT logo FROM doibong WHERE tendoi = N'" + txtTenDoi.Text + "'");
            //txtLogo.Text = GridViewDoiBong.CurrentRow.Cells["Logo"].Value.ToString();
            //picLogo.Image = Image.FromFile(txtLogo.Text);
            /*cmbMaDoi.Text = GridViewDoiBong.CurrentRow.Cells["madoi"].Value.ToString();
            txtTenDoi.Text = GridViewDoiBong.CurrentRow.Cells["tendoi"].Value.ToString();
            txtMaSan.Text = GridViewDoiBong.CurrentRow.Cells["masan"].Value.ToString();
            txtHLV.Text = GridViewDoiBong.CurrentRow.Cells["HLV"].Value.ToString();
            txtMaTinh.Text = GridViewDoiBong.CurrentRow.Cells["matinh"].Value.ToString();
            cmbMaDoi.Enabled = false;*/
        }
        private void ResetValues()
        {
            txtMaSan.Text = "";
            txtTenDoi.Text = "";
            txtHLV.Text = "";
            txtMaTinh.Text = "";
           // txtLogo.Text = "";
            cmbMaDoi.SelectedIndex = -1;
            /*picLogo.Image = null;*/
        }

        private void txtTenDoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            ResetValues();
            int count = 0;
            count = GridViewDoiBong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(GridViewDoiBong.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 100)
            {
                cmbMaDoi.Text = "DB0" + (chuoi2 + 1).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DAO.OpenConnection();
            string sql;
            if (doibong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbMaDoi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE doibong WHERE madoi = '" + cmbMaDoi.Text + "'";
                DAO.LoadDataToTable(sql);

                DAO.CloseConnetion();
                LoadDataToGriview();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            DAO.OpenConnection();
            string sql;
            if (doibong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbMaDoi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Update doibong set TenDoi = N'" + txtTenDoi.Text.Trim().ToString() +
               "',HLV = N'" + txtHLV.Text.Trim().ToString() + "',MaTinh = N'" + txtMaTinh.Text.Trim().ToString() +
              /* "',Logo='" + txtLogo.Text +*/ "'where madoi = N'" + cmbMaDoi.SelectedValue.ToString() + "'";
            DAO.LoadDataToTable(sql);
            
            DAO.CloseConnetion();
            LoadDataToGriview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (cmbMaDoi.Text.Length == 0)
            {
                MessageBox.Show("Ban chua nhap ma doi");
                cmbMaDoi.Focus();
                return;
            }
            if (txtMaSan.Text == "")
            {
                MessageBox.Show("Ban chua nhap ma san");
                txtMaSan.Focus();
                return;
            }

            if (txtTenDoi.Text == "")
            {
                MessageBox.Show("Ban chua nhap ten doi");
                txtTenDoi.Focus();
                return;
            }

            if (txtHLV.Text == "")
            {
                MessageBox.Show("Ban chua nhap ten HLV");
                txtHLV.Focus();
                return;
            }

            if (txtMaTinh.Text == "")
            {
                MessageBox.Show("Ban chua nhap ma tinh");
                txtMaTinh.Focus();
                return;
            }

            /*if (txtLogo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban chua nhap Logo");
                txtLogo.Focus();
                return;
            }*/
            /*if (txtLogo.Text == "")
            {
                MessageBox.Show("Bạn cần nhập logo!");
                txtLogo.Focus();
                return;
            }*/

            sql = "Select madoi from doibong where madoi = '"
                                   + cmbMaDoi.Text + " ' ";


            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Ma doi da ton tai");

                cmbMaDoi.Focus();
                cmbMaDoi.Text = "";
                return;
            }
            else
            {
                sql = "insert into doibong (madoi,tendoi,masan,HLV,matinh,diem,sobanthang,sobanthua,soluongcauthu) " +
                    "values (' " +
                          cmbMaDoi.Text + "', N'" +
                          txtTenDoi.Text.Trim() + "', N'" +
                          txtMaSan.Text.Trim() + "' , N'" +
                          txtHLV.Text.Trim() + "', N'" +
                          txtMaTinh.Text.Trim() + "',null,null,null,null)";
                /*txtLogo.Text + "', N'" + ")"*/
                MessageBox.Show(sql);

                DAO.LoadDataToTable(sql);
                DAO.CloseConnetion();
                LoadDataToGriview();

            }
            
        }
            private void btnDong_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnOpen_Click(object sender, EventArgs e)
            {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
                dlgOpen.InitialDirectory = "D:\\";
                dlgOpen.FilterIndex = 2;
                dlgOpen.Title = "Chon hinh anh de hien thi";
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    picLogo.Image = Image.FromFile(dlgOpen.FileName);
                    txtLogo.Text = dlgOpen.FileName;
                }

            }

        
    }
}
