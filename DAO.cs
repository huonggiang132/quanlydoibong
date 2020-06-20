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
        public static string connectionString = "Data Source=LAPTOP-UM8CT4CV\\SQLEXPRESS;Initial Catalog=quanlysanbong;Integrated Security=True";
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
        

    }
}