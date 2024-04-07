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
    public class CompanyOrdersController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public CompanyOrdersController(BakeryDbContext context)
        {
            _context = context;
        }

        // 2. Get the address and date for an order
        [HttpGet("OrderDetails")]
        public ActionResult GetOrderDetails()
        {
            var orderDetails = _context.CompanyOrders.Select(o => new
            {
                o.DeliveryPlace,
                o.DeliveryDate
            }).ToList();
            
            return Ok(orderDetails);
        }

        //6. Produce a table containing the quantities of each of the baking goods in all the orders 
        // received so far (NB: First column is in Ascending order)

        [HttpGet("BakingGoodsInOrders")]
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