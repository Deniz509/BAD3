using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Packets",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Packets",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Packets",
                keyColumn: "TrackId",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 382f, 219f });

            migrationBuilder.UpdateData(
                table: "Packets",
                keyColumn: "TrackId",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 219f, 109f });

            migrationBuilder.UpdateData(
                table: "Packets",
                keyColumn: "TrackId",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 23f, 539f });

            migrationBuilder.UpdateData(
                table: "Packets",
                keyColumn: "TrackId",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 145f, 679f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Packets");
        }
    }
}

