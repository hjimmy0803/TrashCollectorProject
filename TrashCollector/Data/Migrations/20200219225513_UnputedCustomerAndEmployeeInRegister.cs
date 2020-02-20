using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UnputedCustomerAndEmployeeInRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1142ac67-dac5-41e7-a3ea-157480545e1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b02fe54-ea10-413b-8c2b-3d39b256afa9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "881771d4-1e6d-4f9e-8123-c562678a3204");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "881771d4-1e6d-4f9e-8123-c562678a3204", "5366ae55-7ec2-4e44-869d-f9f6e0a11cf8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b02fe54-ea10-413b-8c2b-3d39b256afa9", "762f30b5-1a26-4379-b9e3-83fab7555ada", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1142ac67-dac5-41e7-a3ea-157480545e1a", "6430f0e9-68fb-4022-9303-926670d78ec3", "Employee", "EMPLOYEE" });
        }
    }
}
