using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzariaWebsite
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //udkommenteres når design og tests af checkout er færdigt
            //if (Session["Cart"] == null)
            //{
            //    Response.Redirect("Default.aspx");
            //}
            if (Session["Username"] != null)
            {
                LoginPage.InnerText = "Logout";
            }
        }

        protected void BuyPizza_Click(object sender, EventArgs e)
        {
            List<Pizza> products;
            OrderManager manager = new OrderManager();
            products = (List<Pizza>)Session["Cart"];
            for (int i = 0; i < products.Count; i++)
            {
                manager.AddOrder(new Order(products[i].Id, Session["Username"].ToString(), DateTime.Now, products[i].Id, products[i].Quantity));
            }
            Response.Redirect("MyPage.aspx");
        }
    }
}