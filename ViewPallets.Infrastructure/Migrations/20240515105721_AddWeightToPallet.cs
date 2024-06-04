using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViewPallets.Infrastructure.Migrations
{
    public partial class AddWeightToPallet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Pallet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Pallet");
        }
    }
}
