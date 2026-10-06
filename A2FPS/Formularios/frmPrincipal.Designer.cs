namespace A2FPS
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null!;
        private Panel pnlMenu;
        private Panel pnlContenido;
        private Label lblBienvenida;
        private Label lblDescripcion;
        private Button btnClientes;
        private Button btnCatalogo;
        private Button btnAlquileres;
        private Button btnDevoluciones;
        private Button btnMultas;
        private Button btnProveedores;
        private Button btnVentas;
        private Button btnGraficos;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnClientes = new Button();
            btnCatalogo = new Button();
            btnAlquileres = new Button();
            btnDevoluciones = new Button();
            btnMultas = new Button();
            btnProveedores = new Button();
            btnVentas = new Button();
            btnGraficos = new Button();
            pnlContenido = new Panel();
            lblBienvenida = new Label();
            lblDescripcion = new Label();
            pictureBox1 = new PictureBox();
            pnlMenu.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Black;
            pnlMenu.Controls.Add(btnClientes);
            pnlMenu.Controls.Add(btnCatalogo);
            pnlMenu.Controls.Add(btnAlquileres);
            pnlMenu.Controls.Add(btnDevoluciones);
            pnlMenu.Controls.Add(btnMultas);
            pnlMenu.Controls.Add(btnProveedores);
            pnlMenu.Controls.Add(btnVentas);
            pnlMenu.Controls.Add(btnGraficos);
            pnlMenu.Dock = DockStyle.Bottom;
            pnlMenu.Location = new Point(0, 115);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(900, 455);
            pnlMenu.TabIndex = 1;
            // 
            // btnClientes
            // 
            btnClientes.ForeColor = SystemColors.Control;
            btnClientes.Location = new Point(21, 105);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(194, 35);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            // 
            // btnCatalogo
            // 
            btnCatalogo.ForeColor = SystemColors.Control;
            btnCatalogo.Location = new Point(21, 145);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(194, 35);
            btnCatalogo.TabIndex = 2;
            btnCatalogo.Text = "Catálogo e inventario";
            // 
            // btnAlquileres
            // 
            btnAlquileres.ForeColor = SystemColors.Control;
            btnAlquileres.Location = new Point(21, 185);
            btnAlquileres.Name = "btnAlquileres";
            btnAlquileres.Size = new Size(194, 35);
            btnAlquileres.TabIndex = 3;
            btnAlquileres.Text = "Alquileres";
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.ForeColor = SystemColors.Control;
            btnDevoluciones.Location = new Point(21, 225);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(194, 35);
            btnDevoluciones.TabIndex = 4;
            btnDevoluciones.Text = "Devoluciones";
            // 
            // btnMultas
            // 
            btnMultas.ForeColor = SystemColors.Control;
            btnMultas.Location = new Point(21, 265);
            btnMultas.Name = "btnMultas";
            btnMultas.Size = new Size(194, 35);
            btnMultas.TabIndex = 5;
            btnMultas.Text = "Multas";
            // 
            // btnProveedores
            // 
            btnProveedores.ForeColor = SystemColors.Control;
            btnProveedores.Location = new Point(21, 305);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(194, 35);
            btnProveedores.TabIndex = 6;
            btnProveedores.Text = "Proveedores";
            // 
            // btnVentas
            // 
            btnVentas.ForeColor = SystemColors.Control;
            btnVentas.Location = new Point(21, 345);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(194, 35);
            btnVentas.TabIndex = 7;
            btnVentas.Text = "Ventas";
            // 
            // btnGraficos
            // 
            btnGraficos.ForeColor = SystemColors.Control;
            btnGraficos.Location = new Point(21, 385);
            btnGraficos.Name = "btnGraficos";
            btnGraficos.Size = new Size(194, 35);
            btnGraficos.TabIndex = 8;
            btnGraficos.Text = "Gráficos";
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(lblBienvenida);
            pnlContenido.Controls.Add(lblDescripcion);
            pnlContenido.Location = new Point(230, 115);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(670, 455);
            pnlContenido.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBienvenida.Location = new Point(45, 55);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(204, 47);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(48, 115);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(263, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Seleccione una opción del menú para comenzar.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BANNER;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            ClientSize = new Size(900, 570);
            Controls.Add(pictureBox1);
            Controls.Add(pnlContenido);
            Controls.Add(pnlMenu);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A2 FPS | Panel principal";
            pnlMenu.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
    }
}