using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Madesomechangestoemployercontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00d64d54-6b4c-4414-981e-18db94a5d5b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7bfa39a-f887-4b29-a905-9234e61fb695");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3478806-f31a-44dc-83d0-c6895e4a7089");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d07a9c3a-66fa-46a2-8d58-671d2f19817b", "b5a63890-87bc-47cf-aad2-cdf9cd31d8c9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d848317-4b20-42f8-afaa-d8500a6578fb", "839eca90-1ad2-430c-80c1-a9e46764a048", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f60ba194-0d4a-416b-b1de-b6d08a82b669", "609eef99-3f63-4589-8395-e6ab8ae57d4e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d848317-4b20-42f8-afaa-d8500a6578fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d07a9c3a-66fa-46a2-8d58-671d2f19817b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f60ba194-0d4a-416b-b1de-b6d08a82b669");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3478806-f31a-44dc-83d0-c6895e4a7089", "fe30781d-7f9f-4785-b2ef-f0a3102fdfb9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7bfa39a-f887-4b29-a905-9234e61fb695", "3b585f73-cef6-4c17-a74e-2bc96c93e02f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00d64d54-6b4c-4414-981e-18db94a5d5b8", "c46946e4-3c23-4cf4-b5a8-fc65453a1d6e", "Employee", "EMPLOYEE" });
        }
    }
}
