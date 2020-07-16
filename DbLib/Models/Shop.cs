using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DbLib.Models
{
    [Table("Shop")]
    public class Shop
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string customKey { get; set; }
        public string customSecret { get; set; }

        public string tempkey { get; set; }
        public string tempsecret { get; set; }

        public string tokenKey { get; set; }
        public string tokenSecret { get; set; }

        public bool load { get; set; }

        public User Owner { get; set; }
        public string Key { get; set; }

        public bool state { get; set; }
        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }
        public ICollection<UserShop> worker { get; set; }
    }

    public class ShopCode
    {
        public int id { get; set; }
        public string Code { get; set; }
    }
}
