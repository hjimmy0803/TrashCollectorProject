using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Madechangestoemployeeview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e157f05-9e1f-4915-9dfa-0086c7de3458");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be094eca-f17a-4bf6-b69b-37401245008a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3738956-542b-400a-9cf7-e40bdf2d9792");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "be094eca-f17a-4bf6-b69b-37401245008a", "2a6ea86e-72bb-4e09-b0aa-a644bc5c538e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3738956-542b-400a-9cf7-e40bdf2d9792", "6baef6c6-ae1e-4ea7-948f-ca9d44e4fe12", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e157f05-9e1f-4915-9dfa-0086c7de3458", "dfba99ef-fc03-4daa-8121-1aa3ed9989f2", "Employee", "EMPLOYEE" });
        }
    }
}
