using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace istanbulbageri.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyOrders",
                columns: table => new
                {
                    CompanyOrdersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryPlace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyOrders", x => x.CompanyOrdersID);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    RecipeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.RecipeID);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockID);
                });

            migrationBuilder.CreateTable(
                name: "Dispatch",
                columns: table => new
                {
                    TrackID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyOrdersID = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispatch", x => x.TrackID);
                    table.ForeignKey(
                        name: "FK_Dispatch_CompanyOrders_CompanyOrdersID",
                        column: x => x.CompanyOrdersID,
                        principalTable: "CompanyOrders",
                        principalColumn: "CompanyOrdersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BakingGoods",
                columns: table => new
                {
                    BakingGoodsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CompanyOrdersID = table.Column<int>(type: "int", nullable: false),
                    RecipeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakingGoods", x => x.BakingGoodsID);
                    table.ForeignKey(
                        name: "FK_BakingGoods_CompanyOrders_CompanyOrdersID",
                        column: x => x.CompanyOrdersID,
                        principalTable: "CompanyOrders",
                        principalColumn: "CompanyOrdersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BakingGoods_Recipe_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipe",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allergen",
                columns: table => new
                {
                    AllergenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergen", x => x.AllergenID);
                    table.ForeignKey(
                        name: "FK_Allergen_Stock_StockID",
                        column: x => x.StockID,
                        principalTable: "Stock",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    RecipeID = table.Column<int>(type: "int", nullable: false),
                    StockID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => new { x.RecipeID, x.StockID });
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipe_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipe",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredients_Stock_StockID",
                        column: x => x.StockID,
                        principalTable: "Stock",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    BatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delay = table.Column<float>(type: "real", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BakingGoodsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.BatchID);
                    table.ForeignKey(
                        name: "FK_Batch_BakingGoods_BakingGoodsID",
                        column: x => x.BakingGoodsID,
                        principalTable: "BakingGoods",
                        principalColumn: "BakingGoodsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CompanyOrders",
                columns: new[] { "CompanyOrdersID", "DeliveryDate", "DeliveryPlace" },
                values: new object[,]
                {
                    { 1, "12032002 2205", "Superbrugsen" },
                    { 2, "02052001 2240", "Bilka" },
                    { 3, "16032003 1600", "Lidl" },
                    { 4, "03082001 2359", "SuperBest" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeID", "Name" },
                values: new object[,]
                {
                    { 1, "Citronmaane" },
                    { 2, "Baklava" },
                    { 3, "Jalabe" },
                    { 4, "Kunefe" }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "StockID", "Name", "Quantity" },
                values: new object[,]
                {
                    { 1, "Flour", 123 },
                    { 2, "Leftover Cake", 435 },
                    { 3, "Salt", 342 },
                    { 4, "Milk", 546 },
                    { 5, "Egg", 234 },
                    { 6, "Yeast", 457 },
                    { 7, "Rum", 234 },
                    { 8, "Baking Powder", 675 },
                    { 9, "Baking soda", 243 }
                });

            migrationBuilder.InsertData(
                table: "Allergen",
                columns: new[] { "AllergenID", "Name", "StockID" },
                values: new object[,]
                {
                    { 1, "Leavening agent", 1 },
                    { 2, "Alcohol", 2 },
                    { 3, "Gluten", 3 },
                    { 4, "Lactose", 4 },
                    { 5, "Gluten", 5 },
                    { 6, "Glucose", 6 },
                    { 7, "Sodium", 7 },
                    { 8, "Water", 8 },
                    { 9, "Protein", 9 }
                });

            migrationBuilder.InsertData(
                table: "BakingGoods",
                columns: new[] { "BakingGoodsID", "CompanyOrdersID", "Name", "Quantity", "RecipeID" },
                values: new object[,]
                {
                    { 1, 1, "Citronmaane", 232, 1 },
                    { 2, 2, "Baklava", 1000, 2 },
                    { 3, 3, "Jalabe", 423, 3 },
                    { 4, 4, "Kunefe", 999, 4 }
                });

            migrationBuilder.InsertData(
                table: "Dispatch",
                columns: new[] { "TrackID", "CompanyOrdersID", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, 1, 931f, 139f },
                    { 2, 2, 957f, 759f },
                    { 3, 3, 1f, 529f },
                    { 4, 4, 923f, 329f }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "RecipeID", "StockID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1000 },
                    { 1, 2, 2300 },
                    { 1, 3, 3000 },
                    { 1, 4, 1230 },
                    { 2, 2, 300 },
                    { 2, 3, 100 },
                    { 2, 4, 2400 },
                    { 2, 5, 250 },
                    { 3, 2, 2300 },
                    { 3, 3, 15000 },
                    { 3, 6, 230 },
                    { 3, 7, 1000 },
                    { 4, 3, 200 },
                    { 4, 4, 300 },
                    { 4, 7, 200 },
                    { 4, 8, 300 }
                });

            migrationBuilder.InsertData(
                table: "Batch",
                columns: new[] { "BatchID", "BakingGoodsID", "Delay", "FinishTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 40f, new DateTime(2024, 4, 13, 14, 7, 47, 958, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 4, 13, 13, 27, 47, 958, DateTimeKind.Local).AddTicks(4149) },
                    { 2, 2, 0f, new DateTime(2024, 4, 13, 14, 37, 47, 958, DateTimeKind.Local).AddTicks(4209), new DateTime(2024, 4, 13, 14, 17, 47, 958, DateTimeKind.Local).AddTicks(4207) },
                    { 3, 3, 20f, new DateTime(2024, 4, 13, 15, 7, 47, 958, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 4, 13, 14, 37, 47, 958, DateTimeKind.Local).AddTicks(4212) },
                    { 4, 4, 56f, new DateTime(2024, 4, 13, 15, 57, 47, 958, DateTimeKind.Local).AddTicks(4217), new DateTime(2024, 4, 13, 15, 37, 47, 958, DateTimeKind.Local).AddTicks(4215) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allergen_StockID",
                table: "Allergen",
                column: "StockID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoods_CompanyOrdersID",
                table: "BakingGoods",
                column: "CompanyOrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoods_RecipeID",
                table: "BakingGoods",
                column: "RecipeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Batch_BakingGoodsID",
                table: "Batch",
                column: "BakingGoodsID");

            migrationBuilder.CreateIndex(
                name: "IX_Dispatch_CompanyOrdersID",
                table: "Dispatch",
                column: "CompanyOrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_StockID",
                table: "Ingredients",
                column: "StockID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergen");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Dispatch");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "BakingGoods");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "CompanyOrders");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
