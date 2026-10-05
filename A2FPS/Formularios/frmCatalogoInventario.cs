namespace A2FPS
{
    public partial class frmCatalogoInventario : Form
    {
        public frmCatalogoInventario()
        {
            InitializeComponent();
            btnRegistrar.Click += (_, _) => Preparar("Registrar producto");
            btnEditar.Click += (_, _) => Preparar("Editar producto");
            btnEliminar.Click += (_, _) => Preparar("Eliminar producto");
            btnBuscar.Click += (_, _) => Preparar("Buscar producto");
            btnLimpiar.Click += (_, _) => LimpiarCampos();
        }

        private void Preparar(string accion) => MessageBox.Show($"{accion}: preparado para conectar con SQL Server.", "A2 FPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void LimpiarCampos() { txtNombre.Clear(); txtDescripcion.Clear(); txtCategoria.Clear(); txtPlataforma.Clear(); txtBuscar.Clear(); nudPrecioVenta.Value = 0; nudPrecioAlquiler.Value = 0; nudCantidad.Value = 0; cmbTipo.SelectedIndex = 0; cmbEstado.SelectedIndex = 0; }
    }
}