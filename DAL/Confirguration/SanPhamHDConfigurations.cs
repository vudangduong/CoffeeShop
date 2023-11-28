using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Confirguration
{
    public class SanPhamHDConfigurations : IEntityTypeConfiguration<SP_HD>
    {
        public void Configure(EntityTypeBuilder<SP_HD> builder)
        {
            builder.HasOne(c => c.HoaDon).WithMany().HasForeignKey(c => c.IdHd);
            builder.HasOne(c => c.SanPham).WithMany().HasForeignKey(c => c.IdSp);
        }
    }
}
