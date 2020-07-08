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
using System.Data.Sql;
using System.IO;

namespace QuanLyDoiBong
{
    public partial class FrmCauThu : Form
    {
        
        public FrmCauThu()
        {
            InitializeComponent();
        }

        private void FrmCauThu_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDataToGrivew();
            cmbMaDoi.SelectedIndex = -1;
            DAO.FillDataToCombo("select madoi from cauthu", cmbMaDoi, "madoi", "madoi");
            DAO.CloseConnetion();
        }
        private void LoadDataToGrivew()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from cauthu";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable cauthu = new DataTable();
                myAdapter.Fill(cauthu);
                GridViewCauThu.DataSource = cauthu;

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

        private void GridViewCauThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string madoi;
            txtMaCT.Text = GridViewCauThu.CurrentRow.Cells["macauthu"].Value.ToString();
            //madoi = GridViewCauThu.CurrentRow.Cells["madoi"].Value.ToString();
            txtTenCT.Text = GridViewCauThu.CurrentRow.Cells["tencauthu"].Value.ToString();
            txtViTri.Text = GridViewCauThu.CurrentRow.Cells["vitri"].Value.ToString();
            txtNgaySinh.Text = GridViewCauThu.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtSoAo.Text = GridViewCauThu.CurrentRow.Cells["soao"].Value.ToString();
            txtMaQuocTich.Text = GridViewCauThu.CurrentRow.Cells["maquoctich"].Value.ToString();
            //txtAnh.Text = GridViewCauThu.CurrentRow.Cells["anh"].Value.ToString();
            //picAnh.Image = Image.FromFile(txtAnh.Text);
            //cmbMaDoi.Text = DAO.GetFieldValues("SELECT tendoi FROM cauthu inner join doibong on cauthu.madoi=doibong.madoi where cauthu.madoi = '" + madoi + "'");
            cmbMaDoi.Text = GridViewCauThu.CurrentRow.Cells["MaDoi"].Value.ToString();
            txtMaCT.Enabled = false;
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
                picAnhCT.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            txtMaCT.Text = "";
            txtTenCT.Text = "";
            txtViTri.Text = "";
            txtNgaySinh.Text = "";
            txtSoAo.Text = "";
            txtMaQuocTich.Text = "";
            txtAnh.Text = "";
            //txtSoBanThang.Text = "0";
            //picAnh.Image = null;
            cmbMaDoi.SelectedIndex = -1;
            txtMaCT.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from cauthu where macauthu = '" + txtMaCT.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnetion();
            LoadDataToGrivew();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update cauthu set madoi = '" + cmbMaDoi.SelectedValue.ToString() + "', tencauthu = N'" + txtTenCT.Text.Trim().ToString() +
                "', vitri ='" + txtViTri.Text.Trim() + "', ngaysinh ='" + txtNgaySinh.Text.Trim() + "',soao ='" + txtSoAo.Text.Trim() + /*", anh = '" + txtAnh.Text +*/
                "' where macauthu = '" + txtMaCT.Text + "'";
            
            DAO.GetDataToTable(sql);
            LoadDataToGrivew();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMaCT.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã cầu thủ");
                txtMaCT.Focus();
                return;
            }
            if (cmbMaDoi.Text == "")
            {
                MessageBox.Show("bạn chưa chọn mã đội");
                cmbMaDoi.Focus();
                return;
            }
            if (txtTenCT.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên cầu thủ");
                txtTenCT.Focus();
                return;
            }
            if (txtViTri.Text == "")
            {
                MessageBox.Show("bạn chưa nhập vị trí của cầu thủ");
                txtViTri.Focus();
                return;
            }
            if (txtNgaySinh.Text == "")
            {
                MessageBox.Show("bạn chưa nhập ngày sinh");
                txtNgaySinh.Focus();
                return;
            }
            if (txtSoAo.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số áo");
                txtSoAo.Focus();
                return;
            }
            if (txtMaQuocTich.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã quốc tịch");
                txtMaQuocTich.Focus();
                return;
            }
            /*if (txtAnh.Text == "")
            {
                MessageBox.Show("bạn chưa chọn ảnh minh họa");
                txtAnh.Focus();
                return;
            }*/
            sql = "select * from cauthu where macauthu = '" + txtMaCT.Text.Trim() + "'";
            
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("mã cầu thủ đã tồn tại");
                
                txtMaCT.Focus();
                return;
            }
            else
            {
                
                sql = " insert into cauthu (macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan) " +
                    " values('" 
                    + txtMaCT.Text.Trim() + "',N'"
                    + cmbMaDoi.SelectedValue + "',N'" 
                    + txtTenCT.Text.Trim() + "',N'" 
                    + txtViTri.Text.Trim() + "',N'" 
                    + txtNgaySinh.Text.Trim() + "',N'" 
                    + txtSoAo.Text.Trim() +  "',null,null,null,'"
                    + txtMaQuocTich.Text.Trim() + "',null)";
                
                MessageBox.Show(sql);

                DAO.LoadDataToTable(sql);
                DAO.CloseConnetion();
                LoadDataToGrivew();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            if ((txtTenCT.Text == "") && (cmbMaDoi.Text == "") && (txtSobanthang.Text == ""))
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm!!!");
                return;
            }
            string sql = "select * from cauthu where 1=1";
            if (txtTenCT.Text != "")
            {
                sql = sql + " and tencauthu = N'" + txtTenCT.Text + "'";

            }
            if (cmbMaDoi.Text != "")
            {
                sql = sql + "  and madoi = '" + cmbMaDoi.SelectedValue + "'";

            }
            if (txtSobanthang.Text != "")
            {
                sql = sql + "  and sobanthang = " + txtSobanthang.Text;

            }
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!");
            else
                MessageBox.Show("Có " + table.Rows.Count + " bản ghi thỏa mãn điều kiện!!!");
            GridViewCauThu.DataSource = table;
            SqlCommand cmd = new SqlCommand(sql, DAO.conn)
            {
                CommandText = sql,
                Connection = DAO.conn
            };
            cmd.ExecuteNonQuery();
            DAO.CloseConnetion();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
