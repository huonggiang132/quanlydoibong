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
    public partial class FrmTrandau_Cauthu : Form
    {
        DataTable trandau_cauthu;
        public FrmTrandau_Cauthu()
        {
            InitializeComponent();
        }

        private void FrmTrandau_Cauthu_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDataToGridView();
            DAO.FillDataToCombo("Select madoi from trandau_cauthu", cmbMadoi, "madoi", "madoi");
            cmbMadoi.SelectedIndex = -1;
            DAO.CloseConnetion();
        }
        private void LoadDataToGridView()
        {
            //mở kết nối
            try
            {
                DAO.OpenConnection();
                string sql = "select * from trandau_cauthu";
                SqlDataAdapter adapt = new SqlDataAdapter(sql, DAO.conn);
                DataTable trandau_cauthu = new DataTable();
                adapt.Fill(trandau_cauthu);
                GridViewTrandau_Cauthu.DataSource = trandau_cauthu;

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
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMatran.Enabled = true;
            txtMacauthu.Enabled = true;
            txtVitri.Enabled = true;
            txtMatran.Text = "";
            cmbMadoi.SelectedIndex = -1;
            txtMacauthu.Text = "";
            txtVitri.Text = "";
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update trandau_cauthu set macauthu='" + txtMacauthu.Text.Trim() +
                        "', madoi='" + cmbMadoi.SelectedValue.ToString() + "', vitri = N'" + txtVitri.Text + "'" +
                        " where matrandau =N'" + txtMatran.Text + "'";

            DAO.LoadDataTable(sql);
            LoadDataToGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from trandau_cauthu where matrandau = '" +
                txtMatran.Text + "'";
            DAO.LoadDataTable(sql);
            LoadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatran.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã trận đấu");
                txtMatran.Focus();
                return;
            }
            if (txtMacauthu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã cầu thủ");
                txtMacauthu.Focus();
                return;
            }
            if (cmbMadoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã đội");
                cmbMadoi.Focus();
                return;
            }
            if (txtVitri.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vị trí");
                txtVitri.Focus();
                return;
            }

            string sqlCheckKey = "select * from trandau_cauthu where matrandau='" +
                txtMatran.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.checkKeyExit(sqlCheckKey))
            {
                MessageBox.Show("Mã trận đấu đã tồn tại");
                DAO.CloseConnetion();
                txtMatran.Focus();
                return;
            }
            string sql = "insert into trandau_cauthu values ('" +
                txtMatran.Text.Trim() + "','" +
                    cmbMadoi.SelectedValue.ToString() + "', '" +
                    txtMacauthu.Text.Trim() + "',N'" +
                txtVitri.Text.Trim() + "')";
            DAO.RunSqlDel(sql); //Thực hiện câu lệnh sql
            LoadDataToGridView(); //Nạp lại DataGridView
            
        }
    

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewTrandau_Cauthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatran.Text = GridViewTrandau_Cauthu.CurrentRow.Cells["matrandau"].Value.ToString();
            txtMacauthu.Text = GridViewTrandau_Cauthu.CurrentRow.Cells["macauthu"].Value.ToString();
            cmbMadoi.Text = GridViewTrandau_Cauthu.CurrentRow.Cells["madoi"].Value.ToString();
            txtVitri.Text = GridViewTrandau_Cauthu.CurrentRow.Cells["vitri"].Value.ToString();
            txtMatran.Enabled = false;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adap = new SqlDataAdapter(" select * from trandau_cauthu where matrandau like '%" 
                + txtMatran.Text + "%'", DAO.conn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "trandau_cauthu");
            GridViewTrandau_Cauthu.DataSource = ds.Tables["trandau_cauthu"].DefaultView;
        }
    }
}
