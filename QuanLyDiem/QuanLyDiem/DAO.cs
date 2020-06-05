using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows;
using System.Windows.Forms;
using System.Data;


namespace QuanLyDiem
{
    class DAO
    {

        public static SqlConnection con;
        public static string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = QuanLyDiem; Integrated Security = True";
        public static void openconnection()
        {
            con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            if (con.State == System.Data.ConnectionState.Closed)
                try
                {
                    con.Open();
                    // MessageBox.Show("mo ket noi thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static void closeconnection()
        {
            con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            if (con.State == System.Data.ConnectionState.Open)
                try
                {
                    con.Close();
                    //  MessageBox.Show("dong ket noi thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static bool check_key(string sql)//kiểm tra mã tồn tại
        {
            bool kq = false;

            SqlDataAdapter data = new SqlDataAdapter(sql, DAO.con);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count > 0)

                kq = true;
            return kq;
        }

        public static string getfieldvalues(string sql)
        {
            DAO.openconnection();
            string ma = "";
   
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
                //ten = reader.GetValue(0).ToString();

            }
            reader.Close();
            return ma;

        }
        public static void filldatatocombo(string sql, ComboBox combo, string valueField, string displayField)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            adapter.Fill(mytable);
            combo.DataSource = mytable;
            combo.ValueMember = valueField;
            combo.DisplayMember = displayField;
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) &&
(Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, DAO.con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            return table;
        }

    }
}
