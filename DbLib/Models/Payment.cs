using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime PayDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal summa { get; set; }
        public ICollection<Billing> billings { get; set; }
    }
}