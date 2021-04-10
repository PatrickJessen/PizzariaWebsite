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
        public int CustomerId { get; set; }
        public DateTime Time { get; set; }
        public int PizzaId { get; set; }
        public int Quantity { get; set; }

        public Order(int id, string username, DateTime time, int pizzaId, int quantity)
        {
            Id = id;
            Username = username;
            Time = time;
            PizzaId = pizzaId;
            Quantity = quantity;
        }
    }
}