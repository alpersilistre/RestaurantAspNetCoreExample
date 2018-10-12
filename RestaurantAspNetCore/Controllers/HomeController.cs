﻿using Microsoft.AspNetCore.Mvc;
using RestaurantAspNetCore.Models;
using RestaurantAspNetCore.Services;

namespace RestaurantAspNetCore.Controllers
{
	public class HomeController : Controller
    {
		private IRestaurantData _restaurantData;

		public HomeController(IRestaurantData restaurantData)
		{
			_restaurantData = restaurantData;
		}

		public IActionResult Index()
		{
			var model = _restaurantData.GetAll();

			return View(model);
		}
    }
}
