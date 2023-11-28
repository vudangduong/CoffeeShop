using BUS.IServices;
using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Sub_views
{
    public partial class SubFrm_DoiMK : Form
    {
        private INhanVienServices _nhanVienServices;
        public NhanVien _nv = new NhanVien();
        public SubFrm_DoiMK()
        {
            _nhanVienServices = new NhanVienServices();
            tbttaikhoan.Text = _nv.TaiKhoan;
            InitializeComponent();
        }

        private void btnxacnhandoimk_Click(object sender, EventArgs e)
        {

            NhanVien nhanvien = _nhanVienServices.GetNhanVien(_nv.Email);
            if (!tbtmkmoi.Text.Equals(""))
            {
                nhanvien.MatKhau = tbtmkmoi.Text;
                _nhanVienServices.UpdateNhanVien(nhanvien);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
            }
        }
    }
}
