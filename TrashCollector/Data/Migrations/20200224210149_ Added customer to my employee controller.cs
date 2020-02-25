using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Addedcustomertomyemployeecontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "114d148c-c9f3-4955-b6aa-872aae3691ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13a076a0-c5d1-4eaa-ae1f-6b70b4c90df0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "869ebdce-7b1c-4e6b-98bd-d1fab411b83c");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "114d148c-c9f3-4955-b6aa-872aae3691ea", "89101058-af80-40f6-9c25-2a39f62839ce", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "869ebdce-7b1c-4e6b-98bd-d1fab411b83c", "a6074af8-92a8-4d9a-b373-f576c56e5d83", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13a076a0-c5d1-4eaa-ae1f-6b70b4c90df0", "a7e6cba3-23c4-41a5-8394-81f54bab26e8", "Employee", "EMPLOYEE" });
        }
    }
}
