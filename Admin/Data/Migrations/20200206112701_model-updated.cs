using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class modelupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f68f1ae-5f63-4846-90cb-c263700c32c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df1f9aca-5d55-4b57-b652-86da02f2781a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2109d2f-da76-4741-91ac-88878f982f33", "a632f217-ebf1-402b-8f2a-f17b80f4e4ac", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9845699-e617-4a71-9abb-5b861db90e37", "6934022f-8133-40c3-967f-abe77829546a", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "df1f9aca-5d55-4b57-b652-86da02f2781a", "6e4949a4-1d4d-4a47-9834-40df97a5bff4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f68f1ae-5f63-4846-90cb-c263700c32c9", "af190f0e-72d0-448f-9447-92db42c475bf", "Staff", "STAFF" });
        }
    }
}
