using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    [Table("PhotoItem")]
    public class PhotoItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long transaction_id { get; set; }
        public byte[] image { get; set; }
        public int ord { get; set; }
        public User user { get; set; }
        public int state { get; set; }
    }
}
