using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            // Validaciones básicas
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Debe introducir un usuario y una contraseña.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Consulta para obtener el rol y el estado de baneo del usuario
                    string query = "SELECT rol, baneado FROM usuarios WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", usuario);
                        cmd.Parameters.AddWithValue("@password", pass);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool baneado = Convert.ToBoolean(reader["baneado"]);
                                if (baneado)
                                {
                                    MessageBox.Show("Este usuario está baneado y no puede acceder.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                string rolUsuario = reader["rol"].ToString(); // Obtener el rol del usuario

                                MessageBox.Show("Login exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Pasamos el usuario y el rol al formulario Home
                                Home home = new Home(usuario, rolUsuario);
                                home.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario ventanaCrearUsuario = new CrearUsuario();
            ventanaCrearUsuario.Show();
            this.Hide();
        }
    }
}
