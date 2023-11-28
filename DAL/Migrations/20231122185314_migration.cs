using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ban_HDs",
                table: "ban_HDs");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdBan",
                table: "ban_HDs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ban_HDs",
                table: "ban_HDs",
                columns: new[] { "IdBan", "IdHd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ban_HDs",
                table: "ban_HDs");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdBan",
                table: "ban_HDs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ban_HDs",
                table: "ban_HDs",
                column: "IdHd");
        }
    }
}
