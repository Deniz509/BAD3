using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Allergen
    {
        [Key]
        public int AllergenID { get; set; }
        public string Name { get; set; } = null!;

        public int StockID { get; set; }
        public Stock Stock { get; set; } = null!;
    }
}