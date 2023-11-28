using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SP_HD
    {
        Guid ID { get; set; }
        public Guid? IdHd { get; set; }
        
        public Guid? IdSp { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public virtual SanPham? SanPham { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
    }
}
