using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzariaWebsite
{
    public partial class Login : System.Web.UI.Page
    {
        LoginManager lm = new LoginManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (lm.IsLoginValid(username.Value, password.Value) == true)
            {
                //Add sessionID til brugeren og før brugeren videre til start siden + fjern login fra nav bare når man er logget ind
            }
        }
    }
}