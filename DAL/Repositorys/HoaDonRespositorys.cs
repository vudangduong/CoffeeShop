using DAL.IRespositorys;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorys
{
    public class HoaDonRespositorys : IHoaDonRespositorys
    {
        CoffeeDbContext _context;
        public HoaDonRespositorys()
        {
            _context = new CoffeeDbContext();
        }
        public bool AddHoaDon(HoaDon obj)
        {
            try
            {
                _context.hoaDons.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoaDon(Guid id)
        {
            try
            {
                var idhd = _context.hoaDons.Find(id);
                _context.hoaDons.Remove(idhd);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return _context.hoaDons.ToList();
        }

        public HoaDon GetHoaDonByid(Guid id)
        {
            return _context.hoaDons.Find(id);
        }

        public List<HoaDon> GetHoaDonUnCheck()
        {
            return _context.hoaDons.Where(p => p.TrangThai == 0).ToList();
        }

        public bool UpdateHoaDon(HoaDon obj)
        {
            try
            {
                var hd = _context.hoaDons.Find(obj.Id);
                hd.IdNv = obj.IdNv;
                hd.IdKm = obj.IdKm;
                hd.NgayTao = obj.NgayTao;
                hd.NgayThanhToan = obj.NgayThanhToan;
                hd.TongTien = obj.TongTien;
                hd.TrangThai = obj.TrangThai;
                _context.hoaDons.Update(hd);
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
