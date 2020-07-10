using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace QuanLyDoiBong
{
    class DAO
    {
        public static SqlConnection conn;
        public static string connectionString = "Data Source=LAPTOP-UM8CT4CV\\SQLEXPRESS;Initial Catalog=BTLquanlydoibong;Integrated Security=True";
        public static void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            try
            {
                conn.Open();
                //      MessageBox.Show("mo ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void CloseConnetion()
        {

            if (conn.State == System.Data.ConnectionState.Open)
                try
                {
                    conn.Close();
                    //   MessageBox.Show("dong ket noi thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

        }
        public static DataTable LoadDataTable(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter();
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = DAO.conn;
            MyData.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }
        public static void LoadDataToTable(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = DAO.conn;
            cmd.CommandText = sql;

            try
            {
                cmd.ExecuteNonQuery();// Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool checkKeyExit(string sql)
        {
            bool kq = false;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                kq = true;
            return kq;
        }
        public static void FillDataToCombo(string sql, ComboBox combo, string ValueField, string DisplayField)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable mytable = new DataTable();
            adapter.Fill(mytable);
            combo.DataSource = mytable;
            combo.ValueMember = ValueField;
            combo.DisplayMember = DisplayField;
        }
        //Tiên Tiên
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DAO.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        
        public static string GetFieldValues(string sql)
        {
            DAO.OpenConnection();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, DAO.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
            DAO.CloseConnetion();
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();	// Khai báo
            // Tạo đối tượng Command thực hiện câu lệnh SELECT        
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = DAO.conn; 	// Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql;	// Gán câu lệnh SELECT
            DataTable table = new DataTable();    // Khai báo DataTable nhận dữ liệu trả về
            Mydata.Fill(table); 	//Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
            return table;
        }


    }


}