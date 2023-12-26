using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soild.data.Migrations
{
    public partial class CreatDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListCustomer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<int>(type: "int", nullable: true),
                    Credit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind = table.Column<int>(type: "int", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListCustomer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListInvoicing",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Reception_number = table.Column<int>(type: "int", nullable: false),
                    Enter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exiting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Payment = table.Column<double>(type: "float", nullable: false),
                    Dwell_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kind = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListInvoicing", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListCustomer");

            migrationBuilder.DropTable(
                name: "ListInvoicing");
        }
    }
}
