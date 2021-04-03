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
        public List<PizzaTopping> Toppings { get; set; }
        public decimal Price { get; set; }

        public Pizza(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
            Toppings = new List<PizzaTopping>();
        }

        public void AddTopping(PizzaTopping top)
        {
            Toppings.Add(top);
        }
    }
}