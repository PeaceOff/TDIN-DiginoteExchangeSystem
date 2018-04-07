﻿using Server.DiginoteExchangeSystem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerDB
    {

        #region Connection

        public static string connectionString = "Data Source = .\\SQLEXPRESS;Initial Catalog = TDIN1; Integrated Security = True; MultipleActiveResultSets=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        #endregion

        #region Quote

        public static bool InitQuote(double quote)
        {
            using (SqlConnection connection = GetConnection())
            {
                string commandString = "SELECT COUNT(*) FROM \"System\";";

                using (var command = new SqlCommand(commandString, connection))
                {
                    if ((int)command.ExecuteScalar() > 0)
                    {
                        return false;
                    }
                }

                commandString = string.Format("INSERT INTO \"System\"(quote, lock) VALUES({0}, 'X');", quote);

                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            return true;
        }

        public static double GetQuote()
        {
            using (SqlConnection connection = GetConnection())
            {

                string commandString = "SELECT quote FROM \"System\";";

                using (var command = new SqlCommand(commandString, connection))
                {
                    return (double)command.ExecuteScalar();
                }
            }
        }

        public static void UpdateQuote(double quote)
        {
            using (SqlConnection connection = GetConnection())
            {

                string commandString = "UPDATE \"System\" SET quote = @quote WHERE lock='X';";

                using (var command = new SqlCommand(commandString, connection))
                {
                    command.Parameters.AddWithValue("@quote", quote);
                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region User

        public static string Register(string username, string nickname, string password)
        {
            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT Count(*) FROM \"User\" WHERE username = '{0}' OR nickname = '{1}';", username, nickname);
                using (var command = new SqlCommand(commandString, connection))
                {
                    if ((int)command.ExecuteScalar() > 0)
                    {
                        return "Username already exists";
                    }
                }

                commandString = string.Format("INSERT INTO \"User\" (username, nickname, password) VALUES ('{0}', '{1}' , '{2}')", username, nickname, password);
                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }

                commandString = string.Format("SELECT id FROM \"User\" WHERE username = '{0}' AND password = '{1}'", username, password);
                int id = 0;
                using (var command = new SqlCommand(commandString, connection))
                {
                    id = (int)command.ExecuteScalar();
                }

                for (int i = 0; i < 50; i++)
                {
                    commandString = string.Format("INSERT INTO Diginote (user_id) VALUES ('{0}')", id);
                    using (var command = new SqlCommand(commandString, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            return "Successfully registered";
        }

        public static string Login(string username, string password)
        {
            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT nickname FROM \"User\" WHERE username = '{0}' AND password = '{1}'", username, password);
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            return reader["nickname"].ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static bool UsernameExists(string username)
        {
            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT COUNT(*) FROM \"User\" WHERE username = '{0}'", username);
                using (var command = new SqlCommand(commandString, connection))
                {
                    if ((int)command.ExecuteScalar() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static int GetUserId(string username)
        {
            if(!UsernameExists(username))
            {
                return 0;
            }

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT id FROM \"User\" WHERE username = '{0}'", username);
                using (var command = new SqlCommand(commandString, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        #endregion

        #region Order

        public static List<PurchaseOrder> GetPurchaseOrders(string username)
        {
            List<PurchaseOrder> orders = new List<PurchaseOrder>();

            int id = GetUserId(username);
            if(id == 0)
            {
                return orders;
            }

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT quantity, timestamp, suspension FROM PurchaseOrder WHERE user_id = '{0}'", id);
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PurchaseOrder purchaseOrder = new PurchaseOrder();

                            int quantity = int.Parse(reader["quantity"].ToString());
                            string timestampS = reader["timestamp"].ToString();
                            string suspensionS = reader["suspension"].ToString();

                            orders.Add(purchaseOrder);
                        }
                    }
                }
            }

            return orders;
        }

        public static List<SellOrder> GetSellingOrders(string username)
        {
            List<SellOrder> orders = new List<SellOrder>();

            int id = GetUserId(username);
            if (id == 0)
            {
                return orders;
            }

            return orders;
        }

        public static void InsertPurchaseOrder(string username, int quantity)
        {
            int id = GetUserId(username);
            if (id == 0)
            {
                return;
            }

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("INSERT INTO \"BuyOrder\" (user_id, quantity, timestamp, suspension) VALUES ('{0}', '{1}' , '{2}')", id, quantity, DateTime.Now);
                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InsertSellingOrder(string username, int quantity)
        {

        }

        #endregion

    }
}