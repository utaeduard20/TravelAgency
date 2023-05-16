using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAgencyTest.Data.Migrations
{
    public partial class DismissBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holiday_Booking_BookingId",
                table: "Holiday");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Holiday_HotelId",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Holiday_HolidayId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AirlineCompany_AirlineId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Booking_BookingId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Holiday_HolidayId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_BookingId",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotel",
                table: "Hotel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday");

            migrationBuilder.DropIndex(
                name: "IX_Holiday_BookingId",
                table: "Holiday");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AirlineCompany",
                table: "AirlineCompany");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Holiday");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Hotel",
                newName: "Hotels");

            migrationBuilder.RenameTable(
                name: "Holiday",
                newName: "Holidays");

            migrationBuilder.RenameTable(
                name: "AirlineCompany",
                newName: "AirlineCompanies");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_HolidayId",
                table: "Tickets",
                newName: "IX_Tickets_HolidayId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_AirlineId",
                table: "Tickets",
                newName: "IX_Tickets_AirlineId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_HolidayId",
                table: "Reviews",
                newName: "IX_Reviews_HolidayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "TicketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels",
                column: "HotelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays",
                column: "HolidayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirlineCompanies",
                table: "AirlineCompanies",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Holidays_HotelId",
                table: "Hotels",
                column: "HotelId",
                principalTable: "Holidays",
                principalColumn: "HolidayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Holidays_HolidayId",
                table: "Reviews",
                column: "HolidayId",
                principalTable: "Holidays",
                principalColumn: "HolidayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AirlineCompanies_AirlineId",
                table: "Tickets",
                column: "AirlineId",
                principalTable: "AirlineCompanies",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Holidays_HolidayId",
                table: "Tickets",
                column: "HolidayId",
                principalTable: "Holidays",
                principalColumn: "HolidayId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Holidays_HotelId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Holidays_HolidayId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AirlineCompanies_AirlineId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Holidays_HolidayId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AirlineCompanies",
                table: "AirlineCompanies");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Hotels",
                newName: "Hotel");

            migrationBuilder.RenameTable(
                name: "Holidays",
                newName: "Holiday");

            migrationBuilder.RenameTable(
                name: "AirlineCompanies",
                newName: "AirlineCompany");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_HolidayId",
                table: "Ticket",
                newName: "IX_Ticket_HolidayId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_AirlineId",
                table: "Ticket",
                newName: "IX_Ticket_AirlineId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_HolidayId",
                table: "Review",
                newName: "IX_Review_HolidayId");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Ticket",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Holiday",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "TicketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotel",
                table: "Hotel",
                column: "HotelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday",
                column: "HolidayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirlineCompany",
                table: "AirlineCompany",
                column: "AirlineId");

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_BookingId",
                table: "Ticket",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_BookingId",
                table: "Holiday",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Holiday_Booking_BookingId",
                table: "Holiday",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Holiday_HotelId",
                table: "Hotel",
                column: "HotelId",
                principalTable: "Holiday",
                principalColumn: "HolidayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Holiday_HolidayId",
                table: "Review",
                column: "HolidayId",
                principalTable: "Holiday",
                principalColumn: "HolidayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AirlineCompany_AirlineId",
                table: "Ticket",
                column: "AirlineId",
                principalTable: "AirlineCompany",
                principalColumn: "AirlineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Booking_BookingId",
                table: "Ticket",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Holiday_HolidayId",
                table: "Ticket",
                column: "HolidayId",
                principalTable: "Holiday",
                principalColumn: "HolidayId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
