using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
    // Represents a dispatch, containing GPS coordinates and associated with a company order.
    public class Dispatch
    {
        // Unique identifier for the dispatch.
        [Key]
        public int TrackID { get; set; }

        // ID of the company orders associated with the dispatch.
        public int CompanyOrdersID { get; set; }

        // Company orders associated with the dispatch.
        public virtual CompanyOrders CompanyOrders { get; set; } = null!;

        // GPS coordinates.
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
