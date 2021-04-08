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
        public List<Pizza> GetPizzaData()
        {
            List<Pizza> pizzaList = new List<Pizza>();
            string query = $"SELECT PizzaID, Name, Price FROM Pizza";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    pizzaList.Add(new Pizza(int.Parse(dt.Rows[i]["PizzaID"].ToString()), dt.Rows[i]["Name"].ToString(), decimal.Parse(dt.Rows[i]["Price"].ToString())));
                }
                return pizzaList;
            }
        }

        public Order AddOrder(Order order)
        {
            string query = "INSERT INTO Orders (OrderID, Username, Product, Price, OrderTime) VALUES (@Id, @Username, @Product, @Price, @Time)";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", order.Id);
                cmd.Parameters.AddWithValue("@Username", order.Username);
                cmd.Parameters.AddWithValue("@Product", order.Product);
                cmd.Parameters.AddWithValue("@Price", order.Price);
                cmd.Parameters.AddWithValue("@Time", order.Time);
                cmd.ExecuteNonQuery();
            }
            return order;
        }

        public string GetPizzaName(int id)
        {
            string query = $"SELECT Name FROM Pizza WHERE PizzaID = {id + 1}";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                return dt.Rows[0]["Name"].ToString();
            }
        }

        public decimal GetPizzaPrice(int id)
        {
            string query = $"SELECT Price FROM Pizza WHERE PizzaID = {id + 1}";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                return decimal.Parse(dt.Rows[0]["Price"].ToString());
            }
        }

        public string IsUsernameValid(string username)
        {
            try
            {
                string query = $"SELECT * FROM login WHERE Username = '{username}'";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    return dtbl.Rows[0]["username"].ToString();
                }
            }
            catch
            {
                return "";
            }
        }

        public string IsPasswordValid(string password)
        {
            try
            {
                string query = $"SELECT * FROM login WHERE Password = '{password}'";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    return dtbl.Rows[0]["password"].ToString();
                }
            }
            catch
            {
                return "";
            }
        }
    }
}