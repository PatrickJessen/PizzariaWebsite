using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaTopping Topping { get; set; }
        public decimal Price { get; set; }

        public Pizza(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public void AddTopping()
        {
            
        }

        public void AddPizzaToCart(ShoppingCart cart)
        {

        }
    }
}