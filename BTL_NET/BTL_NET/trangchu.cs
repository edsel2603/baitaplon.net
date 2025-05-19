using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET
{
    public partial class trangchu: Form
    {
        private Form currentFormChild;
        public trangchu()
        {
            InitializeComponent();
        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            Ketnoi.Connect();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            this.Close(); 
            dangnhap f = new dangnhap();
            f.Show();     
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label2.Text = "Home";
        }

        private void btnQlkh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new quanlykhachhang());
            label2.Text = btnQlkh.Text;
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new nhanvien());
            label2.Text = btnNhanvien.Text;
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new bao());
            label2.Text = btnBao.Text;
        }

        private void btnHdqc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new quangcao());
            label2.Text = btnHdqc.Text;
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new baocao());
            label2.Text = btnBaocao.Text;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new timkiem());
            label2.Text = btnTimkiem.Text;
        }
    }
}
