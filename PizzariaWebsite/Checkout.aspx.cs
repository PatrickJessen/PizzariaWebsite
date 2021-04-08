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
        }

        protected void BuyPizza_Click(object sender, EventArgs e)
        {
            List<Pizza> products;
            List<User> user;
            if (cardNumber.Text.Length != 16 && cardExpire.Text != null && cardCVV.Text.Length != 2)
            {
                OrderManager manager = new OrderManager();
                products = (List<Pizza>)Session["Card"];
                user = (List<User>)Session["Username"];
                for (int i = 0; i < products.Count; i++)
                {
                    manager.AddOrder(new Order(products[i].Id, user[0].Username, products[i].Name, products[i].Price, DateTime.Now));
                }
            }
        }
    }
}