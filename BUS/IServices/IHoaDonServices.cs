using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IHoaDonServices
    {
        public bool AddHoaDon(HoaDon? obj);

        public bool DeleteHoaDon(Guid id);

        public bool UpdateHoaDon(HoaDon obj);

        public List<HoaDon> GetAllHoaDon();
        public HoaDon GetHoaDonByid(Guid id);
        public List<HoaDon> GetHoaDonUnCheck();
    }
}
