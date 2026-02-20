namespace SmartTradeHub.Domain.Commandes;

public enum OrderStatus
{
    Draft,
    Confirmed,
    Shipped,
    Paid
}

public class Commande
{
    public Guid Id { get; private set; }
    public Guid ClientId { get; private set; }
    public DateTime OrderDate { get; private set; }
    public OrderStatus Status { get; private set; }

    public decimal TotalHT { get; private set; }
    public decimal TotalTVA { get; private set; }
    public decimal TotalTTC { get; private set; }

    private readonly List<OrderLine> _lines = new();
    public IReadOnlyCollection<OrderLine> Lines => _lines.AsReadOnly();

    protected Commande() { }

    public Commande(Guid clientId)
    {
        Id = Guid.NewGuid();
        ClientId = clientId;
        OrderDate = DateTime.UtcNow;
        Status = OrderStatus.Draft;
    }

    public void AddLine(Guid produitId, int quantity, decimal unitPriceHT, decimal vatRate)
    {
        if (Status != OrderStatus.Draft)
            throw new InvalidOperationException("Cannot modify a confirmed order.");

        var line = new OrderLine(produitId, quantity, unitPriceHT, vatRate);
        _lines.Add(line);

        RecalculateTotals();
    }

    public decimal GetTotal()
        => _lines.Sum(l => l.UnitPriceHT * l.Quantity);

    public void Confirm()
    {
        if (!_lines.Any())
            throw new InvalidOperationException("Order must have at least one line.");

        Status = OrderStatus.Confirmed;
    }

    private void RecalculateTotals()
    {
        TotalHT = _lines.Sum(l => l.TotalHT);
        TotalTVA = _lines.Sum(l => l.TotalTVA);
        TotalTTC = TotalHT + TotalTVA;
    }
}