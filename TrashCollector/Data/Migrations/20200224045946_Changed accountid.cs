using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Changedaccountid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "052bb470-9c24-461c-b1d3-d95ac25fd4b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3af6adf0-7835-403c-9cc0-7cb9949e5b42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48d5ba29-9581-464a-bdb8-8f1b949c558c");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "052bb470-9c24-461c-b1d3-d95ac25fd4b0", "b3da12ea-4f34-4772-84de-35937c5b51f2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48d5ba29-9581-464a-bdb8-8f1b949c558c", "1f205efd-6e93-4227-a98c-907ffefda865", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3af6adf0-7835-403c-9cc0-7cb9949e5b42", "b144e678-e2de-4e9a-b3a7-d5f4803723a3", "Employee", "EMPLOYEE" });
        }
    }
}
