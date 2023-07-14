using Microsoft.EntityFrameworkCore;
using TestShopAPI.Models;
using TestShopAPI.Services.Interfaces;

namespace TestShopAPI.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly ShopContext _context;
        public ProductService(ShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> Get(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Create(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task CreateRange(IEnumerable<Product> products)
        {
            await _context.Products.AddRangeAsync(products);
            await _context.SaveChangesAsync();
        }
    }
}
