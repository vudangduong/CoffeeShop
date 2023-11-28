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
    public partial class fKhuVuc : Form
    {
        ILoaiSpServices _loaiSpServices;
        IKhuyenMaiServices _khuyenMaiServices;
        IBanServices _banServices;
        ISanPhamServices _sanPhamServices;
        IHoaDonServices _hoaDonServices;
        ISP_HDServices _sP_HDServices;
        IBan_HDServices _ban_HDServices;
        List<HoaDonVm> hd;
        Guid _idHd;
        Guid _idNv;
        Guid _idBan;
        bool _checkOut = true;
        //public fBanHang(Guid idn)
        //{

        //}
        //public fKhuVuc()
        //{
        //    _loaiSpServices = n
        //    ew LoaiSpServices();
        //    _khuyenMaiServices = new KhuyenMaiServices();
        //    _banServices = new BanServices();
        //    _sanPhamServices = new SanPhamServices();
        //    _sP_HDServices = new SP_HDServices();
        //    _ban_HDServices = new Ban_HDServices();
        //    _hoaDonServices = new HoaDonServices();
        //    InitializeComponent();
        //    //dtg_view_hd.ColumnCount = 8;
        //    //dtg_view_hd.Columns[0].Name = "Id";
        //    //dtg_view_hd.Columns[0].Visible = false;
        //    //dtg_view_hd.Columns[1].Name = "STT";
        //    //dtg_view_hd.Columns[1].Width = 60;
        //    //dtg_view_hd.Columns[2].Name = "Tên sản phẩm";
        //    //dtg_view_hd.Columns[3].Name = "Đơn giá";
        //    //dtg_view_hd.Columns[4].Name = "Số lượng";
        //    //dtg_view_hd.Columns[5].Name = "Thành tiền";
        //    //dtg_view_hd.Columns[6].Name = "Mô tả";
        //    //dtg_view_hd.AllowUserToAddRows = false;
        //    LoadCbb();
        //    List<Ban> SortList = _banServices.GetAllBan().OrderBy(p => p.TenBan).ToList();
        //    LoadBan(SortList);
        //    List<SanPham> SortListSanPham = _sanPhamServices.GetAllSanPham().OrderBy(p => p.IdLoai).ToList();
        //    LoadSp(SortListSanPham);
        //}
        public void LoadBan(List<Ban> list)
        {
            fl_Ban.Controls.Clear();
            foreach (Ban b in list)
            {
                Button btn = new Button() 
                {
                    Width = 110,
                    Height = 100,
                    FlatStyle = FlatStyle.Standard,
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    Tag = b,
                    Text = b.TenBan,
                };
                btn.Click += Btn_Click;
                if (b.TrangThai == 1) btn.BackColor = Color.GhostWhite;
                else btn.BackColor = Color.AntiqueWhite;
                fl_Ban.Controls .Add(btn);
            }
        }
        public void LoadSp(List<SanPham> list)
        {
            fl_mon.Controls.Clear();
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
                pictureBox.Click += PictureBox_Click; ; ;
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

                fl_mon.Controls.Add(pn);
            }
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void LoadCbb()
        {
            var listkm = _khuyenMaiServices.GetAllKhuyenMai().Where(p => p.TrangThai == 1 && p.NgayKt >= DateTime.Now);
            cb_khuyenmai.Items.Add("Không");
            cb_khuyenmai.SelectedIndex = 0;
            foreach (var item in listkm)
            {
                cb_khuyenmai.Items.Add(item.Ten);
            }
        }
    }
}
