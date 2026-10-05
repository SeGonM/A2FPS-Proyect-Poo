namespace A2FPS
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            btnRegistrar.Click += (_, _) => Preparar("Registrar venta");
            btnBuscar.Click += (_, _) => Preparar("Buscar venta");
            btnLimpiar.Click += (_, _) => LimpiarCampos();
        }

        private void Preparar(string accion) => MessageBox.Show($"{accion}: preparado para conectar con SQL Server.", "A2 FPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void LimpiarCampos() { txtCliente.Clear(); txtProducto.Clear(); txtBuscar.Clear(); nudCantidad.Value = 0; nudPrecioUnitario.Value = 0; dtpFechaVenta.Value = DateTime.Today; }
    }
}