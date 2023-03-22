using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    /// <inheritdoc />
    public partial class gender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Genders_GenderId",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Genders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "fem");

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "men");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "GenderId", "Updated" },
                values: new object[] { 2, new DateTime(2023, 3, 22, 16, 12, 58, 663, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "GenderId", "Updated" },
                values: new object[] { 1, new DateTime(2023, 3, 22, 16, 12, 58, 663, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "GenderId", "Updated" },
                values: new object[] { 1, new DateTime(2023, 3, 22, 16, 12, 58, 663, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                columns: new[] { "GenderId", "Updated" },
                values: new object[] { 2, new DateTime(2023, 3, 22, 16, 12, 58, 663, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.AddForeignKey(
                name: "FK_People_Genders_GenderId",
                table: "People",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Genders_GenderId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Genders");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "People",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "GenderId", "Updated" },
                values: new object[] { null, new DateTime(2023, 3, 22, 8, 41, 51, 519, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "GenderId", "Updated" },
                values: new object[] { null, new DateTime(2023, 3, 22, 8, 41, 51, 519, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "GenderId", "Updated" },
                values: new object[] { null, new DateTime(2023, 3, 22, 8, 41, 51, 519, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                columns: new[] { "GenderId", "Updated" },
                values: new object[] { null, new DateTime(2023, 3, 22, 8, 41, 51, 519, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.AddForeignKey(
                name: "FK_People_Genders_GenderId",
                table: "People",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id");
        }
    }
}
