using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class Welcome : Form
    {
        private const string LOGIN_QUERY = "SELECT id, rol, baneado FROM usuarios WHERE username = @username AND password = @password";

        public Welcome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic del botón de inicio de sesión.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            // Validar credenciales
            if (!ValidarCredenciales(username, password))
            {
                return;
            }

            try
            {
                // Obtener información del usuario
                int idUsuario;
                string rolUsuario;
                if (ObtenerInformacionUsuario(username, password, out idUsuario, out rolUsuario))
                {
                    // Establecer el estado global
                    GlobalState.Instance.RolUsuario = rolUsuario;
                    GlobalState.Instance.IdUsuario = idUsuario;

                    // Mostrar mensaje de bienvenida
                    MessageBox.Show("Login exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el formulario Home
                    Home home = new Home(username, rolUsuario);
                    home.Show();
                    Hide();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida que los campos de usuario y contraseña no estén vacíos.
        /// </summary>
        private bool ValidarCredenciales(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe introducir un usuario y una contraseña.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtiene la información del usuario desde la base de datos.
        /// </summary>
        private bool ObtenerInformacionUsuario(string username, string password, out int idUsuario, out string rolUsuario)
        {
            idUsuario = 0;
            rolUsuario = null;

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(LOGIN_QUERY, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (Convert.ToBoolean(reader["baneado"]))
                            {
                                MessageBox.Show("Este usuario está baneado y no puede acceder.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            idUsuario = reader.GetInt32(0);
                            rolUsuario = reader.GetString("rol");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Borra el contenido de los campos de usuario y contraseña.
        /// </summary>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        /// <summary>
        /// Cierra la aplicación.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Abre el formulario de creación de usuario.
        /// </summary>
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario ventanaCrearUsuario = new CrearUsuario();
            ventanaCrearUsuario.Show();
            Hide();
        }
    }
}