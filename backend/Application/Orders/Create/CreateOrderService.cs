using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHubApplication.Orders.Create
{
    public class CreateOrderService
    {
        public Guid CustomerId { get; init; }
        public List<CreateOrderLineService> Lines { get; init; } = new();
    }
}
