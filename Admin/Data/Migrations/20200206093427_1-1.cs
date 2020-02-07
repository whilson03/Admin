using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36f69c05-703b-41ac-aa7c-3c3eaa79fb71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f20a095-643a-4767-a16a-e7280eaaf5a8");

            migrationBuilder.DropColumn(
                name: "BankDetailId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PaymentDetailId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "PaymentDetailId",
                table: "PaymentDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a28a7c78-fa72-4245-aa38-d15dd9a6c13f", "82df2b7b-b40d-4d38-a5f6-194786d75c34", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0351165d-f55c-4aed-b649-c8662a8989a2", "8a48ad03-6ffc-4b39-a74a-4028fa1b3260", "Staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0351165d-f55c-4aed-b649-c8662a8989a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a28a7c78-fa72-4245-aa38-d15dd9a6c13f");

            migrationBuilder.DropColumn(
                name: "PaymentDetailId",
                table: "PaymentDetails");

            migrationBuilder.AddColumn<string>(
                name: "BankDetailId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentDetailId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f20a095-643a-4767-a16a-e7280eaaf5a8", "434e2ad5-3d48-401d-bfc7-c42f08472fa0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36f69c05-703b-41ac-aa7c-3c3eaa79fb71", "82d1f473-7294-4229-9e15-086e91dd0849", "Staff", "STAFF" });
        }
    }
}
