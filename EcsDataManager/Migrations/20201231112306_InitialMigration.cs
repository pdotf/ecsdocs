using Microsoft.EntityFrameworkCore.Migrations;

namespace EcsDataManager.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApnCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tell = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    OwnerTeam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WanIpRange = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AccessList = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NumberOfSimCard = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApnCustomers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    OwnerTeam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceTopology = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountManager = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IpHQ = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AAAGroup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IpTunnel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    WanIpRange = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LanIpRange = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    VRF = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    VpnToolsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AccessList = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    APN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerUrl",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isMain = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerUrl", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RadioName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadioIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadioModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadioMetroSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAuto = table.Column<short>(type: "smallint", nullable: false),
                    IsMain = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApnCustomers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CustomerUrl");

            migrationBuilder.DropTable(
                name: "DeviceList");
        }
    }
}
