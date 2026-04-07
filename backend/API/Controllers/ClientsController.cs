using Microsoft.AspNetCore.Mvc;
using SmartTradeHubApplication.Client;

namespace SmartTradeHub.Api.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientsController : ControllerBase
    {
        private readonly ClientService _clientService; // Inject your client service here

        public ClientsController(ClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            // Implementation for getting clients would go here
            _clientService.GetAll();
            return Ok();
        }
    }
}
