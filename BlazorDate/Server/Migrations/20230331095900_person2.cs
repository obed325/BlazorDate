using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    /// <inheritdoc />
    public partial class person2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "People",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Updated" },
                values: new object[] { null, new DateTime(2023, 3, 31, 11, 59, 0, 767, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "Updated" },
                values: new object[] { null, new DateTime(2023, 3, 31, 11, 59, 0, 767, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "Updated" },
                values: new object[] { null, new DateTime(2023, 3, 31, 11, 59, 0, 767, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "Updated" },
                values: new object[] { null, new DateTime(2023, 3, 31, 11, 59, 0, 767, DateTimeKind.Local).AddTicks(6073) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Updated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 9, 47, 6, 858, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "Updated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 9, 47, 6, 858, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "Updated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 9, 47, 6, 858, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "Updated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 9, 47, 6, 858, DateTimeKind.Local).AddTicks(4100) });
        }
    }
}
