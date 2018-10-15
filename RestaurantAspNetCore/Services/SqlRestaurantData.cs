using System.Collections.Generic;
using System.Linq;
using RestaurantAspNetCore.Data;
using RestaurantAspNetCore.Models;

namespace RestaurantAspNetCore.Services
{
	public class SqlRestaurantData : IRestaurantData
	{
		private RestaurantAspNetCoreDbContext _context;

		public SqlRestaurantData(RestaurantAspNetCoreDbContext context)
		{
			_context = context;
		}

		public Restaurant Add(Restaurant restaurant)
		{
			_context.Restaurants.Add(restaurant);
			_context.SaveChanges();

			return restaurant;
		}

		public Restaurant Get(int id)
		{
			return _context.Restaurants.FirstOrDefault(x => x.Id == id);
		}

		public IEnumerable<Restaurant> GetAll()
		{
			return _context.Restaurants.OrderBy(x => x.Name);
		}
	}
}
