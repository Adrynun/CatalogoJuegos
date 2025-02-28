using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CatalogoJuegos
{
    public partial class CrearUsuario : Form
    {
        /// <summary>
        /// Constructor de la clase CrearUsuario.
        /// </summary>
        public CrearUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic del botón Guardar.
        /// Valida los campos, verifica la existencia del usuario e inserta el nuevo usuario.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            // Validar los campos
            if (!ValidarCampos(usuario, pass, confirmPass))
            {
                return;
            }

            try
            {
                // Verificar si el usuario ya existe
                if (UsuarioExiste(usuario))
                {
                    MessageBox.Show("El nombre de usuario ya existe. Intente con otro.", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Insertar el nuevo usuario
                if (InsertarUsuario(usuario, pass))
                {
                    MessageBox.Show("Usuario creado exitosamente.", "Éxito en la Creación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();

                    this.Hide();
                    Welcome welcomeForm = new Welcome();
                    welcomeForm.Show();
                }
                else
                {
                    MessageBox.Show("Error al crear el usuario. Intente nuevamente.", "Error de Creación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida que los campos de usuario, contraseña y confirmación de contraseña no estén vacíos y que las contraseñas coincidan.
        /// </summary>
        private bool ValidarCampos(string usuario, string pass, string confirmPass)
        {
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error de Creación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("La contraseña no puede estar vacía.", "Error de Creación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de Creación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Verifica si el nombre de usuario ya existe en la base de datos.
        /// </summary>
        private bool UsuarioExiste(string usuario)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM usuarios WHERE username = @username";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@username", usuario);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Inserta el nuevo usuario en la base de datos.
        /// </summary>
        private bool InsertarUsuario(string usuario, string pass)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string insertQuery = "INSERT INTO usuarios (username, password) VALUES (@username, @password)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@username", usuario);
                    insertCmd.Parameters.AddWithValue("@password", pass);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Salir.
        /// Navega al formulario Welcome.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcomeForm = new Welcome();
            welcomeForm.Show();
        }
    }
}