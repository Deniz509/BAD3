using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        public string Name { get; set; }

        public ICollection<IngredientsInRecipe> IngredientsInRecipes { get; } = new List<IngredientsInRecipe>();

        public BakingGoods? BakingGoods { get; set; }



    }
}