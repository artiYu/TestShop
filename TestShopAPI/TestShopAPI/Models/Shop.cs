namespace TestShopAPI.Models
{
    public class Shop
    {
        public int Id { get; set; }

        public IEnumerable<ShopStock> ShopStocks { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
