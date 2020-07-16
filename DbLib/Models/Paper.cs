using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class Paper
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string txt {get;set;}
        public int group { get; set; }
        public ICollection<DocPaper> DocPapers { get; set; }
    }
}
