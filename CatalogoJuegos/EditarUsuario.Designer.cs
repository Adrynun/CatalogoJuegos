namespace CatalogoJuegos
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            cboRol = new ComboBox();
            chkBaneado = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblUsername = new Label();
            lblEmail = new Label();
            lblRol = new Label();
            lblBaneado = new Label();
            txtNuevaContrasena = new TextBox();
            txtConfirmarContrasena = new TextBox();
            lblNuevaContrasena = new Label();
            lblConfirmarContrasena = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtUsername.Location = new Point(263, 33);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEmail.Location = new Point(263, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 1;
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "admin", "usuario" });
            cboRol.Location = new Point(263, 108);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(200, 28);
            cboRol.TabIndex = 2;
            // 
            // chkBaneado
            // 
            chkBaneado.AutoSize = true;
            chkBaneado.BackColor = Color.Transparent;
            chkBaneado.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBaneado.ForeColor = SystemColors.ButtonHighlight;
            chkBaneado.Location = new Point(263, 152);
            chkBaneado.Name = "chkBaneado";
            chkBaneado.Size = new Size(106, 22);
            chkBaneado.TabIndex = 3;
            chkBaneado.Text = "Baneado";
            chkBaneado.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.DarkTurquoise;
            btnGuardar.Location = new Point(112, 273);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 36);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.DarkTurquoise;
            btnCancelar.Location = new Point(310, 273);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            lblUsername.ForeColor = SystemColors.ButtonHighlight;
            lblUsername.Location = new Point(30, 33);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(153, 18);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Nombre Usuario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            lblEmail.ForeColor = SystemColors.ButtonFace;
            lblEmail.Location = new Point(30, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 18);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            lblRol.ForeColor = SystemColors.ButtonHighlight;
            lblRol.Location = new Point(30, 113);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(40, 18);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol";
            // 
            // lblBaneado
            // 
            lblBaneado.AutoSize = true;
            lblBaneado.BackColor = Color.Transparent;
            lblBaneado.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            lblBaneado.ForeColor = SystemColors.ButtonFace;
            lblBaneado.Location = new Point(30, 153);
            lblBaneado.Name = "lblBaneado";
            lblBaneado.Size = new Size(84, 18);
            lblBaneado.TabIndex = 9;
            lblBaneado.Text = "Baneado";
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtNuevaContrasena.Location = new Point(263, 193);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Size = new Size(200, 27);
            txtNuevaContrasena.TabIndex = 12;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtConfirmarContrasena.Location = new Point(263, 230);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(200, 27);
            txtConfirmarContrasena.TabIndex = 13;
            // 
            // lblNuevaContrasena
            // 
            lblNuevaContrasena.AutoSize = true;
            lblNuevaContrasena.BackColor = Color.Transparent;
            lblNuevaContrasena.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            lblNuevaContrasena.ForeColor = SystemColors.ButtonHighlight;
            lblNuevaContrasena.Location = new Point(30, 193);
            lblNuevaContrasena.Name = "lblNuevaContrasena";
            lblNuevaContrasena.Size = new Size(170, 18);
            lblNuevaContrasena.TabIndex = 10;
            lblNuevaContrasena.Text = "Nueva Contraseña";
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.BackColor = Color.Transparent;
            lblConfirmarContrasena.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            lblConfirmarContrasena.ForeColor = SystemColors.ButtonHighlight;
            lblConfirmarContrasena.Location = new Point(30, 233);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(210, 18);
            lblConfirmarContrasena.TabIndex = 11;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // EditarUsuario
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(504, 345);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(lblConfirmarContrasena);
            Controls.Add(lblNuevaContrasena);
            Controls.Add(lblBaneado);
            Controls.Add(lblRol);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkBaneado);
            Controls.Add(cboRol);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Declaración de controles
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.CheckBox chkBaneado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblBaneado;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Label lblNuevaContrasena;
        private System.Windows.Forms.Label lblConfirmarContrasena;
    }
}
