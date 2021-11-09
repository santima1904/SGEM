using BonusTrack_UI.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BonusTrack_UI.Controllers
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
            var IndexVMcs = new IndexVMcs();
            return View(IndexVMcs);
        }

        [HttpPost]
        public IActionResult Index(string slcPlantas)//slcPlantas es el name del select
        {
            clsListadoPlantas listado = new clsListadoPlantas();
            IndexVMcs indexVMcs = new IndexVMcs();
        
            indexVMcs.Planta = listado.obtenerPlantaApartirNombre(slcPlantas);

            return View(indexVMcs);
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
