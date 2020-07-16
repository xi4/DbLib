﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class OrderItemWork
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public OrderItem OrderItem { get; set; }
        public User User { get; set; }
        public WorkListing WorkListing { get; set; }
        public int state { get; set; }
        public DateTime CompleteDate { get; set; }
    }
}