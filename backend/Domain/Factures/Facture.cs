using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHub.Domain.Factures
{
    public enum InvoiceStatus
    {
        Issued,
        Paid,
        Overdue
    }

    public class Facture
    {
        public Guid Id { get; private set; }
        public Guid CommandeId { get; private set; }
        public string InvoiceNumber { get; private set; } = default!;
        public DateTime IssueDate { get; private set; }
        public DateTime DueDate { get; private set; }

        public decimal TotalHT { get; private set; }
        public decimal TotalTVA { get; private set; }
        public decimal TotalTTC { get; private set; }

        public InvoiceStatus Status { get; private set; }

        public Facture(Guid commandeId, decimal totalHT, decimal totalTVA, decimal totalTTC)
        {
            Id = Guid.NewGuid();
            CommandeId = commandeId;
            InvoiceNumber = $"INV-{DateTime.UtcNow.Ticks}";
            IssueDate = DateTime.UtcNow;
            DueDate = IssueDate.AddDays(30);

            TotalHT = totalHT;
            TotalTVA = totalTVA;
            TotalTTC = totalTTC;

            Status = InvoiceStatus.Issued;
        }

        public void MarkAsPaid()
        {
            Status = InvoiceStatus.Paid;
        }
    }
}
