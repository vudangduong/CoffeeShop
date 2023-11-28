using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRespositorys
{
    public interface IBan_HDRespositorys
    {
        bool AddBan_HD(Ban_HD obj);

        bool DeleteBan_HD(Ban_HD obj);

        bool UpdateBan_HD(Ban_HD obj);

        List<Ban_HD> GetAllBan_HD();
        List<Ban_HD> GetBan_HDByid(Guid id);
        Ban_HD GetBan_HDUnCheck(Guid id);
    }
}
