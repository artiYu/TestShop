using Microsoft.EntityFrameworkCore;
using TestShopAPI.Models;
using TestShopAPI.Services.Interfaces;

namespace TestShopAPI.Services.Implementations
{
    public class ClientService : IClientService
    {
        private readonly ShopContext _context;
        public ClientService(ShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> Get(int id)
        {
            return await _context.Clients.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Create(Client client)
        {
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
        }
    }
}
