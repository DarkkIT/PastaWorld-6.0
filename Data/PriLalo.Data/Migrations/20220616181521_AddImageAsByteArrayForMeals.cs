using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PriLalo.Data.Migrations
{
    public partial class AddImageAsByteArrayForMeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Meals",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Meals");
        }
    }
}
