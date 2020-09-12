﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class Billing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int bill_type { get; set; }
        public DateTime CreateDate { get; set; }
        public User User { get; set; }
        public OrderItemWork OrderItemWork { get; set; }
        public Payment Payment { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal tarrif { get; set; }
        public int count { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal summa { get; set; }
        
    }
}