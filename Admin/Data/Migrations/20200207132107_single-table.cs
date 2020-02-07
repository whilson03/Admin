using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class singletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "303534a8-1629-46a8-be83-d50f4a4572a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "363616a0-2c88-446c-83e3-4f862a2439ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "857d97b6-f379-48b1-a88b-b74ba5bc444a", "cafdf554-3d3d-40a9-9b47-97035cc8c529", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f554b2d0-b92b-4dfb-bea1-2ed3d3892724", "8ade30cd-09bd-4061-a53c-3a47db487c80", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "857d97b6-f379-48b1-a88b-b74ba5bc444a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f554b2d0-b92b-4dfb-bea1-2ed3d3892724");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "303534a8-1629-46a8-be83-d50f4a4572a9", "4064eba7-1031-46a4-85fe-2c033774b4de", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "363616a0-2c88-446c-83e3-4f862a2439ee", "5a35defe-7712-4a5b-b1c6-7b06e7d670ac", "Staff", "STAFF" });
        }
    }
}
