using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Madeachangetotozipcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25cfb51e-f0a9-4f76-8463-e0184c5249fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79fced06-32fd-4dff-ab69-1f3d6c325b4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81e4532b-a425-4846-bfbd-41e3e091b0b1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "79fced06-32fd-4dff-ab69-1f3d6c325b4f", "d2e31c9c-3dc6-4bcd-a2fc-22da1042a982", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25cfb51e-f0a9-4f76-8463-e0184c5249fe", "569db33c-9a46-4fe2-9745-3130e4c47c8a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81e4532b-a425-4846-bfbd-41e3e091b0b1", "67e48f69-9752-4cda-91c0-dc987294c022", "Employee", "EMPLOYEE" });
        }
    }
}
