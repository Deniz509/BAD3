﻿// <auto-generated />
using System;
using FoodAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodAPI.Migrations
{
    [DbContext(typeof(BakeryDbContext))]
    partial class BakeryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodAPI.Data.Models.Allergen", b =>
                {
                    b.Property<int>("AllergenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllergenID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.HasKey("AllergenID");

                    b.HasIndex("StockID")
                        .IsUnique();

                    b.ToTable("Allergen");

                    b.HasData(
                        new
                        {
                            AllergenID = 1,
                            Name = "Leavening agent",
                            StockID = 1
                        },
                        new
                        {
                            AllergenID = 2,
                            Name = "Alcohol",
                            StockID = 2
                        },
                        new
                        {
                            AllergenID = 3,
                            Name = "Gluten",
                            StockID = 3
                        },
                        new
                        {
                            AllergenID = 4,
                            Name = "Lactose",
                            StockID = 4
                        },
                        new
                        {
                            AllergenID = 5,
                            Name = "Gluten",
                            StockID = 5
                        },
                        new
                        {
                            AllergenID = 6,
                            Name = "Glucose",
                            StockID = 6
                        },
                        new
                        {
                            AllergenID = 7,
                            Name = "Sodium",
                            StockID = 7
                        },
                        new
                        {
                            AllergenID = 8,
                            Name = "Water",
                            StockID = 8
                        },
                        new
                        {
                            AllergenID = 9,
                            Name = "Protein",
                            StockID = 9
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.BakingGoods", b =>
                {
                    b.Property<int>("BakingGoodsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BakingGoodsID"));

                    b.Property<int>("CompanyOrdersID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.HasKey("BakingGoodsID");

                    b.HasIndex("CompanyOrdersID");

                    b.HasIndex("RecipeID")
                        .IsUnique();

                    b.ToTable("BakingGoods");

                    b.HasData(
                        new
                        {
                            BakingGoodsID = 1,
                            CompanyOrdersID = 1,
                            Name = "Citronmaane",
                            Quantity = 232,
                            RecipeID = 1
                        },
                        new
                        {
                            BakingGoodsID = 2,
                            CompanyOrdersID = 2,
                            Name = "Baklava",
                            Quantity = 1000,
                            RecipeID = 2
                        },
                        new
                        {
                            BakingGoodsID = 3,
                            CompanyOrdersID = 3,
                            Name = "Jalabe",
                            Quantity = 423,
                            RecipeID = 3
                        },
                        new
                        {
                            BakingGoodsID = 4,
                            CompanyOrdersID = 4,
                            Name = "Kunefe",
                            Quantity = 999,
                            RecipeID = 4
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Batch", b =>
                {
                    b.Property<int>("BatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchID"));

                    b.Property<int>("BakingGoodsID")
                        .HasColumnType("int");

                    b.Property<float>("Delay")
                        .HasColumnType("real");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BatchID");

                    b.HasIndex("BakingGoodsID");

                    b.ToTable("Batch");

                    b.HasData(
                        new
                        {
                            BatchID = 1,
                            BakingGoodsID = 1,
                            Delay = 40f,
                            FinishTime = new DateTime(2024, 4, 7, 17, 36, 50, 241, DateTimeKind.Local).AddTicks(6590),
                            StartTime = new DateTime(2024, 4, 7, 16, 56, 50, 241, DateTimeKind.Local).AddTicks(6577)
                        },
                        new
                        {
                            BatchID = 2,
                            BakingGoodsID = 2,
                            Delay = 0f,
                            FinishTime = new DateTime(2024, 4, 7, 18, 6, 50, 241, DateTimeKind.Local).AddTicks(6596),
                            StartTime = new DateTime(2024, 4, 7, 17, 46, 50, 241, DateTimeKind.Local).AddTicks(6596)
                        },
                        new
                        {
                            BatchID = 3,
                            BakingGoodsID = 3,
                            Delay = 20f,
                            FinishTime = new DateTime(2024, 4, 7, 18, 36, 50, 241, DateTimeKind.Local).AddTicks(6598),
                            StartTime = new DateTime(2024, 4, 7, 18, 6, 50, 241, DateTimeKind.Local).AddTicks(6597)
                        },
                        new
                        {
                            BatchID = 4,
                            BakingGoodsID = 4,
                            Delay = 56f,
                            FinishTime = new DateTime(2024, 4, 7, 19, 26, 50, 241, DateTimeKind.Local).AddTicks(6600),
                            StartTime = new DateTime(2024, 4, 7, 19, 6, 50, 241, DateTimeKind.Local).AddTicks(6599)
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.CompanyOrders", b =>
                {
                    b.Property<int>("CompanyOrdersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyOrdersID"));

                    b.Property<string>("DeliveryDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyOrdersID");

                    b.ToTable("CompanyOrders");

                    b.HasData(
                        new
                        {
                            CompanyOrdersID = 1,
                            DeliveryDate = "12032002 2205",
                            DeliveryPlace = "Superbrugsen"
                        },
                        new
                        {
                            CompanyOrdersID = 2,
                            DeliveryDate = "02052001 2240",
                            DeliveryPlace = "Bilka"
                        },
                        new
                        {
                            CompanyOrdersID = 3,
                            DeliveryDate = "16032003 1600",
                            DeliveryPlace = "Lidl"
                        },
                        new
                        {
                            CompanyOrdersID = 4,
                            DeliveryDate = "03082001 2359",
                            DeliveryPlace = "SuperBest"
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Dispatch", b =>
                {
                    b.Property<int>("TrackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrackID"));

                    b.Property<int>("CompanyOrdersID")
                        .HasColumnType("int");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.HasKey("TrackID");

                    b.HasIndex("CompanyOrdersID");

                    b.ToTable("Dispatch");

                    b.HasData(
                        new
                        {
                            TrackID = 1,
                            CompanyOrdersID = 1,
                            Latitude = 931f,
                            Longitude = 139f
                        },
                        new
                        {
                            TrackID = 2,
                            CompanyOrdersID = 2,
                            Latitude = 957f,
                            Longitude = 759f
                        },
                        new
                        {
                            TrackID = 3,
                            CompanyOrdersID = 3,
                            Latitude = 1f,
                            Longitude = 529f
                        },
                        new
                        {
                            TrackID = 4,
                            CompanyOrdersID = 4,
                            Latitude = 923f,
                            Longitude = 329f
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.IngredientsInRecipe", b =>
                {
                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("RecipeID", "StockID");

                    b.HasIndex("StockID");

                    b.ToTable("IngredientsInRecipes");

                    b.HasData(
                        new
                        {
                            RecipeID = 1,
                            StockID = 1,
                            Quantity = 1000
                        },
                        new
                        {
                            RecipeID = 1,
                            StockID = 2,
                            Quantity = 2300
                        },
                        new
                        {
                            RecipeID = 2,
                            StockID = 3,
                            Quantity = 100
                        },
                        new
                        {
                            RecipeID = 2,
                            StockID = 4,
                            Quantity = 2400
                        },
                        new
                        {
                            RecipeID = 2,
                            StockID = 5,
                            Quantity = 300
                        },
                        new
                        {
                            RecipeID = 3,
                            StockID = 1,
                            Quantity = 1000
                        },
                        new
                        {
                            RecipeID = 3,
                            StockID = 2,
                            Quantity = 2300
                        },
                        new
                        {
                            RecipeID = 3,
                            StockID = 6,
                            Quantity = 23
                        },
                        new
                        {
                            RecipeID = 3,
                            StockID = 3,
                            Quantity = 15000
                        },
                        new
                        {
                            RecipeID = 4,
                            StockID = 7,
                            Quantity = 200
                        },
                        new
                        {
                            RecipeID = 4,
                            StockID = 8,
                            Quantity = 300
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeID");

                    b.ToTable("Recipe");

                    b.HasData(
                        new
                        {
                            RecipeID = 1,
                            Name = "Citronmaane"
                        },
                        new
                        {
                            RecipeID = 2,
                            Name = "Baklava"
                        },
                        new
                        {
                            RecipeID = 3,
                            Name = "Jalabe"
                        },
                        new
                        {
                            RecipeID = 4,
                            Name = "Kunefe"
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Stock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("StockID");

                    b.ToTable("Stock");

                    b.HasData(
                        new
                        {
                            StockID = 1,
                            Name = "Flour",
                            Quantity = 123
                        },
                        new
                        {
                            StockID = 2,
                            Name = "Leftover Cake",
                            Quantity = 435
                        },
                        new
                        {
                            StockID = 3,
                            Name = "Salt",
                            Quantity = 342
                        },
                        new
                        {
                            StockID = 4,
                            Name = "Milk",
                            Quantity = 546
                        },
                        new
                        {
                            StockID = 5,
                            Name = "Egg",
                            Quantity = 234
                        },
                        new
                        {
                            StockID = 6,
                            Name = "Yeast",
                            Quantity = 457
                        },
                        new
                        {
                            StockID = 7,
                            Name = "Rum",
                            Quantity = 234
                        },
                        new
                        {
                            StockID = 8,
                            Name = "Baking Powder",
                            Quantity = 675
                        },
                        new
                        {
                            StockID = 9,
                            Name = "Baking soda",
                            Quantity = 243
                        });
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Allergen", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.Stock", "Stock")
                        .WithOne("Allergen")
                        .HasForeignKey("FoodAPI.Data.Models.Allergen", "StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.BakingGoods", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.CompanyOrders", "CompanyOrders")
                        .WithMany("BakingGoods")
                        .HasForeignKey("CompanyOrdersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodAPI.Data.Models.Recipe", "Recipe")
                        .WithOne("BakingGoods")
                        .HasForeignKey("FoodAPI.Data.Models.BakingGoods", "RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyOrders");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Batch", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.BakingGoods", "BakingGoods")
                        .WithMany("Batch")
                        .HasForeignKey("BakingGoodsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGoods");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.Dispatch", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.CompanyOrders", "CompanyOrders")
                        .WithMany("Dispatch")
                        .HasForeignKey("CompanyOrdersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyOrders");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.IngredientsInRecipe", b =>
                {
                    b.HasOne("FoodAPI.Data.Models.Recipe", "Recipe")
                        .WithMany("IngredientsInRecipes")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodAPI.Data.Models.Stock", "Stock")
                        .WithMany("IngredientsInRecipes")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.BakingGoods", b =>
                {
                    b.Navigation("Batch");
                });

            modelBuilder.Entity("FoodAPI.Data.Models.CompanyOrders", b =>
                {
                    b.Navigation("BakingGoods");

                    b.Navigation("Dispatch");
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
