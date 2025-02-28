namespace CatalogoJuegos
{
    partial class BibliotecaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotecaForm));
            bibliotecaControl1 = new BibliotecaControl();
            SuspendLayout();
            // 
            // bibliotecaControl1
            // 
            bibliotecaControl1.BackColor = Color.Transparent;
            bibliotecaControl1.BackgroundImage = (Image)resources.GetObject("bibliotecaControl1.BackgroundImage");
            bibliotecaControl1.BackgroundImageLayout = ImageLayout.Stretch;
            bibliotecaControl1.Dock = DockStyle.Fill;
            bibliotecaControl1.Location = new Point(0, 0);
            bibliotecaControl1.Margin = new Padding(4, 5, 4, 5);
            bibliotecaControl1.Name = "bibliotecaControl1";
            bibliotecaControl1.Size = new Size(800, 450);
            bibliotecaControl1.TabIndex = 0;
            // 
            // BibliotecaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bibliotecaControl1);
            Name = "BibliotecaForm";
            Text = "BibliotecaForm";
            ResumeLayout(false);
        }

        #endregion

        private BibliotecaControl bibliotecaControl1;
    }
}