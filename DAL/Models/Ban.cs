using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ban
    {
        public Guid Id { get; set; }
        public string TenBan { get; set; }
        public int TrangThai { get; set; }
        public virtual List<Ban_HD> Ban_HDs { get; set; }
    }
}
