using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public Guid? IdLoai { get; set; }
        public string TenSp { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
        public int GiaBan { get; set; }
        public int TrangThai { get; set; }
        public virtual LoaiSp? LoaiSp { get; set; }
        public virtual List<SP_HD> SP_HDs { get; set; }
    }
}
