namespace TestShopAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        
        public IEnumerable<OrderProducts> OrderProducts { get; set; }
        public IEnumerable<StockProduct> StockProducts { get; set; }
    }
}
