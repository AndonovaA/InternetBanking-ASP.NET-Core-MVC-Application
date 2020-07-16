using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingSystemMVC.Migrations
{
    public partial class spelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identificaton",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Identification",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identification",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Identificaton",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
