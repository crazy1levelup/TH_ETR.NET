﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TopHatFamDoc.Migrations
{
    public partial class addedforeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Pacienti",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Pacienti");
        }
    }
}
