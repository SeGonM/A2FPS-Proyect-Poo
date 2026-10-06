namespace A2FPS
{
    partial class frmAlquileres
    {
        private System.ComponentModel.IContainer components = null!;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtBuscar;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaDevolucionPrevista;
        private DataGridView tblAlquileres;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label lblCliente;
        private Label lblProducto;
        private Label lblFechaInicio;
        private Label lblFechaDevolucionPrevista;
        private Label lblBuscar;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            txtBuscar = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaDevolucionPrevista = new DateTimePicker();
            tblAlquileres = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colFechaInicio = new DataGridViewTextBoxColumn();
            colFechaDevolucionPrevista = new DataGridViewTextBoxColumn();
            colDisponibilidad = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblCliente = new Label();
            lblProducto = new Label();
            lblFechaInicio = new Label();
            lblFechaDevolucionPrevista = new Label();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)tblAlquileres).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(24, 42);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(200, 27);
            txtCliente.TabIndex = 1;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(245, 42);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(200, 27);
            txtProducto.TabIndex = 3;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(152, 86);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(230, 27);
            txtBuscar.TabIndex = 9;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(466, 42);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 27);
            dtpFechaInicio.TabIndex = 5;
            // 
            // dtpFechaDevolucionPrevista
            // 
            dtpFechaDevolucionPrevista.Location = new Point(665, 42);
            dtpFechaDevolucionPrevista.Name = "dtpFechaDevolucionPrevista";
            dtpFechaDevolucionPrevista.Size = new Size(200, 27);
            dtpFechaDevolucionPrevista.TabIndex = 7;
            // 
            // tblAlquileres
            // 
            tblAlquileres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblAlquileres.ColumnHeadersHeight = 29;
            tblAlquileres.Columns.AddRange(new DataGridViewColumn[] { colId, colCliente, colProducto, colFechaInicio, colFechaDevolucionPrevista, colDisponibilidad });
            tblAlquileres.Location = new Point(24, 135);
            tblAlquileres.Name = "tblAlquileres";
            tblAlquileres.ReadOnly = true;
            tblAlquileres.RowHeadersWidth = 51;
            tblAlquileres.Size = new Size(856, 370);
            tblAlquileres.TabIndex = 13;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colFechaInicio
            // 
            colFechaInicio.HeaderText = "Fecha inicio";
            colFechaInicio.MinimumWidth = 6;
            colFechaInicio.Name = "colFechaInicio";
            colFechaInicio.ReadOnly = true;
            // 
            // colFechaDevolucionPrevista
            // 
            colFechaDevolucionPrevista.HeaderText = "Devolución prevista";
            colFechaDevolucionPrevista.MinimumWidth = 6;
            colFechaDevolucionPrevista.Name = "colFechaDevolucionPrevista";
            colFechaDevolucionPrevista.ReadOnly = true;
            // 
            // colDisponibilidad
            // 
            colDisponibilidad.HeaderText = "Disponibilidad";
            colDisponibilidad.MinimumWidth = 6;
            colDisponibilidad.Name = "colDisponibilidad";
            colDisponibilidad.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(700, 84);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(90, 30);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(388, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 30);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(800, 84);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(80, 30);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(24, 20);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(245, 20);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(466, 20);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(108, 20);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // lblFechaDevolucionPrevista
            // 
            lblFechaDevolucionPrevista.AutoSize = true;
            lblFechaDevolucionPrevista.Location = new Point(665, 20);
            lblFechaDevolucionPrevista.Name = "lblFechaDevolucionPrevista";
            lblFechaDevolucionPrevista.Size = new Size(140, 20);
            lblFechaDevolucionPrevista.TabIndex = 6;
            lblFechaDevolucionPrevista.Text = "Devolución prevista";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(24, 90);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(125, 20);
            lblBuscar.TabIndex = 8;
            lblBuscar.Text = "Buscar txtAlquiler";
            // 
            // frmAlquileres
            // 
            ClientSize = new Size(950, 560);
            Controls.Add(lblCliente);
            Controls.Add(txtCliente);
            Controls.Add(lblProducto);
            Controls.Add(txtProducto);
            Controls.Add(lblFechaInicio);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFechaDevolucionPrevista);
            Controls.Add(dtpFechaDevolucionPrevista);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLimpiar);
            Controls.Add(tblAlquileres);
            Name = "frmAlquileres";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alquileres";
            ((System.ComponentModel.ISupportInitialize)tblAlquileres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colFechaInicio;
        private DataGridViewTextBoxColumn colFechaDevolucionPrevista;
        private DataGridViewTextBoxColumn colDisponibilidad;
    }
}