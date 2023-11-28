using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LoaiSp
    {
        public Guid Id { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public virtual List<SanPham> SanPhams { get; set; }
    }
}
