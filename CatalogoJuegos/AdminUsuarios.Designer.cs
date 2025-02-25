namespace CatalogoJuegos
{
    partial class AdminUsuarios
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsuarios));
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnActualizar = new Button();
            dgvUsuarios = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBanear = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            lblBuscar.Size = new Size(171, 21);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar usuario:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(213, 22);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(335, 28);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Turquoise;
            btnBuscar.Location = new Point(575, 20);
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
            btnActualizar.BackgroundImageLayout = ImageLayout.Center;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.Turquoise;
            btnActualizar.Location = new Point(719, 22);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 31);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar lista";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Location = new Point(27, 74);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 40;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(852, 250);
            dgvUsuarios.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.BackgroundImageLayout = ImageLayout.Center;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.Turquoise;
            btnAgregar.Location = new Point(27, 335);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 37);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Usuario";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Turquoise;
            btnEditar.Location = new Point(193, 335);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(160, 37);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar Usuario";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Turquoise;
            btnEliminar.Location = new Point(359, 335);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 37);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBanear
            // 
            btnBanear.BackColor = Color.Transparent;
            btnBanear.BackgroundImageLayout = ImageLayout.Center;
            btnBanear.FlatStyle = FlatStyle.Flat;
            btnBanear.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnBanear.ForeColor = Color.Turquoise;
            btnBanear.Location = new Point(525, 335);
            btnBanear.Name = "btnBanear";
            btnBanear.Size = new Size(160, 37);
            btnBanear.TabIndex = 8;
            btnBanear.Text = "Banear Usuario";
            btnBanear.UseVisualStyleBackColor = false;
            btnBanear.Click += btnBanear_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImageLayout = ImageLayout.Center;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Turquoise;
            btnSalir.Location = new Point(772, 335);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 37);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // AdminUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 400);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBanear);
            Controls.Add(btnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración de Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Acción para agregar un nuevo usuario
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Acción para eliminar un usuario
        }

        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnActualizar;
        private DataGridView dgvUsuarios;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBanear;
        private Button btnSalir;

        #endregion
    }
}