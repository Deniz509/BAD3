using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class IngredientsInRecipe
    {

        public int Quantity { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;

        public int StockId { get; set; }
        public Stock Stock { get; set; } = null!;



    }
}