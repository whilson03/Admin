using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class policymodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "857d97b6-f379-48b1-a88b-b74ba5bc444a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f554b2d0-b92b-4dfb-bea1-2ed3d3892724");

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Member_Circle = table.Column<int>(nullable: false),
                    Allow_Circle = table.Column<int>(nullable: false),
                    Allowcheck = table.Column<bool>(nullable: false),
                    Chargecheck = table.Column<bool>(nullable: false),
                    Reusecheck = table.Column<bool>(nullable: false),
                    Disallowcheck = table.Column<bool>(nullable: false),
                    Maximum_mem = table.Column<int>(nullable: false),
                    Pay_mem = table.Column<string>(nullable: true),
                    Every = table.Column<int>(nullable: false),
                    Member_num = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8af30aa-7ee4-4197-a353-4455a92c6086", "4d607965-e2fa-40fb-8715-b03493f5a920", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ae5e975-91b0-4928-a843-595748e554d3", "7d69bda4-01a1-4e4f-861a-ab1c03e7f77a", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ae5e975-91b0-4928-a843-595748e554d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8af30aa-7ee4-4197-a353-4455a92c6086");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "857d97b6-f379-48b1-a88b-b74ba5bc444a", "cafdf554-3d3d-40a9-9b47-97035cc8c529", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f554b2d0-b92b-4dfb-bea1-2ed3d3892724", "8ade30cd-09bd-4061-a53c-3a47db487c80", "Staff", "STAFF" });
        }
    }
}
