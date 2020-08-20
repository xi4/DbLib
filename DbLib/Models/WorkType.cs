﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class WorkType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string txt { get; set; }
        public string txt_eng { get; set; }
        public int ord { get; set; }
        public ICollection<WorkListing>  workListings { get; set; }
    }
}