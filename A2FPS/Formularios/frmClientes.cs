namespace A2FPS
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            btnRegistrar.Click += (_, _) => MostrarPreparacion("Registrar cliente");
            btnEditar.Click += (_, _) => MostrarPreparacion("Editar cliente");
            btnEliminar.Click += (_, _) => MostrarPreparacion("Eliminar cliente");
            btnBuscar.Click += (_, _) => MostrarPreparacion("Buscar cliente");
            btnLimpiar.Click += (_, _) => LimpiarCampos();
        }

        private void MostrarPreparacion(string accion) => MessageBox.Show($"{accion}: preparado para conectar con SQL Server.", "A2 FPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void LimpiarCampos() { txtNombre.Clear(); txtDocumento.Clear(); txtTelefono.Clear(); txtCorreo.Clear(); txtBuscar.Clear(); }
    }
}