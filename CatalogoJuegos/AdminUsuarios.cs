using System;

using System.Data;

using System.Windows.Forms;

using MySql.Data.MySqlClient;



namespace CatalogoJuegos

{

    public partial class AdminUsuarios : Form

    {

        public AdminUsuarios()

        {

            InitializeComponent();

        }



        private void btnBuscar_Click(object sender, EventArgs e)

        {

            TextBox txtBuscar = this.Controls["txtBuscar"] as TextBox;

            string filtro = txtBuscar.Text.Trim();

            CargarUsuarios(filtro);

        }



        private void btnActualizar_Click(object sender, EventArgs e)

        {

            CargarUsuarios();

            AjustarTamañoFormulario();

        }



        private void AjustarTamañoFormulario()

        {

            int totalHeight = dgvUsuarios.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

            this.ClientSize = new Size(this.ClientSize.Width, totalHeight + dgvUsuarios.Top + 50); // 50 es un margen

        }



        private void btnAgregar_Click(object sender, EventArgs e)

        {

            EditarUsuario ventanaEditarUsuario = new EditarUsuario(-1);

            ventanaEditarUsuario.Text = "Nuevo Usuario";

            ventanaEditarUsuario.Show();

        }



        private void btnEditar_Click(object sender, EventArgs e)

        {

            DataGridView dgv = this.Controls["dgvUsuarios"] as DataGridView;

            if (dgv.SelectedRows.Count > 0)

            {

                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);

                EditarUsuario ventanaEditarUsuario = new EditarUsuario(id);

                ventanaEditarUsuario.Show();

            }

            else

            {

                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }



        private void btnEliminar_Click(object sender, EventArgs e)

        {

            DataGridView dgv = this.Controls["dgvUsuarios"] as DataGridView;

            if (dgv.SelectedRows.Count > 0)

            {

                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                if (result == DialogResult.Yes)

                {

                    EliminarUsuario(id);

                }

            }

            else

            {

                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }



        private void EliminarUsuario(int id)

        {

            try

            {

                using (MySqlConnection connection = DatabaseHelper.GetConnection())

                {

                    connection.Open();

                    string query = "DELETE FROM usuarios WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))

                    {

                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                    }

                }



                MessageBox.Show("Usuario eliminado correctamente.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuarios();

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void btnBanear_Click(object sender, EventArgs e)

        {

            DataGridView dgv = this.Controls["dgvUsuarios"] as DataGridView;

            if (dgv.SelectedRows.Count > 0)

            {

                int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);

                bool baneado = Convert.ToBoolean(dgv.SelectedRows[0].Cells["Baneado"].Value);

                bool nuevoEstado = !baneado;



                try

                {

                    using (MySqlConnection connection = DatabaseHelper.GetConnection())

                    {

                        connection.Open();



                        string query = "UPDATE usuarios SET baneado = @baneado WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))

                        {

                            cmd.Parameters.AddWithValue("@baneado", nuevoEstado);

                            cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();

                        }

                    }



                    MessageBox.Show($"El usuario ha sido {(nuevoEstado ? "baneado" : "desbaneado")} correctamente.", "Banear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarUsuarios();

                }

                catch (Exception ex)

                {

                    MessageBox.Show($"Error al banear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            else

            {

                MessageBox.Show("Por favor, seleccione un usuario para banear.", "Banear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }



        private void btnSalir_Click(object sender, EventArgs e)

        {

            if (MessageBox.Show("¿Estás seguro de que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                this.Close();

            }

        }



        private void AbrirHome()

        {

            // Verificar si ya existe una instancia de Home

            if (GlobalState.Instance.HomeInstance == null || GlobalState.Instance.HomeInstance.IsDisposed)

            {

                Home home = new Home();

                GlobalState.Instance.HomeInstance = home;

                home.Show();

            }

            else

            {

                // Si ya existe, simplemente la activamos (en lugar de crear una nueva)

                GlobalState.Instance.HomeInstance.Activate();

            }

        }



        private void CargarUsuarios(string filtro = "")

        {

            DataTable dt = new DataTable();

            dt.Columns.Add("ID");

            dt.Columns.Add("Nombre de Usuario");

            dt.Columns.Add("Rol");

            dt.Columns.Add("Email");

            dt.Columns.Add("Baneado");

            dt.Columns.Add("Contraseña");



            try

            {

                using (MySqlConnection connection = DatabaseHelper.GetConnection())

                {

                    connection.Open();

                    string query = string.IsNullOrEmpty(filtro)

                      ? "SELECT id, username, rol, email, baneado, password FROM usuarios"

                      : "SELECT id, username, rol, email, baneado, password FROM usuarios WHERE username LIKE @filtro";



                    using (MySqlCommand cmd = new MySqlCommand(query, connection))

                    {

                        if (!string.IsNullOrEmpty(filtro))

                        {

                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        }



                        using (MySqlDataReader reader = cmd.ExecuteReader())

                        {

                            while (reader.Read())

                            {

                                dt.Rows.Add(reader["id"], reader["username"], reader["rol"], reader["email"], reader["baneado"], reader["password"]);

                            }

                        }

                    }

                }



                DataGridView dgv = this.Controls["dgvUsuarios"] as DataGridView;

                dgv.DataSource = dt;

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}