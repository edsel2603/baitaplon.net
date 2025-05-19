using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET
{
    public partial class quenmatkhau: Form
    {
        public quenmatkhau()
        {
            InitializeComponent();
        }

        private void quenmatkhau_Load(object sender, EventArgs e)
        {
            Ketnoi.Connect();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string matkhauMoi = txtMkm.Text.Trim();
            string nhapLaiMK = txtNhaplmk.Text.Trim();
            string tendn = txtTendangnhap.Text.Trim();

            if (tendn == "" || matkhauMoi == "" || nhapLaiMK == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matkhauMoi != nhapLaiMK)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string sqlCheck = "SELECT COUNT(*) FROM ACC WHERE Tendangnhap = @tendn";
            SqlCommand cmdCheck = new SqlCommand(sqlCheck, Ketnoi.conn);
            cmdCheck.Parameters.AddWithValue("@tendn", tendn);

            int count = (int)cmdCheck.ExecuteScalar();

            if (count == 0)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật mật khẩu mới
            string sqlUpdate = "UPDATE ACC SET Matkhau = @matkhauMoi WHERE Tendangnhap = @tendn";
            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, Ketnoi.conn);
            cmdUpdate.Parameters.AddWithValue("@matkhauMoi", matkhauMoi);
            cmdUpdate.Parameters.AddWithValue("@tendn", tendn);

            int rows = cmdUpdate.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
