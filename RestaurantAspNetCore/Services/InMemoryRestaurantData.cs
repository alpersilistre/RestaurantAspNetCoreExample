using RestaurantAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAspNetCore.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
		List<Restaurant> restaurants;

		public InMemoryRestaurantData()
		{
			restaurants = new List<Restaurant>
			{
				new Restaurant { Id = 1, Name = "Alper's place" },
				new Restaurant { Id = 2, Name = "Hovel restaurant" },
				new Restaurant { Id = 3, Name = "King's Contrivance" },
			};
		}

		public Restaurant Get(int id)
		{
			return restaurants.FirstOrDefault(x => x.Id == id);
		}

		public IEnumerable<Restaurant> GetAll()
		{
			return restaurants.OrderBy(r => r.Name);
		}
	}
}
