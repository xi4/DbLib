using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    public class OrderNum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int num { get; set; }
        public int OrderId { get; set; }
    }
}