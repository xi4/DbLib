using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    [Table("ItemParam")]
    public class ItemParam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public long property_id { get; set; }
        public long? value_id { get; set; }
        public string formatted_name { get; set; }
        public string formatted_value { get; set; }
        public string formatted_name_local { get; set; }
        public string formatted_value_local { get; set; }
        public ICollection<OrderItemParams> OrderItemParams { get; set; }
    }
}