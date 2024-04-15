using Microsoft.AspNetCore.Mvc;
using FoodAPI.Data;
using FoodAPI.Data.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;


//Here we are defining the controller as an API controller
namespace FoodAPI.Controllers
{
    // This is the controller for the Stock controller.
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    // Here we have a class for the Stock controller.
    public class StockController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public StockController(BakeryDbContext context)
        {
            _context = context;
        }

        // Add new ingredient and quantity to stock
        // We are defining the route for the method
        [HttpPost("AddIngredient")]
        public ActionResult AddIngredientToStock(int quantity, string name)
        {
            if (quantity < 0 || string.IsNullOrEmpty(name))
            {
                return BadRequest();
            }

            var existingIngredient = _context.Stock.FirstOrDefault(s => s.Name.ToLower() == name.ToLower());
            if (existingIngredient != null)
            {
                existingIngredient.Quantity += quantity;
                _context.SaveChanges();
                return Ok(existingIngredient);
            }

            var newIngredient = new Stock
            {

                Quantity = quantity,
                Name = name
            };

            _context.Stock.Add(newIngredient);
            _context.SaveChanges();

            return Ok();
        }
        // Here we have a method that removes an ingredient from the stock
        [HttpDelete("RemoveIngredient")]
        public ActionResult RemoveIngredientFromStock(int id)
        {
            var stock = _context.Stock.FirstOrDefault(s => s.StockID == id);

            if (stock == null)
            {
                return NotFound();
            }

            _context.Stock.Remove(stock);
            _context.SaveChanges();

            return Ok();

        }

        // 1. Get current stock
        [HttpGet("CurrentStock")]
        public ActionResult GetCurrentStock()
        {
            var currentStock = _context.GetCurrentStock().ToList();
            return Ok(currentStock);
        }

        [HttpPut("UpdateIngredientQuantity")]
        public ActionResult UpdateIngredientQuantity(int Stockid, int quantity)
        {

            var stock = _context.Stock.FirstOrDefault(s => s.StockID == Stockid);

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