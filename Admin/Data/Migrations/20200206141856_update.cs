using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2109d2f-da76-4741-91ac-88878f982f33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9845699-e617-4a71-9abb-5b861db90e37");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ac29db7-3b0b-4d00-a35b-c0bc6294bee2", "605bb525-8ce1-49a9-8bcf-32f4f86dd17d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd20ee17-c404-4fe0-86d5-5b705d746c89", "a4af768d-c325-455c-81d9-54d8c1ce5690", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ac29db7-3b0b-4d00-a35b-c0bc6294bee2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd20ee17-c404-4fe0-86d5-5b705d746c89");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2109d2f-da76-4741-91ac-88878f982f33", "a632f217-ebf1-402b-8f2a-f17b80f4e4ac", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9845699-e617-4a71-9abb-5b861db90e37", "6934022f-8133-40c3-967f-abe77829546a", "Staff", "STAFF" });
        }
    }
}
