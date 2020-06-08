using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Market.Models
{
    public class ProductCart
    {
        public Cart cart { get; set; }
        public Product product { get; set; }
    }
}