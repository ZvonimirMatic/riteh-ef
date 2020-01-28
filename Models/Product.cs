using System.Collections.Generic;

namespace EFCoreDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
