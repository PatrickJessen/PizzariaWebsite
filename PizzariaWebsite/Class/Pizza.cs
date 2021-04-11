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
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal SinglePrice { get; set; }

        public Pizza(int id, string name, decimal price, int quantity, decimal singlePrice)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            SinglePrice = singlePrice;
        }

        public Pizza(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}