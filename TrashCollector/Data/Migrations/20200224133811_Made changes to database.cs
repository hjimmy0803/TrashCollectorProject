using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Madechangestodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ee6885-b5d4-43d1-9d69-bb0953708f1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0ae23fe-6c50-422e-8f6d-198b66e935b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f757914e-c017-44cf-b4e8-66af39a9591d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "02ee6885-b5d4-43d1-9d69-bb0953708f1a", "8681b6a6-3dca-46ca-b318-67d464ff4ced", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0ae23fe-6c50-422e-8f6d-198b66e935b2", "c76ece3c-3132-4969-973d-2280287db561", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f757914e-c017-44cf-b4e8-66af39a9591d", "6c3f9115-a043-4596-93ce-d191c016e615", "Employee", "EMPLOYEE" });
        }
    }
}
