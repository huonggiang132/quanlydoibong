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
    public partial class FrmCapNhatTĐ : Form
    {
        public FrmCapNhatTĐ()
        {
            InitializeComponent();
        }

        private void FrmCapNhatTĐ_Load(object sender, EventArgs e)
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
                string sql = "select * from capnhatTĐ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable capnhatTĐ = new DataTable();
                myAdapter.Fill(capnhatTĐ);
                GridViewCNTrandau.DataSource = capnhatTĐ;
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

        private void GridViewCNTrandau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatran.Text = GridViewCNTrandau.CurrentRow.Cells["matrandau"].Value.ToString();
            txtbanthangDN.Text = GridViewCNTrandau.CurrentRow.Cells["sobanthangdoinha"].Value.ToString();
            txtbanthuaDN.Text = GridViewCNTrandau.CurrentRow.Cells["sobanthuadoinha"].Value.ToString();
            txtthevangDN.Text = GridViewCNTrandau.CurrentRow.Cells["sothevangdoinha"].Value.ToString();
            txtthedoDN.Text = GridViewCNTrandau.CurrentRow.Cells["sothedodoinha"].Value.ToString();
            txtthevangDK.Text = GridViewCNTrandau.CurrentRow.Cells["sothevangdoikhach"].Value.ToString();
            txtthedoDK.Text = GridViewCNTrandau.CurrentRow.Cells["sothedodoikhach"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update CapNhatTĐ set sobanthangdoinha = N'" + txtbanthangDN.Text +
                      "', sobanthuadoinha='" + txtbanthuaDN.Text + "', sothevangdoinha='" + txtthevangDN.Text +
                      "', sothedodoinha='" + txtthedoDN.Text + "', sothevangdoikhach='" + txtthevangDK.Text + "', sothedodoikhach='" + txtthedoDK.Text +
                      "' where matrandau = '" + txtmatran.Text + "'";

            DAO.OpenConnection();
            DAO.LoadDataTable(sql);
            LoadDataToGrivew();
            DAO.CloseConnetion();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
