using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAgencyTest.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Reviews",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "HolidayId",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolidayId",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Reviews",
                newName: "Content");
        }
    }
}
