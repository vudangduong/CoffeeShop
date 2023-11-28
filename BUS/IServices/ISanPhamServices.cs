using BUS.ViewModels;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ISanPhamServices
    {
        bool AddSanPham(SanPham obj);

        bool DeleteSanPham(Guid id);

        bool UpdateSanPham(SanPham obj);

        List<SanPhamVm> GetAllSanPhamVm();
        List<SanPham> GetAllSanPham();
        SanPham GetSanPhamByid(Guid id);
    }
}
