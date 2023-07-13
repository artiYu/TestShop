namespace TestShopAPI.Models
{
    public class StockProduct
    {
        public int StockId { get; set; }
        public int ProductId { get; set; }

        public Stock Stock { get; set; }
        public Product Product { get; set; }
    }
}
