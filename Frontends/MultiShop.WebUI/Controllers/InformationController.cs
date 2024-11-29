using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;

namespace MultiShop.WebUI.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            var currentCulture = System.Globalization.CultureInfo.CurrentCulture.Name;
            Console.WriteLine($"Current Culture: {currentCulture}");
            ViewBag.Culture = currentCulture;

            return View();
        }
    }
}
