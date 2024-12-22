using Hw_Cookies.Interfaces;
using Hw_Cookies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hw_Cookies.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SetStyle([FromServices] IUserPreference userPreference, string selectedColor)
		{
			userPreference.SetUserPreferences("SiteStyle", HttpContext, new Preference
			{
				BackGroundColor = selectedColor,
			});
			return RedirectToAction(nameof(Index));
		}
	}
}
