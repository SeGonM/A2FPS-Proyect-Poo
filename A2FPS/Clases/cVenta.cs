namespace A2FPS
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int IdUsuarioResponsable { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public string FechaVenta { get; set; }

        public Venta()
        {
            FechaVenta = string.Empty;
        }

        public Venta(int idVenta, int idCliente, int idProducto, int idUsuarioResponsable,
            int cantidad, decimal precioUnitario, decimal total, string fechaVenta)
        {
            IdVenta = idVenta;
            IdCliente = idCliente;
            IdProducto = idProducto;
            IdUsuarioResponsable = idUsuarioResponsable;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Total = total;
            FechaVenta = fechaVenta;
        }
    }
}