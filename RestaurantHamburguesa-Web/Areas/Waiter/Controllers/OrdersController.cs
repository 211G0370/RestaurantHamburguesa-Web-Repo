using Microsoft.AspNetCore.Mvc;

namespace RestaurantHamburguesa_Web.Areas.Waiter.Controllers
{
    [Area("Waiter")]
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
