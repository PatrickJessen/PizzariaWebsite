using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzariaWebsite
{
    public partial class Admin : System.Web.UI.Page
    {
        OrderManager manager = new OrderManager();
        PizzaManager pizzaManager = new PizzaManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["Admin"] != null)
                {

                    DataTable dt = new DataTable();
                    DataRow row;
                    dt.Columns.Add("OrderID");
                    dt.Columns.Add("Username");
                    dt.Columns.Add("PizzaID");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("OrderDateTime");
                    dt.Columns.Add("DeliveryTime");
                    for (int i = 0; i < manager.GetOrders().Count; i++)
                    {
                        row = dt.NewRow();
                        row["OrderID"] = manager.GetOrders()[i].Id;
                        row["Username"] = manager.GetOrders()[i].Username;
                        row["PizzaID"] = manager.GetOrders()[i].PizzaId;
                        row["Quantity"] = manager.GetOrders()[i].Quantity;
                        row["OrderDateTime"] = manager.GetOrders()[i].Time;
                        row["DeliveryTime"] = manager.GetOrders()[i].DeliveryTime;
                        dt.Rows.Add(row);

                    }
                    grid.DataSource = dt;
                    grid.DataBind();
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        protected void Delivered_Click(object sender, EventArgs e)
        {

        }

        protected void AddPizza_Click(object sender, EventArgs e)
        {
            pizzaManager.InsertPizza(new Pizza(pizzaName.Text, Convert.ToDecimal(pizzaPrice.Text)));
        }

        protected void DeletePizza_Click(object sender, EventArgs e)
        {
            pizzaManager.DeletePizza(delPizza.Text);
        }
    }
}