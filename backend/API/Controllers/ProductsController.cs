using Microsoft.AspNetCore.Mvc;
using SmartTradeHub.Domain.Produits;
using SmartTradeHubApplication.Products.Queries;


namespace SmartTradeHub.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly GetProductService _getProductService;

        public ProductsController(GetProductService getProductService)
        {
            _getProductService = getProductService;
        }

        //public ActionResult<IEnumerable<Product>> GetProducts()
        //{

        //}
        [HttpGet("{id}")]
        public ActionResult<Produit> GetProduct(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produit>>> GetAll()
        {
            List<Produit> produits = await _getProductService.ExecuteAsync();
            return Ok(produits);
        }
    }
}
