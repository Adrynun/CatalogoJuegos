namespace CatalogoJuegos
{
    partial class BibliotecaControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTituloBiblioteca = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.ForeColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 375);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblTituloBiblioteca
            // 
            lblTituloBiblioteca.BackColor = Color.FromArgb(50, 0, 0, 0);
            lblTituloBiblioteca.Dock = DockStyle.Top;
            lblTituloBiblioteca.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloBiblioteca.ForeColor = Color.White;
            lblTituloBiblioteca.Location = new Point(0, 0);
            lblTituloBiblioteca.Name = "lblTituloBiblioteca";
            lblTituloBiblioteca.Size = new Size(800, 40);
            lblTituloBiblioteca.TabIndex = 3;
            lblTituloBiblioteca.Text = "MIS JUEGOS";
            lblTituloBiblioteca.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BibliotecaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblTituloBiblioteca);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BibliotecaControl";
            Size = new Size(800, 415);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Label lblTituloBiblioteca;
    }
}
