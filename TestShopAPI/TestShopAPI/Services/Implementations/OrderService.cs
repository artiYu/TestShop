using Microsoft.EntityFrameworkCore;
using TestShopAPI.Models;
using TestShopAPI.Services.Interfaces;

namespace TestShopAPI.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly ShopContext _context;
        public OrderService(ShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> Get(int id)
        {
            return await _context.Orders.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Create(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }
    }
}
