using Microsoft.AspNetCore.Mvc;

namespace RestaurantHamburguesa_Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
