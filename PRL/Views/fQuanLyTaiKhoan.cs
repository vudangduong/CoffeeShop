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

namespace PRL.Views
{
    public partial class fQuanLyTaiKhoan : Form
    {
        INhanVienServices _nhanVienServices;
        Guid _id;
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
            #region Load
            dtg_view_nv.ColumnCount = 11;
            dtg_view_nv.Columns[0].Name = "Id";
            dtg_view_nv.Columns[0].Visible = false;
            dtg_view_nv.Columns[1].Name = "STT";
            dtg_view_nv.Columns[2].Name = "Mã nhân viên";
            dtg_view_nv.Columns[3].Name = "Tên nhân viên";
            dtg_view_nv.Columns[4].Name = "Giới tính";
            dtg_view_nv.Columns[5].Name = "Số điện thoại";
            dtg_view_nv.Columns[6].Name = "Email";
            dtg_view_nv.Columns[7].Name = "Chức vụ";
            dtg_view_nv.Columns[8].Name = "Tài khoản";
            dtg_view_nv.Columns[9].Name = "Mật khẩu";
            dtg_view_nv.Columns[10].Name = "Trạng thái";
            dtg_view_nv.AllowUserToAddRows = false;
            #endregion
            LoadView(_nhanVienServices.GetAllNhanVien());
        }

        public void LoadView(List<NhanVien> list)
        {
            List<NhanVien> list_nv = new List<NhanVien>();
            if (rd_hoatdong.Checked)
            {
                list_nv = list.Where(p => p.TrangThai == 0).ToList();
            }
            else if (rd_danghi.Checked)
            {
                list_nv = list.Where(p => p.TrangThai == 1).ToList();
            }
            else list_nv = list;
            int stt = 0;
            foreach (NhanVien v in list_nv)
            {
                dtg_view_nv.Rows.Add(v.Id, ++stt, v.MaNv, v.HoTen, v.GioiTinh == 0 ? "Nam" : "Nữ", v.Sdt, v.Email,v.ChucVu == 1 ? "Admin" : "Staff", v.TaiKhoan,v.MatKhau, v.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void dtg_view_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_view_nv.CurrentRow.Cells[0].Value.ToString());
            txt_manv.Text = dtg_view_nv.CurrentRow.Cells[2].Value.ToString();
            txt_tennv.Text = dtg_view_nv.CurrentRow.Cells[3].Value.ToString();
            cb_gioitinh.Text = dtg_view_nv.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = dtg_view_nv.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = dtg_view_nv.CurrentRow.Cells[6].Value.ToString();
            cb_chucvu.Text = dtg_view_nv.CurrentRow.Cells[7].Value.ToString();
            txt_taikhoan.Text = dtg_view_nv.CurrentRow.Cells[8].Value.ToString();
            txt_matkhau.Text = dtg_view_nv.CurrentRow.Cells[9].Value.ToString();
            cb_trangthai.Text = dtg_view_nv.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
