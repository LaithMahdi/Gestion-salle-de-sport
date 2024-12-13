using MySql.Data.MySqlClient;
using System;

namespace gym_app
{
    public static class DatabaseConnection
    {
        private static MySqlConnection connection;

        public static void OpenConnection()
        {
            if (connection == null)
            {
                string connectionString = DatabaseConfig.ConnectionString;
                connection = new MySqlConnection(connectionString);
            }

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static MySqlCommand CreateCommand(string query)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                throw new InvalidOperationException("Connection is not open.");
            }

            return new MySqlCommand(query, connection);
        }

        public static MySqlConnection GetConnection()
        {
            return connection;
        }


        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
