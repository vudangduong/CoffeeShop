using DAL.IRespositorys;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorys
{
    public class BanRepositorys : iBanRepositorys
    {
        CoffeeDbContext _context;
        public BanRepositorys()
        {
            _context = new CoffeeDbContext();
        }
        public bool AddBan(Ban obj)
        {
            try
            {
                _context.bans.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteBan(Guid id)
        {
            try
            {
                var idban = _context.bans.Find(id);
                _context.bans.Remove(idban);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Ban> GetAllBan()
        {
            return _context.bans.ToList();
        }

        public Ban GetBanByid(Guid id)
        {
            return _context.bans.Find(id);
        }

        public bool UpdateBan(Ban obj)
        {
            try
            {
                var ban = _context.bans.Find(obj.Id);
                ban.TenBan = obj.TenBan;
                ban.TrangThai = obj.TrangThai;
                _context.Update(ban);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
