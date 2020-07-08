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

namespace QuanLyDoiBong
{
    public partial class FrmTimKiemTD : Form
    {
        public FrmTimKiemTD()
        {
            InitializeComponent();
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
                GridViewTimKiemTD.DataSource = trandau;
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

       

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            DAO.OpenConnection();
            if (rbmadoinha.Checked == true)
            {
                SqlDataAdapter adap = new SqlDataAdapter(" select * from trandau where madoinha like '%" + txtNhap.Text + "%'",DAO.conn);
                DataSet ds = new DataSet();
                adap.Fill(ds, "trandau");
                GridViewTimKiemTD.DataSource = ds.Tables["trandau"].DefaultView;
                
            }
            if (rbbanthang.Checked == true)
            {
                SqlDataAdapter adap = new SqlDataAdapter(" select * from trandau where sobanthangdoinha like '%" + txtNhap.Text + "%'", DAO.conn);
                DataSet ds = new DataSet();
                adap.Fill(ds, "trandau");
                GridViewTimKiemTD.DataSource = ds.Tables["trandau"].DefaultView;
                
            }
            if (rbthedo.Checked == true)
            {
                SqlDataAdapter adap = new SqlDataAdapter(" select * from trandau where sothedodoinha like '%" + txtNhap.Text + "%'", DAO.conn);
                DataSet ds = new DataSet();
                adap.Fill(ds, "trandau");
                GridViewTimKiemTD.DataSource = ds.Tables["trandau"].DefaultView;
                
            }
            DAO.CloseConnetion();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
