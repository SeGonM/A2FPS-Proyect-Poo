namespace A2FPS
{
    public partial class frmAlquileres : Form
    {
        public frmAlquileres()
        {
            InitializeComponent();
            btnRegistrar.Click += (_, _) => Preparar("Registrar alquiler");
            btnBuscar.Click += (_, _) => Preparar("Buscar alquiler");
            btnLimpiar.Click += (_, _) => LimpiarCampos();
        }

        private void Preparar(string accion) => MessageBox.Show($"{accion}: preparado para conectar con SQL Server.", "A2 FPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void LimpiarCampos() { txtCliente.Clear(); txtProducto.Clear(); txtBuscar.Clear(); dtpFechaInicio.Value = DateTime.Today; dtpFechaDevolucionPrevista.Value = DateTime.Today; }
    }
}