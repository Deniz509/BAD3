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
    public class OrdersController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public OrdersController(BakeryDbContext context)
        {
            _context = context;
        }

        // 2. Get the address and date for an order
        [HttpGet("OrderDetails2")]
        public ActionResult GetOrderDetails()
        {
            var orderDetails = _context.Orders.Select(o => new
            {
                o.DeliveryPlace,
                o.DeliveryDate
            }).ToList();
            
            return Ok(orderDetails);
        }

        //6. Produce a table containing the quantities of each of the baking goods in all the orders 
        // received so far (NB: First column is in Ascending order)

        [HttpGet("BakingGoodsInOrders6")]
        public ActionResult GetBakingGoodsInOrders()
        {
            var bakingGoodsInOrders = _context.BakingGoods
                .GroupBy(bg => bg.BakingGoodsName)
                .Select(bg => new
                {
                    BakingGoodsName = bg.Key,
                    TotalAmount = bg.Sum(bg => bg.Amount)
                })
                .OrderBy(bg => bg.TotalAmount)
                .ToList();

            return Ok(bakingGoodsInOrders);
        }
    }
}