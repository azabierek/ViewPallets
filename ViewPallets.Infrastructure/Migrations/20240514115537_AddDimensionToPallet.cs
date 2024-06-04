using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViewPallets.Infrastructure.Migrations
{
    public partial class AddDimensionToPallet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Pallet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Pallet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Pallet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Pallet");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Pallet");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Pallet");
        }
    }
}
