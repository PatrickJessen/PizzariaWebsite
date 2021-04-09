using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class LoginManager
    {
        DalManager dm = new DalManager();

        public bool IsLoginValid(string uname, string psw)
        {
            if (dm.IsLoginValid(uname, psw))
            {
                return true;
            }
            return false;
        }
    }
}