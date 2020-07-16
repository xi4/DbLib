using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class Curse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime chrono { get; set; }
        public double ua { get; set; }
    }
}