﻿using System;
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
            string query = "INSERT INTO Orders (OrderID, Username, OrderTime, PizzaID) VALUES (@Id, @Username, @Time, @PizzaID)";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", order.Id);
                cmd.Parameters.AddWithValue("@Username", order.Username);
                cmd.Parameters.AddWithValue("@Time", order.Time);
                cmd.Parameters.AddWithValue("@PizzaID", order.PizzaId);
                cmd.ExecuteNonQuery();
            }
            return order;
        }

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

        public List<User> GetUserInfo(string username)
        {
            List<User> users = new List<User>();
            string query = $"SELECT * FROM UserInfo INNER JOIN Users ON Users.UserID = {GetUsernameID(username)}";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                users.Add(new User(dt.Rows[0]["fName"].ToString(), dt.Rows[0]["Lname"].ToString(), Convert.ToInt32(dt.Rows[0]["PhoneNr"]), dt.Rows[0]["Adress"].ToString()));

                return users;
            }
        }

        private int GetUsernameID(string username)
        {
            string query = $"SELECT UserID FROM Users WHERE Username = '{username}'";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                return (int)dt.Rows[0]["UserID"];
            }
        }
    }
}