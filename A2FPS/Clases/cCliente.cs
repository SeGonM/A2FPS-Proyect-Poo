namespace A2FPS
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Cliente()
        {
            Nombre = string.Empty;
            Documento = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
        }

        public Cliente(int idCliente, string nombre, string documento, string telefono, string correo)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Documento = documento;
            Telefono = telefono;
            Correo = correo;
        }
    }
}