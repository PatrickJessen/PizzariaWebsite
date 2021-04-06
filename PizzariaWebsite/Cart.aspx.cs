using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzariaWebsite
{
    public partial class Cart : System.Web.UI.Page
    {
        PizzaManager manager = new PizzaManager();
        decimal total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = new DataTable();
                DataRow row;
                dt.Columns.Add("Name");
                dt.Columns.Add("Price");
                for (int i = 0; i < SessionManager.GetList().Count; i++)
                {
                    row = dt.NewRow();
                    row["Name"] = manager.GetPizza(SessionManager.GetList()[i]).Name;
                    row["Price"] = manager.GetPizza(SessionManager.GetList()[i]).Price;
                    dt.Rows.Add(row);
                    total += manager.GetPizza(SessionManager.GetList()[i]).Price;
                }
                grid.DataSource = dt;
                grid.DataBind();
                totalPrice.Text = $"Total: {total}";
            }
        }

        protected void grid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void chkBtn_Click(object sender, EventArgs e)
        {

        }

        protected void delBtn_Click(object sender, EventArgs e)
        {
            int index = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;
            SessionManager.RemoveSessionId(index);
        }
    }
}