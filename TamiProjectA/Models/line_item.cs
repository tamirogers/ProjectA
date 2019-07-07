using System;
using System.ComponentModel.DataAnnotations;

namespace TamiProjectA.Models
{
    public class line_item
    {
        [Key]
        public int line_item_id  { get; set; }

        public int order_id { get; set; }
        public int stock_id { get; set; }
        public string description { get; set; }
        public int qty { get; set; }
        public DateTime date_added { get; set; }
        public int unit_id { get; set; }
    }
}
