using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EtsyApi.Models
{
    public class Variation
    {

        public long property_id { get; set; }
        public long? value_id { get; set; }
        public string formatted_name { get; set; }
        public string formatted_value { get; set; }
    }

    public class PropertyValue
    {
        public long property_id { get; set; }
        public string property_name { get; set; }
        public object scale_id { get; set; }
        public object scale_name { get; set; }
        public IList<string> values { get; set; }
        public IList<object> value_ids { get; set; }
    }

    public class Price
    {
        public int amount { get; set; }
        public int divisor { get; set; }
        public string currency_code { get; set; }
        public string currency_formatted_short { get; set; }
        public string currency_formatted_long { get; set; }
        public string currency_formatted_raw { get; set; }
    }

    public class Offering
    {
        public object offering_id { get; set; }
        public Price price { get; set; }
        public int quantity { get; set; }
    }

    public class ProductData
    {
        public object product_id { get; set; }
        public string sku { get; set; }
        public IList<PropertyValue> property_values { get; set; }
        public IList<Offering> offerings { get; set; }
    }

    public class ETransaction
    {
        public long transaction_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int seller_user_id { get; set; }
        public int buyer_user_id { get; set; }
        public int creation_tsz { get; set; }
        public int? paid_tsz { get; set; }
        public int? shipped_tsz { get; set; }
        public string price { get; set; }
        public string currency_code { get; set; }
        public int quantity { get; set; }
        public IList<string> tags { get; set; }
        public IList<string> materials { get; set; }
        public long image_listing_id { get; set; }
        public int receipt_id { get; set; }
        public string shipping_cost { get; set; }
        public bool is_digital { get; set; }
        public string file_data { get; set; }
        public int listing_id { get; set; }
        public bool is_quick_sale { get; set; }
        public int? seller_feedback_id { get; set; }
        public int? buyer_feedback_id { get; set; }
        public string transaction_type { get; set; }
        public string url { get; set; }
        public IList<Variation> variations { get; set; }
        public ProductData product_data { get; set; }
    }

    public class Params
    {
        public string receipt_id { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public object page { get; set; }
    }


    public class Transactions
    {
        public int count { get; set; }
        public IList<ETransaction> results { get; set; }
        public Params @params { get; set; }
        public string type { get; set; }
        public Pagination pagination { get; set; }
    }
}
