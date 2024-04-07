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

        [HttpGet("IngredientsInBatch4/{id}")]
        public ActionResult GetIngredientsAndAllergensFromBatch(int id)
        {


            var first = from i in _context.Batch
                        where i.BatchId.Equals(id)
                        select i;
            if (first == null)
                return NotFound();

            var second =
                from bakingGoods in _context.BakingGoods
                join batch in first
                on bakingGoods.BakingGoodsId equals batch.BakingGoodsId
                select new
                {
                    bakingGoodsId = bakingGoods.BakingGoodsId,
                    recipeId = bakingGoods.RecipeId
                };

            var third =
                from recipe in _context.Recipe
                join bg in second
                on recipe.RecipeId equals bg.recipeId
                select new
                {
                    recipeId = recipe.RecipeId
                };
            var fourth =
                from ingredient in _context.IngredientsInRecipes
                join re in third
                on ingredient.RecipeId equals re.recipeId
                select new
                {
                    stockId = ingredient.StockId,
                    Quantity = ingredient.Quantity
                };
            var fifth =
                from stock in _context.Stock
                join ing in fourth
                on stock.StockId equals ing.stockId
                select new
                {
                    ingredientName = stock.IngredientName,
                    stockId = ing.stockId,
                    Quantity = ing.Quantity
                };
            var res =
                from allergen in _context.Allergen
                join stk in fifth
                on allergen.StockId equals stk.stockId
                select new
                {
                    ingredientName = stk.ingredientName,
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