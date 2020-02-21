using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Minorchangetoaccountmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Accounts_AccountId",
                table: "Customers");

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

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Accounts_AccountId",
                table: "Customers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Accounts_AccountId",
                table: "Customers");

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

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Accounts_AccountId",
                table: "Customers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
