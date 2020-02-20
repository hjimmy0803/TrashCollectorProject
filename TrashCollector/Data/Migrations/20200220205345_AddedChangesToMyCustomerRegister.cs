using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedChangesToMyCustomerRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16214ed6-43bf-4269-b685-d1b366e88dda");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2407a378-5931-42ef-b92d-6574f24cc406");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e22559c2-a263-47a3-a96b-49014cb48183");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31badf2d-adfc-4d62-9e3b-ec94120bcfcd", "3683f489-e6a4-4804-bc2a-ee5d4b150fd6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c4948e7-cf5f-4f7a-8323-da89c9dbe5cc", "72145b9f-d44c-437b-9501-3d59ebef6790", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eaba880c-583e-4efc-adf2-ffa246467467", "9b9056c3-dbad-43ad-b923-0b5d10076039", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c4948e7-cf5f-4f7a-8323-da89c9dbe5cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31badf2d-adfc-4d62-9e3b-ec94120bcfcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaba880c-583e-4efc-adf2-ffa246467467");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2407a378-5931-42ef-b92d-6574f24cc406", "9c4d1993-1aa5-44ee-9a3a-3156618619a3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16214ed6-43bf-4269-b685-d1b366e88dda", "9674de61-6f6d-4f13-85c2-6b259bca9b01", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e22559c2-a263-47a3-a96b-49014cb48183", "47670750-9ce1-4957-92c2-b2b554099663", "Employee", "EMPLOYEE" });
        }
    }
}
