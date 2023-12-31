﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebDevelopment.Data;
using WebDevelopment.Models;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;

namespace WebDevelopment.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;
		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		[HttpPost]
		public IActionResult Add(CarsComboModel combo, List<IFormFile> carImages)
		{
			combo.car.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var car = combo.car;

			_context.Cars.Add(car);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult Add()
		{

			var cars = _context.Cars
				.Include(c => c.Model)
				.ThenInclude(c => c.Make);
			var carModels = new CarsComboModel()
			{
				carModels = new List<CarModel>(),

			};
			foreach (var car in cars)
			{
				carModels.carModels.Add(new CarModel
				{
					Make = car.Model.Make.Name,
					Model = car.Model.Name
				});

			}
			return View(carModels);
		}
		public IActionResult MyPage()
		{
			return View();
		}
		[HttpGet]
		public IActionResult MyVehicles()
		{
			var id = User.FindFirstValue(ClaimTypes.NameIdentifier);

			var cars = _context.Cars.Where(c => c.UserID == id);

			List<MyCarsModel> mycars = new List<MyCarsModel>();
			foreach (var car in cars)
			{
				var carImages = car.Images.Select(i => i.ImageUrl).ToList();
				mycars.Add(new MyCarsModel
				{
					Id = car.Id,
					Make = car.Model.Make.Name,
					Model = car.Model.Name,
					Type = car.Type.ToString(),
					Fuel = car.Fuel.ToString(),
					GearBox = car.GearBox.ToString(),
					Color = car.Color.ToString(),
					EngineSize = car.EngineSize,
					Power = car.Power,
					Doors = car.Doors,
					Seats = car.Seats,
					Year = car.Year,
					Price = car.Price,
					Mileage = car.Mileage,
					Carpics = carImages

				});
			}
			return View(mycars);
		}
		[HttpPost]
		public IActionResult MyVehicles(MyCarsModel mycars)
		{
			return RedirectToAction("MyVehcles");
		}
		public IActionResult Delete(int id)
		{
			var car = _context.Cars.Find(id);
			_context.Cars.Remove(car);
			_context.SaveChanges();
			return RedirectToAction("MyVehicles");
		}
		[HttpGet]
		public IActionResult Edit(int id)
		{
			var context = _context.Cars.Find(id);
			return View(context);

		}
		[HttpPost]
		public IActionResult Edit(Car car)
		{
			_context.Cars.Update(car);
			_context.SaveChanges();
			return RedirectToAction("MyVehicles");
		}


		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Team()
		{
			return View();
		}

		public IActionResult Blog()
		{
			return View();
		}

		public IActionResult BlogPost()
		{
			return View();
		}

		public IActionResult Testimonials()
		{
			return View();
		}

		public IActionResult Faq()
		{
			return View();
		}

		public IActionResult Terms()
		{
			return View();
		}

		public IActionResult Cars()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}