using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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

                SetOrdersSuspension(true);
            }

            Task t = Task.Run
                    (
                        ()
                         =>
                        {
                            Thread.Sleep(1 * 60 * 1000);
                            SetOrdersSuspension(false);
                        }
                    );
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

                commandString = string.Format("SELECT nickname, username FROM \"User\" WHERE username = '{0}' AND password = '{1}'", username, password);
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            return reader["username"].ToString();
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

        public static string GetUsername(int userId)
        {
            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT username FROM \"User\" WHERE id = '{0}'", userId);
                using (var command = new SqlCommand(commandString, connection))
                {
                    return command.ExecuteScalar().ToString();
                }
            }
        }

        #endregion

        #region Order

        public static void DeletePurchaseOrder(PurchaseOrder order)
        {
            int id = order.id;

            using (SqlConnection connection = GetConnection())
            {
                string commandString = string.Format("DELETE FROM \"BuyOrder\" WHERE id = {0}", id);
                using (var innerCommand = new SqlCommand(commandString, connection))
                {
                    innerCommand.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteSellingOrder(SellOrder order)
        {
            int id = order.id;

            using (SqlConnection connection = GetConnection())
            {
                string commandString = string.Format("DELETE FROM \"SellOrder\" WHERE id = {0}", id);
                using (var innerCommand = new SqlCommand(commandString, connection))
                {
                    innerCommand.ExecuteNonQuery();
                }
            }
        }

        public static void SetOrdersSuspension(bool suspend)
        {
            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                // Buy Order
                if (suspend)
                {
                    commandString = String.Format("UPDATE \"BuyOrder\" SET Suspension = '{0}'", DateTime.Now);
                }
                else
                {
                    commandString = String.Format("UPDATE \"BuyOrder\" SET Suspension = null");
                }

                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Sell Order
                if (suspend)
                {
                    commandString = String.Format("UPDATE \"SellOrder\" SET Suspension = '{0}'", DateTime.Now);
                }
                else
                {
                    commandString = String.Format("UPDATE \"SellOrder\" SET Suspension = null");
                }

                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UnsuspendOrders(string username)
        {
            int id = GetUserId(username);
            if (id == 0)
            {
                return;
            }

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                // Buy Order
                commandString = String.Format("UPDATE \"BuyOrder\" SET Suspension = null WHERE user_id = {0}");

                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Sell Order
                commandString = String.Format("UPDATE \"SellOrder\" SET Suspension = null WHERE user_id = {0}");

                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

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

                commandString = string.Format("SELECT id, quantity, timestamp, suspension FROM \"BuyOrder\" WHERE user_id = '{0}'", id);
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = int.Parse(reader["id"].ToString());
                            int quantity = int.Parse(reader["quantity"].ToString());
                            DateTime timestamp = Convert.ToDateTime(reader["timestamp"].ToString());
                            DateTime suspension = new DateTime();
                            try
                            {
                                suspension = Convert.ToDateTime(reader["suspension"].ToString());
                            }
                            catch(Exception e)
                            {

                            }

                            PurchaseOrder purchaseOrder = new PurchaseOrder(orderId, quantity, timestamp, suspension);

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

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT id, quantity, timestamp, suspension FROM \"SellOrder\" WHERE user_id = '{0}'", id);
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = int.Parse(reader["id"].ToString());
                            int quantity = int.Parse(reader["quantity"].ToString());
                            DateTime timestamp = Convert.ToDateTime(reader["timestamp"].ToString());
                            DateTime suspension = new DateTime();
                            try
                            {
                                suspension = Convert.ToDateTime(reader["suspension"].ToString());
                            }
                            catch(Exception e)
                            {

                            }

                            SellOrder sellOrder = new SellOrder(orderId, quantity, timestamp, suspension);

                            orders.Add(sellOrder);
                        }
                    }
                }
            }

            return orders;
        }

        public static List<int> InsertPurchaseOrder(string username, int quantity)
        {
            List<int> serialNumbers = new List<int>();

            if(quantity < 1)
            {
                return serialNumbers;
            }

            int id = GetUserId(username);
            if (id == 0)
            {
                return serialNumbers;
            }

            double quote = GetQuote();

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT id, user_id, quantity FROM \"SellOrder\" WHERE suspension IS NULL ORDER BY timestamp ASC");
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int sellId = int.Parse(reader["id"].ToString());
                            int sellUserId = int.Parse(reader["user_id"].ToString());
                            int sellQuantity = int.Parse(reader["quantity"].ToString());

                            int transactionQuantity = sellQuantity < quantity ? sellQuantity : quantity;

                            // Create Transaction
                            commandString = string.Format("INSERT INTO \"Transaction\" (old_user_id, new_user_id, quantity, timestamp, quote) VALUES ('{0}', '{1}', '{2}', '{3}','{4}')", sellUserId, id, transactionQuantity, DateTime.Now, quote);
                            using (var innerCommand = new SqlCommand(commandString, connection))
                            {
                                innerCommand.ExecuteNonQuery();
                            }

                            // Change Diginote Owner
                            for (int i = 0; i < transactionQuantity; i++)
                            {
                                int diginoteId = 0;

                                commandString = string.Format("SELECT TOP 1 serial_number FROM \"Diginote\" WHERE user_id = {0}", sellUserId);
                                using (var innerCommand = new SqlCommand(commandString, connection))
                                {
                                    diginoteId =  (int)innerCommand.ExecuteScalar();
                                }

                                commandString = string.Format("UPDATE \"Diginote\" SET user_id = {0} WHERE serial_number = {1}", id, diginoteId);
                                using (var innerCommand = new SqlCommand(commandString, connection))
                                {
                                    innerCommand.ExecuteNonQuery();
                                }

                                serialNumbers.Add(diginoteId);
                            }

                            if (sellQuantity > quantity)
                            {
                                // Update Sell Order
                                int newSellQuantity = sellQuantity - quantity;
                                commandString = string.Format("UPDATE \"SellOrder\" SET quantity = {0} WHERE id = {1}", newSellQuantity, sellId);
                                using (var innerCommand = new SqlCommand(commandString, connection))
                                {
                                    innerCommand.ExecuteNonQuery();
                                }

                                return serialNumbers;
                            }

                            // Delete Sell Order
                            commandString = string.Format("DELETE FROM \"SellOrder\" WHERE id = {0}", sellId);
                            using (var innerCommand = new SqlCommand(commandString, connection))
                            {
                                innerCommand.ExecuteNonQuery();
                            }

                            if(sellQuantity == quantity)
                            {
                                return serialNumbers;
                            }
                            
                            quantity -= sellQuantity;
                        }
                    }
                }

                commandString = string.Format("INSERT INTO \"BuyOrder\" (user_id, quantity, timestamp) VALUES ('{0}', '{1}' , '{2}')", id, quantity, DateTime.Now);
                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            return serialNumbers;
        }

        public static List<int> InsertSellingOrder(string username, int quantity)
        {
            List<int> serialNumbers = new List<int>();

            if (quantity < 1)
            {
                return serialNumbers;
            }

            int id = GetUserId(username);
            if (id == 0)
            {
                return serialNumbers;
            }

            if (!HasEnoughDiginotes(username, quantity))
            {
                return serialNumbers;
            }

            double quote = GetQuote();

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT id, user_id, quantity FROM \"BuyOrder\" WHERE suspension IS NULL ORDER BY timestamp ASC");
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int buyId = int.Parse(reader["id"].ToString());
                            int buyUserId = int.Parse(reader["user_id"].ToString());
                            int buyQuantity = int.Parse(reader["quantity"].ToString());

                            int transactionQuantity = buyQuantity < quantity ? buyQuantity : quantity;

                            // Create Transaction
                            commandString = string.Format("INSERT INTO \"Transaction\" (old_user_id, new_user_id, quantity, timestamp, quote) VALUES ('{0}', '{1}', '{2}', '{3}','{4}')", id, buyUserId, transactionQuantity, DateTime.Now, quote);
                            using (var innerCommand = new SqlCommand(commandString, connection))
                            {
                                innerCommand.ExecuteNonQuery();
                            }

                            // Change Diginote Owner
                            for (int i = 0; i < transactionQuantity; i++)
                            {
                                int diginoteId = 0;

                                commandString = string.Format("SELECT TOP 1 serial_number FROM \"Diginote\" WHERE user_id = {0}", id);
                                using (var innerCommand = new SqlCommand(commandString, connection))
                                {
                                    diginoteId = (int)innerCommand.ExecuteScalar();
                                }

                                commandString = string.Format("UPDATE \"Diginote\" SET user_id = {0} WHERE serial_number = {1}", buyUserId, diginoteId);
                                using (var innerCommand = new SqlCommand(commandString, connection))
                                {
                                    innerCommand.ExecuteNonQuery();
                                }

                                serialNumbers.Add(diginoteId);
                            }

                            if (buyQuantity > quantity)
                            {
                                // Update Buy Order
                                int newBuyQuantity = buyQuantity - quantity;
                                commandString = string.Format("UPDATE \"BuyOrder\" SET quantity = {0} WHERE id = {1}", newBuyQuantity, buyId);
                                using (var innerCommand = new SqlCommand(commandString, connection))
                                {
                                    innerCommand.ExecuteNonQuery();
                                }

                                return serialNumbers;
                            }

                            // Delete Buy Order
                            commandString = string.Format("DELETE FROM \"BuyOrder\" WHERE id = {0}", buyId);
                            using (var innerCommand = new SqlCommand(commandString, connection))
                            {
                                innerCommand.ExecuteNonQuery();
                            }

                            if (buyQuantity == quantity)
                            {
                                return serialNumbers;
                            }

                            quantity -= buyQuantity;
                        }
                    }
                }

                commandString = string.Format("INSERT INTO \"SellOrder\" (user_id, quantity, timestamp) VALUES ('{0}', '{1}' , '{2}')", id, quantity, DateTime.Now);
                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            return serialNumbers;
        }

        public static bool HasEnoughDiginotes(string username, int quantity)
        {
            if (quantity < 1)
            {
                return true;
            }

            int id = GetUserId(username);
            if (id == 0)
            {
                return true;
            }

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT COUNT(*) FROM \"Diginote\" WHERE user_id = '{0}'", id);
                using (var command = new SqlCommand(commandString, connection))
                {
                    if ((int)command.ExecuteScalar() >= quantity)
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

        #endregion

        #region Diginote

        public static List<Diginote> GetDiginotes(string username)
        {
            List<Diginote> diginotes = new List<Diginote>();

            int id = GetUserId(username);
            if (id == 0)
            {
                return diginotes;
            }

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT serial_number FROM \"Diginote\" WHERE user_id = '{0}'", id);
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int serial_number = int.Parse(reader["serial_number"].ToString());

                            Diginote diginote = new Diginote(serial_number);

                            diginotes.Add(diginote);
                        }
                    }
                }
            }

            return diginotes;
        }

        #endregion

        #region Transactions

        public static List<Transaction> GetTransactions(string username)
        {
            List<Transaction> transactions = new List<Transaction>();

            int id = GetUserId(username);
            if (id == 0)
            {
                return transactions;
            }

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT old_user_id, new_user_id, quantity, timestamp, quote FROM \"Transaction\" WHERE old_user_id = '{0}' OR new_user_id = '{0}'", id);
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int old_user_id = int.Parse(reader["old_user_id"].ToString());
                            int new_user_id = int.Parse(reader["new_user_id"].ToString());
                            int quantity = int.Parse(reader["quantity"].ToString());
                            DateTime timestamp = Convert.ToDateTime(reader["timestamp"].ToString());
                            double quote = double.Parse(reader["quote"].ToString());

                            string old_user_username = GetUsername(old_user_id);
                            string new_user_username = GetUsername(new_user_id);

                            Transaction transaction = new Transaction(old_user_username, new_user_username, quantity, timestamp, quote);

                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public static List<Transaction> GetTransactions(int rows)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT old_user_id, new_user_id, quantity, timestamp, quote FROM \"Transaction\" ORDER BY timestamp DESC OFFSET 0 ROWS FETCH NEXT {0} ROWS ONLY", rows);
                using (var command = new SqlCommand(commandString, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int old_user_id = int.Parse(reader["old_user_id"].ToString());
                            int new_user_id = int.Parse(reader["new_user_id"].ToString());
                            int quantity = int.Parse(reader["quantity"].ToString());
                            DateTime timestamp = Convert.ToDateTime(reader["timestamp"].ToString());
                            double quote = double.Parse(reader["quote"].ToString());

                            string old_user_username = GetUsername(old_user_id);
                            string new_user_username = GetUsername(new_user_id);

                            Transaction transaction = new Transaction(old_user_username, new_user_username, quantity, timestamp, quote);

                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public static double GetTransactionalBalance(string username)
        {
            int id = GetUserId(username);
            if (id == 0)
            {
                return 0;
            }

            double balance = 0;

            List<Transaction> transactions = GetTransactions(username);
            
            foreach(Transaction t in transactions)
            {
                double value = t.quantity * t.quote;

                if (t.newOwner == username)
                {
                    balance -= value;
                }
                else if(t.oldOwner == username)
                {
                    balance += value;
                }
            }

            return balance;
        }

        #endregion

    }
}