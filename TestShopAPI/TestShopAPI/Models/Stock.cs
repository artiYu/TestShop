namespace TestShopAPI.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int Count { get; set; }

        public IEnumerable<StockProduct> StockProducts { get; set; }
        public IEnumerable<ShopStock> ShopStocks { get; set; }
    }
}
