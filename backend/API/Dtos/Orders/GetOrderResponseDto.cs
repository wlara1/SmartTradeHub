namespace SmartTradeHub.Api.Dtos.Orders
{
    public class GetOrderResponseDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public List<GetOrderLineDto> Lines { get; set; }
    }

    public class GetOrderLineDto
    {
        public Guid ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal VatRate { get; set; }
    }
}
