namespace CatalogoJuegos
{
    partial class CarritoCompraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarritoCompraForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelEncabezado = new Panel();
            lblTituloCarrito = new Label();
            flowLayoutPanelJuegos = new FlowLayoutPanel();
            panelResumen = new Panel();
            lblTotalEstimado = new Label();
            lblPrecioTotal = new Label();
            btnContinuarPago = new Button();
            panelPie = new Panel();
            btnSeguirComprando = new Button();
            lblEliminarArticulos = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelEncabezado.SuspendLayout();
            panelResumen.SuspendLayout();
            panelPie.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelEncabezado, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanelJuegos, 0, 1);
            tableLayoutPanel1.Controls.Add(panelResumen, 0, 2);
            tableLayoutPanel1.Controls.Add(panelPie, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(896, 491);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelEncabezado
            // 
            panelEncabezado.BackColor = Color.Transparent;
            panelEncabezado.Controls.Add(lblTituloCarrito);
            panelEncabezado.Dock = DockStyle.Fill;
            panelEncabezado.Location = new Point(3, 3);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(890, 54);
            panelEncabezado.TabIndex = 0;
            // 
            // lblTituloCarrito
            // 
            lblTituloCarrito.AutoSize = true;
            lblTituloCarrito.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCarrito.ForeColor = Color.Azure;
            lblTituloCarrito.Location = new Point(3, 6);
            lblTituloCarrito.Name = "lblTituloCarrito";
            lblTituloCarrito.Size = new Size(295, 37);
            lblTituloCarrito.TabIndex = 1;
            lblTituloCarrito.Text = "Tu carro de la compra";
            // 
            // flowLayoutPanelJuegos
            // 
            flowLayoutPanelJuegos.AutoScroll = true;
            flowLayoutPanelJuegos.BackColor = Color.Transparent;
            flowLayoutPanelJuegos.Dock = DockStyle.Fill;
            flowLayoutPanelJuegos.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelJuegos.Location = new Point(3, 63);
            flowLayoutPanelJuegos.Name = "flowLayoutPanelJuegos";
            flowLayoutPanelJuegos.Size = new Size(890, 295);
            flowLayoutPanelJuegos.TabIndex = 1;
            // 
            // panelResumen
            // 
            panelResumen.BackColor = Color.Transparent;
            panelResumen.Controls.Add(lblTotalEstimado);
            panelResumen.Controls.Add(lblPrecioTotal);
            panelResumen.Controls.Add(btnContinuarPago);
            panelResumen.Dock = DockStyle.Fill;
            panelResumen.Location = new Point(3, 364);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(890, 80);
            panelResumen.TabIndex = 2;
            // 
            // lblTotalEstimado
            // 
            lblTotalEstimado.AutoSize = true;
            lblTotalEstimado.ForeColor = Color.Azure;
            lblTotalEstimado.Location = new Point(690, 10);
            lblTotalEstimado.Name = "lblTotalEstimado";
            lblTotalEstimado.Size = new Size(108, 20);
            lblTotalEstimado.TabIndex = 0;
            lblTotalEstimado.Text = "Total estimado";
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioTotal.ForeColor = Color.Azure;
            lblPrecioTotal.Location = new Point(804, 3);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(0, 28);
            lblPrecioTotal.TabIndex = 1;
            // 
            // btnContinuarPago
            // 
            btnContinuarPago.AutoSize = true;
            btnContinuarPago.BackColor = Color.Transparent;
            btnContinuarPago.BackgroundImageLayout = ImageLayout.Center;
            btnContinuarPago.FlatAppearance.BorderSize = 2;
            btnContinuarPago.FlatStyle = FlatStyle.Flat;
            btnContinuarPago.ForeColor = Color.Azure;
            btnContinuarPago.Location = new Point(701, 33);
            btnContinuarPago.Name = "btnContinuarPago";
            btnContinuarPago.Size = new Size(180, 40);
            btnContinuarPago.TabIndex = 3;
            btnContinuarPago.Text = "Continuar al pago";
            btnContinuarPago.UseVisualStyleBackColor = false;
            btnContinuarPago.Click += btnContinuarPago_Click;
            // 
            // panelPie
            // 
            panelPie.Controls.Add(btnSeguirComprando);
            panelPie.Controls.Add(lblEliminarArticulos);
            panelPie.Dock = DockStyle.Fill;
            panelPie.Location = new Point(3, 450);
            panelPie.Name = "panelPie";
            panelPie.Size = new Size(890, 38);
            panelPie.TabIndex = 3;
            // 
            // btnSeguirComprando
            // 
            btnSeguirComprando.AutoSize = true;
            btnSeguirComprando.BackColor = Color.Transparent;
            btnSeguirComprando.BackgroundImageLayout = ImageLayout.Center;
            btnSeguirComprando.FlatAppearance.BorderSize = 2;
            btnSeguirComprando.FlatStyle = FlatStyle.Flat;
            btnSeguirComprando.ForeColor = Color.Azure;
            btnSeguirComprando.Location = new Point(0, 0);
            btnSeguirComprando.Name = "btnSeguirComprando";
            btnSeguirComprando.Size = new Size(148, 34);
            btnSeguirComprando.TabIndex = 0;
            btnSeguirComprando.Text = "Seguir Comprando";
            btnSeguirComprando.UseVisualStyleBackColor = false;
            btnSeguirComprando.Click += btnSeguirComprando_Click;
            // 
            // lblEliminarArticulos
            // 
            lblEliminarArticulos.AutoSize = true;
            lblEliminarArticulos.ForeColor = Color.Azure;
            lblEliminarArticulos.Location = new Point(690, 3);
            lblEliminarArticulos.Name = "lblEliminarArticulos";
            lblEliminarArticulos.Size = new Size(188, 20);
            lblEliminarArticulos.TabIndex = 1;
            lblEliminarArticulos.Text = "Eliminar todos los artículos";
            lblEliminarArticulos.Click += lblEliminarArticulos_Click;
            // 
            // CarritoCompraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 491);
            Controls.Add(tableLayoutPanel1);
            Name = "CarritoCompraForm";
            Text = "Carrito de Compras";
            tableLayoutPanel1.ResumeLayout(false);
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            panelPie.ResumeLayout(false);
            panelPie.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label lblTituloCarrito;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelJuegos;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Label lblTotalEstimado;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Button btnContinuarPago;
        private System.Windows.Forms.Panel panelPie;
        private System.Windows.Forms.Button btnSeguirComprando;
        private System.Windows.Forms.Label lblEliminarArticulos;
    }
}