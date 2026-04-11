using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHubApplication.Client
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Create(SmartTradeHub.Domain.Clients.Client client)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SmartTradeHub.Domain.Clients.Client>> GetAllAsync()
        {
            return await _clientRepository.GetAllAsync();
        }

        public async Task<SmartTradeHub.Domain.Clients.Client?> GetByIdAsync(Guid id)
        {
            return await _clientRepository.GetByIdAsync(id);
        }
    }
}
