using TestShopAPI.Models;

namespace TestShopAPI.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();

        Task<Product> Get(int id);

        Task Create(Product product);

        Task CreateRange(IEnumerable<Product> products);
    }
}
