using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BonusTrack_UI.Models
{
    public class IndexVMcs
    {
        private List<String> listadoNombres;
        private clsPlantas planta;

        public IndexVMcs()
        {
            clsListadoPlantas listadoPersonas = new clsListadoPlantas();

            this.listadoNombres = listadoPersonas.obtenerListadoNombrePlantas();
            this.planta = new clsPlantas();
        }

        public List<string> ListadoNombres { get => listadoNombres; set => listadoNombres = value; }
        public clsPlantas Planta { get => planta; set => planta = value; }
    }
}
