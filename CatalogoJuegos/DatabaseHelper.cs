using MySql.Data.MySqlClient;

namespace CatalogoJuegos
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=localhost;Database=blizzard_users;Uid=root;Pwd=1234;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static void OpenConnection(MySqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
