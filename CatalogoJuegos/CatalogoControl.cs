using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class CatalogoControl : UserControl
    {
        /// <summary>
        /// Obtiene o establece el rol del usuario.
        /// </summary>
        public string RolUsuario { get; set; }

        /// <summary>
        /// Constructor de la clase CatalogoControl.
        /// </summary>
        public CatalogoControl()
        {
            InitializeComponent();
            // Configurar el control para permitir fondos transparentes
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            // Establecer el color de fondo para que coincida con el padre
            this.BackColor = Parent != null ? Parent.BackColor : Color.Transparent;
            CargarCatalogo();
        }

        /// <summary>
        /// Carga el catálogo de juegos desde la base de datos y los muestra en el FlowLayoutPanel.
        /// </summary>
        public void CargarCatalogo()
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT id, titulo, descripcion, precio, imagen FROM videojuegos";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        flowLayoutPanel1.Controls.Clear(); // Limpiar los controles existentes

                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["imagen"] != DBNull.Value)
                            {
                                byte[] imagenBytes = (byte[])row["imagen"];
                                using (MemoryStream ms = new MemoryStream(imagenBytes))
                                {
                                    Image imagen = Image.FromStream(ms);

                                    Panel juegoPanel = new Panel();
                                    juegoPanel.Width = 220; // Ajustar el ancho del panel
                                    juegoPanel.Height = 350; // Ajustar la altura del panel
                                    juegoPanel.BackColor = Color.FromArgb(50, 0, 0, 0); // Fondo transparente

                                    PictureBox pb = new PictureBox();
                                    pb.Click += juegoPanel_Click;
                                    pb.Image = imagen;
                                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                                    pb.Width = 200; // Ajustar el ancho de la imagen
                                    pb.Height = 250; // Ajustar la altura de la imagen
                                    pb.Location = new Point(10, 10); // Centrar la imagen
                                    juegoPanel.Controls.Add(pb);

                                    Label lblTitulo = new Label();
                                    lblTitulo.Text = row["titulo"].ToString();
                                    lblTitulo.Location = new Point(10, 270); // Colocar el título debajo de la imagen
                                    lblTitulo.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Ajustar la fuente
                                    lblTitulo.ForeColor = Color.White;
                                    lblTitulo.AutoSize = true; // Ajustar el tamaño de la etiqueta al contenido
                                    juegoPanel.Controls.Add(lblTitulo);

                                    Label lblPrecio = new Label();
                                    lblPrecio.Text = row["precio"].ToString()+" €"; // Formatear el precio como moneda
                                    lblPrecio.Location = new Point(10, 300); // Colocar el precio debajo del título
                                    lblPrecio.Font = new Font("Segoe UI", 10); // Ajustar la fuente
                                    lblPrecio.ForeColor = Color.LightGray;
                                    lblPrecio.AutoSize = true; // Ajustar el tamaño de la etiqueta al contenido
                                    juegoPanel.Controls.Add(lblPrecio);

                                    juegoPanel.Tag = row["id"];
                                    juegoPanel.Cursor = Cursors.Hand;
                                    pb.Cursor = Cursors.Hand;
                                    lblTitulo.Cursor = Cursors.Hand;
                                    lblPrecio.Cursor = Cursors.Hand;
                                    juegoPanel.Click += juegoPanel_Click;

                                    flowLayoutPanel1.Controls.Add(juegoPanel);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el catálogo: " + ex.Message);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en un panel de juego.
        /// Obtiene el juego desde la base de datos y muestra los detalles en un formulario.
        /// </summary>
        private void juegoPanel_Click(object sender, EventArgs e)
        {
            Panel panel;
            if (sender is PictureBox)
            {
                panel = (Panel)((PictureBox)sender).Parent;
            }
            else
            {
                panel = (Panel)sender;
            }

            int juegoId = (int)panel.Tag;
            Juego juego = ObtenerJuegoDesdeBaseDeDatos(juegoId);

            if (juego != null)
            {
                Home homeForm = GlobalState.Instance.HomeInstance;
                JuegoForm detallesForm = new JuegoForm(juego, ObtenerRolUsuario(), homeForm);
                detallesForm.Show();
            }
            else
            {
                MessageBox.Show("No se encontró el juego con el ID: " + juegoId);
            }
        }

        /// <summary>
        /// Obtiene el rol del usuario desde GlobalState.
        /// </summary>
        private string ObtenerRolUsuario()
        {
            return GlobalState.Instance.RolUsuario;
        }

        /// <summary>
        /// Obtiene un juego desde la base de datos por su ID.
        /// </summary>
        private Juego ObtenerJuegoDesdeBaseDeDatos(int juegoId)
        {
            Juego juego = null;
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT id, titulo, descripcion, precio, imagen FROM videojuegos WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", juegoId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                juego = new Juego
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Titulo = reader["titulo"].ToString(),
                                    Descripcion = reader["descripcion"].ToString(),
                                    Precio = Convert.ToDecimal(reader["precio"]),
                                    Imagen = Image.FromStream(new MemoryStream((byte[])reader["imagen"]))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el juego: " + ex.Message);
            }
            return juego;
        }

        /// <summary>
        /// Maneja el evento ParentChanged del control.
        /// Actualiza el color de fondo para que coincida con el padre.
        /// </summary>
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (Parent != null)
            {
                this.BackColor = Parent.BackColor;
            }
        }
    }
}