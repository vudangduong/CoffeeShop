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
    public class LoaiSpServices : ILoaiSpServices
    {
        CoffeeDbContext _context;
        private ILoaiSpRespositorys _loaiSpRespositorys;
        public LoaiSpServices()
        {
            _context = new CoffeeDbContext();
            _loaiSpRespositorys = new LoaiSpRespositorys();
        }
        public bool AddLoaiSp(LoaiSp obj)
        {
            _loaiSpRespositorys.AddLoaiSp(obj);
            return true;
        }

        public bool DeleteLoaiSp(Guid id)
        {
            _loaiSpRespositorys.DeleteLoaiSp(id);
            return true;
        }

        public List<LoaiSp> GetAllLoaiSp()
        {
            return _loaiSpRespositorys.GetAllLoaiSp().ToList();
        }

        public bool UpdateLoaiSp(LoaiSp obj)
        {
            _loaiSpRespositorys.UpdateLoaiSp(obj);
            return true;
        }
    }
}
