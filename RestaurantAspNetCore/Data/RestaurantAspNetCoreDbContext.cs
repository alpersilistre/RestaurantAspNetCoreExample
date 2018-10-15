using Microsoft.EntityFrameworkCore;
using RestaurantAspNetCore.Models;

namespace RestaurantAspNetCore.Data
{
	public class RestaurantAspNetCoreDbContext : DbContext
    {
		public RestaurantAspNetCoreDbContext(DbContextOptions options) 
			: base(options)
		{

		}

		public DbSet<Restaurant> Restaurants { get; set; }
	}
}