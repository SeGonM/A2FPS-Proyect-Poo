namespace A2FPS
{
    public partial class frmGraficos : Form
    {
        public frmGraficos()
        {
            InitializeComponent();
            pnlVentas.Click += (_, _) => MostrarPreparacion("Producto más vendido");
            pnlAlquileres.Click += (_, _) => MostrarPreparacion("Producto más alquilado");
        }

        private void MostrarPreparacion(string grafico)
        {
            MessageBox.Show($"{grafico}: preparado para incorporar un gráfico interactivo.", "A2 FPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}