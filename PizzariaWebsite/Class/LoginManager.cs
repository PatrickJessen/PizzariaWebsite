using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class LoginManager
    {
        DalManager dm = new DalManager();

        public Boolean IsLoginValid(string uname, string psw)
        {
            if (dm.IsUsernameValid(uname) == uname && dm.IsPasswordValid(psw) == psw)
            {
                return true;
            }
            return false;
        }
    }
}