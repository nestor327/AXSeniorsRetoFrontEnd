namespace AXSeniorsRetoFrontEnd.Models
{
    public class PaginatedClientResponse
    {
        public List<ClientPaginatedDto> Records { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
