using Microsoft.EntityFrameworkCore;
using SmartTradeHub.Domain.Clients;
using SmartTradeHub.Domain.Commandes;
using SmartTradeHub.Domain.Produits;

namespace SmartTradeHub.Infrastructure.Persistance
{
    public class SmartTradeHubDbContext : DbContext
    {
        public SmartTradeHubDbContext(DbContextOptions<SmartTradeHubDbContext> options)
            : base(options)
        {
        }

        public DbSet<Commande> Orders => Set<Commande>();
        public DbSet<OrderLine> OrderLines => Set<OrderLine>();
        public DbSet<Domain.Produits.Produit> Products => Set<Domain.Produits.Produit>();
        public DbSet<Domain.Clients.Client> Clients => Set<Domain.Clients.Client>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SmartTradeHubDbContext).Assembly);

            // Seed Clients (GUIDs must be valid hex)
            modelBuilder.Entity<Client>().HasData(
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Marie Dupont",
                    Email = "marie.dupont@example.com",
                    Country = "France",
                    IsCompany = false,
                    CreditScore = 720,
                    CreatedAt = new DateTime(2025, 1, 15, 9, 12, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Société TechNova",
                    Email = "contact@technova.fr",
                    Country = "France",
                    IsCompany = true,
                    CreditScore = 820,
                    CreatedAt = new DateTime(2025, 2, 20, 11, 30, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Ahmed Benali",
                    Email = "a.benali@example.ma",
                    Country = "Maroc",
                    IsCompany = false,
                    CreditScore = 610,
                    CreatedAt = new DateTime(2025, 3, 5, 14, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Laura Martin",
                    Email = "laura.martin@example.com",
                    Country = "France",
                    IsCompany = false,
                    CreditScore = 760,
                    CreatedAt = new DateTime(2025, 3, 22, 8, 45, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Entreprise Lumina",
                    Email = "hello@lumina.com",
                    Country = "Belgique",
                    IsCompany = true,
                    CreditScore = 790,
                    CreatedAt = new DateTime(2025, 4, 10, 10, 20, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Julien Lefevre",
                    Email = "julien.lefevre@example.com",
                    Country = "France",
                    IsCompany = false,
                    CreditScore = 680,
                    CreatedAt = new DateTime(2025, 5, 2, 16, 10, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "Agence Horizon",
                    Email = "contact@horizon.agency",
                    Country = "France",
                    IsCompany = true,
                    CreditScore = 740,
                    CreatedAt = new DateTime(2025, 6, 18, 9, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "Samantha Roy",
                    Email = "samantha.roy@example.com",
                    Country = "France",
                    IsCompany = false,
                    CreditScore = 700,
                    CreatedAt = new DateTime(2025, 7, 4, 12, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Mille et Une Solutions",
                    Email = "contact@mille1.com",
                    Country = "Suisse",
                    IsCompany = true,
                    CreditScore = 835,
                    CreatedAt = new DateTime(2025, 8, 12, 15, 30, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-00000000000A"),
                    Name = "Oumar Traoré",
                    Email = "oumar.traore@example.ci",
                    Country = "Côte d'Ivoire",
                    IsCompany = false,
                    CreditScore = 590,
                    CreatedAt = new DateTime(2025, 9, 1, 10, 5, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-00000000000B"),
                    Name = "Isabelle Moreau",
                    Email = "isabelle.moreau@example.com",
                    Country = "France",
                    IsCompany = false,
                    CreditScore = 715,
                    CreatedAt = new DateTime(2025, 9, 20, 11, 11, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-00000000000C"),
                    Name = "Papeterie Locale",
                    Email = "contact@papeterielocale.fr",
                    Country = "France",
                    IsCompany = true,
                    CreditScore = 670,
                    CreatedAt = new DateTime(2025, 10, 5, 9, 45, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-00000000000D"),
                    Name = "Carlos Mendes",
                    Email = "c.mendes@example.pt",
                    Country = "Portugal",
                    IsCompany = false,
                    CreditScore = 730,
                    CreatedAt = new DateTime(2025, 10, 28, 13, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-00000000000E"),
                    Name = "Atelier Bois",
                    Email = "atelier@bois-artisan.fr",
                    Country = "France",
                    IsCompany = true,
                    CreditScore = 650,
                    CreatedAt = new DateTime(2025, 11, 15, 8, 30, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-00000000000F"),
                    Name = "Nadia Haddad",
                    Email = "nadia.haddad@example.com",
                    Country = "Tunisie",
                    IsCompany = false,
                    CreditScore = 605,
                    CreatedAt = new DateTime(2025, 12, 2, 17, 20, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Global Events SA",
                    Email = "events@global-events.com",
                    Country = "Luxembourg",
                    IsCompany = true,
                    CreditScore = 780,
                    CreatedAt = new DateTime(2026, 1, 8, 10, 10, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "Pierre Gauthier",
                    Email = "pierre.gauthier@example.com",
                    Country = "France",
                    IsCompany = false,
                    CreditScore = 695,
                    CreatedAt = new DateTime(2026, 1, 25, 14, 40, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "Ecole Primaire Les Tilleuls",
                    Email = "admin@les-tilleuls.fr",
                    Country = "France",
                    IsCompany = true,
                    CreditScore = 710,
                    CreatedAt = new DateTime(2026, 2, 11, 9, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Name = "Valérie Petit",
                    Email = "valerie.petit@example.com",
                    Country = "France",
                    IsCompany = false,
                    CreditScore = 725,
                    CreatedAt = new DateTime(2026, 3, 1, 8, 0, 0, DateTimeKind.Utc)
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Name = "Studio Photo Lumière",
                    Email = "studio@lumiere.photo",
                    Country = "France",
                    IsCompany = true,
                    CreditScore = 760,
                    CreatedAt = new DateTime(2026, 3, 15, 18, 30, 0, DateTimeKind.Utc)
                }
            );

            // Seed Products (GUIDs must be valid hex)
            modelBuilder.Entity<Produit>().HasData(
                new
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-000000000101"),
                    Name = "Clavier mécanique K120",
                    Description = "Clavier mécanique rétroéclairé, switch tactile.",
                    PriceHT = 59.90m,
                    VatRate = 0.20m,
                    StockQuantity = 120,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-000000000102"),
                    Name = "Souris sans fil M55",
                    Description = "Souris ergonomique, 2.4GHz et Bluetooth.",
                    PriceHT = 24.50m,
                    VatRate = 0.20m,
                    StockQuantity = 200,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-000000000103"),
                    Name = "Écran 24\" Full HD",
                    Description = "Moniteur 24 pouces, 1080p, 75Hz.",
                    PriceHT = 129.00m,
                    VatRate = 0.20m,
                    StockQuantity = 45,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-000000000104"),
                    Name = "Casque audio XPro",
                    Description = "Casque circum-aural, réduction de bruit.",
                    PriceHT = 89.99m,
                    VatRate = 0.20m,
                    StockQuantity = 60,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-000000000105"),
                    Name = "SSD 1To NVMe",
                    Description = "Stockage NVMe haute performance 1TB.",
                    PriceHT = 109.00m,
                    VatRate = 0.20m,
                    StockQuantity = 80,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-000000000106"),
                    Name = "Lampe de bureau LED",
                    Description = "Lampe de bureau LED dimmable.",
                    PriceHT = 29.90m,
                    VatRate = 0.20m,
                    StockQuantity = 150,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("77777777-7777-7777-7777-000000000107"),
                    Name = "Imprimante A4 multifonction",
                    Description = "Impression, scan et copie.",
                    PriceHT = 149.50m,
                    VatRate = 0.20m,
                    StockQuantity = 30,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-000000000108"),
                    Name = "Webcam HD 1080p",
                    Description = "Webcam avec micro intégré.",
                    PriceHT = 39.95m,
                    VatRate = 0.20m,
                    StockQuantity = 90,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("99999999-9999-9999-9999-000000000109"),
                    Name = "Chaise ergonomique Série B",
                    Description = "Chaise de bureau ergonomique avec support lombaire.",
                    PriceHT = 199.00m,
                    VatRate = 0.20m,
                    StockQuantity = 25,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-00000000010A"),
                    Name = "Hub USB-C 7 ports",
                    Description = "Hub aluminium, USB-C PD support.",
                    PriceHT = 49.00m,
                    VatRate = 0.20m,
                    StockQuantity = 70,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-00000000010B"),
                    Name = "Station d'accueil 4K",
                    Description = "Dock Thunderbolt pour 4K et charge.",
                    PriceHT = 229.00m,
                    VatRate = 0.20m,
                    StockQuantity = 15,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("cccccccc-cccc-cccc-cccc-00000000010C"),
                    Name = "Chargeur sans fil 15W",
                    Description = "Pad Qi rapide 15W.",
                    PriceHT = 19.90m,
                    VatRate = 0.20m,
                    StockQuantity = 140,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("dddddddd-dddd-dddd-dddd-00000000010D"),
                    Name = "Sangle fitness",
                    Description = "Sangle résistante pour sport.",
                    PriceHT = 12.50m,
                    VatRate = 0.20m,
                    StockQuantity = 300,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-00000000010E"),
                    Name = "Câble HDMI 2.1 - 2m",
                    Description = "Câble haute vitesse 2 mètres.",
                    PriceHT = 14.99m,
                    VatRate = 0.20m,
                    StockQuantity = 220,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("ffffffff-ffff-ffff-ffff-00000000010F"),
                    Name = "Microphone USB Studio",
                    Description = "Microphone cardioïde pour podcast.",
                    PriceHT = 79.90m,
                    VatRate = 0.20m,
                    StockQuantity = 40,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000110"),
                    Name = "Logiciel Antivirus Pro",
                    Description = "Licence 1 an.",
                    PriceHT = 39.00m,
                    VatRate = 0.20m,
                    StockQuantity = 1000,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("12121212-1212-1212-1212-000000000111"),
                    Name = "Coffret tournevis 32 pcs",
                    Description = "Kit 32 pièces aimanté.",
                    PriceHT = 22.00m,
                    VatRate = 0.20m,
                    StockQuantity = 180,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("13131313-1313-1313-1313-000000000112"),
                    Name = "Réglette LED 120cm",
                    Description = "Éclairage LED basse consommation.",
                    PriceHT = 34.90m,
                    VatRate = 0.20m,
                    StockQuantity = 65,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("14141414-1414-1414-1414-000000000113"),
                    Name = "Routeur Wi-Fi AC1200",
                    Description = "Routeur double bande, parental control.",
                    PriceHT = 59.00m,
                    VatRate = 0.20m,
                    StockQuantity = 55,
                    IsActive = true
                },
                new
                {
                    Id = Guid.Parse("15151515-1515-1515-1515-000000000114"),
                    Name = "Table de réunion pliable",
                    Description = "Table pliante 180x80cm, transport facile.",
                    PriceHT = 129.00m,
                    VatRate = 0.20m,
                    StockQuantity = 10,
                    IsActive = true
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
