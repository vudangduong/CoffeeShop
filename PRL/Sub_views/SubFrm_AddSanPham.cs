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
using DAL.Models;
using BUS.ViewModels;

namespace PRL.Sub_views
{
    public partial class SubFrm_AddSanPham : Form
    {
        //public SubFrm_AddSanPham()
        //{
        //    InitializeComponent();
        //    List<HoaDonVm> hoaDonVms = list;
        //    if (sender != null)
        //    {
        //        SanPham sp = (SanPham)sender;
        //        lb_tensp.Text = sp.TenSp;
        //        lb_gia.Text = sp.GiaBan.ToString();
        //    }
        //}

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
