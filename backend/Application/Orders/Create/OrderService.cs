using SmartTradeHub.Domain.Commandes;

namespace SmartTradeHubApplication.Orders.Create
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Guid> CreateOrderAsync(CreateOrderService command)
        {
            var order = new Commande(command.CustomerId);

            foreach (var line in command.Lines)
            {
                order.AddLine(line.ProductId, line.Quantity, line.UnitPrice, line.VatRate);
            }

            await _orderRepository.AddAsync(order);

            return order.Id;
        }
    }
}
