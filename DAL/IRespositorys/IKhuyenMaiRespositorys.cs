using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRespositorys
{
    public interface IKhuyenMaiRespositorys
    {
        bool AddKhuyenMai(KhuyenMai obj);

        bool DeleteKhuyenMai(Guid id);

        bool UpdateKhuyenMai(KhuyenMai obj);

        List<KhuyenMai> GetAllKhuyenMai();
        KhuyenMai GetKhuyenMaiByid(Guid id);
        KhuyenMai GetKhuyenMaiByName(string name);
    }
}
