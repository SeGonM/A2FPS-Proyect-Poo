namespace A2FPS
{
    partial class frmProveedores
    {
        private System.ComponentModel.IContainer components = null!;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtProducto;
        private TextBox txtBuscar;
        private NumericUpDown nudCantidad;
        private DateTimePicker dtpFechaSuministro;
        private DataGridView tblProveedores;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblFechaSuministro;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent(){
            components = new System.ComponentModel.Container();
            txtNombre=new TextBox(); txtTelefono=new TextBox(); txtCorreo=new TextBox(); txtProducto=new TextBox(); txtBuscar=new TextBox(); nudCantidad=new NumericUpDown(); dtpFechaSuministro=new DateTimePicker(); tblProveedores=new DataGridView(); btnRegistrar=new Button(); btnEditar=new Button(); btnEliminar=new Button(); btnBuscar=new Button(); btnLimpiar=new Button(); lblNombre=new Label(); lblTelefono=new Label(); lblCorreo=new Label(); lblProducto=new Label(); lblCantidad=new Label(); lblFechaSuministro=new Label(); Text="Proveedores"; Name="frmProveedores"; ClientSize=new Size(1000,570); StartPosition=FormStartPosition.CenterParent;
            lblNombre.Text="Nombre"; lblNombre.Location=new Point(24,20); lblNombre.AutoSize=true; txtNombre.Location=new Point(24,42); txtNombre.Size=new Size(200,27); lblTelefono.Text="Teléfono"; lblTelefono.Location=new Point(245,20); lblTelefono.AutoSize=true; txtTelefono.Location=new Point(245,42); txtTelefono.Size=new Size(170,27); lblCorreo.Text="Correo"; lblCorreo.Location=new Point(436,20); lblCorreo.AutoSize=true; txtCorreo.Location=new Point(436,42); txtCorreo.Size=new Size(200,27); lblProducto.Text="Producto"; lblProducto.Location=new Point(24,85); lblProducto.AutoSize=true; txtProducto.Location=new Point(24,107); txtProducto.Size=new Size(200,27); lblCantidad.Text="Cantidad suministrada"; lblCantidad.Location=new Point(245,85); lblCantidad.AutoSize=true; nudCantidad.Location=new Point(245,107); nudCantidad.Maximum=100000; lblFechaSuministro.Text="Fecha"; lblFechaSuministro.Location=new Point(436,85); lblFechaSuministro.AutoSize=true; dtpFechaSuministro.Location=new Point(436,107); txtBuscar.Location=new Point(24,155); txtBuscar.Size=new Size(240,27); btnBuscar.Text="Buscar"; btnBuscar.Location=new Point(275,153); btnBuscar.Size=new Size(80,30); btnRegistrar.Text="Registrar"; btnRegistrar.Location=new Point(500,153); btnRegistrar.Size=new Size(85,30); btnEditar.Text="Editar"; btnEditar.Location=new Point(590,153); btnEditar.Size=new Size(75,30); btnEliminar.Text="Eliminar"; btnEliminar.Location=new Point(675,153); btnEliminar.Size=new Size(85,30); btnLimpiar.Text="Limpiar"; btnLimpiar.Location=new Point(770,153); btnLimpiar.Size=new Size(80,30); tblProveedores.Location=new Point(24,205); tblProveedores.Size=new Size(920,330); tblProveedores.ReadOnly=true; tblProveedores.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; tblProveedores.Columns.Add("Id","Id"); tblProveedores.Columns.Add("Proveedor","Proveedor"); tblProveedores.Columns.Add("Telefono","Teléfono"); tblProveedores.Columns.Add("Correo","Correo"); tblProveedores.Columns.Add("Producto","Producto"); tblProveedores.Columns.Add("Cantidad","Cantidad"); tblProveedores.Columns.Add("Fecha","Fecha"); Controls.Add(lblNombre); Controls.Add(txtNombre); Controls.Add(lblTelefono); Controls.Add(txtTelefono); Controls.Add(lblCorreo); Controls.Add(txtCorreo); Controls.Add(lblProducto); Controls.Add(txtProducto); Controls.Add(lblCantidad); Controls.Add(nudCantidad); Controls.Add(lblFechaSuministro); Controls.Add(dtpFechaSuministro); Controls.Add(txtBuscar); Controls.Add(btnBuscar); Controls.Add(btnRegistrar); Controls.Add(btnEditar); Controls.Add(btnEliminar); Controls.Add(btnLimpiar); Controls.Add(tblProveedores);
            SuspendLayout(); ResumeLayout(false);
        }
    }
}