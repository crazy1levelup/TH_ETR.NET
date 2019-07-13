using Microsoft.EntityFrameworkCore.Migrations;

namespace TopHatFamDoc.Migrations
{
    public partial class removedpacientifromuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Pacienti_Pacientiid",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Pacientiid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pacientiid",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pacientiid",
                table: "AspNetUsers",
                nullable: true);

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
    }
}
