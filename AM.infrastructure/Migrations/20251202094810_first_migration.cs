using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class first_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "passengers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    emailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passportName = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    employmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<double>(type: "float", nullable: true),
                    healthInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "planes",
                columns: table => new
                {
                    planeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    planetype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planes", x => x.planeid);
                });

            migrationBuilder.CreateTable(
                name: "flights",
                columns: table => new
                {
                    flightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    effectiveArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estimateDuration = table.Column<int>(type: "int", nullable: false),
                    flightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    planeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flights", x => x.flightId);
                    table.ForeignKey(
                        name: "FK_flights_planes_planeid",
                        column: x => x.planeid,
                        principalTable: "planes",
                        principalColumn: "planeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightPassenger",
                columns: table => new
                {
                    flightsflightId = table.Column<int>(type: "int", nullable: false),
                    passengersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassenger", x => new { x.flightsflightId, x.passengersid });
                    table.ForeignKey(
                        name: "FK_FlightPassenger_flights_flightsflightId",
                        column: x => x.flightsflightId,
                        principalTable: "flights",
                        principalColumn: "flightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassenger_passengers_passengersid",
                        column: x => x.passengersid,
                        principalTable: "passengers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_passengersid",
                table: "FlightPassenger",
                column: "passengersid");

            migrationBuilder.CreateIndex(
                name: "IX_flights_planeid",
                table: "flights",
                column: "planeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPassenger");

            migrationBuilder.DropTable(
                name: "flights");

            migrationBuilder.DropTable(
                name: "passengers");

            migrationBuilder.DropTable(
                name: "planes");
        }
    }
}
