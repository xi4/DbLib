using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class OrderInvoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Order order { get; set; }
        public byte[] image { get; set; }
    }
}
