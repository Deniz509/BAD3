using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class Orders
    {
        [Key]
        public int OrdersId { get; set; }

        public string DeliveryDate { get; set; }

        public string DeliveryPlace { get; set; }

        public ICollection<Packets> Packets { get; } = new List<Packets>();

        public ICollection<BakingGoods> BakingGoods { get; } = new List<BakingGoods>();
    }
}