using System.Collections.Generic;

namespace EtsyApi.Models
{
    public class Shipment
    {
        public string receipt_shipping_id { get; set; }
        public int mailing_date { get; set; }
        public string carrier_name { get; set; }
        public string tracking_code { get; set; }
        public string major_tracking_state { get; set; }
        public string current_step { get; set; }
        public int? current_step_date { get; set; }
        public string mail_class { get; set; }
        public string buyer_note { get; set; }
        public int notification_date { get; set; }
        public string tracking_url { get; set; }
    }

    public class ShippingDetail
    {
        public bool can_mark_as_shipped { get; set; }
        public bool was_shipped { get; set; }
        public bool is_future_shipment { get; set; }
        public bool has_free_shipping_discount { get; set; }
        public string not_shipped_state_display { get; set; }
        public string shipping_method { get; set; }
        public bool is_estimated_delivery_date_relevant { get; set; }
        public int? shipment_date { get; set; }
        public bool? has_upgrade { get; set; }
        public string upgrade_name { get; set; }
    }

    public class Receipt
    {
        public long receipt_id { get; set; }
        public int creation_tsz { get; set; }
        public int last_modified_tsz { get; set; }
        public string name { get; set; }
        public string first_line { get; set; }
        public string second_line { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string formatted_address { get; set; }
        public int country_id { get; set; }
        public string message_from_seller { get; set; }
        public string message_from_buyer { get; set; }
        public bool was_paid { get; set; }
        public string message_from_payment { get; set; }
        public bool was_shipped { get; set; }
        public string buyer_email { get; set; }
        public bool is_gift { get; set; }
        public bool needs_gift_wrap { get; set; }
        public string gift_message { get; set; }
        public bool is_dead { get; set; }
    }

    public class Param
    {
        public string shop_id { get; set; }
        public object min_created { get; set; }
        public object max_created { get; set; }
        public object min_last_modified { get; set; }
        public object max_last_modified { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public object page { get; set; }
        public object was_paid { get; set; }
        public object was_shipped { get; set; }
    }

    public class Receipts
    {
        public int count { get; set; }
        public IList<Receipt> results { get; set; }
        //public Param @params { get; set; }
        //public string type { get; set; }
        public Pagination pagination { get; set; }
    }
}
