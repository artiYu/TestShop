using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestShopAPI.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public IEnumerable<OrderProducts> OrderProducts { get; set; }
        public IEnumerable<StockProduct> StockProducts { get; set; }
    }
}
