using RestaurantAspNetCore.Models;
using System.Collections.Generic;

namespace RestaurantAspNetCore.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public string CurrentMessage { get; set; }
    }
}
