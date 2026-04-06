namespace SmartTradeHubApplication.Products.Create
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PriceHT { get; set; }
        public decimal VatRate { get; set; }
        public int StockQuantity { get; set; }
    }
}
