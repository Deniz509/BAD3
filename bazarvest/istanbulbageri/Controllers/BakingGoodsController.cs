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
        [HttpGet("CompanyOrderID")]
        public ActionResult GetBakingGoodsInOrder(int CompanyOrderID)
        {
            var bakingGoods = _context.BakingGoods.Where(bg => bg.CompanyOrdersID == CompanyOrderID).ToList();

            if (bakingGoods == null)
            {
                return NotFound();
            }

            return Ok(bakingGoods);
        }
    }
}