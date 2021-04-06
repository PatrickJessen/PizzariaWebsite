using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzariaWebsite
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            SessionManager.SessionId = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;
            Session["pizzaId" + SessionManager.SessionId] = SessionManager.SessionId;
            SessionManager.AddSession((int)Session["pizzaId" + SessionManager.SessionId]);
        }

        protected void AddToCart_Click1(object sender, EventArgs e)
        {

        }
    }
}