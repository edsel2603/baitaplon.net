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
    public partial class timkiem: Form
    {
        private Form currentFormChild;
        public timkiem()
        {
            InitializeComponent();
        }

        private void timkiem_Load(object sender, EventArgs e)
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

        private void btntkkh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tkkhachhang());
        }

        private void btntknv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tknhanvien());
        }

        private void btntkbao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tkbao());
        }
    }
}
