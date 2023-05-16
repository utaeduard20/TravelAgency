using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAgencyTest.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirlineCompany",
                columns: table => new
                {
                    AirlineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlineCompany", x => x.AirlineId);
                });

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

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    HolidayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    BookingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.HolidayId);
                    table.ForeignKey(
                        name: "FK_Holiday_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    AllInclusive = table.Column<bool>(nullable: false),
                    Healthcare = table.Column<bool>(nullable: false),
                    Days = table.Column<int>(nullable: false),
                    Rooms = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotel_Holiday_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Holiday",
                        principalColumn: "HolidayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    HolidayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Holiday_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "Holiday",
                        principalColumn: "HolidayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: false),
                    Departure = table.Column<DateTime>(nullable: false),
                    Arrival = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    HolidayId = table.Column<int>(nullable: false),
                    AirlineId = table.Column<int>(nullable: false),
                    BookingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Ticket_AirlineCompany_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "AirlineCompany",
                        principalColumn: "AirlineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Holiday_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "Holiday",
                        principalColumn: "HolidayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_BookingId",
                table: "Holiday",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_HolidayId",
                table: "Review",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_AirlineId",
                table: "Ticket",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_BookingId",
                table: "Ticket",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_HolidayId",
                table: "Ticket",
                column: "HolidayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "AirlineCompany");

            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DropTable(
                name: "Booking");
        }
    }
}
