using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TopHatFamDoc.Migrations
{
    public partial class Addedpacientitable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pacientiid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pacienti",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nume = table.Column<string>(nullable: false),
                    Prenume = table.Column<string>(nullable: false),
                    ZiuaNastere = table.Column<DateTime>(nullable: false),
                    DataInregistrare = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacienti", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Pacientiid",
                table: "AspNetUsers",
                column: "Pacientiid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Pacienti_Pacientiid",
                table: "AspNetUsers",
                column: "Pacientiid",
                principalTable: "Pacienti",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Pacienti_Pacientiid",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Pacienti");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Pacientiid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pacientiid",
                table: "AspNetUsers");
        }
    }
}
