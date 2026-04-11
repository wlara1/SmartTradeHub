
using SmartTradeHub.Domain.Clients;

namespace SmartTradeHubApplication.Client
{
    public interface IClientService
    {
        Task<SmartTradeHub.Domain.Clients.Client> GetByIdAsync(Guid id);
        Task<List<SmartTradeHub.Domain.Clients.Client>> GetAllAsync();
        void Create(SmartTradeHub.Domain.Clients.Client client);
    }
}
