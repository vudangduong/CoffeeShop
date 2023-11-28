using DAL.IRespositorys;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorys
{
    public class SP_HDRespositorys : ISP_HDRespositorys
    {
        CoffeeDbContext _context;
        public SP_HDRespositorys()
        {
            _context = new CoffeeDbContext();
        }
        public bool AddSP_HD(SP_HD obj)
        {
            try
            {
                _context.sP_HDs.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSP_HD(SP_HD obj)
        {
            try
            {
                var sp_hd = _context.sP_HDs.FirstOrDefault(p => p.IdHd == obj.IdHd && p.IdSp == obj.IdSp);
                _context.sP_HDs.Remove(sp_hd);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<SP_HD> GetAllSP_HD()
        {
            return _context.sP_HDs.ToList();
        }

        public SP_HD GetSP_HDByid(Guid id)
        {
            return _context.sP_HDs.Find(id);
        }

        public bool UpdateSP_HD(SP_HD obj)
        {
            try
            {
                var sp_hd = _context.sP_HDs.Find(obj.IdHd, obj.IdSp);
                _context.Remove(sp_hd);
                sp_hd.IdHd = obj.IdHd;
                sp_hd.IdSp = obj.IdSp;
                sp_hd.DonGia = obj.DonGia;
                sp_hd.SoLuong = obj.SoLuong;
                _context.sP_HDs.Add(obj);
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
