using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Batch
    {
        [Key]
        public int BatchId { get; set; }

        public float Delay { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime StopTime { get; set; }

        public int BakingGoodsId { get; set; }

        public BakingGoods BakingGoods { get; set; } = null!;

        

        
    }
}