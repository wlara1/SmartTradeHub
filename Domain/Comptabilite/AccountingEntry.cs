using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHub.Domain.Comptabilite
{
    public class AccountingEntry
    {
        public Guid Id { get; private set; }
        public string Reference { get; private set; } = default!;
        public decimal Debit { get; private set; }
        public decimal Credit { get; private set; }
        public DateTime Date { get; private set; }
        public string AccountNumber { get; private set; } = default!;

        public AccountingEntry(string reference, decimal debit, decimal credit, string accountNumber)
        {
            if (debit > 0 && credit > 0)
                throw new InvalidOperationException("Debit and Credit cannot both be set.");

            Id = Guid.NewGuid();
            Reference = reference;
            Debit = debit;
            Credit = credit;
            AccountNumber = accountNumber;
            Date = DateTime.UtcNow;
        }
    }
}
