namespace TestShopAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        public Client Client { get; set; }
        public Shop Shop { get; set; }

        public IEnumerable<OrderProducts> OrderProducts { get; set; }
    }
}
