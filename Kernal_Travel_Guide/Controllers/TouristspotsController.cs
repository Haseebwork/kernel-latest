using Microsoft.AspNetCore.Mvc;

namespace Kernal_Travel_Guide.Controllers
{
    public class TouristspotsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
