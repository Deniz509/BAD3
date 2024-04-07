using Microsoft.AspNetCore.Mvc;
using FoodAPI.Data;
using FoodAPI.Data.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class RecipeController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public RecipeController(BakeryDbContext context)
        {
            _context = context;
        }
        
    }
}
