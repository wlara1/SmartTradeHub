using SmartTradeHub.Domain.Produits;

namespace SmartTradeHubApplication.Products.Create
{
    public class CreateProductService
    {
        private readonly IProductRepository _productRepository;

        public CreateProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> CreateProductAsync(CreateProductCommand command)
        {
            var product = new Produit(
                command.Name,
                command.Description,
                command.PriceHT,
                command.VatRate,
                command.StockQuantity
            );
            await _productRepository.AddAsync(product);
            return product.Id;
        }
    }

    
}
