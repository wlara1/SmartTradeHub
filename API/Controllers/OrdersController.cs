using Microsoft.AspNetCore.Mvc;
using SmartTradeHub.Api.Dtos.Orders;
using SmartTradeHubApplication.Orders.Create;
using SmartTradeHubApplication.Orders.Queries;

namespace SmartTradeHub.Api.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;
        private readonly GetOrderService _getOrderService;

        public OrdersController(OrderService orderService, GetOrderService getOrderService)
        {
            _orderService = orderService;
            _getOrderService = getOrderService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderRequestDto dto)
        {
            var command = new CreateOrderCommand
            {
                CustomerId = dto.CustomerId,
                Lines = dto.Lines.Select(l => new CreateOrderLineCommand
                {
                    ProductId = l.ProductId,
                    UnitPrice = l.UnitPrice,
                    Quantity = l.Quantity,
                    VatRate = l.VatRate
                }).ToList()
            };

            var orderId = await _orderService.CreateOrderAsync(command);

            return Ok(new CreateOrderResponseDto
            {
                OrderId = orderId
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var order = await _getOrderService.ExecuteAsync(id);

            if (order == null)
                return NotFound();

            var dto = new GetOrderResponseDto
            {
                Id = order.Id,
                CustomerId = order.ClientId,
                Status = order.Status.ToString(),
                Total = order.GetTotal(),
                Lines = order.Lines.Select(l => new GetOrderLineDto
                {
                    ProductId = l.ProduitId,
                    UnitPrice = l.UnitPriceHT,
                    Quantity = l.Quantity,
                    VatRate = l.VatRate
                }).ToList()
            };

            return Ok(dto);
        }
    }
}
