﻿using Microsoft.AspNetCore.Mvc;

namespace RestaurantHamburguesa_Web.Areas.Waiter.Controllers
{
    [Area("Waiter")]

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
