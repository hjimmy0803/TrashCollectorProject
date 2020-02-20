using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class DeletedBindFromCustomerCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e98480c8-ac11-47c0-855d-81217c3043d3", "ea34afae-afce-4c1c-a2f6-12380003a7af", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3fade7e-b6fa-4c85-802d-df45df54c1c7", "1038673b-dabd-4bfd-b12a-237fd1ac08d6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e627f6a-cb2a-45dd-a6a8-ed06b469ec7d", "67b31d6e-925f-4a0d-abde-0d83e8dec732", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e627f6a-cb2a-45dd-a6a8-ed06b469ec7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3fade7e-b6fa-4c85-802d-df45df54c1c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e98480c8-ac11-47c0-855d-81217c3043d3");

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
    }
}
