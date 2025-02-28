using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CatalogoJuegos
{
    public partial class EditarUsuario : Form
    {
        /// <summary>
        /// ID del usuario a editar. -1 indica un nuevo usuario.
        /// </summary>
        private int usuarioId;

        /// <summary>
        /// Indica si se está creando un nuevo usuario.
        /// </summary>
        private bool esNuevoUsuario;

        /// <summary>
        /// Constructor de la clase EditarUsuario.
        /// </summary>
        /// <param name="id">ID del usuario a editar. -1 para un nuevo usuario.</param>
        public EditarUsuario(int id = -1)
        {
            InitializeComponent();
            usuarioId = id;
            esNuevoUsuario = (id == -1);
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga los datos del usuario si es una edición, o inicializa para un nuevo usuario.
        /// </summary>
        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            this.Text = "Editar Usuario"; // Título del formulario

            if (usuarioId != -1)
            {
                CargarDatosUsuario(usuarioId);
            }
            else
            {
                //Si es un nuevo usuario, no se cargan datos.
            }
        }

        /// <summary>
        /// Carga los datos del usuario desde la base de datos y los muestra en el formulario.
        /// </summary>
        /// <param name="id">ID del usuario a cargar.</param>
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

                                string rol = reader["rol"].ToString();
                                if (!string.IsNullOrEmpty(rol))
                                {
                                    cboRol.SelectedItem = rol;
                                }
                                else
                                {
                                    cboRol.SelectedIndex = -1;
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

        /// <summary>
        /// Maneja el evento de clic del botón Guardar.
        /// Guarda los datos del usuario en la base de datos.
        /// </summary>
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

        /// <summary>
        /// Maneja el evento de clic del botón Cancelar.
        /// Cierra el formulario después de confirmar con el usuario.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}