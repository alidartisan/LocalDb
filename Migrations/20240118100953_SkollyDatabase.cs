using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcLocalDb.Migrations
{
    /// <inheritdoc />
    public partial class SkollyDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeeRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StdId = table.Column<int>(type: "int", nullable: false),
                    FeeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeeMonth = table.Column<DateOnly>(type: "date", nullable: false),
                    FeeYear = table.Column<DateOnly>(type: "date", nullable: false),
                    FeeAmount = table.Column<int>(type: "int", nullable: false),
                    FeeBalance = table.Column<int>(type: "int", nullable: false),
                    Fine = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeeRecord");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
