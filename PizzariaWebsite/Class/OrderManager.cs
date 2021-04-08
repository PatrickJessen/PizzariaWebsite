using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class OrderManager
    {
        DalManager manager = new DalManager();

        public Order AddOrder(Order order)
        {
            return manager.AddOrder(order);
        }
    }
}