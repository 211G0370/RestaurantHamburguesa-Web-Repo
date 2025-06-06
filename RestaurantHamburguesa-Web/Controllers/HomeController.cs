using Microsoft.AspNetCore.Mvc;

namespace RestaurantHamburguesa_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
