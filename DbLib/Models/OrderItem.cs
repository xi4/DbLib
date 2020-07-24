using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    [Table("OrderItem")]
    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public long transaction_id { get; set; }
        public int quantity { get; set; }
        public DateTime? creation_tsz { get; set; }
        public Listing listing { get; set; }
        public Order order { get; set; }
        public string initial { get; set; }
        public string comment { get; set; }
        public ListingSku listingSku { get; set; }
        public ICollection<PhotoItem> PhotoItems { get; set; }
        public ICollection<OrderItemParams> OrderItemParams { get; set; }
        public ICollection<OrderItemWork> OrderItemWorks { get; set; }
    }
}
