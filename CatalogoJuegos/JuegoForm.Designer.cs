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
            labelPrecio = new Label();
            buttonCompra = new Button();
            buttonVolver = new Button();
            panelDescripcion = new Panel();
            buttonGestionar = new Button();
            labelDescripcion = new Label();
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
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.Azure;
            labelTitulo.Location = new Point(220, 40);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(200, 30);
            labelTitulo.TabIndex = 10;
            labelTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrecio
            // 
            labelPrecio.BackColor = Color.Transparent;
            labelPrecio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            labelPrecio.ForeColor = Color.Azure;
            labelPrecio.Location = new Point(220, 80);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(200, 30);
            labelPrecio.TabIndex = 12;
            labelPrecio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCompra
            // 
            buttonCompra.BackColor = Color.Transparent;
            buttonCompra.FlatStyle = FlatStyle.Flat;
            buttonCompra.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            buttonCompra.ForeColor = Color.Azure;
            buttonCompra.Location = new Point(12, 350);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(94, 29);
            buttonCompra.TabIndex = 13;
            buttonCompra.Text = "Comprar";
            buttonCompra.UseVisualStyleBackColor = false;
            buttonCompra.Visible = false;
            buttonCompra.Click += buttonCompra_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Transparent;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            buttonVolver.ForeColor = Color.Azure;
            buttonVolver.Location = new Point(326, 350);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(94, 29);
            buttonVolver.TabIndex = 14;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // panelDescripcion
            // 
            panelDescripcion.AutoScroll = true;
            panelDescripcion.BackColor = Color.Transparent;
            panelDescripcion.Controls.Add(labelDescripcion);
            panelDescripcion.Location = new Point(220, 120);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Size = new Size(200, 100);
            panelDescripcion.TabIndex = 15;
            // 
            // buttonGestionar
            // 
            buttonGestionar.BackColor = Color.Transparent;
            buttonGestionar.FlatStyle = FlatStyle.Flat;
            buttonGestionar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            buttonGestionar.ForeColor = Color.Azure;
            buttonGestionar.Location = new Point(171, 350);
            buttonGestionar.Name = "buttonGestionar";
            buttonGestionar.Size = new Size(94, 29);
            buttonGestionar.TabIndex = 17;
            buttonGestionar.Text = "Gestionar";
            buttonGestionar.UseVisualStyleBackColor = false;
            buttonGestionar.Visible = false;
            buttonGestionar.Click += buttonGestionar_Click;
            // 
            // labelDescripcion
            // 
            labelDescripcion.BackColor = Color.Transparent;
            labelDescripcion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = Color.Azure;
            labelDescripcion.Location = new Point(0, 0);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(200, 100);
            labelDescripcion.TabIndex = 11;
            labelDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // JuegoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(432, 388);
            Controls.Add(buttonGestionar);
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
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button buttonCompra;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Panel panelDescripcion;
        private Button buttonGestionar;
        private Label labelDescripcion;
    }
}