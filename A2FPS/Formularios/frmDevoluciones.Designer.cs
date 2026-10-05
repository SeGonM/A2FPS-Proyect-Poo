namespace A2FPS
{
    partial class frmDevoluciones
    {
        private System.ComponentModel.IContainer components = null!;
        private TextBox txtBuscar;
        private TextBox txtAlquiler;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtDiasRetraso;
        private DateTimePicker dtpFechaDevolucionPrevista;
        private DateTimePicker dtpFechaReal;
        private Button btnBuscar;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label lblBuscar;
        private Label lblCliente;
        private Label lblProducto;
        private Label lblFechaDevolucionPrevista;
        private Label lblFechaReal;
        private Label lblDiasRetraso;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent(){
            components = new System.ComponentModel.Container();
            txtBuscar=new TextBox(); txtAlquiler=new TextBox(); txtCliente=new TextBox(); txtProducto=new TextBox(); txtDiasRetraso=new TextBox(); dtpFechaDevolucionPrevista=new DateTimePicker(); dtpFechaReal=new DateTimePicker(); btnBuscar=new Button(); btnRegistrar=new Button(); btnLimpiar=new Button(); lblBuscar=new Label(); lblCliente=new Label(); lblProducto=new Label(); lblFechaDevolucionPrevista=new Label(); lblFechaReal=new Label(); lblDiasRetraso=new Label(); Text="Devoluciones"; Name="frmDevoluciones"; ClientSize=new Size(650,400); StartPosition=FormStartPosition.CenterParent;
            lblBuscar.Text="Buscar txtAlquiler"; lblBuscar.Location=new Point(24,20); lblBuscar.AutoSize=true; txtBuscar.Location=new Point(24,42); txtBuscar.Size=new Size(250,27); btnBuscar.Text="Buscar"; btnBuscar.Location=new Point(285,40); btnBuscar.Size=new Size(80,30); lblCliente.Text="Cliente"; lblCliente.Location=new Point(24,90); lblCliente.AutoSize=true; txtCliente.Location=new Point(24,112); txtCliente.Size=new Size(250,27); txtCliente.ReadOnly=true; lblProducto.Text="Producto"; lblProducto.Location=new Point(300,90); lblProducto.AutoSize=true; txtProducto.Location=new Point(300,112); txtProducto.Size=new Size(250,27); txtProducto.ReadOnly=true; lblFechaDevolucionPrevista.Text="Fecha prevista"; lblFechaDevolucionPrevista.Location=new Point(24,160); lblFechaDevolucionPrevista.AutoSize=true; dtpFechaDevolucionPrevista.Location=new Point(24,182); lblFechaReal.Text="Fecha real"; lblFechaReal.Location=new Point(300,160); lblFechaReal.AutoSize=true; dtpFechaReal.Location=new Point(300,182); lblDiasRetraso.Text="Días de txtDiasRetraso"; lblDiasRetraso.Location=new Point(24,235); lblDiasRetraso.AutoSize=true; txtDiasRetraso.Location=new Point(24,257); txtDiasRetraso.Size=new Size(120,27); txtDiasRetraso.ReadOnly=true; btnRegistrar.Text="Registrar"; btnRegistrar.Location=new Point(350,280); btnRegistrar.Size=new Size(90,30); btnLimpiar.Text="Limpiar"; btnLimpiar.Location=new Point(450,280); btnLimpiar.Size=new Size(90,30); Controls.Add(lblBuscar); Controls.Add(txtBuscar); Controls.Add(btnBuscar); Controls.Add(lblCliente); Controls.Add(txtCliente); Controls.Add(lblProducto); Controls.Add(txtProducto); Controls.Add(lblFechaDevolucionPrevista); Controls.Add(dtpFechaDevolucionPrevista); Controls.Add(lblFechaReal); Controls.Add(dtpFechaReal); Controls.Add(lblDiasRetraso); Controls.Add(txtDiasRetraso); Controls.Add(btnRegistrar); Controls.Add(btnLimpiar);
            SuspendLayout(); ResumeLayout(false);
        }
    }
}