namespace CatalogoJuegos
{
    partial class JuegoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoForm));
            pictureBoxImagen = new PictureBox();
            labelTitulo = new Label();
            labelDescripcion = new Label();
            labelPrecio = new Label();
            buttonCompra = new Button();
            buttonVolver = new Button();
            panelDescripcion = new Panel();
            labelTituloFormulario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            panelDescripcion.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagen.Location = new Point(12, 40);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(200, 200);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 9;
            pictureBoxImagen.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.Location = new Point(220, 40);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(200, 30);
            labelTitulo.TabIndex = 10;
            labelTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescripcion
            // 
            labelDescripcion.Location = new Point(0, 0);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(200, 100);
            labelDescripcion.TabIndex = 11;
            // 
            // labelPrecio
            // 
            labelPrecio.Location = new Point(220, 80);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(200, 30);
            labelPrecio.TabIndex = 12;
            labelPrecio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCompra
            // 
            buttonCompra.Location = new Point(12, 350);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(94, 29);
            buttonCompra.TabIndex = 13;
            buttonCompra.Text = "Comprar";
            buttonCompra.UseVisualStyleBackColor = true;
            buttonCompra.Click += buttonCompra_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(326, 350);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(94, 29);
            buttonVolver.TabIndex = 14;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // panelDescripcion
            // 
            panelDescripcion.AutoScroll = true;
            panelDescripcion.Controls.Add(labelDescripcion);
            panelDescripcion.Location = new Point(220, 120);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Size = new Size(200, 100);
            panelDescripcion.TabIndex = 15;
            // 
            // labelTituloFormulario
            // 
            labelTituloFormulario.Dock = DockStyle.Top;
            labelTituloFormulario.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloFormulario.Location = new Point(0, 0);
            labelTituloFormulario.Name = "labelTituloFormulario";
            labelTituloFormulario.Size = new Size(432, 37);
            labelTituloFormulario.TabIndex = 16;
            labelTituloFormulario.Text = "Detalles del Juego";
            labelTituloFormulario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // JuegoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(432, 388);
            Controls.Add(labelTituloFormulario);
            Controls.Add(panelDescripcion);
            Controls.Add(buttonVolver);
            Controls.Add(buttonCompra);
            Controls.Add(labelPrecio);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBoxImagen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JuegoForm";
            Text = "Detalles del Juego";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            panelDescripcion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button buttonCompra;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Panel panelDescripcion;
        private System.Windows.Forms.Label labelTituloFormulario;
    }
}