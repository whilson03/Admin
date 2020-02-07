using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Data.Migrations
{
    public partial class memberidtostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BankDetails_BankDetailId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PaymentDetails_PaymentDetailId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BankDetailId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PaymentDetailId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e1886ba-c8f8-4fbe-9d98-2ddb48453196");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d378a509-6cf2-4f4e-a77b-8b495678cf81");

            migrationBuilder.AlterColumn<string>(
                name: "MemberId",
                table: "PaymentDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "MemberId",
                table: "BankDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "PaymentDetailId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankDetailId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f20a095-643a-4767-a16a-e7280eaaf5a8", "434e2ad5-3d48-401d-bfc7-c42f08472fa0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36f69c05-703b-41ac-aa7c-3c3eaa79fb71", "82d1f473-7294-4229-9e15-086e91dd0849", "Staff", "STAFF" });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_MemberId",
                table: "PaymentDetails",
                column: "MemberId",
                unique: true,
                filter: "[MemberId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_MemberId",
                table: "BankDetails",
                column: "MemberId",
                unique: true,
                filter: "[MemberId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_AspNetUsers_MemberId",
                table: "BankDetails",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetails_AspNetUsers_MemberId",
                table: "PaymentDetails",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankDetails_AspNetUsers_MemberId",
                table: "BankDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDetails_AspNetUsers_MemberId",
                table: "PaymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_PaymentDetails_MemberId",
                table: "PaymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_BankDetails_MemberId",
                table: "BankDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36f69c05-703b-41ac-aa7c-3c3eaa79fb71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f20a095-643a-4767-a16a-e7280eaaf5a8");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "PaymentDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "BankDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentDetailId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankDetailId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e1886ba-c8f8-4fbe-9d98-2ddb48453196", "1a6fac4b-3272-4252-8aa4-582c52c4e4c1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d378a509-6cf2-4f4e-a77b-8b495678cf81", "ce54d058-2aae-4c8d-8cbb-1c0d3478ee44", "Staff", "STAFF" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BankDetailId",
                table: "AspNetUsers",
                column: "BankDetailId",
                unique: true,
                filter: "[BankDetailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PaymentDetailId",
                table: "AspNetUsers",
                column: "PaymentDetailId",
                unique: true,
                filter: "[PaymentDetailId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BankDetails_BankDetailId",
                table: "AspNetUsers",
                column: "BankDetailId",
                principalTable: "BankDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PaymentDetails_PaymentDetailId",
                table: "AspNetUsers",
                column: "PaymentDetailId",
                principalTable: "PaymentDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
