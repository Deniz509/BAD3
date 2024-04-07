using Microsoft.AspNetCore.Mvc;
using FoodAPI.Data;
using FoodAPI.Data.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class StockController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public StockController(BakeryDbContext context)
        {
            _context = context;
        }

        // Add new ingredient and quantity to stock
        [HttpPost("add-ingredient-to-stock")]
        public ActionResult AddIngredientToStock(int quantity, string name)
        {
            if (quantity < 0 || string.IsNullOrEmpty(name))
            {
                return BadRequest();
            }

            var existingIngredient = _context.Stock.FirstOrDefault(s => s.IngredientName.ToLower() == name.ToLower());
            if (existingIngredient != null)
            {
                existingIngredient.Quantity += quantity;
                _context.SaveChanges();
                return Ok(existingIngredient);
            }

            var newIngredient = new Stock
            {

                Quantity = quantity,
                IngredientName = name
            };

            _context.Stock.Add(newIngredient);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("remove-ingredient-from-stock")]
        public ActionResult RemoveIngredientFromStock(int id)
        {
            var stock = _context.Stock.FirstOrDefault(s => s.StockId == id);

            if (stock == null)
            {
                return NotFound();
            }

            _context.Stock.Remove(stock);
            _context.SaveChanges();

            return Ok();

        }

        // 1. Get current stock
        [HttpGet("current-stock1")]
        public ActionResult GetCurrentStock()
        {
            var currentStock = _context.GetCurrentStock().ToList();
            return Ok(currentStock);
        }

        [HttpPut("update-ingredient-quantity")]
        public ActionResult UpdateIngredientQuantity(int Stockid, int quantity)
        {

            var stock = _context.Stock.FirstOrDefault(s => s.StockId == Stockid);

            if (stock == null)
            {
                return NotFound();
            }

            if ((stock.Quantity + quantity) < 0)
            {
                return BadRequest();
            }


            stock.Quantity += quantity;
            _context.SaveChanges();
            return Ok(stock);
        }

    }
}