using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addingaddressesdbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Account_AccountId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Address_AddressId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0527f7df-faea-41fc-afa8-56b1443f5e41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c0f0910-409c-4e60-b887-241ab4f10988");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36507839-0789-4174-980c-e2b1e126f604");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6feef49-0422-4c71-9012-713278221ca4", "6c73aceb-b513-4639-b4e8-c0e919c1f97b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "336bd617-69aa-4d75-93ba-acaed6b3ec2b", "a87fde25-fd1a-4deb-8472-31a87dbc4502", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d0476fd-ec7d-4c3e-b074-15e164b7e63a", "aabd851c-ca87-4e47-bf78-01c60567a9c8", "Employee", "EMPLOYEE" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Account_AccountId",
                table: "Customers",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Account_AccountId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "336bd617-69aa-4d75-93ba-acaed6b3ec2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d0476fd-ec7d-4c3e-b074-15e164b7e63a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6feef49-0422-4c71-9012-713278221ca4");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c0f0910-409c-4e60-b887-241ab4f10988", "1f2201aa-dbd6-4784-9fc3-6c65ff564cea", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0527f7df-faea-41fc-afa8-56b1443f5e41", "5acc11b3-3827-446f-aaf5-26c50310c5e4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36507839-0789-4174-980c-e2b1e126f604", "f7441a59-f82f-4943-aa22-3620306d1edb", "Employee", "EMPLOYEE" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Account_AccountId",
                table: "Customers",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Address_AddressId",
                table: "Customers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
