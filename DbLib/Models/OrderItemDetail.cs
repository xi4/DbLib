using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class OrderItemDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderNum { get; set; }
        public Listing listing { get; set; }
        public Shop Shop { get; set; }
        public Order order { get; set; }
        public string initial { get; set; }
        public string comment { get; set; }
        public ListingSku listingSku { get; set; }
        public ICollection<OrderItemWork> OrderItemWorks { get; set; }
        public ICollection<OrderItemParams> OrderItemParams { get; set; }
    }
}
