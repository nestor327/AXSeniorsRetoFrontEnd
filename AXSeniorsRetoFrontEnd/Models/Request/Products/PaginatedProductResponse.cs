namespace AXSeniorsRetoFrontEnd.Models.Request.Products
{
    public class PaginatedProductResponse
    {
        public List<ProductDto> Records { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
