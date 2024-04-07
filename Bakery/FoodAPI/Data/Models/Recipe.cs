using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        public string RecipeName { get; set; }

        public ICollection<IngredientsInRecipe> IngredientsInRecipes { get; } = new List<IngredientsInRecipe>();

        public BakingGoods? BakingGoods { get; set; }



    }
}