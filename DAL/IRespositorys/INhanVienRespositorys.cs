using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRespositorys
{
    public interface INhanVienRespositorys
    {
        bool AddNhanVien(NhanVien obj);

        bool DeleteNhanVien(Guid id);

        bool UpdateNhanVien(NhanVien obj);

        List<NhanVien> GetAllNhanVien();
        NhanVien GetNhanVien(string email);
    }
}
