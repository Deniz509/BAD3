using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodAPI.Data.Models
{
    public class Dispatch
	{
        [Key]
        public int TrackID{ get; set; }

        public int CompanyOrdersID { get; set; }

        public virtual CompanyOrders CompanyOrders { get; set; } = null!;

        //Gps Coords
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}