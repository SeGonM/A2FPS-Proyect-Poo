namespace A2FPS
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null!;
        private Panel pnlMenu;
        private Panel pnlContenido;
        private Label lblTitulo;
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
        private void InitializeComponent(){
            components = new System.ComponentModel.Container();
            pnlMenu=new Panel(); pnlContenido=new Panel(); lblTitulo=new Label(); lblBienvenida=new Label(); lblDescripcion=new Label(); btnClientes=new Button(); btnCatalogo=new Button(); btnAlquileres=new Button(); btnDevoluciones=new Button(); btnMultas=new Button(); btnProveedores=new Button(); btnVentas=new Button(); btnGraficos=new Button(); Text="A2 FPS | Panel principal"; Name="frmPrincipal"; ClientSize=new Size(900,570); StartPosition=FormStartPosition.CenterScreen;
            pnlMenu.BackColor=Color.FromArgb(35,47,62); pnlMenu.Location=new Point(0,0); pnlMenu.Size=new Size(230,570); lblTitulo.Text="A2 FPS"; lblTitulo.ForeColor=Color.White; lblTitulo.Font=new Font("Segoe UI",20F,FontStyle.Bold); lblTitulo.Location=new Point(70,20); lblTitulo.AutoSize=true; btnClientes.Text="Clientes"; btnClientes.Location=new Point(18,80); btnClientes.Size=new Size(194,35); btnCatalogo.Text="Catálogo e inventario"; btnCatalogo.Location=new Point(18,120); btnCatalogo.Size=new Size(194,35); btnAlquileres.Text="Alquileres"; btnAlquileres.Location=new Point(18,160); btnAlquileres.Size=new Size(194,35); btnDevoluciones.Text="Devoluciones"; btnDevoluciones.Location=new Point(18,200); btnDevoluciones.Size=new Size(194,35); btnMultas.Text="Multas"; btnMultas.Location=new Point(18,240); btnMultas.Size=new Size(194,35); btnProveedores.Text="Proveedores"; btnProveedores.Location=new Point(18,280); btnProveedores.Size=new Size(194,35); btnVentas.Text="Ventas"; btnVentas.Location=new Point(18,320); btnVentas.Size=new Size(194,35); btnGraficos.Text="Gráficos"; btnGraficos.Location=new Point(18,360); btnGraficos.Size=new Size(194,35); pnlMenu.Controls.Add(lblTitulo); pnlMenu.Controls.Add(btnClientes); pnlMenu.Controls.Add(btnCatalogo); pnlMenu.Controls.Add(btnAlquileres); pnlMenu.Controls.Add(btnDevoluciones); pnlMenu.Controls.Add(btnMultas); pnlMenu.Controls.Add(btnProveedores); pnlMenu.Controls.Add(btnVentas); pnlMenu.Controls.Add(btnGraficos);
            pnlContenido.Location=new Point(230,0); pnlContenido.Size=new Size(670,570); lblBienvenida.Text="Bienvenido"; lblBienvenida.Font=new Font("Segoe UI",26F,FontStyle.Bold); lblBienvenida.Location=new Point(45,55); lblBienvenida.AutoSize=true; lblDescripcion.Text="Seleccione una opción del menú para comenzar."; lblDescripcion.Location=new Point(48,115); lblDescripcion.AutoSize=true; pnlContenido.Controls.Add(lblBienvenida); pnlContenido.Controls.Add(lblDescripcion); Controls.Add(pnlContenido); Controls.Add(pnlMenu);
            SuspendLayout(); ResumeLayout(false);
        }
    }
}