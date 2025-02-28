using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class GestionCatalogo : Form
    {

        public CatalogoControl CatalogoControl { get; set; }
        /// <summary>
        /// Constructor de la clase GestionCatalogo.
        /// </summary>
        public GestionCatalogo(CatalogoControl catalogoControl)
        {
            InitializeComponent();
            CatalogoControl = catalogoControl;
            JuegoControl juegoControl = new JuegoControl();
            juegoControl.Dock = DockStyle.Fill;
            juegoControl1.Visible = false; //Ocultamos el control al inicio.
            CargarJuegos(); //Cargamos los juegos al inicio.
        }

        /// <summary>
        /// Maneja el evento de clic del botón Agregar.
        /// Muestra el control JuegoControl para agregar un nuevo juego.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            juegoControl1.Visible = true;
            juegoControl1.LimpiarCampos();
        }

        /// <summary>
        /// Maneja el evento de clic del botón Editar.
        /// Carga los datos del juego seleccionado en el control JuegoControl para editarlo.
        /// </summary>
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

        /// <summary>
        /// Maneja el evento de clic del botón Salir.
        /// Cierra el formulario.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de clic del botón Eliminar.
        /// Elimina el juego seleccionado de la base de datos.
        /// </summary>
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
                        CatalogoControl?.CargarCatalogo();
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

        /// <summary>
        /// Maneja el evento de clic del botón Buscar.
        /// Filtra la lista de juegos según el texto de búsqueda.
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarJuegos();
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
                        cmd.Parameters.AddWithValue("@busqueda", "%" + textoBusqueda + "%");
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

        /// <summary>
        /// Maneja el evento de clic del botón Actualizar.
        /// Recarga la lista de juegos desde la base de datos.
        /// </summary>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarJuegos();
        }

        /// <summary>
        /// Carga la lista de juegos desde la base de datos y la muestra en el DataGridView.
        /// </summary>
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