using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class Order
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Product { get; set; }
        public int CustomerId { get; set; }
        public decimal Price { get; set; }
        public DateTime Time { get; set; }

        public Order(int id, string username, string product, decimal price, DateTime time)
        {
            Id = id;
            Username = username;
            Product = product;
            Price = price;
            Time = time;
        }
    }
}