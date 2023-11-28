using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenBan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "khuyenMais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhamTramGiam = table.Column<int>(type: "int", nullable: false),
                    SoTienGiam = table.Column<int>(type: "int", nullable: false),
                    DkGiam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khuyenMais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loaiSps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiSps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucVu = table.Column<int>(type: "int", nullable: false),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenSp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    LoaiSpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sanPhams_loaiSps_LoaiSpId",
                        column: x => x.LoaiSpId,
                        principalTable: "loaiSps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNv = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKm = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongTien = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KhuyenMaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoaDons_khuyenMais_KhuyenMaiId",
                        column: x => x.KhuyenMaiId,
                        principalTable: "khuyenMais",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "nhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ban_HDs",
                columns: table => new
                {
                    IdHd = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    BanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ban_HDs", x => x.IdHd);
                    table.ForeignKey(
                        name: "FK_ban_HDs_bans_BanId",
                        column: x => x.BanId,
                        principalTable: "bans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ban_HDs_hoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "hoaDons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "sP_HDs",
                columns: table => new
                {
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHd = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    SanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sP_HDs", x => x.IdSp);
                    table.ForeignKey(
                        name: "FK_sP_HDs_hoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "hoaDons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_sP_HDs_sanPhams_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "sanPhams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ban_HDs_BanId",
                table: "ban_HDs",
                column: "BanId");

            migrationBuilder.CreateIndex(
                name: "IX_ban_HDs_HoaDonId",
                table: "ban_HDs",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_KhuyenMaiId",
                table: "hoaDons",
                column: "KhuyenMaiId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_NhanVienId",
                table: "hoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_LoaiSpId",
                table: "sanPhams",
                column: "LoaiSpId");

            migrationBuilder.CreateIndex(
                name: "IX_sP_HDs_HoaDonId",
                table: "sP_HDs",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_sP_HDs_SanPhamId",
                table: "sP_HDs",
                column: "SanPhamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ban_HDs");

            migrationBuilder.DropTable(
                name: "sP_HDs");

            migrationBuilder.DropTable(
                name: "bans");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "khuyenMais");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "loaiSps");
        }
    }
}
