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
    public partial class FrmTrandau_Banthang : Form
    {
        public FrmTrandau_Banthang()
        {
            InitializeComponent();
        }

        private void FrmTrandau_Banthang_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDataToGrivew();
            DAO.CloseConnetion();
        }
        private void LoadDataToGrivew()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from trandau_banthang";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable trandau_banthang = new DataTable();
                myAdapter.Fill(trandau_banthang);
                GridViewTrandau_Banthang.DataSource = trandau_banthang;
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

        private void GridViewTrandau_Banthang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatran.Text = GridViewTrandau_Banthang.CurrentRow.Cells["matrandau"].Value.ToString();
            txtMacauthu.Text = GridViewTrandau_Banthang.CurrentRow.Cells["macauthu"].Value.ToString();
            txtThoigian.Text = GridViewTrandau_Banthang.CurrentRow.Cells["thoigianphut"].Value.ToString();
            txtghichu.Text = GridViewTrandau_Banthang.CurrentRow.Cells["ghichu"].Value.ToString();
            txtMatran.Enabled = false;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMatran.Text = "";
            txtMacauthu.Text = "";
            txtThoigian.Text = "";
            txtghichu.Text = "";
            txtMatran.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update trandau_banthang set macauthu='" + txtMacauthu.Text +
                "',ghichu ='" + txtghichu.Text + "'where matrandau = '" + txtMatran.Text + "'";
            DAO.LoadDataTable(sql);
            LoadDataToGrivew();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from trandau_banthang where macauthu = '" + txtMacauthu.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            DAO.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnetion();
            LoadDataToGrivew();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatran.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã trận đấu");
                txtMatran.Focus();
                return;
            }
            if (txtMacauthu.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã cầu thủ");
                txtMacauthu.Focus();
                return;
            }
            if (txtThoigian.Text == "")
            {
                MessageBox.Show("bạn chưa nhập thời gian phút");
                txtThoigian.Focus();
                return;
            }
            /*string sqlCheckKey = "Select * from trandau_banthang Where matrandau = '"
                                + txtMatran.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.checkKeyExit(sqlCheckKey))
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
                DAO.CloseConnetion();
                txtMatran.Focus();
                return;
            }*/

            else
            {

                string sql = " insert into trandau_banthang(matrandau,macauthu,thoigianphut,ghichu)  values('" + txtMatran.Text.Trim() + "','"
                    + txtMacauthu.Text.Trim() + "'," + txtThoigian.Text.Trim() + ",'" + txtghichu.Text.Trim() + "')";
                DAO.LoadDataTable(sql);
                LoadDataToGrivew();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adap = new SqlDataAdapter(" select * from trandau_banthang where matrandau like '%" + txtMatran.Text + "%'", DAO.conn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "trandau_banthang");
            GridViewTrandau_Banthang.DataSource = ds.Tables["trandau_banthang"].DefaultView;
        }
    }

}
