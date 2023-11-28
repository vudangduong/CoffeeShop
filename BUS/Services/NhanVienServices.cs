using BUS.IServices;
using DAL.IRespositorys;
using DAL.Models;
using DAL.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanVienServices : INhanVienServices
    {
        INhanVienRespositorys respositorys;
        public NhanVienServices()
        {
            respositorys = new NhanVienSpRespositorys();
        }
        public bool AddNhanVien(NhanVien obj)
        {
            return respositorys.AddNhanVien(obj);
        }

        public bool DeleteNhanVien(Guid id)
        {
            return respositorys.DeleteNhanVien(id);
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return respositorys.GetAllNhanVien();
        }

        public NhanVien GetNhanVien(string email)
        {
            return respositorys.GetNhanVien(email);
        }

        public bool UpdateNhanVien(NhanVien obj)
        {
            return respositorys.UpdateNhanVien(obj);
        }
    }
}
