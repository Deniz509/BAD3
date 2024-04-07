using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryPlace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrdersId);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IngredientName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                });

            migrationBuilder.CreateTable(
                name: "Packets",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packets", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_Packets_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrdersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BakingGoods",
                columns: table => new
                {
                    BakingGoodsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakingGoodsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakingGoods", x => x.BakingGoodsId);
                    table.ForeignKey(
                        name: "FK_BakingGoods_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "OrdersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BakingGoods_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientsInRecipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientsInRecipes", x => new { x.RecipeId, x.StockId });
                    table.ForeignKey(
                        name: "FK_IngredientsInRecipes_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientsInRecipes_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delay = table.Column<float>(type: "real", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StopTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BakingGoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.BatchId);
                    table.ForeignKey(
                        name: "FK_Batch_BakingGoods_BakingGoodsId",
                        column: x => x.BakingGoodsId,
                        principalTable: "BakingGoods",
                        principalColumn: "BakingGoodsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrdersId", "DeliveryDate", "DeliveryPlace" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 14, 49, 24, 575, DateTimeKind.Local).AddTicks(9803), "Kvickly" },
                    { 2, new DateTime(2024, 4, 4, 14, 49, 24, 575, DateTimeKind.Local).AddTicks(9863), "Rema1000" },
                    { 3, new DateTime(2024, 4, 5, 14, 49, 24, 575, DateTimeKind.Local).AddTicks(9867), "Aldi" },
                    { 4, new DateTime(2024, 4, 6, 14, 49, 24, 575, DateTimeKind.Local).AddTicks(9869), "Netto" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "RecipeName" },
                values: new object[,]
                {
                    { 1, "Cake" },
                    { 2, "Bread" },
                    { 3, "Lagkage" },
                    { 4, "Romkugler" }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "StockId", "IngredientName", "Quantity" },
                values: new object[,]
                {
                    { 1, "Flour", 100000 },
                    { 2, "Sugar", 100000 },
                    { 3, "Salt", 100000 },
                    { 4, "Water", 100000 },
                    { 5, "Egg", 100000 },
                    { 6, "Baking Powder", 100000 },
                    { 7, "Rum", 100000 },
                    { 8, "Leftover cake", 100000 },
                    { 9, "milk", 100000 }
                });

            migrationBuilder.InsertData(
                table: "BakingGoods",
                columns: new[] { "BakingGoodsId", "Amount", "BakingGoodsName", "OrdersId", "RecipeId" },
                values: new object[,]
                {
                    { 1, 100, "Cake", 1, 1 },
                    { 2, 50, "Bread", 2, 2 },
                    { 3, 20, "Lagkage", 3, 3 },
                    { 4, 10, "Romkugler", 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsInRecipes",
                columns: new[] { "RecipeId", "StockId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1000 },
                    { 1, 2, 2300 },
                    { 2, 3, 100 },
                    { 2, 4, 2400 },
                    { 2, 5, 300 },
                    { 3, 1, 1000 },
                    { 3, 2, 2300 },
                    { 3, 3, 15000 },
                    { 3, 6, 23 },
                    { 4, 7, 200 },
                    { 4, 8, 300 }
                });

            migrationBuilder.InsertData(
                table: "Packets",
                columns: new[] { "TrackId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Batch",
                columns: new[] { "BatchId", "BakingGoodsId", "Delay", "StartTime", "StopTime" },
                values: new object[,]
                {
                    { 1, 1, 10f, new DateTime(2024, 4, 3, 14, 49, 24, 576, DateTimeKind.Local).AddTicks(6), new DateTime(2024, 4, 3, 15, 29, 24, 576, DateTimeKind.Local).AddTicks(9) },
                    { 2, 2, 0f, new DateTime(2024, 4, 3, 15, 39, 24, 576, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 4, 3, 15, 59, 24, 576, DateTimeKind.Local).AddTicks(14) },
                    { 3, 3, 30f, new DateTime(2024, 4, 3, 15, 59, 24, 576, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 4, 3, 16, 29, 24, 576, DateTimeKind.Local).AddTicks(18) },
                    { 4, 4, 40f, new DateTime(2024, 4, 3, 16, 59, 24, 576, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 4, 3, 17, 19, 24, 576, DateTimeKind.Local).AddTicks(21) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoods_OrdersId",
                table: "BakingGoods",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoods_RecipeId",
                table: "BakingGoods",
                column: "RecipeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Batch_BakingGoodsId",
                table: "Batch",
                column: "BakingGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsInRecipes_StockId",
                table: "IngredientsInRecipes",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Packets_OrderId",
                table: "Packets",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "IngredientsInRecipes");

            migrationBuilder.DropTable(
                name: "Packets");

            migrationBuilder.DropTable(
                name: "BakingGoods");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
