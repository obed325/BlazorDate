using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 3, 22, 8, 41, 51, 519, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2023, 3, 22, 8, 41, 51, 519, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2023, 3, 22, 8, 41, 51, 519, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2023, 3, 22, 8, 41, 51, 519, DateTimeKind.Local).AddTicks(5361));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 3, 21, 13, 12, 19, 714, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2023, 3, 21, 13, 12, 19, 714, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2023, 3, 21, 13, 12, 19, 714, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2023, 3, 21, 13, 12, 19, 714, DateTimeKind.Local).AddTicks(154));
        }
    }
}
