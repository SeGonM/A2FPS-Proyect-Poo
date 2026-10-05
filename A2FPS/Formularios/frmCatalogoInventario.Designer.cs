namespace A2FPS
{
    partial class frmCatalogoInventario
    {
        private System.ComponentModel.IContainer components = null!;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtCategoria;
        private TextBox txtPlataforma;
        private TextBox txtBuscar;
        private NumericUpDown nudPrecioVenta;
        private NumericUpDown nudPrecioAlquiler;
        private NumericUpDown nudCantidad;
        private ComboBox cmbTipo;
        private ComboBox cmbEstado;
        private DataGridView tblCatalogoInventario;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblTipo;
        private Label lblCategoria;
        private Label lblPlataforma;
        private Label lblPrecioVenta;
        private Label lblPrecioAlquiler;
        private Label lblCantidad;
        private Label lblEstado;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent(){
            components = new System.ComponentModel.Container();
            txtNombre=new TextBox(); txtDescripcion=new TextBox(); txtCategoria=new TextBox(); txtPlataforma=new TextBox(); txtBuscar=new TextBox(); nudPrecioVenta=new NumericUpDown(); nudPrecioAlquiler=new NumericUpDown(); nudCantidad=new NumericUpDown(); cmbTipo=new ComboBox(); cmbEstado=new ComboBox(); tblCatalogoInventario=new DataGridView(); btnRegistrar=new Button(); btnEditar=new Button(); btnEliminar=new Button(); btnBuscar=new Button(); btnLimpiar=new Button(); lblNombre=new Label(); lblDescripcion=new Label(); lblTipo=new Label(); lblCategoria=new Label(); lblPlataforma=new Label(); lblPrecioVenta=new Label(); lblPrecioAlquiler=new Label(); lblCantidad=new Label(); lblEstado=new Label();
            Text="Catálogo e inventario"; Name="frmCatalogoInventario"; ClientSize=new Size(1050,620); StartPosition=FormStartPosition.CenterParent;
            lblNombre.Text="Nombre"; lblNombre.Location=new Point(24,18); lblNombre.AutoSize=true; txtNombre.Name="txtNombre"; txtNombre.Location=new Point(24,40); txtNombre.Size=new Size(180,27); lblDescripcion.Text="Descripción"; lblDescripcion.Location=new Point(220,18); lblDescripcion.AutoSize=true; txtDescripcion.Name="txtDescripcion"; txtDescripcion.Location=new Point(220,40); txtDescripcion.Size=new Size(180,27); lblTipo.Text="Tipo"; lblTipo.Location=new Point(416,18); lblTipo.AutoSize=true; cmbTipo.Name="cmbTipo"; cmbTipo.Location=new Point(416,40); cmbTipo.Size=new Size(150,28); cmbTipo.DropDownStyle=ComboBoxStyle.DropDownList; cmbTipo.Items.Add("Videojuego"); cmbTipo.Items.Add("Consola"); cmbTipo.SelectedIndex=0; lblCategoria.Text="Categoría"; lblCategoria.Location=new Point(582,18); lblCategoria.AutoSize=true; txtCategoria.Name="txtCategoria"; txtCategoria.Location=new Point(582,40); txtCategoria.Size=new Size(150,27); lblPlataforma.Text="Plataforma"; lblPlataforma.Location=new Point(748,18); lblPlataforma.AutoSize=true; txtPlataforma.Name="txtPlataforma"; txtPlataforma.Location=new Point(748,40); txtPlataforma.Size=new Size(180,27);
            lblPrecioVenta.Text="Precio venta"; lblPrecioVenta.Location=new Point(24,85); lblPrecioVenta.AutoSize=true; nudPrecioVenta.Name="nudPrecioVenta"; nudPrecioVenta.Location=new Point(24,107); nudPrecioVenta.Maximum=1000000; lblPrecioAlquiler.Text="Precio txtAlquiler"; lblPrecioAlquiler.Location=new Point(180,85); lblPrecioAlquiler.AutoSize=true; nudPrecioAlquiler.Name="nudPrecioAlquiler"; nudPrecioAlquiler.Location=new Point(180,107); nudPrecioAlquiler.Maximum=1000000; lblCantidad.Text="Cantidad"; lblCantidad.Location=new Point(336,85); lblCantidad.AutoSize=true; nudCantidad.Name="nudCantidad"; nudCantidad.Location=new Point(336,107); nudCantidad.Maximum=100000; lblEstado.Text="Estado"; lblEstado.Location=new Point(492,85); lblEstado.AutoSize=true; cmbEstado.Name="cmbEstado"; cmbEstado.Location=new Point(492,107); cmbEstado.Size=new Size(150,28); cmbEstado.DropDownStyle=ComboBoxStyle.DropDownList; cmbEstado.Items.Add("Disponible"); cmbEstado.Items.Add("Alquilado"); cmbEstado.Items.Add("Reservado"); cmbEstado.SelectedIndex=0;
            btnRegistrar.Text="Registrar"; btnRegistrar.Location=new Point(680,105); btnRegistrar.Size=new Size(85,30); btnEditar.Text="Editar"; btnEditar.Location=new Point(775,105); btnEditar.Size=new Size(75,30); btnEliminar.Text="Eliminar"; btnEliminar.Location=new Point(860,105); btnEliminar.Size=new Size(75,30); txtBuscar.Name="txtBuscar"; txtBuscar.Location=new Point(24,150); txtBuscar.Size=new Size(250,27); btnBuscar.Text="Buscar"; btnBuscar.Location=new Point(285,148); btnBuscar.Size=new Size(80,30); btnLimpiar.Text="Limpiar"; btnLimpiar.Location=new Point(375,148); btnLimpiar.Size=new Size(80,30);
            tblCatalogoInventario.Name="tblCatalogoInventario"; tblCatalogoInventario.Location=new Point(24,195); tblCatalogoInventario.Size=new Size(921,380); tblCatalogoInventario.ReadOnly=true; tblCatalogoInventario.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; tblCatalogoInventario.Columns.Add("Id","Id"); tblCatalogoInventario.Columns.Add("Nombre","Nombre"); tblCatalogoInventario.Columns.Add("Descripcion","Descripción"); tblCatalogoInventario.Columns.Add("Tipo","Tipo"); tblCatalogoInventario.Columns.Add("Categoria","Categoría"); tblCatalogoInventario.Columns.Add("Plataforma","Plataforma"); tblCatalogoInventario.Columns.Add("PrecioVenta","Precio venta"); tblCatalogoInventario.Columns.Add("PrecioAlquiler","Precio txtAlquiler"); tblCatalogoInventario.Columns.Add("Cantidad","Cantidad"); tblCatalogoInventario.Columns.Add("Estado","Estado"); Controls.Add(lblNombre); Controls.Add(txtNombre); Controls.Add(lblDescripcion); Controls.Add(txtDescripcion); Controls.Add(lblTipo); Controls.Add(cmbTipo); Controls.Add(lblCategoria); Controls.Add(txtCategoria); Controls.Add(lblPlataforma); Controls.Add(txtPlataforma); Controls.Add(lblPrecioVenta); Controls.Add(nudPrecioVenta); Controls.Add(lblPrecioAlquiler); Controls.Add(nudPrecioAlquiler); Controls.Add(lblCantidad); Controls.Add(nudCantidad); Controls.Add(lblEstado); Controls.Add(cmbEstado); Controls.Add(btnRegistrar); Controls.Add(btnEditar); Controls.Add(btnEliminar); Controls.Add(txtBuscar); Controls.Add(btnBuscar); Controls.Add(btnLimpiar); Controls.Add(tblCatalogoInventario);
            SuspendLayout(); ResumeLayout(false);
        }
    }
}