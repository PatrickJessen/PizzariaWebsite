using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class PizzaManager
    {
        DalManager manager = new DalManager();
        public string GetPizzaName(int id)
        {
            string temp = "";
            for (int i = 0; i < manager.GetPizzaData(id).Count; i++)
            {
                temp += manager.GetPizzaData(id)[i].Name;
            }
            return temp;
        }

        public string GetPizzaID(int id)
        {
            string temp = "";
            for (int i = 0; i < manager.GetPizzaData(id).Count; i++)
            {
                temp += manager.GetPizzaData(id)[i].Id;
            }
            return temp;
        }
    }
}