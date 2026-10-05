namespace A2FPS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnIngresar.Click += btnIngresar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Hide();
            using (var formularioPrincipal = new frmPrincipal(cmbRol.Text))
            {
                formularioPrincipal.ShowDialog(this);
            }
            Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}