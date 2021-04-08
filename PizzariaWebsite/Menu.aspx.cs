using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data;

namespace PizzariaWebsite
{
    public partial class Menu : System.Web.UI.Page
    {
        PizzaManager manager = new PizzaManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                DataTable dt = new DataTable();
                DataRow row;
                dt.Columns.Add("PizzaID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Price");
                for (int i = 0; i < manager.GetAllPizza().Count; i++)
                {
                    row = dt.NewRow();
                    row["PizzaID"] = manager.GetAllPizza()[i].Id;
                    row["Name"] = manager.GetAllPizza()[i].Name;
                    row["Price"] = manager.GetAllPizza()[i].Price;
                    dt.Rows.Add(row);

                }
                MenuGrid.DataSource = dt;
                MenuGrid.DataBind();
            }
            
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            List<Pizza> pizzalist;
            int pID = Convert.ToInt32(MenuGrid.Rows[((GridViewRow)((Control)sender).NamingContainer).RowIndex].Cells[0].Text);
            string pName = MenuGrid.Rows[((GridViewRow)((Control)sender).NamingContainer).RowIndex].Cells[1].Text;
            decimal pPrice = Convert.ToDecimal(MenuGrid.Rows[((GridViewRow)((Control)sender).NamingContainer).RowIndex].Cells[2].Text);
            if (Session["Cart"] == null)
            {
                pizzalist = new List<Pizza>();
            }
            else
            {
                pizzalist = (List<Pizza>)Session["Cart"];
            }
            pizzalist.Add(new Pizza(pID, pName, pPrice));
                Session["Cart"] = pizzalist;
            Debug.WriteLine(pID + pName + pPrice);
            //Session["pizzaId"] = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;
            //SessionManager.AddSession((int)Session["pizzaId"]);

            //get the clicked row
            //int row = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;

            ////create new list
            //List<string> sesList = new List<string>();

            ////adds the clicked rows content to the list
            //sesList.Add(MenuGrid.Rows[row].Cells[1].Text);

            ////assign session to our list
            //Session["cart"] = sesList;

        }
    }
}