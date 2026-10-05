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
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(160, 96);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(230, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(160, 141);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(230, 27);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Items.AddRange(new object[] { "Cliente", "Empleado", "Administrador", "Proveedor" });
            cmbRol.Location = new Point(160, 186);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(230, 28);
            cmbRol.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(105, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(310, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tienda de Videojuegos";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(45, 100);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(45, 145);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(83, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(45, 190);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 20);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(190, 260);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 35);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(300, 260);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 35);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            ClientSize = new Size(440, 390);
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
            ResumeLayout(false);
            PerformLayout();
        }
    }
}