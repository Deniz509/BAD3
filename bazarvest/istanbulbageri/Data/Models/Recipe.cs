using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        public string Name { get; set; }

        public ICollection<Ingredients> Ingredients { get; } = new List<Ingredients>();

        public BakingGoods? BakingGoods { get; set; }



    }
}