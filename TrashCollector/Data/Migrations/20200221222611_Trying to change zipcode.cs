using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Tryingtochangezipcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1038a71e-f17a-4aca-95cc-81376f15627f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84d319c5-0b52-41f0-98eb-71aa53dc92ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8220ac8-abff-4837-94b3-b66c8bb0bcc3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f6e2d2b-4804-4238-a963-1376ec725784", "884e1beb-e1e5-47bc-a51d-fd4af664b2d8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbd87bb4-03e9-4818-b503-b303d1d23b60", "78bdc47e-166f-4979-8b71-b83ee6a80204", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd3b8d8f-ff02-41f9-af1d-004c86cef035", "80c44498-a8a3-4da3-a2b1-c103de6dec23", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f6e2d2b-4804-4238-a963-1376ec725784");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd3b8d8f-ff02-41f9-af1d-004c86cef035");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbd87bb4-03e9-4818-b503-b303d1d23b60");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8220ac8-abff-4837-94b3-b66c8bb0bcc3", "e43f0ff7-d258-4ea8-86bd-aeb222ed40ef", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1038a71e-f17a-4aca-95cc-81376f15627f", "217084d2-4b6a-494c-81b7-12e38ff59732", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84d319c5-0b52-41f0-98eb-71aa53dc92ee", "0a7cefe8-09a0-4d91-9068-317783f893b4", "Employee", "EMPLOYEE" });
        }
    }
}
