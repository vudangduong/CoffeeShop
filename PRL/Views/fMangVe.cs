using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
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
    public partial class fMangVe : Form
    {
        ILoaiSpServices _loaiSpServices;
        IKhuyenMaiServices _khuyenMaiServices;
        ISanPhamServices _sanPhamServices;
        IHoaDonServices _hoaDonServices;
        ISP_HDServices _sP_HDServices;
        List<HoaDonVm> hd;
        Guid _idHd;
        Guid _idNv;
        bool _checkOut = true;
        public fMangVe()
        {
            _loaiSpServices = new LoaiSpServices();
            _khuyenMaiServices = new KhuyenMaiServices();
            _sanPhamServices = new SanPhamServices();
            _hoaDonServices = new HoaDonServices();
            _sP_HDServices = new SP_HDServices();
            InitializeComponent();
            LoadCbb();
            List<SanPham> SortListSanPham = _sanPhamServices.GetAllSanPham().OrderBy(p => p.IdLoai).ToList();
            LoadSp(SortListSanPham);
        }
        public fMangVe(Guid idNv)
        {
            _idNv = idNv;
            _loaiSpServices = new LoaiSpServices();
            _khuyenMaiServices = new KhuyenMaiServices();
            //_banServices = new BanServices();
            _sanPhamServices = new SanPhamServices();
            _sP_HDServices = new SP_HDServices();
            //_ban_HDServices = new Ban_HDServices();
            _hoaDonServices = new HoaDonServices();
            InitializeComponent();
            #region loadview
            //dtg_view_hd.ColumnCount = 7;
            //dtg_view_hd.Columns[0].Name = "Idsp";
            //dtg_view_hd.Columns[0].Visible = false;
            //dtg_view_hd.Columns[1].Name = "STT";
            //dtg_view_hd.Columns[2].Name = "Tên sản phẩm";
            //dtg_view_hd.Columns[3].Name = "Đơn giá";
            //dtg_view_hd.Columns[4].Name = "Số lượng";
            //dtg_view_hd.Columns[5].Name = "Thành tiền";
            //dtg_view_hd.Columns[6].Name = "Mô tả";
            //dtg_view_hd.AllowUserToAddRows = false;
            LoadCbb();
            List<SanPham> SortListSanPham = _sanPhamServices.GetAllSanPham().OrderBy(p => p.IdLoai).ToList();
            LoadSp(SortListSanPham);
            #endregion
        }
        public void LoadSp(List<SanPham> list)
        {
            fl_sanpham.Controls.Clear();
            foreach (SanPham sp in list)
            {
                Panel pn = new Panel()
                {
                    Width = 130,
                    Height = 110,
                    BackColor = Color.Tan,
                };
                PictureBox pictureBox = new PictureBox()
                {
                    Image = Image.FromFile(sp.HinhAnh),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill,
                    Tag = sp,
                };
                pictureBox.Click += PictureBox_Click; ;
                pn.Controls.Add(pictureBox);
                Label lb = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = sp.TenSp,
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                };
                pn.Controls.Add(lb);

                fl_sanpham.Controls.Add(pn);
            }
        }
        public void LoadCbb()
        {
            cb_loaisp.Items.Add("Tất cả");
            cb_loaisp.SelectedIndex = 0;
            foreach (var item in _loaiSpServices.GetAllLoaiSp())
            {
                cb_loaisp.Items.Add(item.TenLoai);
            }
            var listkm = _khuyenMaiServices.GetAllKhuyenMai().Where(p => p.TrangThai == 1 && p.NgayKt >= DateTime.Now);
            cb_khuyenmai.Items.Add("Không");
            cb_khuyenmai.SelectedIndex = 0;
            foreach (var item in listkm)
            {
                cb_khuyenmai.Items.Add(item.Ten);
            }
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
