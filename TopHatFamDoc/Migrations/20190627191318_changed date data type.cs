using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TopHatFamDoc.Migrations
{
    public partial class changeddatedatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ZiuaNastere",
                table: "Pacienti",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Pacienti",
                type: "nvarchar(150)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Pacienti",
                type: "nvarchar(150)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Pacienti",
                type: "nvarchar(1000)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInregistrare",
                table: "Pacienti",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ZiuaNastere",
                table: "Pacienti",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Pacienti",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "Nume",
                table: "Pacienti",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Pacienti",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInregistrare",
                table: "Pacienti",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
