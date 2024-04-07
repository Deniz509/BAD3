﻿using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public ICollection<IngredientsInRecipe> IngredientsInRecipes { get; } = new List<IngredientsInRecipe>();

        public Allergen? Allergen { get; set; }

    }
}