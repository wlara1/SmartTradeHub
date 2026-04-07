
using SmartTradeHub.Domain.Clients;

namespace SmartTradeHubApplication.Client
{
    public interface IClientService
    {
        SmartTradeHub.Domain.Clients.Client GetById(int id);
        List<SmartTradeHub.Domain.Clients.Client> GetAll();
        //Task<List<SmartTradeHub.Domain.Clients.Client>> GetAllAsync();
        void Create(SmartTradeHub.Domain.Clients.Client client);
    }
}
