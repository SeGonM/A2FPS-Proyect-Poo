namespace A2FPS
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            btnRegistrar.Click += (_, _) => Preparar("Registrar proveedor");
            btnEditar.Click += (_, _) => Preparar("Editar proveedor");
            btnEliminar.Click += (_, _) => Preparar("Eliminar proveedor");
            btnBuscar.Click += (_, _) => Preparar("Buscar proveedor");
            btnLimpiar.Click += (_, _) => LimpiarCampos();
        }

        private void Preparar(string accion) => MessageBox.Show($"{accion}: preparado para conectar con SQL Server.", "A2 FPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void LimpiarCampos() { txtNombre.Clear(); txtTelefono.Clear(); txtCorreo.Clear(); txtProducto.Clear(); txtBuscar.Clear(); nudCantidad.Value = 0; dtpFechaSuministro.Value = DateTime.Today; }
    }
}