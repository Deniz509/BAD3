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
        public int BakingGoodsId { get; set; }

        public string BakingGoodsName { get; set; }

        public int Amount { get; set; }

        public Orders Orders { get; set; } = null!;

        public int OrdersId { get; set; }

        public Recipe Recipe { get; set; } = null!;

        public int RecipeId { get; set; }

        public ICollection<Batch> Batch { get; } = new List<Batch>(); 

    }

}
