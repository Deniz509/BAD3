using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace istanbulbageri.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 12, 31, 1, 389, DateTimeKind.Local).AddTicks(295), new DateTime(2024, 4, 20, 11, 51, 1, 389, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 1, 1, 389, DateTimeKind.Local).AddTicks(301), new DateTime(2024, 4, 20, 12, 41, 1, 389, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 31, 1, 389, DateTimeKind.Local).AddTicks(304), new DateTime(2024, 4, 20, 13, 1, 1, 389, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 14, 21, 1, 389, DateTimeKind.Local).AddTicks(307), new DateTime(2024, 4, 20, 14, 1, 1, 389, DateTimeKind.Local).AddTicks(306) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
