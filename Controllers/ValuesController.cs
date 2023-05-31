using Microsoft.AspNetCore.Mvc;
using WebForm.Models;

namespace WebForm.Controllers
{
	public class ValuesController : Controller
	{
		private static List<Values> valuesList = new List<Values>();
		public IActionResult Index()
		{
			return View(valuesList);
		}

		[HttpPost]
		public ActionResult AddValues(Values values)
		{
			valuesList.Add(values);
			return RedirectToAction("Index");
		}
	}
}
