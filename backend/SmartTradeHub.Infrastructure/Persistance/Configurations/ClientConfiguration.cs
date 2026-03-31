using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartTradeHub.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHub.Infrastructure.Persistance.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.Email)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.Country)
                   .HasMaxLength(100);

            builder.Property(c => c.IsCompany)
                   .IsRequired();

            builder.Property(c => c.CreditScore)
                   .IsRequired();

            builder.Property(c => c.CreatedAt)
                   .IsRequired();

            builder.ToTable("Clients");
        }
    }
}
