using Microsoft.AspNetCore.Mvc;

namespace RestaurantHamburguesa_Web.Areas.Waiter.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
