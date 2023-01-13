using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFTestingWithSql.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Forecasts",
                columns: new[] { "Id", "Date", "Sumary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Cool", 14 },
                    { 2, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "Chilly", 8 },
                    { 3, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "Balmy", 8 },
                    { 4, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "Chilly", 3 },
                    { 5, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Warm", 16 },
                    { 6, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "Mild", 14 },
                    { 7, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "Sweltering", 3 },
                    { 8, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Warm", 22 },
                    { 9, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "Scorching", 28 },
                    { 10, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "Balmy", 2 },
                    { 11, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "Sweltering", 2 },
                    { 12, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Bracing", 28 },
                    { 13, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "Freezing", 22 },
                    { 14, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Scorching", 22 },
                    { 15, new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Scorching", 14 },
                    { 16, new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "Sweltering", 9 },
                    { 17, new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Hot", 9 },
                    { 18, new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Hot", 0 },
                    { 19, new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "Freezing", 17 },
                    { 20, new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "Warm", 1 },
                    { 21, new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "Balmy", 0 },
                    { 22, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "Freezing", 15 },
                    { 23, new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Bracing", 15 },
                    { 24, new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), "Mild", 26 },
                    { 25, new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "Mild", 25 },
                    { 26, new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "Mild", 8 },
                    { 27, new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "Freezing", 17 },
                    { 28, new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "Balmy", 17 },
                    { 29, new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "Bracing", 12 },
                    { 30, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "Chilly", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Forecasts",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
