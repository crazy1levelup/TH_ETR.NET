using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TopHatFamDoc.Migrations
{
    public partial class Addedallfieldsforuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AspNetUsers",
                newName: "Prenume");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInregistrare",
                table: "AspNetUsers",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "AspNetUsers",
                type: "nvarchar(1000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ZiuaNastere",
                table: "AspNetUsers",
                type: "date",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataInregistrare",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nume",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ZiuaNastere",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Prenume",
                table: "AspNetUsers",
                newName: "FullName");
        }
    }
}
