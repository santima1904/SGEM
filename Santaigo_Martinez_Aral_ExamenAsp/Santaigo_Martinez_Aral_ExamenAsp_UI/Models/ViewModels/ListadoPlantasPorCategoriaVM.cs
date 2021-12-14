using Santaigo_Martinez_Aral_ExamenAsp_Entidades;
using System.Collections.ObjectModel;
using Santaigo_Martinez_Aral_ExamenAsp_BL.Listado;

namespace Santaigo_Martinez_Aral_ExamenAsp_UI.Models.ViewModels
{
    public class ListadoPlantasPorCategoriaVM
    {
        ObservableCollection<clsPlanta> listadoPlantas;

        public ListadoPlantasPorCategoriaVM()
        {
            this.listadoPlantas = new ObservableCollection<clsPlanta>();             
        }

        public ObservableCollection<clsPlanta> ListadoPlantas { get => listadoPlantas; set => listadoPlantas = value; }


        /// <summary>
        /// <cadecera>public void rellenarListadoPlantasPorCategoria(int idCategoria)</cadecera>
        /// <descripcion>Método para rellenar un listado de plantas con una lista de plantas de una categoría dada</descripcion>
        /// <precondiciones>Ninguna</precondiciones>
        /// <postcondiciones>lista rellena</postcondiciones>
        /// </summary>
        /// <param name="idCategoria">int</param>
        public void rellenarListadoPlantasPorCategoria(int idCategoria)
        {
            listadoPlantas = clsListadoPlantasBL.obtenerListadoPlantasPorCategoriaBL(idCategoria);
        }
    }
}
