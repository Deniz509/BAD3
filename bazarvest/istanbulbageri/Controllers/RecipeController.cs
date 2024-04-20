using Microsoft.AspNetCore.Mvc;
using Bakery.Data;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


//Here we are defining the controller as an API controller
namespace Bakery.Controllers
{
    // This is the controller for the Recipe controller.
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class RecipeController : ControllerBase
    {
        //Here we have a private and public constructor for the Recipe controller.
        private readonly BakeryDbContext _context;

        public RecipeController(BakeryDbContext context)
        {
            _context = context;
        }
        
    }
}
