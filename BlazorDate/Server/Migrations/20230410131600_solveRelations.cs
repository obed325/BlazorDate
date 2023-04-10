using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    /// <inheritdoc />
    public partial class solveRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_UserId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 4, 10, 15, 16, 0, 171, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2023, 4, 10, 15, 16, 0, 171, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2023, 4, 10, 15, 16, 0, 171, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2023, 4, 10, 15, 16, 0, 171, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Address_AddressId",
                table: "Users",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_AddressId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 4, 1, 23, 17, 26, 880, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2023, 4, 1, 23, 17, 26, 880, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2023, 4, 1, 23, 17, 26, 880, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2023, 4, 1, 23, 17, 26, 880, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
