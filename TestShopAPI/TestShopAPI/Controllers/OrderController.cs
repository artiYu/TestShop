using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestShopAPI.Models.DTO;
using TestShopAPI.Models;
using TestShopAPI.Services.Interfaces;

namespace TestShopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Order>> Get()
        {
            return await _orderService.GetAll();
        }

        [HttpGet("Get/{id}")]
        public async Task<Order> Get([FromQuery] int id)
        {
            return await _orderService.Get(id);
        }

        [HttpPost("Create")]
        public async Task Create([FromBody] OrderDTO orderDto)
        {
            Order order = _mapper.Map<Order>(orderDto);
            await _orderService.Create(order);
        }
    }
}
