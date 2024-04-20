using Microsoft.AspNetCore.Mvc;
using Bakery.Data;
using Bakery.Models;
using System.Linq;

namespace Bakery.Controllers
{
    // This is the controller for the BakingGoods controller.
    [Route("api/[controller]")]
    //Here we are defining the controller as an API controller
    [ApiController]

    //Here we are defining the controller as an API controller
    [Produces("application/json")]
    public class BakingGoodsController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public BakingGoodsController(BakeryDbContext context)
        {
            _context = context;
        }


        // Get the list of baked goods in an order
        [HttpGet("CompanyOrderID")]
        // This method returns a list of baking goods in an order
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
