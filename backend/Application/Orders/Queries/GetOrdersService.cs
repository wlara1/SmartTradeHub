using SmartTradeHub.Domain.Commandes;

namespace SmartTradeHubApplication.Orders.Queries
{
    public class GetOrdersService
    {
        private readonly IOrderRepository _repository;
        public GetOrdersService(IOrderRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Commande>> ExecuteAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
