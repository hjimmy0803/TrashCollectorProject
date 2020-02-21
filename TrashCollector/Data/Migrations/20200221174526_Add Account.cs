using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58183dd4-71bd-4ac5-8bb7-6835d0964005");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e422e3-0748-49b1-8325-383654f357f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8896cad-fe46-48fe-bb87-8424bd2f62b2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85ebd5aa-c714-44f9-b95e-990dedce9866", "4640a8f4-9f13-4c3d-a39a-0ac6939e1bc7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "058afd4f-0f0d-400b-a8d5-b2628b525ae2", "f529c9f5-c267-49d3-8170-86a0838de10a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef2ca3ac-6b43-4f95-a45e-6452228d4432", "e0eb0762-6745-454b-8059-250accd5f334", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "058afd4f-0f0d-400b-a8d5-b2628b525ae2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85ebd5aa-c714-44f9-b95e-990dedce9866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef2ca3ac-6b43-4f95-a45e-6452228d4432");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58183dd4-71bd-4ac5-8bb7-6835d0964005", "1c4c14bf-139e-4911-b820-8196a58a9ffe", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3e422e3-0748-49b1-8325-383654f357f9", "5f31c4cc-4be5-4ff2-a060-a2025404a55e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8896cad-fe46-48fe-bb87-8424bd2f62b2", "2925d8ba-1d74-49e1-b8e2-f33c417dbf18", "Employee", "EMPLOYEE" });
        }
    }
}
