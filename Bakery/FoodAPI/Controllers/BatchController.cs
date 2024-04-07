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

        [HttpGet("IngredientsInBatch4/{BatchID}")]
        public ActionResult GetIngredientsAndAllergensFromBatch(int BatchID)
        {


            var first = from i in _context.Batch
                        where i.BatchID.Equals(BatchID)
                        select i;
            if (first == null)
                return NotFound();

            var second =
                from bakingGoods in _context.BakingGoods
                join batch in first
                on bakingGoods.BakingGoodsID equals batch.BakingGoodsID
                select new
                {
                    bakingGoodsId = bakingGoods.BakingGoodsID,
                    recipeID = bakingGoods.RecipeID
                };

            var third =
                from recipe in _context.Recipe
                join bg in second
                on recipe.RecipeID equals bg.recipeID
                select new
                {
                    recipeID = recipe.RecipeID
                };
            var fourth =
                from ingredient in _context.IngredientsInRecipes
                join re in third
                on ingredient.RecipeID equals re.recipeID
                select new
                {
                    stockID = ingredient.StockID,
                    Quantity = ingredient.Quantity
                };
            var fifth =
                from stock in _context.Stock
                join ing in fourth
                on stock.StockID equals ing.stockID
                select new
                {
                    ingredientName = stock.Name,
                    stockID = ing.stockID,
                    Quantity = ing.Quantity
                };
            var res =
                from allergen in _context.Allergen
                join stk in fifth
                on allergen.StockID equals stk.stockID
                select new
                {
                    Name = stk.ingredientName,
                    Quantity = stk.Quantity,
                    allergens = allergen
                };


            return Ok(res);
        }

        // 7. Get the average delay for all the batches
        [HttpGet("AverageDelay7")]
        public ActionResult GetAverageDelay()
        {
            var averageDelay = _context.Batch.Average(b => b.Delay);

            return Ok(averageDelay);
        }

    }
}