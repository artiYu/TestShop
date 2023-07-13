namespace TestShopAPI.Models
{
    public class ShopStock
    {
        public int ShopId { get; set; }
        public int StockId { get; set; }

        public Shop Shop { get; set; }
        public Stock Stock { get; set; }
    }
}
