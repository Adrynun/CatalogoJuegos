using System;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class JuegoForm : Form
    {
        public string RolUsuario { get; set; }

        public JuegoForm(Juego juego, string rol)
        {
            InitializeComponent();
            RolUsuario = rol;

            pictureBoxImagen.Image = juego.Imagen;
            labelTitulo.Text = juego.Titulo;
            labelDescripcion.Text = juego.Descripcion;
            labelPrecio.Text = juego.Precio.ToString("C");

            if (RolUsuario == "administrador")
            {
                buttonCompra.Text = "Gestionar";
            }
            else
            {
                buttonCompra.Text = "Comprar";
            }
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            if (RolUsuario == "administrador")
            {
                GestionCatalogo gestionCatalogoForm = new GestionCatalogo();
                gestionCatalogoForm.Show();
            }
            else
            {
                MessageBox.Show("¡Compra realizada!");
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Juego
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Image Imagen { get; set; }
    }
}