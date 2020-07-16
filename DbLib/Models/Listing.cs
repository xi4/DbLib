using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DbLib.Models
{
    [Table("Listing")]
    public class Listing
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int shop_id { get; set; }
        public long listing_id { get; set; }
        public byte[] image { get; set; }
        public string image_url {get; set;}
        public long image_id { get; set; }
        public ICollection<ListingSku> listingSku { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}