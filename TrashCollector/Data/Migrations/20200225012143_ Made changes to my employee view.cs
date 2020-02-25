using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Madechangestomyemployeeview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "998283f2-9675-4720-a50e-48cc7f68e348", "00b59a34-7734-4e27-a5c5-7030965f3712", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "743399ef-75dd-4d4e-a64c-402a4ab408ea", "71d7d7eb-393a-4886-9ead-578b5ef379f1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5335e1e7-62bf-4e0a-8aa2-63c4605f97da", "33f0b9f9-7099-4f81-a320-43343615fbbd", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5335e1e7-62bf-4e0a-8aa2-63c4605f97da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "743399ef-75dd-4d4e-a64c-402a4ab408ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "998283f2-9675-4720-a50e-48cc7f68e348");

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
    }
}
