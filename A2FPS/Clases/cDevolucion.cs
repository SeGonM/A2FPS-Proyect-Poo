namespace A2FPS
{
    public class Devolucion
    {
        public int IdDevolucion { get; set; }
        public int IdAlquiler { get; set; }
        public int IdUsuarioResponsable { get; set; }
        public string FechaDevolucion { get; set; }
        public int DiasRetraso { get; set; }

        public Devolucion()
        {
            FechaDevolucion = string.Empty;
        }

        public Devolucion(int idDevolucion, int idAlquiler, int idUsuarioResponsable,
            string fechaDevolucion, int diasRetraso)
        {
            IdDevolucion = idDevolucion;
            IdAlquiler = idAlquiler;
            IdUsuarioResponsable = idUsuarioResponsable;
            FechaDevolucion = fechaDevolucion;
            DiasRetraso = diasRetraso;
        }
    }
}