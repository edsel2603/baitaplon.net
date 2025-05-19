using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET
{
    public partial class quanlykhachhang: Form
    {
        private Form currentFormChild;
        public quanlykhachhang()
        {
            InitializeComponent();
        }

        private void quanlykhachhang_Load(object sender, EventArgs e)
        {
            Ketnoi.Connect();
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

        private void btnTtkh_Click(object sender, EventArgs e)
        {

            OpenChildForm(new khachhang());
        }

        private void btnBaiviet_Click(object sender, EventArgs e)
        {

            OpenChildForm(new baiviet());
        }
    }
}
