using TestShopAPI.Models;

namespace TestShopAPI.Services.Interfaces
{
    public interface IShopService
    {
        Task<IEnumerable<Shop>> GetAll();

        Task<Shop> Get(int id);

        Task Create(Shop shop);
    }
}
