using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class DeletedCustomersAndEmployeesInApplicationDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c1fd312-d726-4ae1-aa6c-bc0ce70020df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7d9fbcb-780c-4869-8135-ab5d00c8a7c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb31c516-ab48-4398-99cc-b79ef6f34e0d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a676d20-353f-497a-8c4f-9f7f6ae24db0", "6ac91590-275a-47a3-86d9-e9f1a3aef257", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b350961-7fbd-4643-95a3-b9d3a8f4ca30", "26aef3d5-c24a-48e1-bce2-6533b48c18d7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b319d0a6-a3e8-42e2-abf4-fc899b88e153", "a6211bea-cb7c-449a-83ad-65315424de3c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a676d20-353f-497a-8c4f-9f7f6ae24db0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b350961-7fbd-4643-95a3-b9d3a8f4ca30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b319d0a6-a3e8-42e2-abf4-fc899b88e153");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb31c516-ab48-4398-99cc-b79ef6f34e0d", "5387484b-98db-41e9-8157-2adc58e63bf4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c1fd312-d726-4ae1-aa6c-bc0ce70020df", "d349d1a3-e8a1-4482-abb4-27bf1a78543b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7d9fbcb-780c-4869-8135-ab5d00c8a7c0", "d94b7325-33fe-459b-bf2e-463c6df332ab", "Employee", "EMPLOYEE" });
        }
    }
}
