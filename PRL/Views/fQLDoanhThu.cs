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
    public partial class fQLDoanhThu : Form
    {
        private IHoaDonServices _IHoaDon;
        List<HoaDon> _lst;
        Guid _id;

        public fQLDoanhThu()
        {

            InitializeComponent();
            _IHoaDon = new HoaDonServices();
            _lst = _IHoaDon.GetAllHoaDon();
            LoadHoaDon();
        }
        public void LoadHoaDon()
        {
            dtg_view_hoadon.Rows.Clear();
            dtg_view_hoadon.ColumnCount = 7;
            dtg_view_hoadon.Columns[0].Name = "Stt";
            dtg_view_hoadon.Columns[0].Visible = false;
            dtg_view_hoadon.Columns[1].Name = "ID";
            dtg_view_hoadon.Columns[2].Name = "Ngày tạo";
            dtg_view_hoadon.Columns[3].Name = "Ngày thanh toán";
            //dtg_view_hoadon.Columns[4].Name = "Tên KM";
            dtg_view_hoadon.Columns[4].Name = "Mã nhân viên";
            dtg_view_hoadon.Columns[5].Name = "Tổng tiền";
            dtg_view_hoadon.Columns[6].Name = "Trạn thái";
            dtg_view_hoadon.AllowUserToAddRows = false;
            var hd = _IHoaDon.GetAllHoaDon();
            int stt = 0;
            foreach (var item in hd)
            {
                dtg_view_hoadon.Rows.Add(item.Id,++stt, item.NgayTao, item.NgayThanhToan, item.IdNv, item.TongTien, item.TrangThai);
                //dtg_view_hoadon.Rows.Add(item.Id, item.NgayTao, item.NgayThanhToan, item.TenNV, item.TenKm, item.TongTien, item.TrangThai);
            }
        }
    }
}
