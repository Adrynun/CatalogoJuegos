using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class CarritoJuegoControl : UserControl
    {
        /// <summary>
        /// Constructor de la clase CarritoJuegoControl.
        /// </summary>
        public CarritoJuegoControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiene o establece la imagen del juego.
        /// </summary>
        public Image JuegoImagen
        {
            get { return pictureBoxJuego.Image; }
            set { pictureBoxJuego.Image = value; }
        }

        /// <summary>
        /// Obtiene o establece el título del juego.
        /// </summary>
        public string JuegoTitulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        /// <summary>
        /// Obtiene o establece el precio del juego.
        /// </summary>
        public decimal JuegoPrecio
        {
            get { return decimal.Parse(lblPrecio.Text.Replace("$", "")); }
            set { lblPrecio.Text = value.ToString("C"); }
        }

        /// <summary>
        /// Evento que se dispara cuando se hace clic en el botón Eliminar.
        /// </summary>
        public event EventHandler EliminarClick;

        /// <summary>
        /// Maneja el evento de clic del botón Eliminar.
        /// Invoca el evento EliminarClick.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarClick?.Invoke(this, EventArgs.Empty);
        }

    }
}