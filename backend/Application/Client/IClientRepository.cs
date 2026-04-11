using SmartTradeHub.Domain.Clients;

namespace SmartTradeHubApplication.Client
{
    public interface IClientRepository
    {
        Task AddAsync(SmartTradeHub.Domain.Clients.Client client);
        Task<SmartTradeHub.Domain.Clients.Client?> GetByIdAsync(Guid id);
        Task<List<SmartTradeHub.Domain.Clients.Client>> GetAllAsync();
    }
}
