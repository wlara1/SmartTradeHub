using Microsoft.EntityFrameworkCore;
using SmartTradeHub.Infrastructure.Persistance;
using SmartTradeHubApplication.Orders;
using SmartTradeHub.Domain.Commandes;

namespace SmartTradeHub.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SmartTradeHubDbContext _context;

        public OrderRepository(SmartTradeHubDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Commande order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<Commande?> GetByIdAsync(Guid id)
        {
            return await _context.Orders
                .Include("_lines")
                .FirstOrDefaultAsync(o => o.Id == id);
        }
    }
}
