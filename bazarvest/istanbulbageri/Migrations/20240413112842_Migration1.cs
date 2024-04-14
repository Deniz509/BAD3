using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace istanbulbageri.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 8, 41, 401, DateTimeKind.Local).AddTicks(4906), new DateTime(2024, 4, 13, 13, 28, 41, 401, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 38, 41, 401, DateTimeKind.Local).AddTicks(4913), new DateTime(2024, 4, 13, 14, 18, 41, 401, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 8, 41, 401, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 4, 13, 14, 38, 41, 401, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 58, 41, 401, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 4, 13, 15, 38, 41, 401, DateTimeKind.Local).AddTicks(4919) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 7, 47, 958, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 4, 13, 13, 27, 47, 958, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 37, 47, 958, DateTimeKind.Local).AddTicks(4209), new DateTime(2024, 4, 13, 14, 17, 47, 958, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 7, 47, 958, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 4, 13, 14, 37, 47, 958, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 57, 47, 958, DateTimeKind.Local).AddTicks(4217), new DateTime(2024, 4, 13, 15, 37, 47, 958, DateTimeKind.Local).AddTicks(4215) });
        }
    }
}
