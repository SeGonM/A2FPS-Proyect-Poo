namespace A2FPS
{
    partial class frmMultas
    {
        private System.ComponentModel.IContainer components = null!;
        private TextBox txtAlquiler;
        private TextBox txtDiasRetraso;
        private TextBox txtMotivo;
        private TextBox txtBuscar;
        private NumericUpDown nudValor;
        private ComboBox cmbEstado;
        private DataGridView tblMultas;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnLimpiar;
        private Label lblPrecioAlquiler;
        private Label lblRetraso;
        private Label lblMotivo;
        private Label lblValor;
        private Label lblEstado;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent(){
            components = new System.ComponentModel.Container();
            txtAlquiler=new TextBox(); txtDiasRetraso=new TextBox(); txtMotivo=new TextBox(); txtBuscar=new TextBox(); nudValor=new NumericUpDown(); cmbEstado=new ComboBox(); tblMultas=new DataGridView(); btnRegistrar=new Button(); btnBuscar=new Button(); btnEditar=new Button(); btnLimpiar=new Button(); lblPrecioAlquiler=new Label(); lblRetraso=new Label(); lblMotivo=new Label(); lblValor=new Label(); lblEstado=new Label(); Text="Multas"; Name="frmMultas"; ClientSize=new Size(900,560); StartPosition=FormStartPosition.CenterParent;
            lblPrecioAlquiler.Text="Alquiler"; lblPrecioAlquiler.Location=new Point(24,20); lblPrecioAlquiler.AutoSize=true; txtAlquiler.Location=new Point(24,42); txtAlquiler.Size=new Size(150,27); lblRetraso.Text="Días de txtDiasRetraso"; lblRetraso.Location=new Point(190,20); lblRetraso.AutoSize=true; txtDiasRetraso.Location=new Point(190,42); txtDiasRetraso.Size=new Size(120,27); lblMotivo.Text="Motivo"; lblMotivo.Location=new Point(326,20); lblMotivo.AutoSize=true; txtMotivo.Location=new Point(326,42); txtMotivo.Size=new Size(180,27); lblValor.Text="Valor"; lblValor.Location=new Point(522,20); lblValor.AutoSize=true; nudValor.Location=new Point(522,42); nudValor.Maximum=1000000; lblEstado.Text="Estado"; lblEstado.Location=new Point(658,20); lblEstado.AutoSize=true; cmbEstado.Location=new Point(658,42); cmbEstado.Size=new Size(150,28); cmbEstado.DropDownStyle=ComboBoxStyle.DropDownList; cmbEstado.Items.Add("Pendiente"); cmbEstado.Items.Add("Pagada"); cmbEstado.Items.Add("Anulada"); cmbEstado.SelectedIndex=0; txtBuscar.Location=new Point(24,95); txtBuscar.Size=new Size(240,27); btnBuscar.Text="Buscar"; btnBuscar.Location=new Point(275,93); btnBuscar.Size=new Size(80,30); btnRegistrar.Text="Registrar"; btnRegistrar.Location=new Point(500,93); btnRegistrar.Size=new Size(85,30); btnEditar.Text="Editar"; btnEditar.Location=new Point(590,93); btnEditar.Size=new Size(75,30); btnLimpiar.Text="Limpiar"; btnLimpiar.Location=new Point(675,93); btnLimpiar.Size=new Size(80,30); tblMultas.Location=new Point(24,145); tblMultas.Size=new Size(831,350); tblMultas.ReadOnly=true; tblMultas.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; tblMultas.Columns.Add("Id","Id"); tblMultas.Columns.Add("Alquiler","Alquiler"); tblMultas.Columns.Add("Retraso","Días de txtDiasRetraso"); tblMultas.Columns.Add("Motivo","Motivo"); tblMultas.Columns.Add("Valor","Valor"); tblMultas.Columns.Add("Estado","Estado"); Controls.Add(lblPrecioAlquiler); Controls.Add(txtAlquiler); Controls.Add(lblRetraso); Controls.Add(txtDiasRetraso); Controls.Add(lblMotivo); Controls.Add(txtMotivo); Controls.Add(lblValor); Controls.Add(nudValor); Controls.Add(lblEstado); Controls.Add(cmbEstado); Controls.Add(txtBuscar); Controls.Add(btnBuscar); Controls.Add(btnRegistrar); Controls.Add(btnEditar); Controls.Add(btnLimpiar); Controls.Add(tblMultas);
            SuspendLayout(); ResumeLayout(false);
        }
    }
}