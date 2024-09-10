using Microsoft.AspNetCore.Mvc;

namespace Kernal_Travel_Guide.Controllers
{
    public class travelinfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
