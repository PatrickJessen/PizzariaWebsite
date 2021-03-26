using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class ShoppingCart
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ShoppingCart(string description, int quantity, decimal price)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
}