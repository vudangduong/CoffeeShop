using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class KhuyenMai
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public DateTime NgayBd { get; set; }
        public DateTime NgayKt { get; set; }
        public int PhamTramGiam { get; set; }
        public int SoTienGiam { get; set; }
        public string? DkGiam { get; set; }
        public int TrangThai { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
