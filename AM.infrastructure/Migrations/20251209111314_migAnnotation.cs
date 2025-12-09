using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_passengers_passengersid",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passengers",
                table: "passengers");

            migrationBuilder.DropColumn(
                name: "id",
                table: "passengers");

            migrationBuilder.RenameColumn(
                name: "passengersid",
                table: "FlightPassenger",
                newName: "passengerspassportName");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_passengersid",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_passengerspassportName");

            migrationBuilder.AlterColumn<int>(
                name: "passportName",
                table: "passengers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "passengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_passengers",
                table: "passengers",
                column: "passportName");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_passengers_passengerspassportName",
                table: "FlightPassenger",
                column: "passengerspassportName",
                principalTable: "passengers",
                principalColumn: "passportName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_passengers_passengerspassportName",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passengers",
                table: "passengers");

            migrationBuilder.RenameColumn(
                name: "passengerspassportName",
                table: "FlightPassenger",
                newName: "passengersid");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_passengerspassportName",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_passengersid");

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "passportName",
                table: "passengers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "passengers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_passengers",
                table: "passengers",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_passengers_passengersid",
                table: "FlightPassenger",
                column: "passengersid",
                principalTable: "passengers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
