using BUS.IServices;
using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PRL.Sub_views
{
    public partial class SubFrm_QuenMatKhau : Form
    {
        INhanVienServices inhanvienservice;
        string email;
        List<NhanVien> _lst;
        private string hemail = "duongvdph22028@fpt.edu.vn";
        private string haha = "Gửi mail Từ Phần Mềm quản lý quán cà phê mã xác nhận của bạn là:  ";
        private string hihi;
        private string a;
        private string tk;
        string code;
        public SubFrm_QuenMatKhau()
        {
            InitializeComponent();
            inhanvienservice = new NhanVienServices();
            email = tk;
            _lst = new List<NhanVien>();
        }

        private void btn_xacthuc_Click(object sender, EventArgs e)
        {
            //SubFrm_DoiMK f = new SubFrm_DoiMK();
            //f.ShowDialog();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {

            if (tbtmxn.Text == code)
            {
                if (tbtmkmoi.Text == tbtnhaplaimkmoi.Text)
                {
                    NhanVien nhanVien = inhanvienservice.GetAllNhanVien().Where(c => c.Email == tbtemail.Text).FirstOrDefault();
                    nhanVien.MatKhau = tbtmkmoi.Text;
                    if (inhanvienservice.UpdateNhanVien(nhanVien))
                    {
                        MessageBox.Show("sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi rồi cu");
                    }                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, to;
            from = "duongvudang35@gmail.com";
            pass = "Duongbcdm";
            to = tbtemail.Text;
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            code = ramdomMK();
            message.Body = haha + code;
            message.Subject = "Reset";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Đợi", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public string ramdomMK()
        {
            Random r = new Random();
            var x = r.Next(0, 1000000);
            string s = x.ToString("000000");
            return s;
        }
    }
}
