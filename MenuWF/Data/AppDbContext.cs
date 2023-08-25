using MenuWF.Entities;
using Microsoft.EntityFrameworkCore;

namespace MenuWF.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Dish> Dishes { get; set; }
	public DbSet<Journal> Journals { get; set; }
	public DbSet<Product> Products { get; set; }
    public DbSet<Recipe> Recipes { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //}
}
