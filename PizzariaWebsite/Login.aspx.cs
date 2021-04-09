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
            if (Session["Username"] != null)
            {
                LoginPage.InnerText = "Logout";
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            // Checks if the innertext of LoginPage is Logout, if so. It logs the user out.
            if (LoginPage.InnerText == "Logout")
            {
                Session["Username"] = null;
                Response.Redirect("Login.aspx");
            }

            if (lm.IsLoginValid(username.Value, password.Value) == true)
            {
                //Add sessionID til brugeren og før brugeren videre til start siden + fjern login fra nav bare når man er logget ind
                Session["Username"] = username.Value;
                Response.Redirect("MyPage.aspx");
            }
            else
            {
                failText.Text = "Login Failed!";
                //giv en fejlmeddelse
            }
        }
    }
}