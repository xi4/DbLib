﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace DbLib.Models
{
    public class WorkListing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public WorkType workType { get; set; }
        public ListingSku listingSku { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal price_ua { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal price_usd { get; set; }


        //https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json
    }
}