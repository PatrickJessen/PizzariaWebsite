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

            if (Session["Username"] != null)
            {
                LoginPage.InnerText = "Logout";
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

            CalculateQuantity(pizzalist, pID, pName, pPrice);
            
        }

        private void CalculateQuantity(List<Pizza> pizzalist, int pID, string pName, decimal pPrice)
        {
            //check if pizzalist is empty if it is we add a pizza to it, otherwise we cant loop through the list
            if (pizzalist.Count == 0)
            {
                pizzalist.Add(new Pizza(pID, pName, pPrice, 1, pPrice));
                Session["Cart"] = pizzalist;
            }
            else
            {
                manager.CalculateQuantity(pizzalist, pID, pPrice, pName);
                //for (int i = 0; i < pizzalist.Count; i++)
                //{
                //    //check if we already have the same pizza in the list
                //    if (pizzalist[i].Id == pID)
                //    {
                //        //add to quantity if theres added the same pizza multiple times
                //        pizzalist[i].Quantity++;
                //        //calculates the price
                //        pizzalist[i].Price += pPrice;
                //        //break the loop cause we only need to do this once
                //        break;
                //    }
                //    //check if we're at the end of the loop
                //    else if (i == pizzalist.Count - 1)
                //    {
                //        //add new pizza to the list if theres none already matching
                //        pizzalist.Add(new Pizza(pID, pName, pPrice, 1, pPrice));
                //        //break the loop otherwise it adds +1 to quantity
                //        break;
                //    }
                //}
            }
        }
    }
}