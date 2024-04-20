using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace istanbulbageri.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 12, 30, 54, 775, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 4, 20, 11, 50, 54, 775, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 0, 54, 775, DateTimeKind.Local).AddTicks(9746), new DateTime(2024, 4, 20, 12, 40, 54, 775, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 30, 54, 775, DateTimeKind.Local).AddTicks(9750), new DateTime(2024, 4, 20, 13, 0, 54, 775, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 14, 20, 54, 775, DateTimeKind.Local).AddTicks(9753), new DateTime(2024, 4, 20, 14, 0, 54, 775, DateTimeKind.Local).AddTicks(9751) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 12, 30, 42, 830, DateTimeKind.Local).AddTicks(1956), new DateTime(2024, 4, 20, 11, 50, 42, 830, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 0, 42, 830, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 4, 20, 12, 40, 42, 830, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 30, 42, 830, DateTimeKind.Local).AddTicks(1964), new DateTime(2024, 4, 20, 13, 0, 42, 830, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 14, 20, 42, 830, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 4, 20, 14, 0, 42, 830, DateTimeKind.Local).AddTicks(1967) });
        }
    }
}
