using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace istanbulbageri.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 1,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 10, 54, 481, DateTimeKind.Local).AddTicks(8891), new DateTime(2024, 4, 13, 13, 30, 54, 481, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 2,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 40, 54, 481, DateTimeKind.Local).AddTicks(8899), new DateTime(2024, 4, 13, 14, 20, 54, 481, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 3,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 10, 54, 481, DateTimeKind.Local).AddTicks(8902), new DateTime(2024, 4, 13, 14, 40, 54, 481, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchID",
                keyValue: 4,
                columns: new[] { "FinishTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 16, 0, 54, 481, DateTimeKind.Local).AddTicks(8906), new DateTime(2024, 4, 13, 15, 40, 54, 481, DateTimeKind.Local).AddTicks(8905) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
