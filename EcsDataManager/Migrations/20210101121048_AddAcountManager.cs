using Microsoft.EntityFrameworkCore.Migrations;

namespace EcsDataManager.Migrations
{
    public partial class AddAcountManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcountManager",
                table: "IntranetCustomers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AcountManager",
                table: "ApnCustomers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcountManager",
                table: "IntranetCustomers");

            migrationBuilder.DropColumn(
                name: "AcountManager",
                table: "ApnCustomers");
        }
    }
}
