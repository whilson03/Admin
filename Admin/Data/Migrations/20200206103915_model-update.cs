using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class modelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c5cb910-5629-4261-848f-6f890a4988fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdd84cf2-d8d1-4fdf-9b1b-d1682959bf37");

            migrationBuilder.AddColumn<int>(
                name: "BankDetailId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df1f9aca-5d55-4b57-b652-86da02f2781a", "6e4949a4-1d4d-4a47-9834-40df97a5bff4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f68f1ae-5f63-4846-90cb-c263700c32c9", "af190f0e-72d0-448f-9447-92db42c475bf", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f68f1ae-5f63-4846-90cb-c263700c32c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df1f9aca-5d55-4b57-b652-86da02f2781a");

            migrationBuilder.DropColumn(
                name: "BankDetailId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdd84cf2-d8d1-4fdf-9b1b-d1682959bf37", "af2d8f99-d878-42df-b1fa-3edf53ded1db", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c5cb910-5629-4261-848f-6f890a4988fb", "1c57b068-8da5-4b1a-9778-d5b70c1e14fe", "Staff", "STAFF" });
        }
    }
}
