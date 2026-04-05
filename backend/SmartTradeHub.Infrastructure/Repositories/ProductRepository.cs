using Microsoft.EntityFrameworkCore;
using SmartTradeHub.Domain.Produits;
using SmartTradeHub.Infrastructure.Persistance;
using SmartTradeHubApplication.Products;

namespace SmartTradeHub.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SmartTradeHubDbContext _context;

        public ProductRepository(SmartTradeHubDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Produit product)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Produit>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();

        }

        public Task<Produit?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
