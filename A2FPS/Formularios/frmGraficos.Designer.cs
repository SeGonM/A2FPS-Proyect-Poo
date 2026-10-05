namespace A2FPS
{
    partial class frmGraficos
    {
        private System.ComponentModel.IContainer components = null!;
        private Panel pnlVentas;
        private Panel pnlAlquileres;
        private Label lblVentas;
        private Label lblAlquileres;
        private Label lblAlquileresInfo;
        protected override void Dispose(bool disposing){if(disposing&&components!=null)components.Dispose();base.Dispose(disposing);}
        private void InitializeComponent()
        {
            pnlVentas = new Panel();
            pnlAlquileres = new Panel();
            lblAlquileresInfo = new Label();
            lblVentas = new Label();
            lblAlquileres = new Label();
            pnlAlquileres.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVentas
            // 
            pnlVentas.BorderStyle = BorderStyle.FixedSingle;
            pnlVentas.Location = new Point(30, 70);
            pnlVentas.Name = "pnlVentas";
            pnlVentas.Size = new Size(350, 360);
            pnlVentas.TabIndex = 1;
            // 
            // pnlAlquileres
            // 
            pnlAlquileres.BorderStyle = BorderStyle.FixedSingle;
            pnlAlquileres.Controls.Add(lblAlquileresInfo);
            pnlAlquileres.Location = new Point(440, 70);
            pnlAlquileres.Name = "pnlAlquileres";
            pnlAlquileres.Size = new Size(350, 360);
            pnlAlquileres.TabIndex = 3;
            // 
            // lblAlquileresInfo
            // 
            lblAlquileresInfo.AutoSize = true;
            lblAlquileresInfo.Location = new Point(485, 220);
            lblAlquileresInfo.Name = "lblAlquileresInfo";
            lblAlquileresInfo.Size = new Size(272, 20);
            lblAlquileresInfo.TabIndex = 0;
            lblAlquileresInfo.Text = "Área preparada para gráfico interactivo";
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblVentas.Location = new Point(120, 25);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(273, 32);
            lblVentas.TabIndex = 0;
            lblVentas.Text = "Producto más vendido";
            // 
            // lblAlquileres
            // 
            lblAlquileres.AutoSize = true;
            lblAlquileres.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAlquileres.Location = new Point(500, 25);
            lblAlquileres.Name = "lblAlquileres";
            lblAlquileres.Size = new Size(287, 32);
            lblAlquileres.TabIndex = 2;
            lblAlquileres.Text = "Producto más alquilado";
            // 
            // frmGraficos
            // 
            ClientSize = new Size(820, 520);
            Controls.Add(lblVentas);
            Controls.Add(pnlVentas);
            Controls.Add(lblAlquileres);
            Controls.Add(pnlAlquileres);
            Name = "frmGraficos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gráficos";
            pnlAlquileres.ResumeLayout(false);
            pnlAlquileres.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}