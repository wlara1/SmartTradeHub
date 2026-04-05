using SmartTradeHub.Domain.Produits;
using SmartTradeHubApplication.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeHubApplication.Products.Queries
{
    public class GetProductService 
    {
        private readonly IProductRepository _repository;

        public GetProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Produit>> ExecuteAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Task<Produit?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
