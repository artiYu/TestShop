using TestShopAPI.Models;

namespace TestShopAPI.Services.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> Get(int id);
        Task Create(Order order);
    }
}
