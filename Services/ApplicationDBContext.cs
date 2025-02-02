using Microsoft.EntityFrameworkCore;
using ProductCategoryApp.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) 
    { 
    
    
    }

    public DbSet<Product> products { get; set; }

    public DbSet<Category> categories { get; set; }
}
