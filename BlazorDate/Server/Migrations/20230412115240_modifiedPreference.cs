using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    /// <inheritdoc />
    public partial class modifiedPreference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 4, 12, 13, 52, 40, 71, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2023, 4, 12, 13, 52, 40, 71, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2023, 4, 12, 13, 52, 40, 71, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2023, 4, 12, 13, 52, 40, 71, DateTimeKind.Local).AddTicks(582));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
