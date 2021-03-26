using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public DateTime Time { get; set; }

        public Order(int id, string description, int customerId, DateTime time)
        {
            Id = id;
            Description = description;
            CustomerId = customerId;
            Time = time;
        }

        public void AddOrder()
        {

        }
    }
}