using Microsoft.AspNetCore.Mvc;
using Bakery.Data;
using Bakery.Models;
using System.Linq;

//Here we are defining the controller as an API controller
namespace Bakery.Controllers
{
    // This is the controller for the Dispatch controller.
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    //The controller for the Dispatch controller.
    public class DispatchController : ControllerBase
    {
        // Here we are defining the controller as an API controller
        private readonly BakeryDbContext _context;
        // This is the constructor for the Dispatch controller.
        public DispatchController(BakeryDbContext context)
        {
            _context = context;
        }

        // 5. Get the track ids corresponding to an order
        [HttpGet("TrackID")]
        public ActionResult GetTrackIdsOfOrder(int TrackID)
        {
            // This method returns the track ids corresponding to an order
            var packet = from i in _context.Dispatch
                        where i.CompanyOrdersID.Equals(TrackID)
                        select i;
            if (packet == null)
                return NotFound();
            // Here we have a different method that returns the track ids corresponding to an order
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