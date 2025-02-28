namespace CatalogoJuegos
{
    partial class CarritoJuegoControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxJuego = new PictureBox();
            lblTitulo = new Label();
            lblPrecio = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJuego).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxJuego
            // 
            pictureBoxJuego.Location = new Point(10, 10);
            pictureBoxJuego.Name = "pictureBoxJuego";
            pictureBoxJuego.Size = new Size(161, 203);
            pictureBoxJuego.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxJuego.TabIndex = 0;
            pictureBoxJuego.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaption;
            lblTitulo.Location = new Point(210, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(162, 27);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título del juego";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.BorderStyle = BorderStyle.FixedSingle;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = SystemColors.ActiveCaption;
            lblPrecio.Location = new Point(292, 92);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(80, 27);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "$99.99";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.GradientInactiveCaption;
            btnEliminar.Location = new Point(280, 183);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // CarritoJuegoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBoxJuego);
            Controls.Add(lblTitulo);
            Controls.Add(lblPrecio);
            Controls.Add(btnEliminar);
            Name = "CarritoJuegoControl";
            Size = new Size(400, 236);
            ((System.ComponentModel.ISupportInitialize)pictureBoxJuego).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxJuego;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnEliminar;
    }
}