using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace BTL_NET
{

    class Ketnoi
    {
        public static SqlConnection conn;
        public static string ConnectionString = @"Data Source=admin\SQLEXPRESS;Initial Catalog=hopdongquangcao;Integrated Security=True;Encrypt=False";


        public static void Connect()
        {
            conn = new SqlConnection(ConnectionString);
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        public static void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
