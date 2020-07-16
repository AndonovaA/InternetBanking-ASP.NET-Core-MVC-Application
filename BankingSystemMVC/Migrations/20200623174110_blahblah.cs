using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingSystemMVC.Migrations
{
    public partial class blahblah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsResident",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsResident",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
