namespace A2FPS
{
    public partial class frmMultas : Form
    {
        public frmMultas()
        {
            InitializeComponent();
            btnRegistrar.Click += (_, _) => Preparar("Registrar multa");
            btnBuscar.Click += (_, _) => Preparar("Buscar multa");
            btnEditar.Click += (_, _) => Preparar("Editar multa");
            btnLimpiar.Click += (_, _) => LimpiarCampos();
        }

        private void Preparar(string accion) => MessageBox.Show($"{accion}: preparado para conectar con SQL Server.", "A2 FPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void LimpiarCampos() { txtAlquiler.Clear(); txtDiasRetraso.Clear(); txtMotivo.Clear(); txtBuscar.Clear(); nudValor.Value = 0; cmbEstado.SelectedIndex = 0; }
    }
}