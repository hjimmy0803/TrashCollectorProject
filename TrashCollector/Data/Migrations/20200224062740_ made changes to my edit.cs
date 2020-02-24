using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class madechangestomyedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0681ec0f-dbd6-4872-a893-a9adde923c92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d9f58ca-0e0a-4fef-8a77-26d118f0d821");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b527c95f-c9b9-4961-8b01-fbb8b657d13a");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b527c95f-c9b9-4961-8b01-fbb8b657d13a", "f09030fe-aefb-43a2-8987-e15baab9b870", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0681ec0f-dbd6-4872-a893-a9adde923c92", "6adfc0ca-d3f0-477c-a0c7-2589f79f18fd", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d9f58ca-0e0a-4fef-8a77-26d118f0d821", "611d9a77-67f5-48a4-a755-41ab831167c0", "Employee", "EMPLOYEE" });
        }
    }
}
