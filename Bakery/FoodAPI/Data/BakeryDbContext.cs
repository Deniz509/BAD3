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
        public DbSet<CompanyOrders> CompanyOrders { get; set; }
        public DbSet<Dispatch> Dispatch { get; set; }
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

            modelBuilder.Entity<CompanyOrders>()
                .HasMany(o => o.Dispatch)
                .WithOne(p => p.CompanyOrders)
                .HasForeignKey(p => p.CompanyOrdersID)
                .IsRequired();

            modelBuilder.Entity<CompanyOrders>()
                .HasMany(o => o.BakingGoods)
                .WithOne(p => p.CompanyOrders)
                .HasForeignKey(p => p.CompanyOrdersID)
                .IsRequired();

            modelBuilder.Entity<BakingGoods>()
                .HasMany(o => o.Batch)
                .WithOne(o => o.BakingGoods)
                .HasForeignKey(o => o.BakingGoodsID)
                .IsRequired();

            modelBuilder.Entity<Recipe>()
                .HasOne(o => o.BakingGoods)
                .WithOne(o => o.Recipe)
                .HasForeignKey<BakingGoods>(e => e.RecipeID)
                .IsRequired();


            modelBuilder.Entity<IngredientsInRecipe>()
            .HasKey(rs => new { rs.RecipeID, rs.StockID });

            modelBuilder.Entity<IngredientsInRecipe>()
                .HasOne(rs => rs.Recipe)
                .WithMany(r => r.IngredientsInRecipes)
                .HasForeignKey(rs => rs.RecipeID);

            modelBuilder.Entity<IngredientsInRecipe>()
                .HasOne(rs => rs.Stock)
                .WithMany(s => s.IngredientsInRecipes)
                .HasForeignKey(rs => rs.StockID);



            modelBuilder.Entity<Allergen>()
                .HasOne(e => e.Stock)
                .WithOne(e => e.Allergen)
                .HasForeignKey<Allergen>(e => e.StockID)
                .IsRequired();



            modelBuilder.Entity<CompanyOrders>().HasData(
                new CompanyOrders { CompanyOrdersID = 1, DeliveryDate = "03042024 1348", DeliveryPlace = "Kvickly" },
                new CompanyOrders { CompanyOrdersID = 2, DeliveryDate = "19062024 1300", DeliveryPlace = "Rema1000" },
                new CompanyOrders { CompanyOrdersID = 3, DeliveryDate = "23112024 1200", DeliveryPlace = "Aldi" },
                new CompanyOrders { CompanyOrdersID = 4, DeliveryDate = "24122024 1800", DeliveryPlace = "Netto" }

            );


            modelBuilder.Entity<BakingGoods>().HasData(
                new BakingGoods { BakingGoodsID = 1, Name = "Cake", Quantity = 100, CompanyOrdersID = 1, RecipeID = 1 },
                new BakingGoods { BakingGoodsID = 2, Name = "Bread", Quantity = 50, CompanyOrdersID = 2, RecipeID = 2 },
                new BakingGoods { BakingGoodsID = 3, Name = "Lagkage", Quantity = 20, CompanyOrdersID = 3, RecipeID = 3 },
                new BakingGoods { BakingGoodsID = 4, Name = "Romkugler", Quantity = 10, CompanyOrdersID = 4, RecipeID = 4 }
                );

            modelBuilder.Entity<Batch>().HasData(
                new Batch { BatchID = 1, BakingGoodsID = 1, StartTime = DateTime.Now, FinishTime = DateTime.Now.AddMinutes(40), Delay = 10 },
                new Batch { BatchID = 2, BakingGoodsID = 2, StartTime = DateTime.Now.AddMinutes(50), FinishTime = DateTime.Now.AddMinutes(70), Delay = 0 },
                new Batch { BatchID = 3, BakingGoodsID = 3, StartTime = DateTime.Now.AddMinutes(70), FinishTime = DateTime.Now.AddMinutes(100), Delay = 30 },
                new Batch { BatchID = 4, BakingGoodsID = 4, StartTime = DateTime.Now.AddMinutes(130), FinishTime = DateTime.Now.AddMinutes(150), Delay = 40 }

                );

            modelBuilder.Entity<Dispatch>().HasData(

                new Dispatch { TrackID = 1, CompanyOrdersID = 1 , Longitude = 219, Latitude = 382},
                new Dispatch { TrackID = 2, CompanyOrdersID = 2, Longitude = 109, Latitude = 219},
                new Dispatch { TrackID = 3, CompanyOrdersID = 3, Longitude = 539, Latitude = 23},
                new Dispatch { TrackID = 4, CompanyOrdersID = 4, Longitude = 679, Latitude = 145}

            );

            modelBuilder.Entity<Stock>().HasData(
                new Stock { StockID = 1, Name = "Flour", Quantity = 100000, },
                new Stock { StockID = 2, Name = "Sugar", Quantity = 100000 },
                new Stock { StockID = 3, Name = "Salt", Quantity = 100000 },
                new Stock { StockID = 4, Name = "Water", Quantity = 100000 },
                new Stock { StockID = 5, Name = "Egg", Quantity = 100000 },
                new Stock { StockID = 6, Name = "Baking Powder", Quantity = 100000 },
                new Stock { StockID = 7, Name = "Rum", Quantity = 100000 },
                new Stock { StockID = 8, Name = "Leftover cake", Quantity = 100000 },
                new Stock { StockID = 9, Name = "milk", Quantity = 100000 }
            );

            modelBuilder.Entity<Recipe>().HasData(

                new Recipe { RecipeID = 1, Name = "Cake" },
                new Recipe { RecipeID = 2, Name = "Bread" },
                new Recipe { RecipeID = 3, Name = "Lagkage" },
                new Recipe { RecipeID = 4, Name = "Romkugler" }
            );

            modelBuilder.Entity<IngredientsInRecipe>().HasData(

                //cake
                new IngredientsInRecipe { Quantity = 1000, RecipeID = 1, StockID = 1 },
                new IngredientsInRecipe { Quantity = 2300, RecipeID = 1, StockID = 2 },

                //Bread
                new IngredientsInRecipe { Quantity = 100, RecipeID = 2, StockID = 3 },
                new IngredientsInRecipe { Quantity = 2400, RecipeID = 2, StockID = 4 },
                new IngredientsInRecipe { Quantity = 300, RecipeID = 2, StockID = 5 },

                //Lagkage
                new IngredientsInRecipe { Quantity = 1000, RecipeID = 3, StockID = 1 },
                new IngredientsInRecipe { Quantity = 2300, RecipeID = 3, StockID = 2 },
                new IngredientsInRecipe { Quantity = 23, RecipeID = 3, StockID = 6 },
                new IngredientsInRecipe { Quantity = 15000, RecipeID = 3, StockID = 3 },

                //Romkugler
                new IngredientsInRecipe { Quantity = 200, RecipeID = 4, StockID = 7 },
                new IngredientsInRecipe { Quantity = 300, RecipeID = 4, StockID = 8 }
            );

            modelBuilder.Entity<Allergen>().HasData(
                new Allergen { AllergenID = 1, Name = "Gluten", StockID = 1 },
                new Allergen { AllergenID = 2, Name = "Glucose", StockID = 2 },
                new Allergen { AllergenID = 3, Name = "Sodium", StockID = 3 },
                new Allergen { AllergenID = 4, Name = "Water", StockID = 4 },
                new Allergen { AllergenID = 5, Name = "Protein", StockID = 5 },
                new Allergen { AllergenID = 6, Name = "Leavening agent", StockID = 6 },
                new Allergen { AllergenID = 7, Name = "Alcohol", StockID = 7 },
                new Allergen { AllergenID = 8, Name = "Gluten", StockID = 8 },
                new Allergen { AllergenID = 9, Name = "Lactose", StockID = 9 }
            );


        }
    }
}