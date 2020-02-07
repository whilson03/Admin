using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class updatemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b6e9ea9-ed22-4d5d-89be-3728d6247239");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b29a6ccd-8f2e-49e4-94ba-c1b9fffc8e54");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e1886ba-c8f8-4fbe-9d98-2ddb48453196", "1a6fac4b-3272-4252-8aa4-582c52c4e4c1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d378a509-6cf2-4f4e-a77b-8b495678cf81", "ce54d058-2aae-4c8d-8cbb-1c0d3478ee44", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e1886ba-c8f8-4fbe-9d98-2ddb48453196");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d378a509-6cf2-4f4e-a77b-8b495678cf81");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b29a6ccd-8f2e-49e4-94ba-c1b9fffc8e54", "099ecfca-30cc-47bf-9363-8a7244d15917", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b6e9ea9-ed22-4d5d-89be-3728d6247239", "7ff3edf8-05ee-4648-a966-59d7a1c804aa", "Staff", "STAFF" });
        }
    }
}
