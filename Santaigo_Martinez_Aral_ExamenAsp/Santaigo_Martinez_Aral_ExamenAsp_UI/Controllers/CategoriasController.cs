using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Santaigo_Martinez_Aral_ExamenAsp_UI.Models;
using System;

namespace Santaigo_Martinez_Aral_ExamenAsp_UI.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: CategoriasController
        public ActionResult Index()
        {
            ListadoCategoriasVM listadoCategoriasVM = null;
            try
            {
               listadoCategoriasVM = new ListadoCategoriasVM();
            }catch (Exception)
            {
                //vista error
            }
            
            return View(listadoCategoriasVM.ListadoCategoriasCompleto);
        } 
    }
}
