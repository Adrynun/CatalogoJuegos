using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class JuegoControl : UserControl
    {
        public int JuegoId { get; set; } = -1;
        public JuegoControl()
        {
            InitializeComponent();
        }
        
        private byte[] imagenBytes;

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagenPath = openFileDialog.FileName;
                    pbImagen.Image = Image.FromFile(imagenPath);
                    imagenBytes = File.ReadAllBytes(imagenPath);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTitulo.Text;
                string descripcion = txtDescripcion.Text;
                decimal precio;

                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(txtPrecio.Text) || imagenBytes == null)

                {

                    MessageBox.Show("Por favor, complete todos los campos.");

                    return;

                }



                if (!decimal.TryParse(txtPrecio.Text, out precio))

                {

                    MessageBox.Show("Por favor, ingrese un precio válido.");

                    return;

                }

                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query;
                    if (JuegoId == -1) // Nuevo juego
                    {
                        query = "INSERT INTO videojuegos (titulo, descripcion, precio, imagen) VALUES (@titulo, @descripcion, @precio, @imagen)";
                    }
                    else // Editar juego existente
                    {
                        query = "UPDATE videojuegos SET titulo = @titulo, descripcion = @descripcion, precio = @precio, imagen = @imagen WHERE id = @id";
                    }
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@imagen", imagenBytes);
                        if (JuegoId != -1)
                        {
                            cmd.Parameters.AddWithValue("@id", JuegoId);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Juego guardado exitosamente.");
                LimpiarCampos();
                JuegoId = -1; // Restablecer el ID después de guardar
                this.Visible = false;
                ((GestionCatalogo)this.ParentForm).CargarJuegos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el juego: " + ex.Message);
            }
        }
        public void CargarDatosJuego(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT titulo, descripcion, precio, imagen FROM videojuegos WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTitulo.Text = reader["titulo"].ToString();
                                txtDescripcion.Text = reader["descripcion"].ToString();
                                txtPrecio.Text = reader["precio"].ToString();
                                if (reader["imagen"] != DBNull.Value)
                                {
                                    imagenBytes = (byte[])reader["imagen"];
                                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                                    {
                                        pbImagen.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pbImagen.Image = null;
                                    imagenBytes = null;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del juego: " + ex.Message);
            }
        }
        public void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            pbImagen.Image = null;
            imagenBytes = null;
        }
    }
}