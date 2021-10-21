using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld_MVC_Core_UI.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ListaProductos()
        {
            return View();
        }
    }
}
