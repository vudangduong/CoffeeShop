using PRL.Sub_views;
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
    public partial class fBanHang : Form
    {
        public fBanHang()
        {
            InitializeComponent();
        }
        #region LoadForm
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
            pn_MangVe.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_mangve_Click(object sender, EventArgs e)
        {
            ChangeForm(new fMangVe());
        }
        private void btn_khuvuc_Click(object sender, EventArgs e)
        {
            ChangeForm(new fKhuVuc());
        }
        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            ChangeForm(new fQuanLy());
        }
        #endregion
        private void pictureBox2_Click(object sender, EventArgs e)
        {
          SubFrm_DoiThongTin f = new SubFrm_DoiThongTin();
            f.Show();

        }
    }
}
