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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[SessionManager.GetAllPizzaId("PizzaId")] != null)
            {
                DataTable dt = new DataTable();
                DataRow row;
                dt.Columns.Add("Name");
                foreach (string key in Session.Keys)
                {
                    row = dt.NewRow();
                    //row["Name"] = manager.GetPizzaName((int)Session[key]);
                    dt.Rows.Add(row);
                }
                grid.DataSource = dt;
                grid.DataBind();
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
    }
}