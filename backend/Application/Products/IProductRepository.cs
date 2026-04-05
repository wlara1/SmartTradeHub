using SmartTradeHub.Domain.Produits;

namespace SmartTradeHubApplication.Products
{
    public interface IProductRepository
    {
        public Task AddAsync(Produit product);

        public Task <Produit?> GetByIdAsync(Guid id);

        public Task<List<Produit>> GetAllAsync();
    }
}
