using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSAEFULLOHC_.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    PriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PriceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceValidateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PriceValidateTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.PriceId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Price");
        }
    }
}
