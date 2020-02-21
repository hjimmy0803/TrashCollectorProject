using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Changedroletouppercase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0859ab9c-198c-49e3-ac73-2c697d0adc2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "545e1c3c-eabd-4125-962d-944b0a6b13ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60cf55f7-10b0-4472-86cf-1f8af74cc5c6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e63b245-ed3b-46b8-bb0e-883f2bc85415", "dbe31044-8d80-4e62-b8e6-e086f0866c51", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e513226d-6bf3-400b-a289-a88ab92d5924", "5108c485-e990-403f-96f8-f11361d4622e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c6877fd-19ad-4264-9a99-1f68ed84b6ec", "a074b296-a3dc-4c17-ad35-21ef91b3a25b", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c6877fd-19ad-4264-9a99-1f68ed84b6ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e63b245-ed3b-46b8-bb0e-883f2bc85415");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e513226d-6bf3-400b-a289-a88ab92d5924");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "545e1c3c-eabd-4125-962d-944b0a6b13ef", "335222bc-4f1f-4a67-b542-54a8ecfc4c72", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60cf55f7-10b0-4472-86cf-1f8af74cc5c6", "cc9b6c28-b87a-454d-a19d-60dc65bf55d9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0859ab9c-198c-49e3-ac73-2c697d0adc2c", "19ae2a5d-2bf6-446f-8322-1635c919f1fc", "Employee", "EMPLOYEE" });
        }
    }
}
