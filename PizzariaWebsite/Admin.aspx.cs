using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzariaWebsite
{
    public partial class Admin : System.Web.UI.Page
    {
        OrderManager manager = new OrderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
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
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}