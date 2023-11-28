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
    public partial class fQLDanhMuc : Form
    {
        private ILoaiSpServices _ilspServices;
        private LoaiSp _loaiSp;
        Guid _id;
        public fQLDanhMuc()
        {
            InitializeComponent();
            _loaiSp = new LoaiSp();
            _ilspServices = new LoaiSpServices();
            LoadData();
        }
        public void LoadData()
        {
            dtg_danhmuc.ColumnCount = 4;
            dtg_danhmuc.Columns[0].Name = "ID";
            dtg_danhmuc.Columns[0].Visible = false;
            dtg_danhmuc.Columns[1].Name = "Stt";
            dtg_danhmuc.Columns[2].Name = "Tên loại sản phẩm";
            dtg_danhmuc.Columns[3].Name = "Mô tả";
            dtg_danhmuc.AllowUserToAddRows = false;
            dtg_danhmuc.Rows.Clear();
            int stt = 0;
            foreach (var item in _ilspServices.GetAllLoaiSp())
            {
                dtg_danhmuc.Rows.Add(item.Id, ++stt, item.TenLoai, item.MoTa);
            }
        }

        private void dtg_danhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _ilspServices.GetAllLoaiSp().Count) { return; }
            var obj = _ilspServices.GetAllLoaiSp()[index];
            _id = obj.Id;
            txt_tenloaisp.Text = obj.TenLoai;
            txt_mota.Text = obj.MoTa;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            txt_tenloaisp.Text = "";
            txt_mota.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm danh mục này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _loaiSp = new LoaiSp()
                {
                    Id = Guid.NewGuid(),
                    TenLoai = txt_tenloaisp.Text,
                    MoTa = txt_mota.Text,
                };
                if (_ilspServices.AddLoaiSp(_loaiSp))
                {
                    MessageBox.Show("Thên thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa danh mục này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _loaiSp.Id = _id;
                _loaiSp.TenLoai = txt_tenloaisp.Text;
                _loaiSp.MoTa = txt_mota.Text;
                if (_ilspServices.UpdateLoaiSp(_loaiSp))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa danh mục này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _loaiSp.Id = _id;
                _ilspServices.DeleteLoaiSp(_id);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }
}
