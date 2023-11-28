using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ILoaiSpServices
    {
        bool AddLoaiSp(LoaiSp obj);

        bool DeleteLoaiSp(Guid id);

        bool UpdateLoaiSp(LoaiSp obj);

        List<LoaiSp> GetAllLoaiSp();
    }
}
