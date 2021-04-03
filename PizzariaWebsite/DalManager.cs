using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PizzariaWebsite
{
    public class DalManager
    {
        string conString = "Data Source=172.16.7.3,49686;Initial Catalog=PizzaDB;User ID=sa;Password=Kode1234!";
        public List<Pizza> GetPizzaData(int id)
        {
            List<Pizza> pizzaList = new List<Pizza>();
            string query = $"SELECT PizzaID, Name, Price FROM Pizza WHERE PizzaID = {id}";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                pizzaList.Add(new Pizza(int.Parse(dt.Rows[0]["pizzaId"].ToString()), dt.Rows[0]["pizzaName"].ToString(), (decimal)dt.Rows[0]["pizzaPrice"]));
                return pizzaList;
            }
        }
    }
}