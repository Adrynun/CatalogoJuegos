using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class BibliotecaControl : UserControl
    {
        /// <summary>
        /// Constructor de la clase BibliotecaControl.
        /// </summary>
        public BibliotecaControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrescribe el método OnLoad para cargar los juegos comprados al cargar el control.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarJuegosComprados();
        }

        /// <summary>
        /// Carga los juegos comprados por el usuario actual y los muestra en el FlowLayoutPanel.
        /// </summary>
        private void CargarJuegosComprados()
        {
            int idUsuario = GlobalState.Instance.IdUsuario;
            List<Juego> juegosComprados = ObtenerJuegosCompradosPorUsuario(idUsuario);
            MostrarJuegos(juegosComprados);
        }

        /// <summary>
        /// Obtiene la lista de juegos comprados por un usuario desde la base de datos.
        /// </summary>
        /// <param name="idUsuario">ID del usuario.</param>
        /// <returns>Lista de juegos comprados.</returns>
        private List<Juego> ObtenerJuegosCompradosPorUsuario(int idUsuario)
        {
            List<Juego> juegosComprados = new List<Juego>();
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    DatabaseHelper.OpenConnection(connection);

                    string query = @"
                        SELECT videojuegos.* FROM videojuegos
                        INNER JOIN compras ON videojuegos.Id = compras.id_videojuego
                        WHERE compras.id_usuario = @idUsuario;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idUsuario", idUsuario);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Juego juego = new Juego
                                {
                                    Id = reader.GetInt32("Id"),
                                    Titulo = reader.GetString("Titulo"),
                                    Descripcion = reader.GetString("Descripcion"),
                                    Precio = reader.GetDecimal("Precio"),
                                    Imagen = reader["imagen"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])reader["imagen"])) : null
                                };
                                juegosComprados.Add(juego);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al cargar juegos comprados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DatabaseHelper.CloseConnection(connection);
                }
            }
            return juegosComprados;
        }

        /// <summary>
        /// Muestra la lista de juegos en el FlowLayoutPanel.
        /// </summary>
        /// <param name="juegos">Lista de juegos a mostrar.</param>
        private void MostrarJuegos(List<Juego> juegos)
        {
            flowLayoutPanel1.Controls.Clear(); // Limpiar el FlowLayoutPanel

            if (juegos != null)
            {
                foreach (Juego juego in juegos)
                {
                    // Crear un Panel para agrupar la imagen y el título
                    Panel juegoPanel = new Panel();
                    juegoPanel.Width = 180;
                    juegoPanel.Height = 250;
                    juegoPanel.BackColor = Color.Transparent;

                    // Crear PictureBox para la imagen del juego
                    PictureBox pb = new PictureBox();
                    pb.Image = juego.Imagen;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Width = 150;
                    pb.Height = 200;
                    juegoPanel.Controls.Add(pb);

                    // Crear Label para el título del juego
                    Label lblTitulo = new Label();
                    lblTitulo.Text = juego.Titulo;
                    lblTitulo.Location = new Point(10, 205);
                    lblTitulo.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    lblTitulo.ForeColor = Color.White;
                    lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
                    lblTitulo.Width = 150;
                    juegoPanel.Controls.Add(lblTitulo);

                    // Agregar el Panel al FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(juegoPanel);
                }
            }
        }
    }
}