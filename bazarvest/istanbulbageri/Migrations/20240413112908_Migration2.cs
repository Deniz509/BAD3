using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace istanbulbageri.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 9, 7, 536, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 4, 13, 13, 29, 7, 536, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 39, 7, 536, DateTimeKind.Local).AddTicks(1297), new DateTime(2024, 4, 13, 14, 19, 7, 536, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 9, 7, 536, DateTimeKind.Local).AddTicks(1302), new DateTime(2024, 4, 13, 14, 39, 7, 536, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 59, 7, 536, DateTimeKind.Local).AddTicks(1497), new DateTime(2024, 4, 13, 15, 39, 7, 536, DateTimeKind.Local).AddTicks(1486) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
