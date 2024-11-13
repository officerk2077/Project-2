using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KienAuto.Models
{
    public class CartItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}