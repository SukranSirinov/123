﻿using Microsoft.AspNetCore.Mvc;

namespace _22may.Areas.Manage.Controllers
{
    public class DashboardController : Controller
    {
           [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
