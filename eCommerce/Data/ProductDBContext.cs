using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data;

public class ProductDBContext : DbContext
{
    public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
    {
    }
    // Entities to be tracked by DbContext
    public DbSet<Product> Products { get; set; }
    }
