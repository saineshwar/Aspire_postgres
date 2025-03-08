using AspireApp3.ApiService.Models;
using Microsoft.EntityFrameworkCore;

namespace AspireApp3.ApiService.Data;

public class DataDbContext : DbContext
{
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

    // Define your DbSets (tables) here
    public DbSet<Employee> Employees { get; set; }
}