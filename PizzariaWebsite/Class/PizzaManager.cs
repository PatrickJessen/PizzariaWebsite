using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class PizzaManager
    {
        List<Pizza> pizzaList;
        DalManager manager = new DalManager();
        public PizzaManager()
        {
            pizzaList = manager.GetPizzaData();
        }

        public string GetPizzaName(int id)
        {
            return manager.GetPizzaName(id);
        }

        public List<Pizza> GetAllPizza()
        {
            return pizzaList;
        }

        public Pizza GetPizza(int id)
        {
            for (int i = 0; i < pizzaList.Count; i++)
            {
                if (i == id)
                {
                    return pizzaList[i];
                }
            }
            return null;
        }
    }
}