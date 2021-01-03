using Microsoft.EntityFrameworkCore.Migrations;

namespace EcsDataManager.Migrations
{
    public partial class ServiceTypeSizeIntranet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             

            migrationBuilder.AlterColumn<string>(
                name: "ServiceType",
                table: "IntranetCustomers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AlterColumn<string>(
                name: "ServiceType",
                table: "IntranetCustomers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
