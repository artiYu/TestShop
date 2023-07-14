using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestShopAPI.Models;
using TestShopAPI.Models.DTO;
using TestShopAPI.Services.Interfaces;

namespace TestShopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productService.GetAll();
        }

        [HttpGet("Get/{id}")]
        public async Task<Product> Get([FromQuery]int id)
        {
            return await _productService.Get(id);
        }

        [HttpPost("Create")]
        public async Task Create([FromBody] ProductDTO productDto)
        {
            Product product = _mapper.Map<Product>(productDto);
            await _productService.Create(product);
        }
    }
}
