using DAL.IRespositorys;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorys
{
    public class LoaiSpRespositorys : ILoaiSpRespositorys
    {
        CoffeeDbContext _context;
        public LoaiSpRespositorys()
        {
            _context = new CoffeeDbContext();
        }
        public bool AddLoaiSp(LoaiSp obj)
        {
            try
            {
                _context.loaiSps.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLoaiSp(Guid id)
        {
            try
            {
                var Lsp = _context.loaiSps.Find(id);
                _context.loaiSps.Remove(Lsp);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<LoaiSp> GetAllLoaiSp()
        {
            return _context.loaiSps.ToList();
        }

        public LoaiSp GetLoaiSpByid(Guid id)
        {
            return _context.loaiSps.Find(id);
        }

        public bool UpdateLoaiSp(LoaiSp obj)
        {
            try
            {
                var idlsp = _context.loaiSps.Find(obj.Id);
                idlsp.TenLoai = obj.TenLoai;
                idlsp.MoTa = obj.MoTa;
                _context.loaiSps.Update(idlsp);
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
