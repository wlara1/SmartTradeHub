using SmartTradeHub.Domain.Commandes;

namespace SmartTradeHubApplication.Orders.Queries
{
    public class GetOrderService
    {
        private readonly IOrderRepository _repository;

        public GetOrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<Commande?> ExecuteAsync(Guid orderId)
        {
            return await _repository.GetByIdAsync(orderId);
        }
        public async Task<List<Commande>> ExecuteAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
