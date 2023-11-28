using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRespositorys
{
    public interface ISanPhamRespositorys
    {
        bool AddSanPham(SanPham obj);

        bool DeleteSanPham(Guid id);

        bool UpdateSanPham(SanPham obj);

        List<SanPham> GetAllSanPham();
        SanPham GetSanPhamByid(Guid id);
    }
}
