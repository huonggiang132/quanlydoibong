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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UM8CT4CV\\SQLEXPRESS;Initial Catalog=quanlysanbong;Integrated Security=True");
            string sqlSelect = " Select * from Login where username = N" + txtusername + " and password = N" + txtPass + "";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if( reader.Read()==true)
            {
                this.Hide();
                Form main = new FrmMain();
                main.Show();

            }   
            else
            {
                MessageBox.Show(" Sai tên tài khoản hoặc mật khẩu. Bạn hãy nhập lại!");
                txtusername.Text = "";
                txtPass.Text = "";
                txtusername.Focus();

            }
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
