using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            // Checks if Session is not null, if so. Executes code inside if statment.
            if (Session["Username"] != null)
            {
                Session.Abandon();
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            // Calls the instance named lm, and adds the IsLoginValid method, along with the parameteres and checks if their values are true.
            if (lm.IsLoginValid(username.Value, password.Value) == true)
            {
                if (username.Value == "admin")
                {
                    Session["Admin"] = username.Value;
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    Session["Username"] = username.Value;
                    Response.Redirect("Default.aspx");
                }
            }
            else
            {
                // Gives an Error message, if login failed.
                failText.Text = "Login Failed!";
            }
        }
    }
}