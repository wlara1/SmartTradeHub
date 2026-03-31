namespace SmartTradeHub.Domain.Produits;

public class Produit
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public decimal PriceHT { get; private set; }
    public decimal VatRate { get; private set; }
    public int StockQuantity { get; private set; }
    public bool IsActive { get; private set; }

    protected Produit() { }

    public Produit(string name, string description, decimal priceHT, decimal vatRate, int stockQuantity)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        PriceHT = priceHT;
        VatRate = vatRate;
        StockQuantity = stockQuantity;
        IsActive = true;
    }

    public void DecreaseStock(int quantity)
    {
        if (quantity > StockQuantity)
            throw new InvalidOperationException("Not enough stock.");

        StockQuantity -= quantity;
    }
}