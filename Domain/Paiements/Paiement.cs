using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHub.Domain.Paiements
{
    public enum PaymentMethod
    {
        Card,
        Transfer
    }

    public class Paiement
    {
        public Guid Id { get; private set; }
        public Guid FactureId { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public PaymentMethod Method { get; private set; }

        public Paiement(Guid factureId, decimal amount, PaymentMethod method)
        {
            Id = Guid.NewGuid();
            FactureId = factureId;
            Amount = amount;
            Method = method;
            PaymentDate = DateTime.UtcNow;
        }
    }
}
