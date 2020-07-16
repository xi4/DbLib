using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    [Table("OrderItemParams")]
    public class OrderItemParams
    {
        public OrderItem OrderItem { get; set; }
        public int OrderItemId { get; set; }
        public ItemParam ItemParam { get; set; }
        public int ItemParamId { get; set; }
    }
}