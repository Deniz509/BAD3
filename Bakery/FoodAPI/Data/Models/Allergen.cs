using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Allergen
    {
        [Key]
        public int AllergenId { get; set; }
        public string AllergenName { get; set; } = null!;

        public int StockId { get; set; }
        public Stock Stock { get; set; } = null!;
    }
}