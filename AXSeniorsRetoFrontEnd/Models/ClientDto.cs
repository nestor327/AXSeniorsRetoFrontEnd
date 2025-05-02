namespace AXSeniorsRetoFrontEnd.Models
{
    public class ClientDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime Registered { get; set; }
    }
}
