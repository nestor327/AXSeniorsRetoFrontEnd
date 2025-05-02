namespace AXSeniorsRetoFrontEnd.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int? Stock { get; set; }
        public string? Name { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitSellingPrice { get; set; }
        public double? Discount { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
