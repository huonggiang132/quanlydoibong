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
            string user = "admin";
            string pass = "csltnhom5";
            if (user.Equals(txtusername.Text) && pass.Equals(txtPass.Text))
            {
                
                this.Hide();
                Form main = new FrmMain();
                main.Show();
            }
            else
                
                MessageBox.Show("Đăng nhập thất bại", "Notification");
                txtusername.Text = "";
                txtPass.Text = "";
                txtusername.Focus();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();

        }
       
    }
}
