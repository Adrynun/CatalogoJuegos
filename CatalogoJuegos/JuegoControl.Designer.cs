namespace CatalogoJuegos
{
    partial class JuegoControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbImagen = new PictureBox();
            btnSeleccionarImagen = new Button();
            btnGuardar = new Button();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtTitulo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.BackColor = Color.Transparent;
            pbImagen.BorderStyle = BorderStyle.Fixed3D;
            pbImagen.Location = new Point(16, 3);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(200, 200);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 3;
            pbImagen.TabStop = false;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            btnSeleccionarImagen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSeleccionarImagen.ForeColor = Color.DarkTurquoise;
            btnSeleccionarImagen.Location = new Point(16, 340);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(200, 40);
            btnSeleccionarImagen.TabIndex = 4;
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = true;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.DarkTurquoise;
            btnGuardar.Location = new Point(16, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(200, 40);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar Juego";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(16, 288);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(200, 27);
            txtPrecio.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(16, 255);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(200, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(16, 222);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Título del juego";
            txtTitulo.Size = new Size(200, 27);
            txtTitulo.TabIndex = 6;
            // 
            // JuegoControl
            // 
            BackColor = Color.Transparent;
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtTitulo);
            Controls.Add(btnGuardar);
            Controls.Add(btnSeleccionarImagen);
            Controls.Add(pbImagen);
            Name = "JuegoControl";
            Size = new Size(231, 440);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.Button btnGuardar;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtTitulo;
    }
}
