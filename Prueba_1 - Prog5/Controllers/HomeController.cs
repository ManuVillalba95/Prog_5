﻿using Microsoft.AspNetCore.Mvc;
using Prueba_1___Prog5.Data;
using Prueba_1___Prog5.Models;
using System.Diagnostics;

namespace Prueba_1___Prog5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DA_Movie dA_Movie = new DA_Movie();
            var dt = dA_Movie.Obtener();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
