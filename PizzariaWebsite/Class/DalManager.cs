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
        #region GetPizzaData
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
        #endregion
        #region AddOrder
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
        #endregion
        #region IsLoginValid
        public bool IsLoginValid(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count != 0)
                {
                    return true;
                }

                return false;
            }
        }
        #endregion
        #region InsertUserInfo
        public User InsertUserInfo(User user)
        {
            string query = "INSERT INTO UserInfo (UserID, Fname, Lname, PhoneNr, Adress) VALUES (@UserID, @Fname, @Lname, @PhoneNr, @Adress)";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", user.Id);
                cmd.Parameters.AddWithValue("@Fname", user.FirstName);
                cmd.Parameters.AddWithValue("@Lname", user.LastName);
                cmd.Parameters.AddWithValue("@PhoneNr", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@Adress", user.Adress);
                cmd.ExecuteNonQuery();
            }
            return user;
        }
        #endregion
        #region RegisterUser
        public User RegisterUser(User user)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", GetUserID(user));
                cmd.Parameters.AddWithValue("@Fname", user.Password);
                cmd.ExecuteNonQuery();
            }
            return user;
        }
        #endregion
        #region GetUserID
        private int GetUserID(User user)
        {
            string query = $"SELECT UserID FROM Users WHERE Username = '{RegisterUser(user).Username}'";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                return (int)dt.Rows[0]["id"];
            }
        }
        #endregion
        #region IsUsernameTaken
        public bool IsUsernameTaken(string username)
        {
            string query = $"SELECT Username FROM Users WHERE Username = '{username}'";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (username == dt.Rows[i]["Username"].ToString())
                    {
                        return true;
                    }
                }

                return false;
            }
        }
        #endregion
    }
}