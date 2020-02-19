using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Addedroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfee5d24-4bb9-47b7-bf30-b838b1829855");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2e4be97-9bf5-487b-896e-56ff306931f0", "f383301f-ba06-4c38-a52d-5999fe9d1752", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "818a52a8-9845-415d-94bf-a05eca7781a0", "a9941a80-cb8f-4609-a260-39b51ff26586", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96231baf-7f3b-4f23-ba2c-ff8e1e9de47a", "3f503ba5-90fa-4be3-9032-5775ceac660f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "818a52a8-9845-415d-94bf-a05eca7781a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96231baf-7f3b-4f23-ba2c-ff8e1e9de47a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2e4be97-9bf5-487b-896e-56ff306931f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dfee5d24-4bb9-47b7-bf30-b838b1829855", "38731d60-12f5-4a1b-85cb-64cf08764715", "Admin", "ADMIN" });
        }
    }
}
