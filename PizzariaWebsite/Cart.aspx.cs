﻿using System;
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
                List<Pizza> pizzalist = (List<Pizza>)Session["Cart"];
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
                totalPrice.Text = $"Total: {total}";



                //creates list of our session
                //List<string> sesList = (List<string>)Session["cart"];

                ////loop through our sessions
                //for (int i = 0; i < sesList.Count; i++)
                //{
                //    //assign our session to our label
                //    lbltest.Text = sesList[i];

                //    //todo: istedetfor at add til existerende label, så lav et nyt label herinde for hvert id vi har i listen.

                //}


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
            //int index = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;
            //SessionManager.RemoveSessionId(index);
        }
    }
}