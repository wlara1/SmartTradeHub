using Microsoft.AspNetCore.Mvc;
using SmartTradeHub.Api.Dtos.Orders;
using SmartTradeHubApplication.Orders.Create;

namespace SmartTradeHub.Api.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
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
                    Quantity = l.Quantity
                }).ToList()
            };

            var orderId = await _orderService.CreateOrderAsync(command);

            return Ok(new CreateOrderResponseDto
            {
                OrderId = orderId
            });
        }
    }
}
