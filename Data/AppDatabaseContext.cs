using Microsoft.EntityFrameworkCore;
using WebApiTestSolution.Models;

namespace WebApiTestSolution.Data;
/// <summary>
/// Контекст базы данных
/// </summary>
public class AppDatabaseContext : DbContext
{
    public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options) { }
    
    public DbSet<Product> Products { get; set; }
}