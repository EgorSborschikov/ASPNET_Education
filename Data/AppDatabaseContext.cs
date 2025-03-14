using Microsoft.EntityFrameworkCore;
using WebApiTestSolution.Models;

namespace WebApiTestSolution.Data;
/// <summary>
/// Контекст базы данных
/// </summary>
public class AppDatabaseContext : DbContext
{
    public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options) { }
    
    // Существующие в базе данных модели данных
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Orders)
            .WithMany(o => o.Products);
    }
}