using System;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class Home : Form
    {
        public string NombreUsuario { get; set; }
        public string RolUsuario { get; set; }



        public Home(string usuario, string rol)
        {
            InitializeComponent();
            NombreUsuario = usuario;
            RolUsuario = rol;

            lblUser.Text = $"Bienvenido, {NombreUsuario}";
            ConfigurarMenu();
            
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
                // Opción para administrar usuarios
                ToolStripMenuItem menuAdmin = new ToolStripMenuItem("Administrar Usuarios");
                menuAdmin.Click += (sender, e) => MostrarVentanaAdministrarUsuarios();
                menuStrip1.Items.Add(menuAdmin);

                // Opción para gestionar el catálogo
                ToolStripMenuItem menuGestionCatalogo = new ToolStripMenuItem("Gestionar Catálogo");
                menuGestionCatalogo.Click += (sender, e) => MostrarGestionCatalogo();
                menuStrip1.Items.Add(menuGestionCatalogo);
            }
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
            GestionCatalogo gestionCatalogoForm = new GestionCatalogo();
            gestionCatalogoForm.Show();
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
