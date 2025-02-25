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
        public string RolUsuario { get; set; }
        public CatalogoControl()
        {
            
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Parent != null ? Parent.BackColor : Color.Transparent;
            CargarCatalogo();
        }

        private void CargarCatalogo()
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

                        flowLayoutPanel1.Controls.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["imagen"] != DBNull.Value)
                            {
                                byte[] imagenBytes = (byte[])row["imagen"];
                                using (MemoryStream ms = new MemoryStream(imagenBytes))
                                {
                                    Image imagen = Image.FromStream(ms);

                                    Panel juegoPanel = new Panel();
                                    juegoPanel.Width = 180;
                                    juegoPanel.Height = 250;
                                    juegoPanel.BackColor = Color.FromArgb(50, 0, 0, 0);

                                    PictureBox pb = new PictureBox();
                                    pb.Image = imagen;
                                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                                    pb.Width = 150;
                                    pb.Height = 200;
                                    juegoPanel.Controls.Add(pb);

                                    Label lblTitulo = new Label();
                                    lblTitulo.Text = row["titulo"].ToString();
                                    lblTitulo.Location = new Point(10, 205);
                                    lblTitulo.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                                    lblTitulo.ForeColor = Color.White;
                                    lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
                                    lblTitulo.Width = 150;
                                    juegoPanel.Controls.Add(lblTitulo);

                                    Label lblPrecio = new Label();
                                    lblPrecio.Text = row["precio"].ToString();
                                    lblPrecio.Location = new Point(10, 230);
                                    lblPrecio.Font = new Font("Microsoft Sans Serif", 10);
                                    lblPrecio.ForeColor = Color.LightGray;
                                    lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
                                    lblPrecio.Width = 150;
                                    juegoPanel.Controls.Add(lblPrecio);

                                    juegoPanel.Tag = row["id"]; // Agregar el ID del juego al Tag del panel
                                    juegoPanel.Click += juegoPanel_Click; // Agregar evento Click al panel

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

        private void juegoPanel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            int juegoId = (int)panel.Tag; // Obtener el ID del juego desde el Tag del panel
            Juego juego = ObtenerJuegoDesdeBaseDeDatos(juegoId); // Obtener el juego desde la base de datos
            
            string rolUsuario = ObtenerRolUsuario(); // Obtener el rol del usuario actual
            JuegoForm detallesForm = new JuegoForm(juego, rolUsuario);
            detallesForm.Show();
        }
        private string ObtenerRolUsuario()
        {
            return GlobalState.Instance.RolUsuario;
        }

        private Juego ObtenerJuegoDesdeBaseDeDatos(int juegoId)
        {
            Juego juego = null;
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT titulo, descripcion, precio, imagen FROM videojuegos WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", juegoId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                juego = new Juego
                                {
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