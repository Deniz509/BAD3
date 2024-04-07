using Microsoft.AspNetCore.Mvc;
using FoodAPI.Data;
using FoodAPI.Data.Models;
using System.Linq;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BakingGoodsController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public BakingGoodsController(BakeryDbContext context)
        {
            _context = context;
        }

        // 3. Get the list of baked goods in an order
        [HttpGet("GetBakingGoodsInOrder3/{orderId}")]
        public ActionResult GetBakingGoodsInOrder(int orderId)
        {
            var bakingGoods = _context.BakingGoods.Where(bg => bg.OrdersId == orderId).ToList();

            if (bakingGoods == null)
            {
                return NotFound();
            }

            return Ok(bakingGoods);
        }
    }
}