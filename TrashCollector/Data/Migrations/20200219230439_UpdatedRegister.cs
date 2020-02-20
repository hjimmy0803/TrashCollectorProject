using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatedRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4634df89-28a9-4584-b483-b5debc7f539c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2cf004-52dc-4985-841c-c7b98e2dde6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9909eafb-82a7-47ec-a9b5-82db37dba528");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5a2cf004-52dc-4985-841c-c7b98e2dde6e", "0d1a615e-042c-4a91-ad07-5884a54e142c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9909eafb-82a7-47ec-a9b5-82db37dba528", "b089ee5f-05f0-48cc-8546-793c1352381e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4634df89-28a9-4584-b483-b5debc7f539c", "e0da20e7-3557-43ff-b7e3-f332f3368a83", "Employee", "EMPLOYEE" });
        }
    }
}
