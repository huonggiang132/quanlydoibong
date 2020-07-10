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
    public partial class FrmCapNhatCT : Form
    {
        public FrmCapNhatCT()
        {
            InitializeComponent();
        }

        private void FrmCapNhatCT_Load(object sender, EventArgs e)
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
                string sql = "select * from capnhatCT";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable capnhatCT = new DataTable();
                myAdapter.Fill(capnhatCT);
                GridViewCNCauthu.DataSource = capnhatCT;
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

        private void GridViewCNCauthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmacauthu.Text = GridViewCNCauthu.CurrentRow.Cells["macauthu"].Value.ToString();
            txtsobanthang.Text = GridViewCNCauthu.CurrentRow.Cells["sobanthang"].Value.ToString();
            txtsothevang.Text = GridViewCNCauthu.CurrentRow.Cells["sothevang"].Value.ToString();
            txtsothedo.Text = GridViewCNCauthu.CurrentRow.Cells["sothedo"].Value.ToString();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update CapNhatCT set sobanthang = N'" + txtsobanthang.Text +
                      "', sothevang='" + txtsothevang.Text +
                      "', sothedo='" + txtsothedo.Text +  
                      "' where macauthu = '" + txtmacauthu.Text + "'";

            DAO.OpenConnection();
            DAO.LoadDataTable(sql);
            LoadDataToGrivew();
            DAO.CloseConnetion();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtsolanrasan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtsothedo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
