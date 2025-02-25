namespace CatalogoJuegos

{

    partial class GestionCatalogo

    {

        private System.ComponentModel.IContainer components = null;



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCatalogo));
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnActualizar = new Button();
            dgvJuegos = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            juegoControl1 = new JuegoControl();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            lblBuscar.ForeColor = SystemColors.ButtonHighlight;
            lblBuscar.Location = new Point(27, 25);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(149, 21);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar juego:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtBuscar.Location = new Point(200, 22);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(282, 28);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Turquoise;
            btnBuscar.Location = new Point(511, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 31);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Transparent;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.Turquoise;
            btnActualizar.Location = new Point(862, 20);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 31);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar lista";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvJuegos
            // 
            dgvJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvJuegos.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJuegos.Location = new Point(298, 79);
            dgvJuegos.Name = "dgvJuegos";
            dgvJuegos.ReadOnly = true;
            dgvJuegos.RowHeadersWidth = 51;
            dgvJuegos.RowTemplate.Height = 40;
            dgvJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJuegos.Size = new Size(724, 379);
            dgvJuegos.TabIndex = 4;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Turquoise;
            btnEditar.Location = new Point(496, 473);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(160, 37);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar Juego";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Turquoise;
            btnEliminar.Location = new Point(675, 473);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 37);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Juego";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Turquoise;
            btnSalir.Location = new Point(915, 473);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 37);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // juegoControl1
            // 
            juegoControl1.BackColor = Color.Transparent;
            juegoControl1.JuegoId = -1;
            juegoControl1.Location = new Point(27, 79);
            juegoControl1.Name = "juegoControl1";
            juegoControl1.Size = new Size(240, 455);
            juegoControl1.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.Turquoise;
            btnAgregar.Location = new Point(298, 473);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(168, 37);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar Juego";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // GestionCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1056, 531);
            Controls.Add(btnAgregar);
            Controls.Add(juegoControl1);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvJuegos);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestionCatalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión del Catálogo";
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblBuscar;

        private TextBox txtBuscar;

        private Button btnBuscar;

        private Button btnActualizar;

        private DataGridView dgvJuegos;

        private Button btnEditar;

        private Button btnEliminar;

        private Button btnSalir;

        #endregion

        private JuegoControl juegoControl1;
        private Button btnAgregar;
    }

}