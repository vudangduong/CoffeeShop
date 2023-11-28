using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModels
{
    public class SanPhamVm
    {
        public Guid Id { get; set; }
        public string TenSp { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
        public int GiaBan { get; set; }
        public int TrangThai { get; set; }
        //thêm thuộc tính
        public string? TenLoaiSp { get; set; }
    }
}
