namespace A2FPS
{
    public partial class frmDevoluciones : Form
    {
        public frmDevoluciones()
        {
            InitializeComponent();
            btnBuscar.Click += (_, _) => Preparar("Buscar alquiler");
            btnRegistrar.Click += (_, _) => Preparar("Registrar devolución");
            btnLimpiar.Click += (_, _) => LimpiarCampos();
        }

        private void Preparar(string accion) => MessageBox.Show($"{accion}: preparado para conectar con SQL Server.", "A2 FPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void LimpiarCampos() { txtBuscar.Clear(); txtAlquiler.Clear(); txtCliente.Clear(); txtProducto.Clear(); txtDiasRetraso.Clear(); dtpFechaDevolucionPrevista.Value = DateTime.Today; dtpFechaReal.Value = DateTime.Today; }
    }
}