using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTradeHub.Domain.Commandes;

namespace SmartTradeHubApplication.Orders
{
    public interface IOrderRepository
    {
        Task AddAsync(Commande order);

        Task<Commande?> GetByIdAsync(Guid id);

        Task<List<Commande>> GetAllAsync();
    }
}
