using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHubApplication.Orders.Create
{
    public class CreateOrderLineService
    {
        public Guid ProductId { get; init; }
        public decimal UnitPrice { get; init; }
        public int Quantity { get; init; }
        public decimal VatRate { get; init; }
    }
}
