using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2WebApplication.Data.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Window",
                table: "Room",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SuiteNumber",
                table: "Room",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(999)");

            migrationBuilder.AlterColumn<int>(
                name: "RoomNumber",
                table: "Room",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(999)");

            migrationBuilder.AlterColumn<int>(
                name: "RentAmount",
                table: "Room",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(999)");

            migrationBuilder.AlterColumn<string>(
                name: "Occupied",
                table: "Room",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Closit",
                table: "Room",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bathroom",
                table: "Room",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Window",
                table: "Room",
                type: "nvarchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SuiteNumber",
                table: "Room",
                type: "nvarchar(999)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Room",
                type: "nvarchar(999)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "RentAmount",
                table: "Room",
                type: "nvarchar(999)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Occupied",
                table: "Room",
                type: "nvarchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Closit",
                table: "Room",
                type: "nvarchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bathroom",
                table: "Room",
                type: "nvarchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
