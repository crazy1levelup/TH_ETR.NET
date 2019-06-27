using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TopHatFamDoc.Migrations
{
    public partial class Addedpat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Pacienti",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Notes",
                table: "Pacienti",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
