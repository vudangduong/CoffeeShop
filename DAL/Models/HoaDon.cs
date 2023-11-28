using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid? IdNv { get; set; }
        public Guid? IdKm { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public int? TongTien { get; set; }
        public int TrangThai { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual KhuyenMai? KhuyenMai { get; set; }
        public virtual List<Ban_HD>? Ban_HDs { get; set; }
        public virtual List<SP_HD>? SP_HDs { get; set; }
    }
}
