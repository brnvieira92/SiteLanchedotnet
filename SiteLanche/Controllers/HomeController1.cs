using Microsoft.AspNetCore.Mvc;

namespace SiteLanche.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
