using BUS.IServices;
using BUS.Services;
using DAL.Models;
using PRL.Sub_views;
using PRL.Views;

namespace PRL
{
    public partial class fLogin : Form
    {
        INhanVienServices _inhanvienservices;
        
        public fLogin()
        {
            _inhanvienservices = new NhanVienServices();

            InitializeComponent();
        }
        
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            bool checkLogin = false;
            List<NhanVien> listNhanVien = _inhanvienservices.GetAllNhanVien();
            List<NhanVien> nhanViens = new List<NhanVien>();
            foreach (NhanVien nhanVien in listNhanVien)
            {
                if (nhanVien.TaiKhoan == txtUserName.Text || nhanVien.Email == txtUserName.Text)
                {
                    nhanViens.Add(nhanVien);
                    break;

                }
            }
            if (nhanViens.Count() < 1)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if (nhanViens[0].MatKhau == txtPassWord.Text)
                {
                    MessageBox.Show("Đang nhập thành công BITCH");
                    fBanHang f = new fBanHang();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }
            
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SubFrm_QuenMatKhau f = new SubFrm_QuenMatKhau();
            f.ShowDialog();
        }
    }
}
