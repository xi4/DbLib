using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class DocPaper
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Paper Paper { get; set; }
    }
}
