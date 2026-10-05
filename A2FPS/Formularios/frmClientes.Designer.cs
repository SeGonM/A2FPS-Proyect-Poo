namespace A2FPS
{
    partial class frmClientes
    {
        private System.ComponentModel.IContainer components = null!;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtBuscar;
        private Label lblNombre;
        private Label lblDocumento;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblBuscar;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private DataGridView tblClientes;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNombre = new TextBox(); txtDocumento = new TextBox(); txtTelefono = new TextBox(); txtCorreo = new TextBox(); txtBuscar = new TextBox(); lblNombre = new Label(); lblDocumento = new Label(); lblTelefono = new Label(); lblCorreo = new Label(); lblBuscar = new Label(); btnRegistrar = new Button(); btnEditar = new Button(); btnEliminar = new Button(); btnBuscar = new Button(); btnLimpiar = new Button(); tblClientes = new DataGridView();
            Text = "Clientes"; Name = "frmClientes"; StartPosition = FormStartPosition.CenterParent; ClientSize = new Size(900, 560);
            lblNombre.Text = "Nombre"; lblNombre.Location = new Point(24, 20); lblNombre.AutoSize = true; txtNombre.Name = "txtNombre"; txtNombre.Location = new Point(24, 42); txtNombre.Size = new Size(190, 27); lblDocumento.Text = "Documento"; lblDocumento.Location = new Point(230, 20); lblDocumento.AutoSize = true; txtDocumento.Name = "txtDocumento"; txtDocumento.Location = new Point(230, 42); txtDocumento.Size = new Size(190, 27); lblTelefono.Text = "Teléfono"; lblTelefono.Location = new Point(436, 20); lblTelefono.AutoSize = true; txtTelefono.Name = "txtTelefono"; txtTelefono.Location = new Point(436, 42); txtTelefono.Size = new Size(190, 27); lblCorreo.Text = "Correo"; lblCorreo.Location = new Point(642, 20); lblCorreo.AutoSize = true; txtCorreo.Name = "txtCorreo"; txtCorreo.Location = new Point(642, 42); txtCorreo.Size = new Size(210, 27);
            lblBuscar.Text = "Buscar"; lblBuscar.Location = new Point(24, 90); lblBuscar.AutoSize = true; txtBuscar.Name = "txtBuscar"; txtBuscar.Location = new Point(80, 86); txtBuscar.Size = new Size(230, 27); btnBuscar.Name = "btnBuscar"; btnBuscar.Text = "Buscar"; btnBuscar.Location = new Point(320, 84); btnBuscar.Size = new Size(80, 30); btnRegistrar.Name = "btnRegistrar"; btnRegistrar.Text = "Registrar"; btnRegistrar.Location = new Point(500, 84); btnRegistrar.Size = new Size(85, 30); btnEditar.Name = "btnEditar"; btnEditar.Text = "Editar"; btnEditar.Location = new Point(590, 84); btnEditar.Size = new Size(80, 30); btnEliminar.Name = "btnEliminar"; btnEliminar.Text = "Eliminar"; btnEliminar.Location = new Point(675, 84); btnEliminar.Size = new Size(85, 30); btnLimpiar.Name = "btnLimpiar"; btnLimpiar.Text = "Limpiar"; btnLimpiar.Location = new Point(765, 84); btnLimpiar.Size = new Size(85, 30);
            tblClientes.Name = "tblClientes"; tblClientes.Location = new Point(24, 135); tblClientes.Size = new Size(826, 380); tblClientes.ReadOnly = true; tblClientes.AllowUserToAddRows = false; tblClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; tblClientes.Columns.Add("Id", "Id"); tblClientes.Columns.Add("Nombre", "Nombre"); tblClientes.Columns.Add("Documento", "Documento"); tblClientes.Columns.Add("Telefono", "Teléfono"); tblClientes.Columns.Add("Correo", "Correo");
            Controls.Add(lblNombre); Controls.Add(txtNombre); Controls.Add(lblDocumento); Controls.Add(txtDocumento); Controls.Add(lblTelefono); Controls.Add(txtTelefono); Controls.Add(lblCorreo); Controls.Add(txtCorreo); Controls.Add(lblBuscar); Controls.Add(txtBuscar); Controls.Add(btnBuscar); Controls.Add(btnRegistrar); Controls.Add(btnEditar); Controls.Add(btnEliminar); Controls.Add(btnLimpiar); Controls.Add(tblClientes);
            SuspendLayout();
            ResumeLayout(false);
        }
    }
}