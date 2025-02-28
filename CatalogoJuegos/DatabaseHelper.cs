using MySql.Data.MySqlClient;
using System;
using System.Data; // Agregar esta línea para usar ConnectionState

namespace CatalogoJuegos
{
    public static class DatabaseHelper
    {
        // Cadena de conexión (debería moverse a un archivo de configuración)
        private static string connectionString = "Server=localhost;Database=blizzard_users;Uid=root;Pwd=1234;";

        /// <summary>
        /// Obtiene una nueva conexión a la base de datos.
        /// </summary>
        /// <returns>Una nueva instancia de MySqlConnection o null si ocurre un error.</returns>
        public static MySqlConnection GetConnection()
        {
            try
            {
                return new MySqlConnection(connectionString);
            }
            catch (MySqlException ex)
            {
                // Manejar la excepción (por ejemplo, registrarla o mostrar un mensaje de error)
                Console.WriteLine($"Error al obtener la conexión: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Abre una conexión a la base de datos si no está abierta.
        /// </summary>
        /// <param name="connection">La conexión a abrir.</param>
        public static void OpenConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Cierra una conexión a la base de datos si está abierta.
        /// </summary>
        /// <param name="connection">La conexión a cerrar.</param>
        public static void CloseConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}