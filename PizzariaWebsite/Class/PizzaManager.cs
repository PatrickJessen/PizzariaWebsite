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

        public List<Pizza> GetAllPizza()
        {
            return pizzaList;
        }

        public void CalculateQuantity(List<Pizza> pizzalist, int pID, decimal pPrice, string pName)
        {
            for (int i = 0; i < pizzalist.Count; i++)
            {
                //check if we already have the same pizza in the list
                if (pizzalist[i].Id == pID)
                {
                    //add to quantity if theres added the same pizza multiple times
                    pizzalist[i].Quantity++;
                    //calculates the price
                    pizzalist[i].Price += pPrice;
                    //break the loop cause we only need to do this once
                    break;
                }
                //check if we're at the end of the loop
                else if (i == pizzalist.Count - 1)
                {
                    //add new pizza to the list if theres none already matching
                    pizzalist.Add(new Pizza(pID, pName, pPrice, 1, pPrice));
                    //break the loop otherwise it adds +1 to quantity
                    break;
                }
            }
        }
    }
}