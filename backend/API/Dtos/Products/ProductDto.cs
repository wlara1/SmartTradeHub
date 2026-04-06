namespace SmartTradeHub.Api.Dtos.Products
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal PriceHT { get; set; }
        public decimal VatRate { get; set; }
        public int StockQuantity { get; set; }
    }
}
