namespace A2FPS
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Proveedor()
        {
            Nombre = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
        }

        public Proveedor(int idProveedor, string nombre, string telefono, string correo)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }
    }
}