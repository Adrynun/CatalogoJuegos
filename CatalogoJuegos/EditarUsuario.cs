using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CatalogoJuegos
{
    public partial class EditarUsuario : Form
    {
        private int usuarioId;
        private bool esNuevoUsuario;

        public EditarUsuario(int id = -1)
        {
            InitializeComponent();
            usuarioId = id;
            esNuevoUsuario = (id == -1);
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            // Título del formulario: siempre es "Editar Usuario"
            this.Text = "Editar Usuario";

            // Si hay un ID de usuario válido, cargamos sus datos
            if (usuarioId != -1)
            {
                CargarDatosUsuario(usuarioId);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un usuario válido para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cerramos la ventana si el ID no es válido
            }
        }


        private void CargarDatosUsuario(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT username, email, rol, baneado FROM usuarios WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUsername.Text = reader["username"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                // Si el rol está vacío, asignamos un valor predeterminado (por ejemplo, "Usuario")
                                string rol = reader["rol"].ToString();
                                if (!string.IsNullOrEmpty(rol))
                                {
                                    cboRol.SelectedItem = rol; // Asignar el valor del rol al ComboBox
                                }
                                else
                                {
                                    cboRol.SelectedIndex = -1; // Desmarcar si no se encuentra un valor
                                }

                                chkBaneado.Checked = Convert.ToBoolean(reader["baneado"]);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el usuario con ese ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string rol = cboRol.SelectedItem?.ToString() ?? "";
            bool baneado = chkBaneado.Checked;
            string nuevaContrasena = txtNuevaContrasena.Text.Trim();
            string confirmarContrasena = txtConfirmarContrasena.Text.Trim();

            // Validación de campos obligatorios
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, complete los campos de nombre de usuario y rol.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de contraseñas
            if (!string.IsNullOrEmpty(nuevaContrasena) || !string.IsNullOrEmpty(confirmarContrasena))
            {
                if (nuevaContrasena != confirmarContrasena)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query;

                    // Si es un nuevo usuario, insertamos; si es un usuario existente, actualizamos
                    if (esNuevoUsuario)
                    {
                        query = "INSERT INTO usuarios (username, email, rol, baneado, password) VALUES (@username, @email, @rol, @baneado, @password)";
                    }
                    else
                    {
                        query = "UPDATE usuarios SET username = @username, email = @email, rol = @rol, baneado = @baneado";

                        if (!string.IsNullOrEmpty(nuevaContrasena))
                        {
                            query += ", password = @password";
                        }

                        query += " WHERE id = @id";
                    }

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@baneado", baneado);

                        if (esNuevoUsuario || !string.IsNullOrEmpty(nuevaContrasena))
                        {
                            cmd.Parameters.AddWithValue("@password", nuevaContrasena);
                        }

                        if (!esNuevoUsuario)
                        {
                            cmd.Parameters.AddWithValue("@id", usuarioId);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(esNuevoUsuario ? "Usuario creado correctamente." : "Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
