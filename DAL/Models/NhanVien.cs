using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public string MaNv { get; set; }
        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public int ChucVu { get; set; }
        public string? TaiKhoan { get; set; }
        public string? MatKhau { get; set; }
        public int TrangThai { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
