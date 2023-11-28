using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Views
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();
        }
        #region loadForm
        private Form OpenChildForm;
        private void ChangeForm(Form childForm)
        {
            if (OpenChildForm != null)
            {
                OpenChildForm.Close();
            }
            OpenChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_Show.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeForm(new fQuanLyTaiKhoan());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ChangeForm(new fQLHoaDon());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ChangeForm(new fQLDoanhThu());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeForm(new fQLBan());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeForm(new fQLDanhMuc());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeForm(new fQLMon());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeForm(new fQLKhuyenMai());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeForm(new fXemThongTin());
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (OpenChildForm != null)
            {
                OpenChildForm.Close();
            }
        }
        #endregion



    }
}
