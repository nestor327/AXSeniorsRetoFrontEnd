namespace AXSeniorsRetoFrontEnd.Models.Request.Orders
{
    public class DetalleDeOrdenRequest
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; } = "Producto 1";
        public int Cantidad { get; set; } = 1;
        public decimal PrecioUnitario { get; set; } = 100m;
        public decimal Descuento { get; set; } = 0.1m;
    }
}
