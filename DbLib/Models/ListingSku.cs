using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DbLib.Models
{
    public class ListingSku
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string txt { get; set; }
        
        [Column(TypeName = "decimal(18,3)")]
        public decimal area { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }
        [JsonIgnore]
        public ICollection<OrderItem> orderItems { get; set; }

        public ICollection<WorkListing> workListings { get; set; }
        //public ICollection<MaterialListing> materialListings { get; set; }
    }
}