using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHub.Domain.Commandes
{
    public class OrderLine
    {
        public Guid Id { get; private set; }
        public Guid ProduitId { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPriceHT { get; private set; }
        public decimal VatRate { get; private set; }

        public decimal TotalHT => Quantity * UnitPriceHT;
        public decimal TotalTVA => TotalHT * VatRate;

        public OrderLine(Guid produitId, int quantity, decimal unitPriceHT, decimal vatRate)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            Id = Guid.NewGuid();
            ProduitId = produitId;
            Quantity = quantity;
            UnitPriceHT = unitPriceHT;
            VatRate = vatRate;
        }
    }
}
