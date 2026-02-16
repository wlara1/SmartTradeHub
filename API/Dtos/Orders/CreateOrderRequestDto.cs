namespace SmartTradeHub.Api.Dtos.Orders
{
    public class CreateOrderRequestDto
    {
        public Guid CustomerId { get; set; }
        public List<CreateOrderLineDto> Lines { get; set; } = new();
    }
}
