using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class added_keyattr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0351165d-f55c-4aed-b649-c8662a8989a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a28a7c78-fa72-4245-aa38-d15dd9a6c13f");

            migrationBuilder.AddColumn<string>(
                name: "key",
                table: "PaymentDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "key",
                table: "BankDetails",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdd84cf2-d8d1-4fdf-9b1b-d1682959bf37", "af2d8f99-d878-42df-b1fa-3edf53ded1db", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c5cb910-5629-4261-848f-6f890a4988fb", "1c57b068-8da5-4b1a-9778-d5b70c1e14fe", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c5cb910-5629-4261-848f-6f890a4988fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdd84cf2-d8d1-4fdf-9b1b-d1682959bf37");

            migrationBuilder.DropColumn(
                name: "key",
                table: "PaymentDetails");

            migrationBuilder.DropColumn(
                name: "key",
                table: "BankDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a28a7c78-fa72-4245-aa38-d15dd9a6c13f", "82df2b7b-b40d-4d38-a5f6-194786d75c34", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0351165d-f55c-4aed-b649-c8662a8989a2", "8a48ad03-6ffc-4b39-a74a-4028fa1b3260", "Staff", "STAFF" });
        }
    }
}
