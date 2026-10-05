namespace A2FPS
{
    public partial class frmPrincipal : Form
    {
        private readonly string rol;

        public frmPrincipal(string rol = "Administrador")
        {
            this.rol = rol;
            InitializeComponent();
            btnClientes.Click += (_, _) => AbrirFormulario<frmClientes>();
            btnCatalogo.Click += (_, _) => AbrirFormulario<frmCatalogoInventario>();
            btnAlquileres.Click += (_, _) => AbrirFormulario<frmAlquileres>();
            btnDevoluciones.Click += (_, _) => AbrirFormulario<frmDevoluciones>();
            btnMultas.Click += (_, _) => AbrirFormulario<frmMultas>();
            btnProveedores.Click += (_, _) => AbrirFormulario<frmProveedores>();
            btnVentas.Click += (_, _) => AbrirFormulario<frmVentas>();
            btnGraficos.Click += (_, _) => AbrirFormulario<frmGraficos>();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            using (var formulario = new T())
            {
                formulario.ShowDialog(this);
            }
        }
    }
}