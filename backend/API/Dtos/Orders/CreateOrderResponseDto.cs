namespace SmartTradeHub.Api.Dtos.Orders
{
    public class CreateOrderResponseDto
    {
        public Guid OrderId { get; set; }
        public decimal Total { get; set; }
    }
}
