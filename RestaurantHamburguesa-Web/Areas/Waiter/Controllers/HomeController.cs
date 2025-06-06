using Microsoft.AspNetCore.Mvc;

namespace RestaurantHamburguesa_Web.Areas.Waiter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ticket()
        {
            return View();
        }
    }
}
