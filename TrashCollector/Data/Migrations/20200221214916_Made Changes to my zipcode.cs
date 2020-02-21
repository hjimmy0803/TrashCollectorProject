using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class MadeChangestomyzipcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ZipeCode",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OneTimePickup",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7da210b-2625-4ab2-ab68-cb3ff9755395", "23adb856-7eda-47d8-aac8-2d7096127941", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82230f8a-f59c-4d8d-95a7-77f8cbc47cdf", "fc9364c1-8600-403d-975b-21b410adb5f0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74166bbf-6d62-49e5-a720-249eb22732a0", "03ce2aa4-b61f-470a-aa4e-0e62f2f709bf", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74166bbf-6d62-49e5-a720-249eb22732a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82230f8a-f59c-4d8d-95a7-77f8cbc47cdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7da210b-2625-4ab2-ab68-cb3ff9755395");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "OneTimePickup",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "ZipeCode",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
