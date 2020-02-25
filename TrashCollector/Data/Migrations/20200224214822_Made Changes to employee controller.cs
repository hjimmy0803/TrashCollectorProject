using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class MadeChangestoemployeecontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a6d2e1a-4d58-477e-a741-67b3a378e59f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85a83e32-2216-477a-ac90-6df18cab137d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a524a1-2729-454a-b7b7-178cbaa6a20b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e0a524a1-2729-454a-b7b7-178cbaa6a20b", "20794eca-c8b3-4dac-bf16-41287ad14a09", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85a83e32-2216-477a-ac90-6df18cab137d", "bf701dec-5073-473e-9af7-ac17eaa73d3b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a6d2e1a-4d58-477e-a741-67b3a378e59f", "e228dcc4-8a7c-4bdb-869b-afadbf189a30", "Employee", "EMPLOYEE" });
        }
    }
}
