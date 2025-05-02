using static AXSeniorsRetoFrontEnd.Pages.Home;

namespace AXSeniorsRetoFrontEnd.Models.Request.Orders
{
    public class OrderRequest
    {
        public string NumeroPedido { get; set; } = "1001";
        public string Cliente { get; set; } = "";
        public string NombreCliente { get; set; } = "";
        public DateTime FechaPedido { get; set; } = DateTime.Today;
        public DateTime FechaEntrega { get; set; } = DateTime.Today.AddDays(7);
        public string Estado { get; set; } = "Nuevo";
        public List<DetalleDeOrdenRequest> Lineas { get; set; } = new();
        public string Observaciones { get; set; }

        public decimal TotalConDescuento => Lineas.Sum(l => l.Cantidad * l.PrecioUnitario * (1 - l.Descuento));
    }
}
