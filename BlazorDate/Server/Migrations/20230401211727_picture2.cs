using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    /// <inheritdoc />
    public partial class picture2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 4, 1, 21, 51, 8, 328, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2023, 4, 1, 21, 51, 8, 328, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2023, 4, 1, 21, 51, 8, 328, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2023, 4, 1, 21, 51, 8, 328, DateTimeKind.Local).AddTicks(6209));
        }
    }
}
