using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class UserManager
    {
        DalManager manager = new DalManager();

        public User RegistreUser(User user)
        {
            return manager.RegistreUser(user);
        }

        public User InsertUserInfo(User user)
        {
            return manager.InsertUserInfo(user);
        }

        public bool IsUsernameTaken(string username)
        {
            if (manager.IsUsernameTaken(username))
            {
                return true;
            }
            return false;
        }
    }
}