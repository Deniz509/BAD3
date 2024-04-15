 using Microsoft.AspNetCore.Mvc;
using FoodAPI.Data;
using FoodAPI.Data.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
//Here we are defining the controller as an API controller
namespace FoodAPI.Controllers
{
    //Here we are defining the controller as an API controller
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    // This is the controller for the CompanyOrders controller.
    public class CompanyOrdersController : ControllerBase
    {
        // This is the constructor for the CompanyOrders controller.
        private readonly BakeryDbContext _context;
        // This is the constructor for the CompanyOrders controller.
        public CompanyOrdersController(BakeryDbContext context)
        {
            _context = context;
        }

        // 2. Get the address and date for an order
        [HttpGet("OrderDetails")]
        // This method returns the address and date for an order
        public ActionResult GetOrderDetails()
        {
            // This method returns the address and date for an order
            var orderDetails = _context.CompanyOrders.Select(o => new
            {
                o.DeliveryPlace,
                o.DeliveryDate
            }).ToList();
            
            return Ok(orderDetails);
        }

        //6. Produce a table containing the quantities of each of the baking goods in all the orders 
        // received so far (NB: First column is in Ascending order)

        // This method returns a list of baking goods in all orders
        [HttpGet("BakingGoodsInOrders")]
        // Here we have a method that returns a list of baking goods in all orders
        public ActionResult GetBakingGoodsInOrders()
        {
            var bakingGoodsInOrders = _context.BakingGoods
                .GroupBy(bg => bg.Name)
                .Select(bg => new
                {
                    BakingGoodsName = bg.Key,
                    TotalAmount = bg.Sum(bg => bg.Quantity)
                })
                .OrderBy(bg => bg.TotalAmount)
                .ToList();

            return Ok(bakingGoodsInOrders);
        }
    }
}