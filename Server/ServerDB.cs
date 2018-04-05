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

        public static string connectionString = "Data Source = .\\SQLEXPRESS;Initial Catalog = TDIN1; Integrated Security = True; MultipleActiveResultSets=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        // CONFIG
        public static double GetQuote() {

            using (SqlConnection connection = GetConnection()) {

                string commandString = "SELECT quote FROM \"System\";";

                using (var command = new SqlCommand(commandString, connection)) {
                    return (double)command.ExecuteScalar();
                }
            }
        }

        public static bool InitQuote(double quote) {

            using (SqlConnection connection = GetConnection()) {

                string commandString = "SELECT COUNT(*) FROM \"System\";";

                using (var command = new SqlCommand(commandString, connection)) {
                    if ((int)command.ExecuteScalar() > 0) {
                        return false;
                    }
                }

                commandString = string.Format("INSERT INTO \"System\"(quote, lock) VALUES({0}, 'X');", quote);

                using (var c = new SqlCommand(commandString, connection))
                {
                    c.ExecuteNonQuery();
                }
            }

            return true;
        }

        public static void UpdateQuote(double quote) {
            // TODO Testar
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

        // USER
        public static string Register(string username, string password)
        {
            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT Count(*) FROM \"User\" WHERE username = '{0}';", username);
                using (var command = new SqlCommand(commandString, connection))
                {
                    if ((int)command.ExecuteScalar() > 0)
                    {
                        return "Username already exists";
                    }
                }

                commandString = string.Format("INSERT INTO \"User\" (username, password) VALUES ('{0}', '{1}')", username, password);
                using (var command = new SqlCommand(commandString, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            return "Successfully registered";
        }

        public static bool Login(string username, string password)
        {
            using (SqlConnection connection = GetConnection())
            {
                string commandString;

                commandString = string.Format("SELECT COUNT(*) FROM \"User\" WHERE username = '{0}' AND password = '{1}'", username, password);
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

        public static bool UsernameExists(string username) {

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
    }
}