using FoodAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace FoodAPI.Data
{
    public class BakeryDbContext : DbContext
    {
        public DbSet<BakingGoods> BakingGoods { get; set; }
        public DbSet<Batch> Batch { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Dispatch> Packets { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Allergen> Allergen { get; set; }
        public DbSet<IngredientsInRecipe> IngredientsInRecipes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=127.0.0.1,1433;Database=BAD_F24;User Id=sa;Password=password123;TrustServerCertificate=True");
        }

        public BakeryDbContext(DbContextOptions<BakeryDbContext> options) : base(options) { }

  
        public IQueryable<Stock> GetCurrentStock()
        {
            return Stock;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Orders>()
                .HasMany(o => o.Packets)
                .WithOne(p => p.Orders)
                .HasForeignKey(p => p.OrderId)
                .IsRequired();

            modelBuilder.Entity<Orders>()
                .HasMany(o => o.BakingGoods)
                .WithOne(p => p.Orders)
                .HasForeignKey(p => p.OrdersId)
                .IsRequired();

            modelBuilder.Entity<BakingGoods>()
                .HasMany(o => o.Batch)
                .WithOne(o => o.BakingGoods)
                .HasForeignKey(o => o.BakingGoodsId)
                .IsRequired();

            modelBuilder.Entity<Recipe>()
                .HasOne(o => o.BakingGoods)
                .WithOne(o => o.Recipe)
                .HasForeignKey<BakingGoods>(e => e.RecipeId)
                .IsRequired();


            modelBuilder.Entity<IngredientsInRecipe>()
            .HasKey(rs => new { rs.RecipeId, rs.StockId });

            modelBuilder.Entity<IngredientsInRecipe>()
                .HasOne(rs => rs.Recipe)
                .WithMany(r => r.IngredientsInRecipes)
                .HasForeignKey(rs => rs.RecipeId);

            modelBuilder.Entity<IngredientsInRecipe>()
                .HasOne(rs => rs.Stock)
                .WithMany(s => s.IngredientsInRecipes)
                .HasForeignKey(rs => rs.StockId);



            modelBuilder.Entity<Allergen>()
                .HasOne(e => e.Stock)
                .WithOne(e => e.Allergen)
                .HasForeignKey<Allergen>(e => e.StockId)
                .IsRequired();



            modelBuilder.Entity<Orders>().HasData(
                new Orders { OrdersId = 1, DeliveryDate = "03042024 1348", DeliveryPlace = "Kvickly" },
                new Orders { OrdersId = 2, DeliveryDate = "19062024 1300", DeliveryPlace = "Rema1000" },
                new Orders { OrdersId = 3, DeliveryDate = "23112024 1200", DeliveryPlace = "Aldi" },
                new Orders { OrdersId = 4, DeliveryDate = "24122024 1800", DeliveryPlace = "Netto" }

            );


            modelBuilder.Entity<BakingGoods>().HasData(
                new BakingGoods { BakingGoodsId = 1, BakingGoodsName = "Cake", Amount = 100, OrdersId = 1, RecipeId = 1 },
                new BakingGoods { BakingGoodsId = 2, BakingGoodsName = "Bread", Amount = 50, OrdersId = 2, RecipeId = 2 },
                new BakingGoods { BakingGoodsId = 3, BakingGoodsName = "Lagkage", Amount = 20, OrdersId = 3, RecipeId = 3 },
                new BakingGoods { BakingGoodsId = 4, BakingGoodsName = "Romkugler", Amount = 10, OrdersId = 4, RecipeId = 4 }
                );

            modelBuilder.Entity<Batch>().HasData(
                new Batch { BatchId = 1, BakingGoodsId = 1, StartTime = DateTime.Now, StopTime = DateTime.Now.AddMinutes(40), Delay = 10 },
                new Batch { BatchId = 2, BakingGoodsId = 2, StartTime = DateTime.Now.AddMinutes(50), StopTime = DateTime.Now.AddMinutes(70), Delay = 0 },
                new Batch { BatchId = 3, BakingGoodsId = 3, StartTime = DateTime.Now.AddMinutes(70), StopTime = DateTime.Now.AddMinutes(100), Delay = 30 },
                new Batch { BatchId = 4, BakingGoodsId = 4, StartTime = DateTime.Now.AddMinutes(130), StopTime = DateTime.Now.AddMinutes(150), Delay = 40 }

                );

            modelBuilder.Entity<Packets>().HasData(

                new Packets { TrackId = 1, OrderId = 1 , Longitude = 219, Latitude = 382},
                new Packets { TrackId = 2, OrderId = 2, Longitude = 109, Latitude = 219},
                new Packets { TrackId = 3, OrderId = 3, Longitude = 539, Latitude = 23},
                new Packets { TrackId = 4, OrderId = 4, Longitude = 679, Latitude = 145}

            );

            modelBuilder.Entity<Stock>().HasData(
                new Stock { StockId = 1, IngredientName = "Flour", Quantity = 100000, },
                new Stock { StockId = 2, IngredientName = "Sugar", Quantity = 100000 },
                new Stock { StockId = 3, IngredientName = "Salt", Quantity = 100000 },
                new Stock { StockId = 4, IngredientName = "Water", Quantity = 100000 },
                new Stock { StockId = 5, IngredientName = "Egg", Quantity = 100000 },
                new Stock { StockId = 6, IngredientName = "Baking Powder", Quantity = 100000 },
                new Stock { StockId = 7, IngredientName = "Rum", Quantity = 100000 },
                new Stock { StockId = 8, IngredientName = "Leftover cake", Quantity = 100000 },
                new Stock { StockId = 9, IngredientName = "milk", Quantity = 100000 }
            );

            modelBuilder.Entity<Recipe>().HasData(

                new Recipe { RecipeId = 1, RecipeName = "Cake" },
                new Recipe { RecipeId = 2, RecipeName = "Bread" },
                new Recipe { RecipeId = 3, RecipeName = "Lagkage" },
                new Recipe { RecipeId = 4, RecipeName = "Romkugler" }
            );

            modelBuilder.Entity<IngredientsInRecipe>().HasData(

                //cake
                new IngredientsInRecipe { Quantity = 1000, RecipeId = 1, StockId = 1 },
                new IngredientsInRecipe { Quantity = 2300, RecipeId = 1, StockId = 2 },

                //Bread
                new IngredientsInRecipe { Quantity = 100, RecipeId = 2, StockId = 3 },
                new IngredientsInRecipe { Quantity = 2400, RecipeId = 2, StockId = 4 },
                new IngredientsInRecipe { Quantity = 300, RecipeId = 2, StockId = 5 },

                //Lagkage
                new IngredientsInRecipe { Quantity = 1000, RecipeId = 3, StockId = 1 },
                new IngredientsInRecipe { Quantity = 2300, RecipeId = 3, StockId = 2 },
                new IngredientsInRecipe { Quantity = 23, RecipeId = 3, StockId = 6 },
                new IngredientsInRecipe { Quantity = 15000, RecipeId = 3, StockId = 3 },

                //Romkugler
                new IngredientsInRecipe { Quantity = 200, RecipeId = 4, StockId = 7 },
                new IngredientsInRecipe { Quantity = 300, RecipeId = 4, StockId = 8 }
            );

            modelBuilder.Entity<Allergen>().HasData(
                new Allergen { AllergenId = 1, AllergenName = "Gluten", StockId = 1 },
                new Allergen { AllergenId = 2, AllergenName = "Glucose", StockId = 2 },
                new Allergen { AllergenId = 3, AllergenName = "Sodium", StockId = 3 },
                new Allergen { AllergenId = 4, AllergenName = "Water", StockId = 4 },
                new Allergen { AllergenId = 5, AllergenName = "Protein", StockId = 5 },
                new Allergen { AllergenId = 6, AllergenName = "Leavening agent", StockId = 6 },
                new Allergen { AllergenId = 7, AllergenName = "Alcohol", StockId = 7 },
                new Allergen { AllergenId = 8, AllergenName = "Gluten", StockId = 8 },
                new Allergen { AllergenId = 9, AllergenName = "Lactose", StockId = 9 }
            );


        }
    }
}