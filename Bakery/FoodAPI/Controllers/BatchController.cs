using Microsoft.AspNetCore.Mvc;
using FoodAPI.Data;
using FoodAPI.Data.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BatchController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public BatchController(BakeryDbContext context)
        {
            _context = context;
        }

        [HttpGet("BatchID")]
        public ActionResult GetIngredientsAndAllergensFromBatch(int BatchID)
        {


            var Batch_var = from i in _context.Batch
                        where i.BatchID.Equals(BatchID)
                        select i;
            if (Batch_var == null)
                return NotFound();

            var BakingGoods_var =
                from bakingGoods in _context.BakingGoods
                join batch in Batch_var
                on bakingGoods.BakingGoodsID equals batch.BakingGoodsID
                select new
                {
                    bakingGoodsId = bakingGoods.BakingGoodsID,
                    recipeID = bakingGoods.RecipeID
                };

            var Recipe_var =
                from recipe in _context.Recipe
                join bg in BakingGoods_var
                on recipe.RecipeID equals bg.recipeID
                select new
                {
                    recipeID = recipe.RecipeID
                };

            var Ingredients_var =
                from ingredient in _context.Ingredients
                join re in Recipe_var
                on ingredient.RecipeID equals re.recipeID
                select new
                {
                    stockID = ingredient.StockID,
                    Quantity = ingredient.Quantity
                };

            var Stock_var =
                from stock in _context.Stock
                join ing in Ingredients_var
                on stock.StockID equals ing.stockID
                select new
                {
                    ingredientName = stock.Name,
                    stockID = ing.stockID,
                    Quantity = ing.Quantity
                };

            var Allergen_var =
                from allergen in _context.Allergen
                join stk in Stock_var
                on allergen.StockID equals stk.stockID
                select new
                {
                    Name = stk.ingredientName,
                    Quantity = stk.Quantity,
                    allergens = allergen
                };


            return Ok(Allergen_var);
        }

        // 7. Get the average delay for all the batches
        [HttpGet("AverageDelay")]
        public ActionResult GetAverageDelay()
        {
            var averageDelay = _context.Batch.Average(b => b.Delay);

            return Ok(averageDelay);
        }

    }
}