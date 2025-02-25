using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class GestionCatalogo : Form
    {
        public GestionCatalogo()
        {
            InitializeComponent();
            JuegoControl juegoControl = new JuegoControl();
            juegoControl.Dock = DockStyle.Fill;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            juegoControl1.Visible = true;
            juegoControl1.LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvJuegos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvJuegos.SelectedRows[0].Cells["id"].Value);
                juegoControl1.JuegoId = id;
                juegoControl1.CargarDatosJuego(id);
                juegoControl1.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccione un juego para editar.", "Editar Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvJuegos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvJuegos.SelectedRows[0].Cells["id"].Value);
                if (MessageBox.Show("¿Seguro que desea eliminar este juego?", "Eliminar Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using (var connection = DatabaseHelper.GetConnection())
                        {
                            connection.Open();
                            string query = "DELETE FROM videojuegos WHERE id = @id";
                            using (var cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Juego eliminado exitosamente.", "Eliminar Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarJuegos(); // Actualiza la lista después de eliminar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el juego: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un juego para eliminar.", "Eliminar Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower(); // Obtener el texto de búsqueda en minúsculas

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarJuegos(); // Si el texto de búsqueda está vacío, mostrar todos los juegos
                return;
            }

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT id, titulo, descripcion, precio FROM videojuegos WHERE LOWER(titulo) LIKE @busqueda OR LOWER(descripcion) LIKE @busqueda";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", "%" + textoBusqueda + "%"); // Usar '%' para buscar coincidencias parciales

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvJuegos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar juegos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarJuegos();
        }

        public void CargarJuegos()
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT id, titulo, descripcion, precio FROM videojuegos";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvJuegos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los juegos: " + ex.Message);
            }
        }
        

    }
}