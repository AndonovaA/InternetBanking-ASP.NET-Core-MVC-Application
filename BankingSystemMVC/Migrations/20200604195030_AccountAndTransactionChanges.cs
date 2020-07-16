using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingSystemMVC.Migrations
{
    public partial class AccountAndTransactionChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Transactions");

            migrationBuilder.AddColumn<string>(
                name: "Receiver",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PendingBalance",
                table: "BankAccounts",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Receiver",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PendingBalance",
                table: "BankAccounts");

            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "To",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
