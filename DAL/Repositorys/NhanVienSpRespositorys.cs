using DAL.IRespositorys;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorys
{
    public class NhanVienSpRespositorys : INhanVienRespositorys
    {
        CoffeeDbContext _context;
        public NhanVienSpRespositorys()
        {
            _context = new CoffeeDbContext();
        }
        public bool AddNhanVien(NhanVien obj)
        {
            try
            {
                _context.nhanViens.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteNhanVien(Guid id)
        {
            try
            {
                var idnv = _context.nhanViens.Find(id);
                _context.nhanViens.Remove(idnv);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return _context.nhanViens.ToList();
        }

        public NhanVien GetNhanVien(string email)
        {
            return _context.nhanViens.FirstOrDefault(p => p.Email.ToLower().Equals(email.ToLower()));
        }

        public bool UpdateNhanVien(NhanVien obj)
        {
            try
            {
                var idnv = _context.nhanViens.Find(obj.Id);
                idnv.MaNv = obj.MaNv;
                idnv.HoTen = obj.HoTen;
                idnv.GioiTinh = obj.GioiTinh;
                idnv.Sdt = obj.Sdt;
                idnv.Email = obj.Email;
                idnv.ChucVu = obj.ChucVu;
                idnv.TaiKhoan = obj.TaiKhoan;
                idnv.MatKhau = obj.MatKhau;
                idnv.TrangThai = obj.TrangThai;
                _context.nhanViens.Update(idnv);
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
