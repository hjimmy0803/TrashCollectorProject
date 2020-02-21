using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class ChangedCustomerCreateView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f0812f6-24e8-411a-8bca-56da2069a752");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "904957fc-e463-4010-9288-c782fec7925b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab90f08-5481-46c0-a96d-83fae4262848");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c0f0910-409c-4e60-b887-241ab4f10988", "1f2201aa-dbd6-4784-9fc3-6c65ff564cea", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0527f7df-faea-41fc-afa8-56b1443f5e41", "5acc11b3-3827-446f-aaf5-26c50310c5e4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36507839-0789-4174-980c-e2b1e126f604", "f7441a59-f82f-4943-aa22-3620306d1edb", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0527f7df-faea-41fc-afa8-56b1443f5e41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c0f0910-409c-4e60-b887-241ab4f10988");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36507839-0789-4174-980c-e2b1e126f604");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f0812f6-24e8-411a-8bca-56da2069a752", "a053f2cf-c55a-4453-9612-429ce28a13ed", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "904957fc-e463-4010-9288-c782fec7925b", "27419474-1812-43e4-97fb-7e6d916df2b3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fab90f08-5481-46c0-a96d-83fae4262848", "eb66361c-d53d-4186-a9cd-e67e5247ee88", "Employee", "EMPLOYEE" });
        }
    }
}
