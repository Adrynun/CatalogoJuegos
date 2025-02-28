using System;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class BibliotecaForm : Form
    {
        /// <summary>
        /// Obtiene o establece el nombre de usuario.
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Obtiene o establece el rol del usuario.
        /// </summary>
        public string RolUsuario { get; set; }

        /// <summary>
        /// Constructor de la clase BibliotecaForm.
        /// </summary>
        public BibliotecaForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrescribe el método OnLoad para realizar acciones después de que el formulario se carga.
        /// La carga de juegos se delega al control BibliotecaControl.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // La carga de juegos se realiza en BibliotecaControl
            // Puedes pasar los valores de Usuario y RolUsuario al control BibliotecaControl aquí si es necesario.
        }
    }
}