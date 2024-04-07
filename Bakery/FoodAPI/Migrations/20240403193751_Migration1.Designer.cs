﻿// <auto-generated />
using System;
using FoodAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodAPI.Migrations
{
    [DbContext(typeof(BakeryDbContext))]
    [Migration("20240403193751_Migration1")]
    partial class Migration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodAPI.Data.Models.Allergen", b =>
                {
                    b.Property<int>("AllergenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllergenId"));

                    b.Property<string>("AllergenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.HasKey("AllergenId");

                    b.HasIndex("StockId")
                        .IsUnique();

                    b.ToTable("Allergen");

                    b.HasData(
                        new
                        {
                            AllergenId = 1,
                            AllergenName = "Gluten",
                            StockId = 1
                        },
                        new
                        {
                            AllergenId = 2,
                            AllergenName = "Glucose",
                            StockId = 2
                        },
                        new
                        {
                            AllergenId = 3,
                            AllergenName = "Sodium",
                            StockId = 3
                        },
                        new
                        {
                            AllergenId = 4,
                            AllergenName = "Water",
                            StockId = 4
                        },
                        new
                        {
                            AllergenId = 5,
                            AllergenName = "Protein",
                            StockId = 5
                        },
                        new
                        {
                            AllergenId = 6,
                            AllergenName = "Leavening agent",
                            StockId = 6
                        },
                        new
                        {
                            AllergenId = 7,
                            AllergenName = "Alcohol",
                            StockId = 7
                        },
                        new
                        {
                            AllergenId = 8,
                            AllergenName = "Gluten",
                            StockId = 8
                        },
                        new
                        {
                            AllergenId = 9,
                            AllergenName = "Lactose",
                            StockId = 9
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.BakingGoods", b =>
                {
                    b.Property<int>("BakingGoodsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BakingGoodsId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("BakingGoodsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("BakingGoodsId");

                    b.HasIndex("OrdersId");

                    b.HasIndex("RecipeId")
                        .IsUnique();

                    b.ToTable("BakingGoods");

                    b.HasData(
                        new
                        {
                            BakingGoodsId = 1,
                            Amount = 100,
                            BakingGoodsName = "Cake",
                            OrdersId = 1,
                            RecipeId = 1
                        },
                        new
                        {
                            BakingGoodsId = 2,
                            Amount = 50,
                            BakingGoodsName = "Bread",
                            OrdersId = 2,
                            RecipeId = 2
                        },
                        new
                        {
                            BakingGoodsId = 3,
                            Amount = 20,
                            BakingGoodsName = "Lagkage",
                            OrdersId = 3,
                            RecipeId = 3
                        },
                        new
                        {
                            BakingGoodsId = 4,
                            Amount = 10,
                            BakingGoodsName = "Romkugler",
                            OrdersId = 4,
                            RecipeId = 4
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Batch", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchId"));

                    b.Property<int>("BakingGoodsId")
                        .HasColumnType("int");

                    b.Property<float>("Delay")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StopTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BatchId");

                    b.HasIndex("BakingGoodsId");

                    b.ToTable("Batch");

                    b.HasData(
                        new
                        {
                            BatchId = 1,
                            BakingGoodsId = 1,
                            Delay = 10f,
                            StartTime = new DateTime(2024, 4, 3, 21, 37, 50, 412, DateTimeKind.Local).AddTicks(6546),
                            StopTime = new DateTime(2024, 4, 3, 22, 17, 50, 412, DateTimeKind.Local).AddTicks(6607)
                        },
                        new
                        {
                            BatchId = 2,
                            BakingGoodsId = 2,
                            Delay = 0f,
                            StartTime = new DateTime(2024, 4, 3, 22, 27, 50, 412, DateTimeKind.Local).AddTicks(6612),
                            StopTime = new DateTime(2024, 4, 3, 22, 47, 50, 412, DateTimeKind.Local).AddTicks(6614)
                        },
                        new
                        {
                            BatchId = 3,
                            BakingGoodsId = 3,
                            Delay = 30f,
                            StartTime = new DateTime(2024, 4, 3, 22, 47, 50, 412, DateTimeKind.Local).AddTicks(6616),
                            StopTime = new DateTime(2024, 4, 3, 23, 17, 50, 412, DateTimeKind.Local).AddTicks(6618)
                        },
                        new
                        {
                            BatchId = 4,
                            BakingGoodsId = 4,
                            Delay = 40f,
                            StartTime = new DateTime(2024, 4, 3, 23, 47, 50, 412, DateTimeKind.Local).AddTicks(6620),
                            StopTime = new DateTime(2024, 4, 4, 0, 7, 50, 412, DateTimeKind.Local).AddTicks(6621)
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.IngredientsInRecipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("RecipeId", "StockId");

                    b.HasIndex("StockId");

                    b.ToTable("IngredientsInRecipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            StockId = 1,
                            Quantity = 1000
                        },
                        new
                        {
                            RecipeId = 1,
                            StockId = 2,
                            Quantity = 2300
                        },
                        new
                        {
                            RecipeId = 2,
                            StockId = 3,
                            Quantity = 100
                        },
                        new
                        {
                            RecipeId = 2,
                            StockId = 4,
                            Quantity = 2400
                        },
                        new
                        {
                            RecipeId = 2,
                            StockId = 5,
                            Quantity = 300
                        },
                        new
                        {
                            RecipeId = 3,
                            StockId = 1,
                            Quantity = 1000
                        },
                        new
                        {
                            RecipeId = 3,
                            StockId = 2,
                            Quantity = 2300
                        },
                        new
                        {
                            RecipeId = 3,
                            StockId = 6,
                            Quantity = 23
                        },
                        new
                        {
                            RecipeId = 3,
                            StockId = 3,
                            Quantity = 15000
                        },
                        new
                        {
                            RecipeId = 4,
                            StockId = 7,
                            Quantity = 200
                        },
                        new
                        {
                            RecipeId = 4,
                            StockId = 8,
                            Quantity = 300
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Orders", b =>
                {
                    b.Property<int>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdersId"));

                    b.Property<string>("DeliveryDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrdersId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrdersId = 1,
                            DeliveryDate = "03042024 1348",
                            DeliveryPlace = "Kvickly"
                        },
                        new
                        {
                            OrdersId = 2,
                            DeliveryDate = "19062024 1300",
                            DeliveryPlace = "Rema1000"
                        },
                        new
                        {
                            OrdersId = 3,
                            DeliveryDate = "23112024 1200",
                            DeliveryPlace = "Aldi"
                        },
                        new
                        {
                            OrdersId = 4,
                            DeliveryDate = "24122024 1800",
                            DeliveryPlace = "Netto"
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Packets", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrackId"));

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("TrackId");

                    b.HasIndex("OrderId");

                    b.ToTable("Packets");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            Latitude = 382f,
                            Longitude = 219f,
                            OrderId = 1
                        },
                        new
                        {
                            TrackId = 2,
                            Latitude = 219f,
                            Longitude = 109f,
                            OrderId = 2
                        },
                        new
                        {
                            TrackId = 3,
                            Latitude = 23f,
                            Longitude = 539f,
                            OrderId = 3
                        },
                        new
                        {
                            TrackId = 4,
                            Latitude = 145f,
                            Longitude = 679f,
                            OrderId = 4
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"));

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipe");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            RecipeName = "Cake"
                        },
                        new
                        {
                            RecipeId = 2,
                            RecipeName = "Bread"
                        },
                        new
                        {
                            RecipeId = 3,
                            RecipeName = "Lagkage"
                        },
                        new
                        {
                            RecipeId = 4,
                            RecipeName = "Romkugler"
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockId"));

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("StockId");

                    b.ToTable("Stock");

                    b.HasData(
                        new
                        {
                            StockId = 1,
                            IngredientName = "Flour",
                            Quantity = 100000
                        },
                        new
                        {
                            StockId = 2,
                            IngredientName = "Sugar",
                            Quantity = 100000
                        },
                        new
                        {
                            StockId = 3,
                            IngredientName = "Salt",
                            Quantity = 100000
                        },
                        new
                        {
                            StockId = 4,
                            IngredientName = "Water",
                            Quantity = 100000
                        },
                        new
                        {
                            StockId = 5,
                            IngredientName = "Egg",
                            Quantity = 100000
                        },
                        new
                        {
                            StockId = 6,
                            IngredientName = "Baking Powder",
                            Quantity = 100000
                        },
                        new
                        {
                            StockId = 7,
                            IngredientName = "Rum",
                            Quantity = 100000
                        },
                        new
                        {
                            StockId = 8,
                            IngredientName = "Leftover cake",
                            Quantity = 100000
                        },
                        new
                        {
                            StockId = 9,
                            IngredientName = "milk",
                            Quantity = 100000
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Allergen", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.Stock", "Stock")
                        .WithOne("Allergen")
                        .HasForeignKey("FoodAPI.Data.Models.Allergen", "StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.BakingGoods", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.Orders", "Orders")
                        .WithMany("BakingGoods")
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodAPI.Data.Models.Recipe", "Recipe")
                        .WithOne("BakingGoods")
                        .HasForeignKey("FoodAPI.Data.Models.BakingGoods", "RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Batch", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.BakingGoods", "BakingGoods")
                        .WithMany("Batch")
                        .HasForeignKey("BakingGoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGoods");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.IngredientsInRecipe", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.Recipe", "Recipe")
                        .WithMany("IngredientsInRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodAPI.Data.Models.Stock", "Stock")
                        .WithMany("IngredientsInRecipes")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Packets", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.Orders", "Orders")
                        .WithMany("Packets")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.BakingGoods", b =>
                {
                    b.Navigation("Batch");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Orders", b =>
                {
                    b.Navigation("BakingGoods");

                    b.Navigation("Packets");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Recipe", b =>
                {
                    b.Navigation("BakingGoods");

                    b.Navigation("IngredientsInRecipes");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Stock", b =>
                {
                    b.Navigation("Allergen");

                    b.Navigation("IngredientsInRecipes");
                });
#pragma warning restore 612, 618
        }
    }
}
