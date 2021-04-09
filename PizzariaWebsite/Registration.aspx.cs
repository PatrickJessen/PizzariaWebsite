using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzariaWebsite
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegBtn_Click(object sender, EventArgs e)
        {
            UserManager manager = new UserManager();
            if (manager.IsUsernameTaken(username.Value))
            {
                username.Value = "";
                username.Attributes.Add("placeholder", "Username is taken!");
            }
            else
            {
                manager.RegistreUser(new User(username.Value, password.Value));
                manager.InsertUserInfo(new User(fName.Value, lName.Value, Convert.ToInt32(phoneNr.Value), adress.Value));
            }
        }
    }
}