using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLib.Models
{
    [Table("Order")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public long receipt_id { get; set; }
        public string name { get; set; }
        public string name_alternative { get; set; }
        public string email { get; set; }
        public string first_line { get; set; }
        public string second_line { get; set; }
        public int country_id { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string formatted_address { get; set; }
        public string formatter_address_change { get; set; }
        public string message_from_seller { get; set; }
        public string message_from_buyer { get; set; }
        public bool was_paid { get; set; }
        public bool was_shipped { get; set; }
        public DateTime? creation_tsz { get; set; }
        public DateTime loadFromEtsy { get; set; }
        public string message_from_payment { get; set; }
        public bool is_gift { get; set; }
        public string gift_message { get; set; }
        public string gift_message_alternative { get; set; }
        public bool needs_gift_wrap { get; set; }
        public string url_show { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<OrderInvoice> OrderInvoices { get; set; }
        public Shop Shop { get; set; }
        public bool is_dead { get; set; }
        public bool express { get; set; }
    }
}
