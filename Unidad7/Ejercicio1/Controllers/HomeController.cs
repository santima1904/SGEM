using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1.Controllers
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
            clsPersona opersona = new clsPersona("Santi", "Martínez");
            int hora = DateTime.Now.Hour;
            string saludo = "Buenos días";
            if (hora >= 12 && hora < 21)
            {
                saludo = "Buenas tardes";
            }else if(hora >= 21 || hora < 6)
            {
                saludo = "Buenas noches";
            }

            ViewData["saludo"] = saludo;
            ViewBag.Fecha = DateTime.Now;
            
            return View(opersona);
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
