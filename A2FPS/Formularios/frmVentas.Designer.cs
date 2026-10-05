namespace A2FPS
{
    partial class frmVentas
    {
        private System.ComponentModel.IContainer components = null!;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtBuscar;
        private NumericUpDown nudCantidad;
        private NumericUpDown nudPrecioUnitario;
        private DateTimePicker dtpFechaVenta;
        private DataGridView tblVentas;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label lblCliente;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblFechaVenta;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent(){
            components = new System.ComponentModel.Container();
            txtCliente=new TextBox(); txtProducto=new TextBox(); txtBuscar=new TextBox(); nudCantidad=new NumericUpDown(); nudPrecioUnitario=new NumericUpDown(); dtpFechaVenta=new DateTimePicker(); tblVentas=new DataGridView(); btnRegistrar=new Button(); btnBuscar=new Button(); btnLimpiar=new Button(); lblCliente=new Label(); lblProducto=new Label(); lblCantidad=new Label(); lblPrecio=new Label(); lblFechaVenta=new Label(); Text="Ventas"; Name="frmVentas"; ClientSize=new Size(1000,570); StartPosition=FormStartPosition.CenterParent;
            lblCliente.Text="Cliente"; lblCliente.Location=new Point(24,20); lblCliente.AutoSize=true; txtCliente.Location=new Point(24,42); txtCliente.Size=new Size(200,27); lblProducto.Text="Producto"; lblProducto.Location=new Point(245,20); lblProducto.AutoSize=true; txtProducto.Location=new Point(245,42); txtProducto.Size=new Size(200,27); lblCantidad.Text="Cantidad"; lblCantidad.Location=new Point(466,20); lblCantidad.AutoSize=true; nudCantidad.Location=new Point(466,42); nudCantidad.Maximum=100000; lblPrecio.Text="Precio unitario"; lblPrecio.Location=new Point(602,20); lblPrecio.AutoSize=true; nudPrecioUnitario.Location=new Point(602,42); nudPrecioUnitario.Maximum=1000000; lblFechaVenta.Text="Fecha"; lblFechaVenta.Location=new Point(24,85); lblFechaVenta.AutoSize=true; dtpFechaVenta.Location=new Point(24,107); txtBuscar.Location=new Point(245,107); txtBuscar.Size=new Size(240,27); btnBuscar.Text="Buscar"; btnBuscar.Location=new Point(500,105); btnBuscar.Size=new Size(80,30); btnRegistrar.Text="Registrar"; btnRegistrar.Location=new Point(700,105); btnRegistrar.Size=new Size(85,30); btnLimpiar.Text="Limpiar"; btnLimpiar.Location=new Point(795,105); btnLimpiar.Size=new Size(80,30); tblVentas.Location=new Point(24,160); tblVentas.Size=new Size(920,350); tblVentas.ReadOnly=true; tblVentas.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; tblVentas.Columns.Add("Id","Id"); tblVentas.Columns.Add("Cliente","Cliente"); tblVentas.Columns.Add("Producto","Producto"); tblVentas.Columns.Add("Cantidad","Cantidad"); tblVentas.Columns.Add("Precio","Precio unitario"); tblVentas.Columns.Add("Fecha","Fecha"); tblVentas.Columns.Add("Total","Total"); Controls.Add(lblCliente); Controls.Add(txtCliente); Controls.Add(lblProducto); Controls.Add(txtProducto); Controls.Add(lblCantidad); Controls.Add(nudCantidad); Controls.Add(lblPrecio); Controls.Add(nudPrecioUnitario); Controls.Add(lblFechaVenta); Controls.Add(dtpFechaVenta); Controls.Add(txtBuscar); Controls.Add(btnBuscar); Controls.Add(btnRegistrar); Controls.Add(btnLimpiar); Controls.Add(tblVentas);
            SuspendLayout(); ResumeLayout(false);
        }
    }
}