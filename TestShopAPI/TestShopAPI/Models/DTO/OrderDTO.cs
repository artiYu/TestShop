namespace TestShopAPI.Models.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public ClientDTO Client { get; set; }
        public ShopDTO Shop { get; set; }
    }
}
