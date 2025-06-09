using Microsoft.AspNetCore.Mvc;

namespace RestaurantHamburguesa_Web.Areas.Chef.Controllers
{
    [Area("Chef")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
