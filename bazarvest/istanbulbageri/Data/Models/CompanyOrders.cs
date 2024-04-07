using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Data.Models
{
    public class CompanyOrders
    {
        [Key]
        public int CompanyOrdersID { get; set; }

        public string DeliveryDate { get; set; }

        public string DeliveryPlace { get; set; }

        public ICollection<Dispatch> Dispatch { get; } = new List<Dispatch>();

        public ICollection<BakingGoods> BakingGoods { get; } = new List<BakingGoods>();
    }
}