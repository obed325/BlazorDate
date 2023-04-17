using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    /// <inheritdoc />
    public partial class PreferenceCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Preferences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 4, 12, 23, 26, 38, 727, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2023, 4, 12, 23, 26, 38, 727, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2023, 4, 12, 23, 26, 38, 727, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2023, 4, 12, 23, 26, 38, 727, DateTimeKind.Local).AddTicks(5193));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Preferences");

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
    }
}
