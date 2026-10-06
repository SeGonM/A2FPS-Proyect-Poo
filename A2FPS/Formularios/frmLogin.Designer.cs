namespace A2FPS
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null!;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private ComboBox cmbRol;
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblContrasena;
        private Label lblRol;
        private Button btnIngresar;
        private Button btnSalir;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            cmbRol = new ComboBox();
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            lblRol = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(105, 209);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(230, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(105, 250);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(230, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Items.AddRange(new object[] { "Cliente", "Empleado", "Administrador", "Proveedor" });
            cmbRol.Location = new Point(105, 292);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(230, 23);
            cmbRol.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(96, 158);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(249, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tienda de Videojuegos";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(45, 212);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(32, 253);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(68, 295);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(105, 343);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 35);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(245, 343);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 35);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_POO;
            pictureBox1.Location = new Point(105, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(440, 390);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblRol);
            Controls.Add(cmbRol);
            Controls.Add(btnIngresar);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 FPS | Iniciar sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}