using Microsoft.AspNetCore.Mvc;

namespace Kernal_Travel_Guide.Controllers
{
    public class resortsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
