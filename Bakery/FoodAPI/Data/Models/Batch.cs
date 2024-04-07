using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Batch
    {
        [Key]
        public int BatchID { get; set; }

        public float Delay { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }

        public int BakingGoodsID { get; set; }

        public BakingGoods BakingGoods { get; set; } = null!;

        

        
    }
}