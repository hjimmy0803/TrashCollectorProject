using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class ChangedIdentityUserIdIntoAString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId1",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_IdentityUserId1",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a676d20-353f-497a-8c4f-9f7f6ae24db0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b350961-7fbd-4643-95a3-b9d3a8f4ca30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b319d0a6-a3e8-42e2-abf4-fc899b88e153");

            migrationBuilder.DropColumn(
                name: "IdentityUserId1",
                table: "Customer");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82398ca0-beaf-4fb7-983b-9dcfe3429649", "045b774f-ca8e-4c68-aa3f-b68ce54ee942", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4a4f5b0-edb4-4dd0-9641-7c268064ccc3", "3dc5e4bf-1f0d-4810-b480-519a167cf604", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b159087a-2863-466a-a8be-14c8fcee90e3", "26164c53-74a1-47ea-a1cf-2db38b865bfe", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82398ca0-beaf-4fb7-983b-9dcfe3429649");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4a4f5b0-edb4-4dd0-9641-7c268064ccc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b159087a-2863-466a-a8be-14c8fcee90e3");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityUserId",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId1",
                table: "Customer",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a676d20-353f-497a-8c4f-9f7f6ae24db0", "6ac91590-275a-47a3-86d9-e9f1a3aef257", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b350961-7fbd-4643-95a3-b9d3a8f4ca30", "26aef3d5-c24a-48e1-bce2-6533b48c18d7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b319d0a6-a3e8-42e2-abf4-fc899b88e153", "a6211bea-cb7c-449a-83ad-65315424de3c", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IdentityUserId1",
                table: "Customer",
                column: "IdentityUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId1",
                table: "Customer",
                column: "IdentityUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
