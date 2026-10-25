using Microsoft.AspNetCore.Mvc;
using SmartTradeHub.Api.Dtos.Products;
//using SmartTradeHub.Domain.Produits;
using SmartTradeHubApplication.Products.Queries;
using SmartTradeHubApplication.Products.Create;


namespace SmartTradeHub.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly GetProductService _getProductService;
        private readonly CreateProductService _createProductService;

        public ProductsController(GetProductService getProductService, CreateProductService createProductService)
        {
            _getProductService = getProductService;
            _createProductService = createProductService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Implementation for creating a product would go here
            var product = new CreateProductCommand
            {
                Name = dto.Name,
                Description = dto.Description,
                PriceHT = dto.PriceHT,
                VatRate = dto.VatRate,
                StockQuantity = dto.StockQuantity
            };

            var productId = await _createProductService.CreateProductAsync(product);

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var produit = await _getProductService.GetByIdAsync(id);

            if (produit == null) { return NotFound(); }

            var productDto = new ProductDto
            {
                Id = produit.Id,
                Name = produit.Name,
                Description = produit.Description,
                PriceHT = produit.PriceHT,
                VatRate = produit.VatRate,
                StockQuantity = produit.StockQuantity
            };

            return Ok(productDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var produits = await _getProductService.ExecuteAsync();
            List<ProductDto> productDtos = produits.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                PriceHT = p.PriceHT,
                VatRate = p.VatRate,
                StockQuantity = p.StockQuantity
            }).ToList();
            return Ok(productDtos);
        }
    }
}
