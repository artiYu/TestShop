namespace TestShopAPI.Models
{
    public class Client
    {
        public int Id { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
