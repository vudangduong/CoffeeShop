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
    public class KhuyenMaiServices : IKhuyenMaiServices
    {
        CoffeeDbContext _context;
        private IKhuyenMaiRespositorys _khuyenMaiRespositorys;
        public KhuyenMaiServices()
        {
            _context = new CoffeeDbContext();
            _khuyenMaiRespositorys = new KhuyenMaiRespositorys();
        }
        public bool AddKhuyenMai(KhuyenMai obj)
        {
            _khuyenMaiRespositorys.AddKhuyenMai(obj); return true;
        }

        public bool DeleteKhuyenMai(Guid id)
        {
            _khuyenMaiRespositorys?.DeleteKhuyenMai(id);
            return true;
        }

        public List<KhuyenMai> GetAllKhuyenMai()
        {
            return _khuyenMaiRespositorys.GetAllKhuyenMai();
        }

        public KhuyenMai GetKhuyenByName(string name)
        {
            return _khuyenMaiRespositorys.GetKhuyenMaiByName(name);
        }

        public KhuyenMai GetKhuyenMaiByid(Guid id)
        {
            return _khuyenMaiRespositorys.GetKhuyenMaiByid(id);
        }

        public bool UpdateKhuyenMai(KhuyenMai obj)
        {
            _khuyenMaiRespositorys.UpdateKhuyenMai(obj);
            return true;
        }
        public List<KhuyenMai> GetKhuyenMais()
        {
            return _khuyenMaiRespositorys.GetAllKhuyenMai();
        }
    }
}
