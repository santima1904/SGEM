using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Santaigo_Martinez_Aral_ExamenAsp_Entidades;
using Santaigo_Martinez_Aral_ExamenAsp_UI.Models.ViewModels;
using Santaigo_Martinez_Aral_ExamenAsp_BL.Listado;
using Santaigo_Martinez_Aral_ExamenAsp_BL.Gestora;
using System;

namespace Santaigo_Martinez_Aral_ExamenAsp_UI.Controllers
{
    public class PlantaController : Controller
    {
        // GET: PlantaController
        public ActionResult Index(int id)
        {
            ListadoPlantasPorCategoriaVM listadoPlantasPorCategoriaVM = null;
            try
            {
                listadoPlantasPorCategoriaVM = new ListadoPlantasPorCategoriaVM();
                listadoPlantasPorCategoriaVM.rellenarListadoPlantasPorCategoria(id);
            }
            catch (Exception)
            {
                //vista error
            }
            
            return View(listadoPlantasPorCategoriaVM.ListadoPlantas);
        }

        // GET: PlantaController/Edit/5
        public ActionResult Precio(int id)
        {
            clsPlanta oPlanta = null;
            try
            {
               oPlanta = clsListadoPlantasBL.obtenerPlanta(id);
            }
            catch (Exception)
            {
                //vista error
            }
            
            return View(oPlanta);
        }

        // POST: PlantaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, clsPlanta oPlanta)
        {
            try
            {  
                clsGestoraPlantasBL.actualizarPrecioPlantaBL(oPlanta);
            }
            catch
            {
                //vista error
            }
            return View(oPlanta.IdPlanta);
        }
    }
}
//Falta que se actualice la persona con el precio, nose porque falla
//Los data annotations no me ha dado tiempo a hacerlos
//Me faltan los botones para navegar entre páginas por falta de tiempo
//Me falta crear la vista de error para cuando falle algo
