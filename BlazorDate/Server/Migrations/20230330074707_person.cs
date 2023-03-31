using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorDate.Server.Migrations
{
    /// <inheritdoc />
    public partial class person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "People");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "ProfileText", "Updated" },
                values: new object[] { "Vem är fullast?", new DateTime(2023, 3, 30, 9, 47, 6, 858, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "ProfileText", "Updated" },
                values: new object[] { "Lugn person med takt och ton, måttfull och balanserad.", new DateTime(2023, 3, 30, 9, 47, 6, 858, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "ProfileText", "Updated" },
                values: new object[] { "Liten och dristig.", new DateTime(2023, 3, 30, 9, 47, 6, 858, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                columns: new[] { "ProfileText", "Updated" },
                values: new object[] { "Bär oftast hatt.", new DateTime(2023, 3, 30, 9, 47, 6, 858, DateTimeKind.Local).AddTicks(4100) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "Description", "ProfileText", "Updated" },
                values: new object[] { "Vem är fullast?", "", new DateTime(2023, 3, 27, 22, 59, 45, 966, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "Description", "ProfileText", "Updated" },
                values: new object[] { "Lugn person med takt och ton, måttfull och balanserad.", "", new DateTime(2023, 3, 27, 22, 59, 45, 966, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "Description", "ProfileText", "Updated" },
                values: new object[] { "Liten och dristig.", "", new DateTime(2023, 3, 27, 22, 59, 45, 966, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4,
                columns: new[] { "Description", "ProfileText", "Updated" },
                values: new object[] { "Bär oftast hatt.", "", new DateTime(2023, 3, 27, 22, 59, 45, 966, DateTimeKind.Local).AddTicks(3226) });
        }
    }
}
