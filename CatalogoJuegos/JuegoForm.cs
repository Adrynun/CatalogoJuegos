using System;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class JuegoForm : Form
    {
        /// <summary>
        /// Rol del usuario actual.
        /// </summary>
        public string RolUsuario { get; set; }

        /// <summary>
        /// Juego actual que se muestra en el formulario.
        /// </summary>
        private Juego juegoActual;

        /// <summary>
        /// Referencia al formulario principal Home.
        /// </summary>
        private Home homeForm;

        /// <summary>
        /// Constructor de la clase JuegoForm.
        /// </summary>
        /// <param name="juego">Juego a mostrar.</param>
        /// <param name="rol">Rol del usuario.</param>
        /// <param name="homeForm">Instancia del formulario principal Home.</param>
        public JuegoForm(Juego juego, string rol, Home homeForm)
        {
            InitializeComponent();
            RolUsuario = rol;
            juegoActual = juego;
            this.homeForm = homeForm; // Asignar la referencia a Home

            // Mostrar detalles del juego
            pictureBoxImagen.Image = juego.Imagen;
            labelTitulo.Text = juego.Titulo;
            labelDescripcion.Text = juego.Descripcion;
            labelPrecio.Text = juego.Precio.ToString("C");

            // Mostrar botones según el rol del usuario
            if (RolUsuario == "administrador")
            {
                buttonGestionar.Visible = true;
            }
            else
            {
                buttonCompra.Visible = true;
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Comprar.
        /// </summary>
        private void buttonCompra_Click(object sender, EventArgs e)
        {
            // Acceder a la instancia de Home y agregar el juego al carrito
            if (GlobalState.Instance.HomeInstance != null)
            {
                GlobalState.Instance.HomeInstance.AgregarJuegoAlCarrito(juegoActual);
            }
            else
            {
                MessageBox.Show("No se encontró la instancia de HomeForm.");
            }
            this.Hide();
        }

        /// <summary>
        /// Maneja el evento de clic del botón Gestionar.
        /// </summary>
        private void buttonGestionar_Click(object sender, EventArgs e)
        {
            // Verificar si la instancia de Home y CatalogoControl son válidas
            if (homeForm != null && homeForm.CatalogoControl != null)
            {
                // Crear y mostrar el formulario GestionCatalogo pasando la instancia de CatalogoControl
                GestionCatalogo gestionCatalogoForm = new GestionCatalogo(homeForm.CatalogoControl);
                gestionCatalogoForm.Show();
            }
            else
            {
                MessageBox.Show("No se encontró la instancia de CatalogoControl.");
            }
            this.Hide();
        }

        /// <summary>
        /// Maneja el evento de clic del botón Volver.
        /// </summary>
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    /// <summary>
    /// Clase que representa un juego.
    /// </summary>
    public class Juego
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Image Imagen { get; set; }
    }
}