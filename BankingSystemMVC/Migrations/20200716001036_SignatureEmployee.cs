using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingSystemMVC.Migrations
{
    public partial class SignatureEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Employees");
        }
    }
}
