using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace istanbulbageri.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 12, 30, 18, 707, DateTimeKind.Local).AddTicks(2903), new DateTime(2024, 4, 20, 11, 50, 18, 707, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 0, 18, 707, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 4, 20, 12, 40, 18, 707, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 30, 18, 707, DateTimeKind.Local).AddTicks(2923), new DateTime(2024, 4, 20, 13, 0, 18, 707, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 14, 20, 18, 707, DateTimeKind.Local).AddTicks(2928), new DateTime(2024, 4, 20, 14, 0, 18, 707, DateTimeKind.Local).AddTicks(2926) });
        }
    }
}
