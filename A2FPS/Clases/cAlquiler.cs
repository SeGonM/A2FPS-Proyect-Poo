namespace A2FPS
{
    public class Alquiler
    {
        public int IdAlquiler { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int IdUsuarioResponsable { get; set; }
        public string FechaInicio { get; set; }
        public string FechaDevolucionPrevista { get; set; }
        public string Estado { get; set; }

        public Alquiler()
        {
            FechaInicio = string.Empty;
            FechaDevolucionPrevista = string.Empty;
            Estado = string.Empty;
        }

        public Alquiler(int idAlquiler, int idCliente, int idProducto, int idUsuarioResponsable,
            string fechaInicio, string fechaDevolucionPrevista, string estado)
        {
            IdAlquiler = idAlquiler;
            IdCliente = idCliente;
            IdProducto = idProducto;
            IdUsuarioResponsable = idUsuarioResponsable;
            FechaInicio = fechaInicio;
            FechaDevolucionPrevista = fechaDevolucionPrevista;
            Estado = estado;
        }
    }
}