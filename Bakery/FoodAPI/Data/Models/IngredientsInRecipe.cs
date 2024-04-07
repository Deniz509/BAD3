using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class IngredientsInRecipe
    {

        public int Quantity { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; } = null!;

        public int StockID { get; set; }
        public Stock Stock { get; set; } = null!;



    }
}