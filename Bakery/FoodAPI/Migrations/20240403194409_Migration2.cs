using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeliveryDate",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchId",
                keyValue: 1,
                columns: new[] { "StartTime", "StopTime" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 9, 44, 94, DateTimeKind.Local).AddTicks(1727), new DateTime(2024, 4, 3, 15, 49, 44, 94, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchId",
                keyValue: 2,
                columns: new[] { "StartTime", "StopTime" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 59, 44, 94, DateTimeKind.Local).AddTicks(1787), new DateTime(2024, 4, 3, 16, 19, 44, 94, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchId",
                keyValue: 3,
                columns: new[] { "StartTime", "StopTime" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 44, 94, DateTimeKind.Local).AddTicks(1790), new DateTime(2024, 4, 3, 16, 49, 44, 94, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchId",
                keyValue: 4,
                columns: new[] { "StartTime", "StopTime" },
                values: new object[] { new DateTime(2024, 4, 3, 17, 19, 44, 94, DateTimeKind.Local).AddTicks(1793), new DateTime(2024, 4, 3, 17, 39, 44, 94, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 1,
                column: "DeliveryDate",
                value: "03042024 1348");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 2,
                column: "DeliveryDate",
                value: "19062024 1300");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 3,
                column: "DeliveryDate",
                value: "23112024 1200");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 4,
                column: "DeliveryDate",
                value: "24122024 1800");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveryDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchId",
                keyValue: 1,
                columns: new[] { "StartTime", "StopTime" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 1, 48, 351, DateTimeKind.Local).AddTicks(883), new DateTime(2024, 4, 3, 15, 41, 48, 351, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchId",
                keyValue: 2,
                columns: new[] { "StartTime", "StopTime" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 51, 48, 351, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 4, 3, 16, 11, 48, 351, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchId",
                keyValue: 3,
                columns: new[] { "StartTime", "StopTime" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 11, 48, 351, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 4, 3, 16, 41, 48, 351, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Batch",
                keyColumn: "BatchId",
                keyValue: 4,
                columns: new[] { "StartTime", "StopTime" },
                values: new object[] { new DateTime(2024, 4, 3, 17, 11, 48, 351, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 4, 3, 17, 31, 48, 351, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 1,
                column: "DeliveryDate",
                value: new DateTime(2024, 4, 3, 15, 1, 48, 351, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 2,
                column: "DeliveryDate",
                value: new DateTime(2024, 4, 4, 15, 1, 48, 351, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 3,
                column: "DeliveryDate",
                value: new DateTime(2024, 4, 5, 15, 1, 48, 351, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 4,
                column: "DeliveryDate",
                value: new DateTime(2024, 4, 6, 15, 1, 48, 351, DateTimeKind.Local).AddTicks(620));
        }
    }
}
