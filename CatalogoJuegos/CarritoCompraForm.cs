using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class CarritoCompraForm : Form
    {
        /// <summary>
        /// Lista de juegos en el carrito de compras.
        /// </summary>
        private List<Juego> carrito = new List<Juego>();

        /// <summary>
        /// Constructor de la clase CarritoCompraForm.
        /// </summary>
        public CarritoCompraForm()
        {
            InitializeComponent();
            MostrarCarrito();
        }

        /// <summary>
        /// Agrega un juego al carrito de compras.
        /// </summary>
        /// <param name="juego">Juego a agregar.</param>
        public void AgregarJuego(Juego juego)
        {
            carrito.Add(juego);
            MostrarCarrito();
        }

        /// <summary>
        /// Muestra los juegos en el carrito de compras y actualiza el precio total.
        /// </summary>
        private void MostrarCarrito()
        {
            // Limpiar los controles existentes en el FlowLayoutPanel
            flowLayoutPanelJuegos.Controls.Clear();

            // Agregar los juegos del carrito al FlowLayoutPanel
            foreach (Juego juego in carrito)
            {
                CarritoJuegoControl control = new CarritoJuegoControl();
                control.JuegoImagen = juego.Imagen;
                control.JuegoTitulo = juego.Titulo;
                control.JuegoPrecio = juego.Precio;
                control.EliminarClick += Control_EliminarClick;
                flowLayoutPanelJuegos.Controls.Add(control);
            }

            ActualizarPrecioTotal();
        }

        /// <summary>
        /// Maneja el evento EliminarClick de un control CarritoJuegoControl.
        /// Elimina el juego correspondiente del carrito y actualiza la vista.
        /// </summary>
        private void Control_EliminarClick(object sender, EventArgs e)
        {
            CarritoJuegoControl control = sender as CarritoJuegoControl;
            if (control != null)
            {
                carrito.RemoveAt(flowLayoutPanelJuegos.Controls.IndexOf(control));
                MostrarCarrito();
            }
        }

        /// <summary>
        /// Calcula y actualiza el precio total del carrito de compras.
        /// </summary>
        private void ActualizarPrecioTotal()
        {
            decimal total = 0;
            foreach (Juego juego in carrito)
            {
                total += juego.Precio;
            }
            lblPrecioTotal.Text = $"{total:C}";
        }

        /// <summary>
        /// Maneja el evento de clic del botón Continuar Pago.
        /// Guarda la compra en la base de datos y vacía el carrito.
        /// </summary>
        private void btnContinuarPago_Click(object sender, EventArgs e)
        {
            int idUsuario = GlobalState.Instance.IdUsuario;
            MySqlConnection connection = DatabaseHelper.GetConnection();

            try
            {
                DatabaseHelper.OpenConnection(connection);
                foreach (Juego juego in carrito)
                {
                    string query = "INSERT INTO compras (id_usuario, id_videojuego, fecha_compra) VALUES (@idUsuario, @idJuego, @fechaCompra)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idUsuario", idUsuario);
                        command.Parameters.AddWithValue("@idJuego", juego.Id);
                        command.Parameters.AddWithValue("@fechaCompra", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Compra confirmada.");
                carrito.Clear();
                MostrarCarrito();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error de base de datos al realizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al realizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseHelper.CloseConnection(connection);
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Seguir Comprando.
        /// Cierra el formulario del carrito de compras.
        /// </summary>
        private void btnSeguirComprando_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Maneja el evento de clic del label Eliminar Artículos.
        /// Vacía el carrito de compras y actualiza la vista.
        /// </summary>
        private void lblEliminarArticulos_Click(object sender, EventArgs e)
        {
            carrito.Clear();
            MostrarCarrito();
        }
    }
}