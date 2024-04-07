using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergen",
                columns: table => new
                {
                    AllergenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllergenName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergen", x => x.AllergenId);
                    table.ForeignKey(
                        name: "FK_Allergen_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Allergen",
                columns: new[] { "AllergenId", "AllergenName", "StockId" },
                values: new object[,]
                {
                    { 1, "Gluten", 1 },
                    { 2, "Glucose", 2 },
                    { 3, "Sodium", 3 },
                    { 4, "Water", 4 },
                    { 5, "Protein", 5 },
                    { 6, "Leavening agent", 6 },
                    { 7, "Alcohol", 7 },
                    { 8, "Gluten", 8 },
                    { 9, "Lactose", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allergen_StockId",
                table: "Allergen",
                column: "StockId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergen");
        }

    }
}
