using RestaurantAspNetCore.Models;
using System.Collections.Generic;

namespace RestaurantAspNetCore.Services
{
	public interface IRestaurantData
    {
		IEnumerable<Restaurant> GetAll();

		Restaurant Get(int id);
	}
}
