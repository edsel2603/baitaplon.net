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
using System.Runtime.Remoting.Messaging;
namespace BTL_NET
{
    public partial class dangky: Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        public bool check(string a)
        {
            string sql = @"
                         select Tendangnhap from ACC";
            SqlCommand cmd = new SqlCommand(sql, Ketnoi.conn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                string tk = r.GetString(0);
                if (a == tk)
                {
                    
                    return true;
                }
            }
            r.Close();
            return true;
        }
        private void dangky_Load(object sender, EventArgs e)
        {
            Ketnoi.Connect();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if (txtdanhnhap.Text == "")
            {
                MessageBox.Show("Không được bỏ trông tên đăng nhập");
                return;
            }
            if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mật khẩu");
                return;
            }
            if (txtxacminh.Text == "")
            {
                MessageBox.Show("Không được bỏ xác minh mật khẩu");
                return;
            }
            if (check(txtdanhnhap.Text) == false)
            {
                MessageBox.Show("Trùng tên đăng nhập");
                txtdanhnhap.Focus();
                return;
            }
            if (txtmatkhau.Text != txtxacminh.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận sai");
                txtxacminh.Focus();
                return;
            }
            string sql = @"insert into ACC values('" + txtdanhnhap.Text.Trim() + "','" + txtmatkhau.Text.Trim() + "')";
            SqlCommand cmd = new SqlCommand(sql, Ketnoi.conn);
            try
            {
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    
}
