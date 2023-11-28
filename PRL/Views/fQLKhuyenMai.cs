using BUS.IServices;
using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Views
{
    public partial class fQLKhuyenMai : Form
    {
        IKhuyenMaiServices _khuyenMaiServices;
        Guid _id;
        public fQLKhuyenMai()
        {
            InitializeComponent();
            _khuyenMaiServices = new KhuyenMaiServices();
            dtg_khuyenmai.ColumnCount = 9;
            dtg_khuyenmai.Columns[0].Name = "Id";
            dtg_khuyenmai.Columns[0].Visible = false;
            dtg_khuyenmai.Columns[1].Name = "STT";
            dtg_khuyenmai.Columns[2].Name = "Tên khuyến mại";
            dtg_khuyenmai.Columns[3].Name = "Điều kiện giảm";
            dtg_khuyenmai.Columns[3].Visible = false;
            dtg_khuyenmai.Columns[4].Name = "Phần trăm giảm";
            dtg_khuyenmai.Columns[5].Name = "Số tiền giảm";
            dtg_khuyenmai.Columns[6].Name = "Ngày bắt đầu";
            dtg_khuyenmai.Columns[7].Name = "Ngày kết thúc";
            dtg_khuyenmai.Columns[8].Name = "Trạng thái";
            dtg_khuyenmai.AllowUserToAddRows = false;
            LoadView(_khuyenMaiServices.GetAllKhuyenMai());
        }

        public void LoadView(List<KhuyenMai> list)
        {
            List<KhuyenMai> newlist = new List<KhuyenMai>();
            if (rd_chuadung.Checked)
            {
                newlist = list.Where(p => p.TrangThai == 0 && p.NgayKt >= DateTime.Now).ToList();
            }
            else if (rd_dangdung.Checked)
            {
                newlist = list.Where(p => p.TrangThai == 1 && p.NgayKt >= DateTime.Now).ToList();
            }
            else if (rd_hethan.Checked)
            {
                newlist = list.Where(p => p.NgayKt < DateTime.Now).ToList();
            }
            else newlist = list;
            int stt = 0;
            dtg_khuyenmai.Rows.Clear();
            foreach (KhuyenMai item in newlist)
            {
                dtg_khuyenmai.Rows.Add(item.Id, ++stt, item.Ten, item.DkGiam, item.PhamTramGiam, item.SoTienGiam, item.NgayBd, item.NgayKt, item.TrangThai == 1 ? "Đang sử dụng" : "Chưa sử dụng");
            }
        }

        private void dtg_khuyenmai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_khuyenmai.CurrentRow.Cells[0].Value.ToString());
            txt_tenkm.Text = dtg_khuyenmai.CurrentRow.Cells[2].Value.ToString();
            txt_dkgiam.Text = dtg_khuyenmai.CurrentRow.Cells[3].Value.ToString();
            txt_phantram.Text = dtg_khuyenmai.CurrentRow.Cells[4].Value.ToString();
            txt_sotien.Text = dtg_khuyenmai.CurrentRow.Cells[5].Value.ToString();
            dt_ngaybd.Value = DateTime.Parse(dtg_khuyenmai.CurrentRow.Cells[6].Value.ToString());
            dt_ngaykt.Value = DateTime.Parse(dtg_khuyenmai.CurrentRow.Cells[7].Value.ToString());
            if (dtg_khuyenmai.CurrentRow.Cells[8].Value.ToString().Contains("Đang sử dụng"))
                cb_sudung.Checked = true;
            else cb_sudung.Checked = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_an.Enabled = true;
        }
    }
}
