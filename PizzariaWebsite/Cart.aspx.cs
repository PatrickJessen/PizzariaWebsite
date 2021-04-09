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
        List<Pizza> pizzalist;
        decimal total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["Cart"] == null)
                {
                    //sets the visibility to our checkout button and totalprice label to false if theres nothing in our cart
                    //shit way to do it beacause it can probably be manipulated in inspect on the site
                    chkBtn.Visible = false;
                    totalPrice.Visible = false;
                }
                else
                {
                    pizzalist = (List<Pizza>)Session["Cart"];
                    //create a datatable and datarow which we fill out with the stuff we got in our pizzalist
                    DataTable dt = new DataTable();
                    DataRow row;
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Price");
                    for (int i = 0; i < pizzalist.Count; i++)
                    {
                        row = dt.NewRow();
                        row["Name"] = pizzalist[i].Name;
                        row["Price"] = pizzalist[i].Price;
                        dt.Rows.Add(row);
                        total += pizzalist[i].Price;
                    }
                    grid.DataSource = dt;
                    grid.DataBind();
                    totalPrice.Text = $"Total Price: {total}";
                }
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
            if (Session["Username"] == null)
            {
                //if our username session is null, it means the user is not logged in, so we redirect them to login page before they can checkout
                Response.Redirect("Login.aspx");
            }
            else
            {
                //the user is logged in then we redirect the to checkout page
                Response.Redirect("Checkout.aspx");
            }
        }

        protected void delBtn_Click(object sender, EventArgs e)
        {
            pizzalist = (List<Pizza>)Session["Cart"];

            //Get name of clicked pizza
            string pName = grid.Rows[((GridViewRow)((Control)sender).NamingContainer).RowIndex].Cells[0].Text;

            //loop through our pizzalist sessions
            for (int i = 0; i < pizzalist.Count; i++)
            {
                if (pName == pizzalist[i].Name)
                {
                    //if the name of the clicked pizza is the same as in our pizzalist then remove it from the list
                    pizzalist.RemoveAt(i);

                    //check if our pizzalist is empty
                    if (pizzalist.Count == 0)
                    {
                        //if its empty set our session cart to 0 to so our checkout button and total price labels gets invisible again
                        Session["Cart"] = null;
                    }
                    //Updates our page so we can see the change instantly
                    Response.Redirect("Cart.aspx");
                }
            }
        }
    }
}