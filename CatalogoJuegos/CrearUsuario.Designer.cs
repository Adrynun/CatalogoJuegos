namespace CatalogoJuegos
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            grpUsuario = new GroupBox();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            grpUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // grpUsuario
            // 
            grpUsuario.BackColor = Color.Transparent;
            grpUsuario.Controls.Add(lblUsername);
            grpUsuario.Controls.Add(lblEmail);
            grpUsuario.Controls.Add(lblPassword);
            grpUsuario.Controls.Add(lblConfirmPassword);
            grpUsuario.Controls.Add(txtUsername);
            grpUsuario.Controls.Add(txtEmail);
            grpUsuario.Controls.Add(txtPassword);
            grpUsuario.Controls.Add(txtConfirmPassword);
            grpUsuario.Controls.Add(btnGuardar);
            grpUsuario.Controls.Add(btnSalir);
            grpUsuario.ForeColor = Color.White;
            grpUsuario.Location = new Point(12, 12);
            grpUsuario.Name = "grpUsuario";
            grpUsuario.Size = new Size(676, 312);
            grpUsuario.TabIndex = 0;
            grpUsuario.TabStop = false;
            grpUsuario.Text = "Crear Usuario";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblUsername.Location = new Point(40, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(199, 26);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nombre Usuario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(40, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 26);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(40, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(147, 26);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(40, 180);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(276, 26);
            lblConfirmPassword.TabIndex = 3;
            lblConfirmPassword.Text = "Confirmar Contraseña";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(328, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(322, 30);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(328, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 30);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(328, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(322, 30);
            txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtConfirmPassword.Location = new Point(328, 177);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(322, 30);
            txtConfirmPassword.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Aquamarine;
            btnGuardar.Location = new Point(92, 238);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(200, 35);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Aquamarine;
            btnSalir.Location = new Point(419, 238);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 35);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 336);
            Controls.Add(grpUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Usuario";
            grpUsuario.ResumeLayout(false);
            grpUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Label lblUsername, lblEmail, lblPassword, lblConfirmPassword;
        private System.Windows.Forms.TextBox txtUsername, txtEmail, txtPassword, txtConfirmPassword;
        private System.Windows.Forms.Button btnGuardar, btnSalir;
    }
}
