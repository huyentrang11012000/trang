using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Sql;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyDiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //    Data Source = localhost\SQLEXPRESS; Initial Catalog = QLbanhang; Integrated Security = True
                SqlConnection con = new SqlConnection();//tạo kết nối sql
                con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = QuanLyDiem; Integrated Security = True";//link đường dẫn
                try
                {
                    con.Open();
                    MessageBox.Show(" ket noi thanh cong");//mo cau lenh
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Application.Run(new FrmSinhVien());
            
     
        }
    }
}
