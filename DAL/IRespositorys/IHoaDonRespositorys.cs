using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRespositorys
{
    public interface IHoaDonRespositorys
    {
        bool AddHoaDon(HoaDon obj);

        bool DeleteHoaDon(Guid id);

        bool UpdateHoaDon(HoaDon obj);

        List<HoaDon> GetAllHoaDon();
        HoaDon GetHoaDonByid(Guid id);
        List<HoaDon> GetHoaDonUnCheck();
    }
}
