using Azure;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace FoodAPI.Data.Models
{
    public class BakingGoods
    {
        [Key]
        public int BakingGoodsID { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public CompanyOrders CompanyOrders { get; set; } = null!;

        public int CompanyOrdersID { get; set; }

        public Recipe Recipe { get; set; } = null!;

        public int RecipeID { get; set; }

        public ICollection<Batch> Batch { get; } = new List<Batch>(); 

    }

}
