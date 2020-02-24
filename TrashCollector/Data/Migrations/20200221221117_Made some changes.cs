using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Madesomechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74166bbf-6d62-49e5-a720-249eb22732a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82230f8a-f59c-4d8d-95a7-77f8cbc47cdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7da210b-2625-4ab2-ab68-cb3ff9755395");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79fced06-32fd-4dff-ab69-1f3d6c325b4f", "d2e31c9c-3dc6-4bcd-a2fc-22da1042a982", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25cfb51e-f0a9-4f76-8463-e0184c5249fe", "569db33c-9a46-4fe2-9745-3130e4c47c8a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81e4532b-a425-4846-bfbd-41e3e091b0b1", "67e48f69-9752-4cda-91c0-dc987294c022", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25cfb51e-f0a9-4f76-8463-e0184c5249fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79fced06-32fd-4dff-ab69-1f3d6c325b4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81e4532b-a425-4846-bfbd-41e3e091b0b1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7da210b-2625-4ab2-ab68-cb3ff9755395", "23adb856-7eda-47d8-aac8-2d7096127941", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82230f8a-f59c-4d8d-95a7-77f8cbc47cdf", "fc9364c1-8600-403d-975b-21b410adb5f0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74166bbf-6d62-49e5-a720-249eb22732a0", "03ce2aa4-b61f-470a-aa4e-0e62f2f709bf", "Employee", "EMPLOYEE" });
        }
    }
}
