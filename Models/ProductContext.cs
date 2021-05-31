using System.Data.Entity;

namespace BoysToys.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("BoysToys")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}