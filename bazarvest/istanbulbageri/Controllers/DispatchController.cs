using Microsoft.AspNetCore.Mvc;
using FoodAPI.Data;
using FoodAPI.Data.Models;
using System.Linq;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DispatchController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public DispatchController(BakeryDbContext context)
        {
            _context = context;
        }

        // 5. Get the track ids corresponding to an order
        [HttpGet("TrackID")]
        public ActionResult GetTrackIdsOfOrder(int TrackID)
        {

            var packet = from i in _context.Dispatch
                        where i.CompanyOrdersID.Equals(TrackID)
                        select i;
            if (packet == null)
                return NotFound();
            var res =
                from orders in _context.CompanyOrders
                join pack in packet
                on orders.CompanyOrdersID equals pack.CompanyOrdersID
                select new
                {
                    TrackId = pack.TrackID,
                    Address = orders.DeliveryPlace,
                    Latitude = pack.Latitude,
                    Longitude = pack.Longitude
                };

            return Ok(res);
        }
    }
}