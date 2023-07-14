using TestShopAPI.Models;

namespace TestShopAPI.Services.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAll();

        Task<Client> Get(int id);

        Task Create(Client client);
    }
}
