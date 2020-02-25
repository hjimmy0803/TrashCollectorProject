using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class MadeChangestoemployeecontrollertoaddcustomerzipcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0343df5c-020a-4817-ba17-c842e6085a07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63ab5d9f-16bb-43b5-9364-a746d4fca2a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aba5f698-98cd-4d73-9295-d64776dd3aff");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "63ab5d9f-16bb-43b5-9364-a746d4fca2a8", "1ade24c9-4c19-4c72-beb0-89226d220fa9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aba5f698-98cd-4d73-9295-d64776dd3aff", "3ef26495-2970-48c5-a16f-c3b31cfed1b6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0343df5c-020a-4817-ba17-c842e6085a07", "ea2dd7f5-23f7-4ced-8cb8-1be6b4efb803", "Employee", "EMPLOYEE" });
        }
    }
}
