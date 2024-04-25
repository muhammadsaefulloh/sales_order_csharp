using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSAEFULLOHC_.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesOrder",
                columns: table => new
                {
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalesOrderNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CustCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrder", x => x.OrderDate);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderInterface",
                columns: table => new
                {
                    SalesOrderNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Payload = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderInterface", x => x.SalesOrderNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesOrder");

            migrationBuilder.DropTable(
                name: "SalesOrderInterface");
        }
    }
}
