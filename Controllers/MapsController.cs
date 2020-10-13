using System;
using System.Collections.Generic;
using System.Web.Mvc;
using VideoKlub.Models;

namespace VideoKlub.Controllers
{
    public class MapsController : Controller
	{
	
		[HttpGet]
		public ActionResult Index()
		{
			var cities = new List<City>();
			cities.Add(new City() { Title = "Paris", Lat = 48.855901, Lng = 2.349272 });
			cities.Add(new City() { Title = "Berlin", Lat = 52.520413, Lng = 13.402794 });
			cities.Add(new City() { Title = "Rome", Lat = 41.907074, Lng = 12.498474 });
			cities.Add(new City() { Title = "Belgrade", Lat = 44.7866, Lng = 20.4489 });
			return View(cities);
		}


		[HttpPost]
		public JsonResult GetAnswer(string question)
		{
			int index = _rnd.Next(_db.Count);
			var answer = _db[index];
			return Json(answer);
		}

		private static Random _rnd = new Random();

		private static List<string> _db = new List<string> { "Yes", "No", "Definitely, yes", "I don't know", "Looks like, yes" };
	}

}