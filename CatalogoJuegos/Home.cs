using System;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class Home : Form
    {
        public string NombreUsuario { get; set; }
        public string RolUsuario { get; set; }
        private CarritoCompraForm carritoForm;
        public CatalogoControl CatalogoControl
        {
            get
            {
                foreach (Control control in panelCatalogo.Controls)
                {
                    if (control is CatalogoControl)
                    {
                        return (CatalogoControl)control;
                    }
                }
                return null;
            }
        }


        public Home(string usuario, string rol)
        {
            InitializeComponent();
            NombreUsuario = usuario;
            RolUsuario = rol;
            lblUser.Text = $"Bienvenido, {NombreUsuario}";
            ConfigurarMenu();
            carritoForm = new CarritoCompraForm();
            GlobalState.Instance.HomeInstance = this;

        }

        private void CrearCatalogoControl()
        {
            // Crear el control de catálogo
            CatalogoControl catalogoControl = new CatalogoControl();
            catalogoControl.Dock = DockStyle.Fill; // Ocupa todo el espacio disponible dentro del panel
            panelCatalogo.Controls.Add(catalogoControl); // Añadir CatalogoControl al panel
        }

        private void ConfigurarMenu()
        {
            if (RolUsuario == "administrador")
            {
                ConfigurarMenuAdministrador();
            }
            else if (RolUsuario == "usuario")
            {
                ConfigurarMenuUsuario();
            }
        }

        private void ConfigurarMenuAdministrador()
        {
            ToolStripMenuItem menuAdmin = new ToolStripMenuItem("Administrar Usuarios");
            menuAdmin.Click += (sender, e) => MostrarVentanaAdministrarUsuarios();
            menuStrip1.Items.Add(menuAdmin);

            ToolStripMenuItem menuGestionCatalogo = new ToolStripMenuItem("Gestionar Catálogo");
            menuGestionCatalogo.Click += (sender, e) => MostrarGestionCatalogo();
            menuStrip1.Items.Add(menuGestionCatalogo);
        }

        private void ConfigurarMenuUsuario()
        {
            ToolStripMenuItem menuCarrito = new ToolStripMenuItem("Carrito");
            menuCarrito.Click += (sender, e) => MostrarCarrito();
            menuStrip1.Items.Add(menuCarrito);

            ToolStripMenuItem menuBiblioteca = new ToolStripMenuItem("Biblioteca");
            menuBiblioteca.Click += (sender, e) => MostrarBiblioteca();
            menuStrip1.Items.Add(menuBiblioteca);
        }
        public void AgregarJuegoAlCarrito(Juego juego)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"AgregarJuegoAlCarrito: Referencia de carrito antes de agregar: {carritoForm?.GetHashCode()}");

                if (carritoForm == null || carritoForm.IsDisposed)
                {
                    carritoForm = new CarritoCompraForm();
                }
                carritoForm.AgregarJuego(juego);

                System.Diagnostics.Debug.WriteLine($"AgregarJuegoAlCarrito: Referencia de carrito después de agregar: {carritoForm?.GetHashCode()}");

                carritoForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el juego al carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarCarrito()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"MostrarCarrito: Referencia de carrito antes de mostrar: {carritoForm?.GetHashCode()}");
                if (carritoForm == null || carritoForm.IsDisposed)
                {
                    carritoForm = new CarritoCompraForm();
                }
                carritoForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al mostrar el carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarBiblioteca()
        {
            BibliotecaForm bibliotecaForm = new BibliotecaForm();
            bibliotecaForm.Usuario = NombreUsuario;
            bibliotecaForm.RolUsuario = RolUsuario;
            bibliotecaForm.Show();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://eu.gear.blizzard.com/";
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el enlace. Verifique su conexión a internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Welcome loginForm = new Welcome();
                loginForm.Show();
            }
        }

        private void MostrarVentanaAdministrarUsuarios()
        {
            AdminUsuarios adminForm = new();
            adminForm.Show();
        }

        private void MostrarGestionCatalogo()
        {
            // Obtener la instancia de CatalogoControl
            CatalogoControl catalogoControl = null;
            foreach (Control control in panelCatalogo.Controls)
            {
                if (control is CatalogoControl)
                {
                    catalogoControl = (CatalogoControl)control;
                    break;
                }
            }

            if (catalogoControl != null)
            {
                GestionCatalogo gestionCatalogoForm = new GestionCatalogo(catalogoControl); // Pasar la referencia
                gestionCatalogoForm.Show();
            }
            else
            {
                MessageBox.Show("No se encontró el control de catálogo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Agregar CatalogoControl al panelCatalogo
            CatalogoControl catalogoControl = new CatalogoControl();
            catalogoControl.Dock = DockStyle.Fill;
            panelCatalogo.Controls.Add(catalogoControl);
        }
    }
}
