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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SmartTradeHubDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
