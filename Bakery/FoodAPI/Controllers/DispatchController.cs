using Microsoft.AspNetCore.Mvc;
using FoodAPI.Data;
using FoodAPI.Data.Models;
using System.Linq;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PacketsController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public PacketsController(BakeryDbContext context)
        {
            _context = context;
        }

        // 5. Get the track ids corresponding to an order
        [HttpGet("GetTrackIdsOfOrder5/{id}")]
        public ActionResult GetTrackIdsOfOrder(int id)
        {

            var packet = from i in _context.Packets
                        where i.OrderId.Equals(id)
                        select i;
            if (packet == null)
                return NotFound();
            var res =
                from orders in _context.Orders
                join pack in packet
                on orders.OrdersId equals pack.OrderId
                select new
                {
                    TrackId = pack.TrackId,
                    Address = orders.DeliveryPlace,
                    Latitude = pack.Latitude,
                    Longitude = pack.Longitude
                };

            return Ok(res);
        }
    }
}