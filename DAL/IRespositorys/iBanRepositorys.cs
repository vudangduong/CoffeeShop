using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRespositorys
{
    public interface iBanRepositorys
    {
        bool AddBan(Ban obj);

        bool DeleteBan(Guid id);

        bool UpdateBan(Ban obj);

        List<Ban> GetAllBan();
        Ban GetBanByid(Guid id);
    }
}
