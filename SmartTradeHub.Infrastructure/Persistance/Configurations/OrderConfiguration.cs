using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartTradeHub.Domain.Commandes;

namespace SmartTradeHub.Infrastructure.Persistance.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Commande>
    {
        public void Configure(EntityTypeBuilder<Commande> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.ClientId)
                   .IsRequired();

            builder.Property(o => o.Status)
                   .HasConversion<string>();

            builder.HasMany(typeof(OrderLine), "_lines")
                   .WithOne()
                   .HasForeignKey("OrderId");
        }
    }
}
