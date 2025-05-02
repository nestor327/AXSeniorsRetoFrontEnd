namespace AXSeniorsRetoFrontEnd.Models
{
    public class ClientPaginatedDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime Registered { get; set; }
        public int NewOrders { get; set; }
        public double TotalAmount { get; set; }
    }
}
