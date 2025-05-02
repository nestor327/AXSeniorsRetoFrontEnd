using Microsoft.AspNetCore.Components;

namespace AXSeniorsRetoFrontEnd.Models.Request.Products
{
    public class PostProductRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double UnitPrice { get; set; }
        public double UnitSellingPrice { get; set; }
        public double? Discount { get; set; }
        public int Stock { get; set; }
    }
}
