namespace A2FPS
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TipoProducto { get; set; }
        public string Categoria { get; set; }
        public string Plataforma { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public int CantidadDisponible { get; set; }
        public EstadoProducto Estado { get; set; }

        public Producto()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
            TipoProducto = string.Empty;
            Categoria = string.Empty;
            Plataforma = string.Empty;
        }

        public Producto(int idProducto, string nombre, string descripcion, string tipoProducto, string categoria,
            string plataforma, decimal precioVenta, decimal precioAlquiler, int cantidadDisponible, EstadoProducto estado)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            TipoProducto = tipoProducto;
            Categoria = categoria;
            Plataforma = plataforma;
            PrecioVenta = precioVenta;
            PrecioAlquiler = precioAlquiler;
            CantidadDisponible = cantidadDisponible;
            Estado = estado;
        }
    }
}