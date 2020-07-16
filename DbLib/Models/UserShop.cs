using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    [Table("UserShop")]
    public class UserShop
    {
        public User user { get; set; }
        public int userId { get; set; }
        public Shop shop { get; set; }
        public int shopId { get; set; }
        public bool state { get; set; }
    }
}
