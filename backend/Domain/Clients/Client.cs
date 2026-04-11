namespace SmartTradeHub.Domain.Clients;

public class Client
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string Country { get; private set; } = default!;
    public bool IsCompany { get; private set; }
    public int CreditScore { get; private set; }
    public DateTime CreatedAt { get; private set; }

    protected Client() { }

    public Client(string name, string email, string country, bool isCompany)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Country = country;
        IsCompany = isCompany;
        CreditScore = 0;
        CreatedAt = DateTime.UtcNow;
    }

    public void UpdateCreditScore(int score)
    {
        CreditScore = score;
    }
}
