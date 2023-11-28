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
    public class HoaDonServices : IHoaDonServices
    {
        IHoaDonRespositorys _hoaDonIRespositorys;
        public HoaDonServices()
        {
            _hoaDonIRespositorys = new HoaDonRespositorys();
        }
        public bool AddHoaDon(HoaDon? obj)
        {
            return _hoaDonIRespositorys.AddHoaDon(obj);
        }

        public bool DeleteHoaDon(Guid id)
        {
            return _hoaDonIRespositorys.DeleteHoaDon(id);
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return _hoaDonIRespositorys.GetAllHoaDon();
        }

        public HoaDon GetHoaDonByid(Guid id)
        {
            return _hoaDonIRespositorys.GetHoaDonByid(id);
        }

        public List<HoaDon> GetHoaDonUnCheck()
        {
            return _hoaDonIRespositorys.GetHoaDonUnCheck().ToList();
        }

        public bool UpdateHoaDon(HoaDon obj)
        {
            return _hoaDonIRespositorys.UpdateHoaDon(obj);
        }
    }
}
