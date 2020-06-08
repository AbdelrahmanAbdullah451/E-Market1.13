using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Market.Models;
using E_Market.ViewModel;
namespace E_Market.ViewModel
{
    public class ProductCartVM
    {
        public List<Product> products { get; set; }
        public List<Cart> carts { get; set; }
    }
}