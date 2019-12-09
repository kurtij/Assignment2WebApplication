using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2WebApplication.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suite",
                columns: table => new
                {
                    SuiteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SuiteNumber = table.Column<string>(type: "nvarchar(999)", nullable: false),
                    SuiteBuzzCode = table.Column<string>(type: "nvarchar(999)", nullable: false),
                    SqFootage = table.Column<string>(type: "nvarchar(999)", nullable: false),
                    NumberOfRooms = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NumberOfBathrooms = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suite", x => x.SuiteId);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SuiteId = table.Column<int>(nullable: false),
                    SuiteNumber = table.Column<string>(type: "nvarchar(999)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(999)", nullable: false),
                    RentAmount = table.Column<string>(type: "nvarchar(999)", nullable: false),
                    Occupied = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Window = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Closit = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Bathroom = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Room_Suite_SuiteId",
                        column: x => x.SuiteId,
                        principalTable: "Suite",
                        principalColumn: "SuiteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room_SuiteId",
                table: "Room",
                column: "SuiteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Suite");
        }
    }
}
