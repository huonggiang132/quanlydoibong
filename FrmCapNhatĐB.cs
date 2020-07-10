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
    public partial class FrmCapNhatĐB : Form
    {
        public FrmCapNhatĐB()
        {
            InitializeComponent();
        }

        private void FrmCapNhatĐB_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDataToGrivew();
            DAO.FillDataToCombo("select madoi from DoiBong", cmbmadoi, "madoi", "madoi");
            cmbmadoi.SelectedIndex = -1;
            DAO.CloseConnetion();
        }
        private void LoadDataToGrivew()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from capnhatĐB";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable capnhatĐB = new DataTable();
                myAdapter.Fill(capnhatĐB);
                GridViewCapNhatĐB.DataSource = capnhatĐB;
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

        private void GridViewCapNhatĐB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbmadoi.Text = GridViewCapNhatĐB.CurrentRow.Cells["madoi"].Value.ToString();
            txtdiem.Text = GridViewCapNhatĐB.CurrentRow.Cells["diem"].Value.ToString();
            txtsobanthang.Text = GridViewCapNhatĐB.CurrentRow.Cells["sobanthang"].Value.ToString();
            txtsobanthua.Text = GridViewCapNhatĐB.CurrentRow.Cells["sobanthua"].Value.ToString();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {/*
            txtmadoi.Enabled = true;
            txtdiem.Enabled = true;
            txtsobanthang.Enabled = true;
            txtsobanthua.Enabled = true;
            txtsoluongCT.Enabled = true;
            txtmadoi.Text = "";
            txtdiem.Text = "";
            txtsobanthang.Text = "";
            txtsobanthua.Text = "";
            txtsoluongCT.Text = "";
            txtmadoi.Focus();*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update CapNhatĐB set diem = N'" + txtdiem.Text + "', sobanthang='" + txtsobanthang.Text + "', sobanthua='" + txtsobanthua.Text + 
                      "'where madoi = N'" + cmbmadoi.SelectedValue.ToString() + "'";
            DAO.OpenConnection();
            DAO.LoadDataTable(sql);
            LoadDataToGrivew();
            DAO.CloseConnetion();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
