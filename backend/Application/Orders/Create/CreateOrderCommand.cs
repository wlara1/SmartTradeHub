using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHubApplication.Orders.Create
{
    public class CreateOrderCommand
    {
        public Guid CustomerId { get; init; }
        public List<CreateOrderLineCommand> Lines { get; init; } = new();
    }
}
