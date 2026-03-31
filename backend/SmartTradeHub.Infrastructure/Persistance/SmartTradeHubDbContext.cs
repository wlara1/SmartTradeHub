using Microsoft.EntityFrameworkCore;
using SmartTradeHub.Domain.Commandes;

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
            base.OnModelCreating(modelBuilder);
        }
    }
}
