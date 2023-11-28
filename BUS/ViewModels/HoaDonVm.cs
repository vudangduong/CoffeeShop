using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class HoaDonVm
    {
        public Guid? IdHd { get; set; }
        public Guid? IdSp { get; set; }
        public string TenSp { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? MoTa { get; set; }
    }
}
