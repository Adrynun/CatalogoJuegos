namespace CatalogoJuegos
{
    partial class CatalogoControl
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
            lblTituloCatalogo = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.ForeColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Location = new Point(12, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(576, 203);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblTituloCatalogo
            // 
            lblTituloCatalogo.Dock = DockStyle.Top;
            lblTituloCatalogo.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCatalogo.ForeColor = Color.White;
            lblTituloCatalogo.Location = new Point(0, 0);
            lblTituloCatalogo.Name = "lblTituloCatalogo";
            lblTituloCatalogo.Size = new Size(800, 40);
            lblTituloCatalogo.TabIndex = 3;
            lblTituloCatalogo.Text = "CATÁLOGO";
            lblTituloCatalogo.TextAlign = ContentAlignment.MiddleCenter;
            lblTituloCatalogo.BackColor = System.Drawing.Color.FromArgb(50, 0, 0, 0);
            // 
            // CatalogoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblTituloCatalogo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CatalogoControl";
            Size = new Size(800, 415);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Label lblTituloCatalogo;
    }
}