using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class ShoppingCart
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ShoppingCart(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}