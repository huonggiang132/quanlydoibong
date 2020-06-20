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
    public partial class FrmTranDau : Form
    {
        public FrmTranDau()
        {
            InitializeComponent();
        }

        private void FrmTranDau_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDataToGrivew();
            DAO.FillDataToCombo("select madoikhach from trandau", cmbMaDoiKhach, "madoikhach", "madoikhach");
            cmbMaDoiKhach.SelectedIndex = -1;
            DAO.FillDataToCombo("select madoinha from trandau", cmbMaDoiNha, "madoinha", "madoinha");
            cmbMaDoiNha.SelectedIndex = -1;
            DAO.CloseConnetion();

        }

        private void LoadDataToGrivew()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from trandau";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable trandau = new DataTable();
                myAdapter.Fill(trandau);
                GridViewTranDau.DataSource = trandau;
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

        private void GridViewTranDau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTran.Text = GridViewTranDau.CurrentRow.Cells["matrandau"].Value.ToString();
            txtLuotDau.Text = GridViewTranDau.CurrentRow.Cells["luotdau"].Value.ToString();
            txtVongDau.Text = GridViewTranDau.CurrentRow.Cells["vongdau"].Value.ToString();
            cmbMaDoiNha.Text = GridViewTranDau.CurrentRow.Cells["madoinha"].Value.ToString();
            cmbMaDoiKhach.Text = GridViewTranDau.CurrentRow.Cells["madoikhach"].Value.ToString();
            txtGhiChu.Text = GridViewTranDau.CurrentRow.Cells["ghichu"].Value.ToString();
            txtMaTran.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            txtMaTran.Enabled = true;
            txtLuotDau.Enabled = true;
            txtVongDau.Enabled = true;
            txtGhiChu.Enabled = true;
            txtMaTran.Text = "";
            txtLuotDau.Text = "";
            txtVongDau.Text = "";
            cmbMaDoiNha.SelectedIndex = -1;
            cmbMaDoiKhach.SelectedIndex = -1;
            txtGhiChu.Text = "";
           
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTran.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã trận đấu ");
                txtMaTran.Focus();
                return;
            }
            if (txtLuotDau.Text == "")
            {
                MessageBox.Show("bạn chưa nhập lượt đấu");
                txtLuotDau.Focus();
                return;
            }
            if (txtVongDau.Text == "")
            {
                MessageBox.Show("bạn chưa nhập vòng đấu");
                txtVongDau.Focus();
                return;
            }
            if (cmbMaDoiNha.Text == "")
            {
                MessageBox.Show("bạn chưa chọn mã đội nhà");
                cmbMaDoiNha.Focus();
                return;
            }
            if (cmbMaDoiKhach.Text == "")
            {
                MessageBox.Show("bạn chưa chọn mã đội khách");
                cmbMaDoiKhach.Focus();
                return;
            }
            string sqlCheckKey = "Select * from trandau Where matrandau = '"
                                + txtMaTran.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyExit(sqlCheckKey))
            {
                MessageBox.Show("Mã trận đấu đã tồn tại");
                DAO.CloseConnetion();
                txtMaTran.Focus();
                return;
            }
            else
            {
                string sql = "insert into trandau (matrandau,luotdau,vongdau,madoinha,madoikhach,sobanthangdoinha,sobanthuadoinha," +
                    "sothevangdoinha,sothedodoinha,sothevangdoikhach,sothedodoikhach,ghichu)" +
                    " values ('" + txtMaTran.Text.Trim() + "',N'" + txtLuotDau.Text.Trim() + "',N'"
                    + txtVongDau.Text.Trim() + "','" + cmbMaDoiNha.SelectedValue.ToString() + "','"
                    + cmbMaDoiKhach.SelectedValue.ToString() + "',null,null,null,null,null,null,'"
                    + txtGhiChu.Text.Trim() + "')";
                
                DAO.LoadDataTable(sql);
                LoadDataToGrivew();
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from trandau where matrandau = '" + txtMaTran.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnetion();
            LoadDataToGrivew();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update trandau set luotdau = N'" + txtLuotDau.Text +"', vongdau='"+txtVongDau.Text+
                      "' where matrandau = '" + txtMaTran.Text + "'";

            DAO.LoadDataTable(sql);
            LoadDataToGrivew();
        }
    }
}
