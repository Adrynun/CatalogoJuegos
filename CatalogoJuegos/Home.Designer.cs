using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatalogoJuegos
{
    public partial class Home : Form
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private PictureBox logo;
        private Label lblUser;
        private Button btnCerrarSesion;
        private Panel panelHeader;
        private Panel userPanel;
        private Panel panelCatalogo;  // Panel para agregar el CatalogoControl

        public Home()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            logo = new PictureBox();
            lblUser = new Label();
            btnCerrarSesion = new Button();
            panelHeader = new Panel();
            userPanel = new Panel();
            menuStrip1 = new MenuStrip();
            panelCatalogo = new Panel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panelHeader.SuspendLayout();
            userPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(15, 15);
            logo.Name = "logo";
            logo.Size = new Size(40, 40);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            logo.AutoSize = false;
            logo.Click += logo_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Microsoft Sans Serif", 14F);
            lblUser.ForeColor = SystemColors.ButtonHighlight;
            lblUser.Location = new Point(80, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(108, 29);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuario: ";
            lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AutoSize = true;
            btnCerrarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCerrarSesion.BackColor = Color.Red;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(523, 15);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(152, 35);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCerrarSesion.AutoSize = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(logo);
            panelHeader.Controls.Add(userPanel);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1366, 70);
            panelHeader.TabIndex = 0;
            panelHeader.AutoSize = false;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.Transparent;
            userPanel.Controls.Add(lblUser);
            userPanel.Controls.Add(btnCerrarSesion);
            userPanel.Location = new Point(679, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(684, 70);
            userPanel.TabIndex = 1;
            userPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            lblUser.AutoSize = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 70);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1366, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            menuStrip1.AutoSize = true;
            // 
            // panelCatalogo
            // 
            panelCatalogo.BackColor = Color.Transparent;
            panelCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCatalogo.Location = new Point(0, 98);
            panelCatalogo.Name = "panelCatalogo";
            panelCatalogo.Size = new Size(1366, 670);
            panelCatalogo.TabIndex = 2;
            // 
            // Home
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 768);
            Controls.Add(panelCatalogo);
            Controls.Add(menuStrip1);
            Controls.Add(panelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Catálogo Juegos";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panelHeader.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

    }
}
