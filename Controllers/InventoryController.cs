﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
