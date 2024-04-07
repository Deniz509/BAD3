using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodAPI.Data.Models
{
    public class Dispatch
	{
        [Key]
        public int TrackId{ get; set; }

        public int  OrderId { get; set; }

        public virtual Orders Orders {get; set; } = null!;

        //Gps Coords
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}