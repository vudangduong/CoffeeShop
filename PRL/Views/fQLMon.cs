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
    public partial class fQLMon : Form
    {
        private ISanPhamServices _isanPhamSer;
        private ILoaiSpServices _iloaiSpSer;
        private Guid _id;
        private SanPham _sanPham;
        private string linkAnh = "";
        private string tensp = "";
        public fQLMon()
        {
            InitializeComponent();
            _sanPham = new SanPham();
            _isanPhamSer = new SanPhamServices();
            _iloaiSpSer = new LoaiSpServices();
            LoadCbbLoaiSP();
            LoadSanPham();
        }
        public void LoadCbbLoaiSP()
        {
            foreach (var item in _iloaiSpSer.GetAllLoaiSp())
            {
                cb_danhmuc.Items.Add(item.TenLoai);
            }
        }
        public void LoadSanPham()
        {
            dtg_mon.ColumnCount = 7;
            dtg_mon.Columns[0].Name = "ID";
            dtg_mon.Columns[0].Visible = false;
            dtg_mon.Columns[1].Name = "Tên sản phẩm";
            dtg_mon.Columns[2].Name = "Hình ảnh";
            dtg_mon.Columns[3].Name = "Mô tả";
            dtg_mon.Columns[4].Name = "Loại sản phẩm";
            dtg_mon.Columns[5].Name = "Gía bán";
            dtg_mon.Columns[6].Name = "Trạng thái";
            dtg_mon.AllowUserToAddRows = false;
            dtg_mon.Rows.Clear();
            foreach (var item in _isanPhamSer.GetAllSanPhamVm())
            {
                dtg_mon.Rows.Add(item.Id, item.TenSp
                    , item.HinhAnh, item.MoTa, item.TenLoaiSp, item.GiaBan, item.TrangThai);
            }
        }

        private void dtg_mon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_mon.Rows[e.RowIndex].Cells[0].Value.ToString());
            var sp = _isanPhamSer.GetAllSanPham().FirstOrDefault(c => c.Id == _id);
            tb_tensp.Text = sp.TenSp;
            tb_mota.Text = sp.MoTa;
            tb_gia.Text = sp.GiaBan.ToString();
            cb_danhmuc.Text = sp.TenSp.ToString();
            cbb_trangthai.Text = sp.TrangThai.ToString();
            linkAnh = sp.HinhAnh;

            if (linkAnh != null && File.Exists(linkAnh))
            {
                pic_anh.Image = Image.FromFile(linkAnh);
                pic_anh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pic_anh.Image = null;
            }
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường");
            }
            else if (Convert.ToInt32(tb_gia.Text) < 0)
            {
                MessageBox.Show("Giá bán > 0");
            }
            else if (linkAnh == "")
            {
                MessageBox.Show("Bạn chưa chọn ảnh cho sản phẩm");
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult result = MessageBox.Show("Bạn có muốn thêm sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var lsp = _iloaiSpSer.GetAllLoaiSp().FirstOrDefault(c => c.TenLoai == cb_danhmuc.Text);
                    _sanPham = new SanPham();

                    _sanPham.Id = Guid.NewGuid();
                    _sanPham.IdLoai = lsp.Id;
                    _sanPham.TenSp = tb_tensp.Text;
                    _sanPham.HinhAnh = linkAnh;
                    _sanPham.MoTa = tb_mota.Text;
                    _sanPham.GiaBan = Convert.ToInt32(tb_gia.Text);
                    _sanPham.TrangThai = Convert.ToInt32(cbb_trangthai.Text);

                    if (_isanPhamSer.AddSanPham(_sanPham))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        LoadSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại");
                    }

                }
            }
        }
        private void pic_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(pic_anh.Image != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi ảnh không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);   
                if(dialogResult == DialogResult.Yes)
                {
                    if(op.ShowDialog() == DialogResult.OK)
                    {
                        linkAnh = op.FileName;
                        pic_anh.Image = Image.FromFile(linkAnh);
                        pic_anh.SizeMode = PictureBoxSizeMode.StretchImage;
                        MessageBox.Show(op.FileName);
                    }

                }
                
            }
            if(pic_anh.Image == null)
            {
                if(op.ShowDialog() == DialogResult.OK)
                {
                    linkAnh = op.FileName;
                    pic_anh.Image = Image.FromFile(linkAnh);
                    pic_anh.SizeMode = PictureBoxSizeMode.StretchImage;
                    MessageBox.Show(op.FileName);
                }
            }
        }
        private void tb_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public bool checknhap()
        {
            if (tb_tensp.Text == "" || tb_mota.Text == "" || cb_danhmuc.Text == "" || tb_gia.Text == "" || cbb_trangthai.Text == "") return false;
            return true;
        }

    }
}
