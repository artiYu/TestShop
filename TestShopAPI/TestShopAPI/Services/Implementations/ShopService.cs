using Microsoft.EntityFrameworkCore;
using TestShopAPI.Models;
using TestShopAPI.Services.Interfaces;

namespace TestShopAPI.Services.Implementations
{
    public class ShopService : IShopService
    {
        private readonly ShopContext _context;
        public ShopService(ShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Shop>> GetAll()
        {
            return await _context.Shops.ToListAsync();
        }

        public async Task<Shop> Get(int id)
        {
            return await _context.Shops.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Create(Shop shop)
        {
            await _context.Shops.AddAsync(shop);
            await _context.SaveChangesAsync();
        }
    }
}
