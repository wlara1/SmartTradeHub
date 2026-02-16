namespace SmartTradeHub.Api.Dtos.Orders
{
    public class CreateOrderLineDto
    {
        public Guid ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal VatRate { get; set; }
    }
}
