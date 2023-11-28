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
    public class BanServices : IBanServices
    {
        CoffeeDbContext _context;
        iBanRepositorys _repositorys;
        public BanServices()
        {
            _context = new CoffeeDbContext();
            _repositorys = new BanRepositorys();

        }
        public bool AddBan(Ban obj)
        {
            _repositorys.AddBan(obj);
            return true;
        }

        public bool DeleteBan(Guid id)
        {
            _repositorys.DeleteBan(id);
            return true;
        }

        public List<Ban> GetAllBan()
        {
            return _repositorys.GetAllBan();
        }

        public Ban GetBanByid(Guid id)
        {
            return _repositorys.GetBanByid(id);
        }

        public bool UpdateBan(Ban obj)
        {
            _repositorys.UpdateBan(obj);
            return true;
        }
    }
}
