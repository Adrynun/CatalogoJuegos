using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CatalogoJuegos
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            // Validaciones básicas
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error de Creación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("La contraseña no puede estar vacía.", "Error de Creación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de Creación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    // Verificar si el usuario ya existe
                    string checkQuery = "SELECT COUNT(*) FROM usuarios WHERE username = @username";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", usuario);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("El nombre de usuario ya existe. Intente con otro.", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    // Insertar el nuevo usuario
                    string insertQuery = "INSERT INTO usuarios (username, password) VALUES (@username, @password)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@username", usuario);
                        insertCmd.Parameters.AddWithValue("@password", pass); // Contraseña en texto plano

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcomeForm = new Welcome();
            welcomeForm.Show();
        }
    }
}
