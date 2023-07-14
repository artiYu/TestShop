using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestShopAPI.Models.DTO;
using TestShopAPI.Models;
using TestShopAPI.Services.Interfaces;

namespace TestShopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Client>> Get()
        {
            return await _clientService.GetAll();
        }

        [HttpGet("Get/{id}")]
        public async Task<Client> Get([FromQuery] int id)
        {
            return await _clientService.Get(id);
        }

        [HttpPost("Create")]
        public async Task Create([FromBody] ClientDTO clientDto)
        {
            Client client = _mapper.Map<Client>(clientDto);
            await _clientService.Create(client);
        }
    }
}
