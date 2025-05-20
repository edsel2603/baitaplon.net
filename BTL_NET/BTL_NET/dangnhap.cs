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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BTL_NET
{
    public partial class dangnhap: Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        

        private void dangnhap_Load(object sender, EventArgs e)
        {
            Ketnoi.Connect();
            txtmk.UseSystemPasswordChar = true;
            txtmk.PasswordChar = '*';
        }
        private void button2_Click(object sender, EventArgs e)
        {
                 DialogResult result = MessageBox.Show(
                "Bạn chắc chắn muốn thoát không ?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtmk.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mật khẩu");
                return;
            }
            if (txtTendangnhap.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập");
                return;
            }
            string sql = @"SELECT * FROM ACC";
            SqlCommand cmd = new SqlCommand(sql, Ketnoi.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool check = false;
            while (reader.Read())
            {
                string tk = reader.GetString(0);
                string mk = reader.GetString(1);
                if(txtTendangnhap.Text.Trim()==tk && txtmk.Text.Trim() == mk)
                {
                    reader.Close();
                    this.Hide();
                    trangchu trangchu = new trangchu();        
                    trangchu.Show();
                    trangchu.FormClosed += (s, args) =>
                    {
                        this.Show(); 
                    };

                    check = true;
                    return;
                  
                }
            }
            reader.Close();
            if (check == false)
            {
                MessageBox.Show("Tài khoản đăng nhập sai !");
            }
            

            

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangky dangky = new dangky();
            dangky.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenmatkhau quenmatkhau = new quenmatkhau();
            quenmatkhau.Show();
        }
    }
}
