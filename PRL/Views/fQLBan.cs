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
    public partial class fQLBan : Form
    {
        IBanServices _banSv;
        Ban _ban;
        Guid _id;
        public fQLBan()
        {
            InitializeComponent();
            _ban = new Ban();
            _banSv = new BanServices();
            LoadData();
        }
        public void LoadData()
        {
            dtg_view_ban.ColumnCount = 3;
            dtg_view_ban.Columns[0].Name = "ID";
            dtg_view_ban.Columns[0].Visible = false;
            dtg_view_ban.Columns[1].Name = "Tên bàn";
            dtg_view_ban.Columns[2].Name = "Trạng thái";
            dtg_view_ban.AllowUserToAddRows = false;
            dtg_view_ban.Rows.Clear();
            int stt = 0;
            foreach (var item in _banSv.GetAllBan())
            {
                dtg_view_ban.Rows.Add(item.Id, item.TenBan, item.TrangThai == 1 ? "Có khách" : "Không khách");
            }
        }

        private void dtg_view_ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index < 0 || index >= _banSv.GetAllBan().Count) { return; }
            var obj = _banSv.GetAllBan()[index];
            _id = obj.Id;
            txt_tenban.Text = obj.TenBan;
            cb_trangthai.Text = obj.TrangThai.ToString();
            //_id = Guid.Parse(dtg_view_ban.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txt_tenban.Text = dtg_view_ban.Rows[e.RowIndex].Cells[1].Value.ToString();
            //cb_trangthai.Text = dtg_view_ban.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
