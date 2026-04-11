using Microsoft.EntityFrameworkCore;
using SmartTradeHub.Domain.Clients;
using SmartTradeHub.Infrastructure.Persistance;
using SmartTradeHubApplication.Client;

namespace SmartTradeHub.Infrastructure.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly SmartTradeHubDbContext _context;

    public ClientRepository(SmartTradeHubDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Domain.Clients.Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Client>> GetAllAsync()
    {
        return await _context.Clients.ToListAsync();
    }

    public async Task<Client?> GetByIdAsync(Guid id)
    {
        return await _context.Clients.FindAsync(id);
    }
}
