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
    public partial class FrmTrandau_The : Form
    {
        public FrmTrandau_The()
        {
            InitializeComponent();
        }

        private void FrmTrandau_The_Load(object sender, EventArgs e)
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
                string sql = "select * from trandau_the";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable TranDau_The = new DataTable();
                myAdapter.Fill(TranDau_The);
                GridViewTranDau_The.DataSource = TranDau_The;
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
        private void GridViewTranDau_The_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTran.Text = GridViewTranDau_The.CurrentRow.Cells["matrandau"].Value.ToString();
            txtMaCT.Text = GridViewTranDau_The.CurrentRow.Cells["macauthu"].Value.ToString();
            txtThoigian.Text = GridViewTranDau_The.CurrentRow.Cells["thoigianphut"].Value.ToString();
            txtLoaiThe.Text = GridViewTranDau_The.CurrentRow.Cells["loaithe"].Value.ToString();
            txtGhichu.Text = GridViewTranDau_The.CurrentRow.Cells["ghichu"].Value.ToString();
            txtMaTran.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTran.Enabled = true;
            txtMaCT.Enabled = true;
            txtThoigian.Enabled = true;
            txtGhichu.Enabled = true;
            txtLoaiThe.Enabled = true;
            txtMaTran.Text = "";
            txtMaCT.Text = "";
            txtThoigian.Text = "";
            txtGhichu.Text = "";
            txtLoaiThe.Text = "";
            txtMaTran.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql = "update trandau_the set macauthu ='" + txtMaCT.Text + "',loaithe ='" + txtLoaiThe.Text +
                "',ghichu ='" + txtGhichu.Text + "'where matrandau = '" + txtMaTran.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.conn)
            {
                CommandText = sql,
                Connection = DAO.conn
            };
            cmd.ExecuteNonQuery();
            DAO.CloseConnetion();
            
            LoadDataToGrivew();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from trandau_the where matrandau  = '" + txtMaTran.Text.Trim() + "'";
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
            if (txtMaTran.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã trận đấu");
                txtMaTran.Focus();
                return;
            }
            if (txtMaCT.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã cầu thủ");
                txtMaCT.Focus();
                return;
            }
            if (txtLoaiThe.Text == "")
            {
                MessageBox.Show("bạn chưa nhập loai the");
                txtLoaiThe.Focus();
                return;
            }
            if (txtThoigian.Text == "")
            {
                MessageBox.Show("bạn chưa nhập thời gian phút");
                txtThoigian.Focus();
                return;
            }
            /*string sqlCheckKey = "Select * from TranDau_The Where MaTranDau = '"
                                + txtMaTranDau.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.checkKeyExit(sqlCheckKey))
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
                DAO.CloseConnetion();
                txtMaTranDau.Focus();
                return;
            }*/

            else
            {

                string sql = " insert into trandau_the(matrandau,macauthu,thoigianphut,loaithe,ghichu)"+"  values('" + txtMaTran.Text.Trim() + "','"
                    + txtMaCT.Text.Trim() + "','" + txtThoigian.Text.Trim() + "','" + txtLoaiThe.Text.Trim() + "','" + txtGhichu.Text.Trim() + "')";
                DAO.LoadDataTable(sql);
                LoadDataToGrivew();
            }
        
    }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adap = new SqlDataAdapter(" select * from trandau_the where matrandau like '%" + txtMaTran.Text + "%'", DAO.conn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "trandau_the");
            GridViewTranDau_The.DataSource = ds.Tables["trandau_the"].DefaultView;
        }
    }
}
