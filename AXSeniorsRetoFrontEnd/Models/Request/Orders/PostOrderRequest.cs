using static AXSeniorsRetoFrontEnd.Pages.Home;

namespace AXSeniorsRetoFrontEnd.Models.Request.Orders
{
    public class PostOrderRequest
    {
        public string AppUserId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int? Status { get; set; }
        public string Observations { get; set; }
        public List<OrderDetailRequest> OrderDetails { get; set; }
    }
}
