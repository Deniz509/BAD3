using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public ICollection<Ingredients> Ingredients { get; } = new List<Ingredients>();

        public Allergen? Allergen { get; set; }

    }
}