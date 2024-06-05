using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ViewPallets.Infrastructure.Migrations
{
    public partial class AddProjectDataToEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Pallet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "Pallet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Pallet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Pallet");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Pallet");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Pallet");
        }
    }
}
