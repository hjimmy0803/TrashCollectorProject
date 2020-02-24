using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Madechangestoedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09c01f57-217d-4d8d-9e78-4ce4242b7e41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f1e27a2-5ebd-47c3-940d-8d9f4da884ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6127df4-3877-4758-af7e-af7ca28ee87b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "a6127df4-3877-4758-af7e-af7ca28ee87b", "ecafeac6-4285-4488-9318-895be6bdbc60", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f1e27a2-5ebd-47c3-940d-8d9f4da884ad", "cd1e48d5-5b42-4165-855d-4f77bdea8997", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09c01f57-217d-4d8d-9e78-4ce4242b7e41", "ba89beb8-3134-4855-b63b-50ed0115406f", "Employee", "EMPLOYEE" });
        }
    }
}
