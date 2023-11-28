using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CoffeeDbContext: DbContext
    {
        public CoffeeDbContext()
        {
            
        }
        public CoffeeDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<Ban> bans { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<LoaiSp> loaiSps { get; set; }
        public DbSet<KhuyenMai> khuyenMais { get; set; }
        public DbSet<Ban_HD> ban_HDs { get; set; }
        public DbSet<SP_HD> sP_HDs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.
                UseSqlServer(@"Data Source=DESKTOP-KH6N123\SQLEXPRESS;Initial Catalog=CoffeeShop02;Integrated Security=True"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban_HD>().HasKey(b => new { b.IdBan, b.IdHd });
        }
    }
}
