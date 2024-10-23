using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace K8S.DriverAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverNumber = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "AddedDate", "DateOfBirth", "DriverNumber", "FirstName", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1e200a4b-5fae-46b7-b78f-2caa5b1fc133"), new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9322), new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Max", "Verstappen", 1, new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9322) },
                    { new Guid("c74073d8-e3e4-472e-a57d-83127fbf8474"), new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9315), new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, "Lewis", "Hamilton", 1, new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9315) },
                    { new Guid("ebd19528-5541-4e20-b277-ee502f1e35bf"), new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9324), new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Charles", "Leclerc", 1, new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9324) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
