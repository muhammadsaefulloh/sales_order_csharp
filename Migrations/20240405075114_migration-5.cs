using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSAEFULLOHC_.Migrations
{
    /// <inheritdoc />
    public partial class migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SalesOrderNo",
                table: "SalesOrder",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SalesOrderNo",
                table: "SalesOrder",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);
        }
    }
}
